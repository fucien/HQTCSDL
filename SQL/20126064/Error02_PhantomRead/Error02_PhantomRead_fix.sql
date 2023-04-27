CREATE PROCEDURE TaoDonDatHang @ma_cn INT, @ma_kh INT, @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @delay DATETIME, 
									@san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

		DECLARE @phi_sp INT, @ma_dh INT;
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SanPham sp JOIN @san_pham_so_luong spsl
								ON sp.MaSP = spsl.MaSP)

		--Đọc để đặt khóa shared lock
		SELECT * FROM DonHang;

		--Tạo đơn hàng
		INSERT INTO DonHang(MaCN, MaTX, MaKH, CachThanhToan, DiaChi, Gia, PhiVanChuyen)
		VALUES (@ma_cn, NULL, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @phi_sp, @phi_vc);

		WAITFOR DELAY @delay;

		--Lấy mã đơn hàng vừa tạo
		SET @ma_dh = (SELECT TOP 1 MaDH FROM DonHang ORDER BY MaDH DESC);


		--Tạo chi tiết đơn hàng
		INSERT INTO DonHang_SanPham(MaDH, MaSP, SoLuong_SD, Gia_SD)
		SELECT @ma_dh, spsl.MaSP, spsl.SO_LUONG, SP.GIA_SP
		FROM @san_pham_so_luong spsl JOIN SanPham SP
			ON SP.MaSP = spsl.MaSP;


		--Trừ sản phẩm trong chi nhánh sản phẩm
		UPDATE ChiNhanh_SanPham
		SET SoLuong_CS = SoLuong_CS - (SELECT TOP 1 spsl.SO_LUONG 
												FROM @san_pham_so_luong spsl 
												WHERE spsl.MaSP = MaSP)
		WHERE MaCN = @ma_cn AND MaSP IN (SELECT MaSP FROM @san_pham_so_luong)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW;
	END CATCH
COMMIT TRANSACTION
GO
