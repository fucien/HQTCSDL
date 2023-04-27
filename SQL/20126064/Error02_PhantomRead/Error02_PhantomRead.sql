CREATE PROC DoiTacThongKe @ma_dt INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	
	SELECT 'total', COUNT(dh.MaDH) AS N'Tổng hóa đơn', 
					SUM(dh.Gia) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PhiVanChuyen) AS N'Tổng phí vận chuyển'
	FROM DonHang dh
		JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN
	WHERE cn.MaDT = @ma_dt;

	SELECT 'shipping', COUNT(dh.MaDH) AS N'Tổng hóa đơn', 
						SUM(dh.Gia) AS N'Tổng giá sản phẩm hóa đơn', 
						SUM(dh.PhiVanChuyen) AS N'Tổng phí vận chuyển'
	FROM DonHang dh
		JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN
	WHERE cn.MaDT = @ma_dt AND dh.Status = N'Đang giao';
	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MaDH) AS N'Tổng hóa đơn', 
					SUM(dh.Gia) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PhiVanChuyen) AS N'Tổng phí vận chuyển'
	FROM DonHang dh
		JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN
	WHERE cn.MaDT = @ma_dt AND dh.Status = N'Thành công';

	SELECT 'product', sp.MaSP, sp.Ten, 
			SUM(dhsp.SoLuong_SD) AS N'Số lượng đã bán'
	FROM DonHang_SanPham dhsp
		JOIN SanPham sp ON dhsp.MaSP = sp.MaSP
		JOIN DonHang dh ON dhsp.MaDH = dh.MaDH
		JOIN ChiNhanh_SanPham cnsp ON cnsp.MaCN = dh.MaCN
		JOIN ChiNhanh cn ON cn.MaCN = cnsp.MaCN
	WHERE cn.MaDT = @ma_dt
	GROUP BY sp.MaSP, sp.Ten
	HAVING SUM(dhsp.SoLuong_SD) >= ALL (SELECT SUM(dhsp.SoLuong_SD)
											FROM DonHang_SanPham dhsp
												JOIN DonHang dh ON dhsp.MaDH = dh.MaDH
												JOIN ChiNhanh_SanPham cnsp ON cnsp.MaCN = dh.MaCN
												JOIN ChiNhanh cn ON cn.MaCN = cnsp.MaCN
											WHERE cn.MaDT = @ma_dt
											GROUP BY dhsp.MaSP);
COMMIT TRANSACTION;
GO


CREATE PROC DoiTacThongKe_ERROR @ma_dt INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION

	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	

	SELECT 'total', COUNT(dh.MaDH) AS N'Tổng hóa đơn', 
					SUM(dh.Gia) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PhiVanChuyen) AS N'Tổng phí vận chuyển'
	FROM DonHang dh
		JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN
	WHERE cn.MaDT = @ma_dt;

	SELECT 'shipping', COUNT(dh.MaDH) AS N'Tổng hóa đơn', 
						SUM(dh.Gia) AS N'Tổng giá sản phẩm hóa đơn', 
						SUM(dh.PhiVanChuyen) AS N'Tổng phí vận chuyển'
	FROM DonHang dh
		JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN
	WHERE cn.MaDT = @ma_dt AND dh.Status = N'Đang giao';
	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MaDH) AS N'Tổng hóa đơn', 
					SUM(dh.Gia) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PhiVanChuyen) AS N'Tổng phí vận chuyển'
	FROM DonHang dh
		JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN
	WHERE cn.MaDT = @ma_dt AND dh.Status = N'Thành công';

	SELECT 'product', sp.MaSP, sp.Ten, 
			SUM(dhsp.SoLuong_SD) AS N'Số lượng đã bán'
	FROM DonHang_SanPham dhsp
		JOIN SanPham sp ON dhsp.MaSP = sp.MaSP
		JOIN DonHang dh ON dhsp.MaDH = dh.MaDH
		JOIN ChiNhanh_SanPham cnsp ON cnsp.MaCN = dh.MaCN
		JOIN ChiNhanh cn ON cn.MaCN = cnsp.MaCN
	WHERE cn.MaDT = @ma_dt
	GROUP BY sp.MaSP, sp.Ten
	HAVING SUM(dhsp.SoLuong_SD) >= ALL (SELECT SUM(dhsp.SoLuong_SD)
											FROM DonHang_SanPham dhsp
												JOIN DonHang dh ON dhsp.MaDH = dh.MaDH
												JOIN ChiNhanh_SanPham cnsp ON cnsp.MaCN = dh.MaCN
												JOIN ChiNhanh cn ON cn.MaCN = cnsp.MaCN
											WHERE cn.MaDT = @ma_dt
											GROUP BY dhsp.MaSP);
COMMIT TRANSACTION;
GO


CREATE PROCEDURE TaoDonDatHang_ERROR @ma_cn INT, @ma_kh INT, @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @delay DATETIME, 
									@san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		
		DECLARE @phi_sp INT, @ma_dh INT;
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SanPham sp JOIN @san_pham_so_luong spsl
								ON sp.MaSP = spsl.MaSP)

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