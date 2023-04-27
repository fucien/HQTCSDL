--Procedure cho khách hàng hủy đơn đặt hàng
CREATE PROC HuyDH @ma_dh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	BEGIN TRY
	--Chỉ có thể hủy khi đơn hàng đang trong trạng thái Đang xử lý
	IF EXISTS (SELECT * 
				FROM DonHang WITH (UPDLOCK)
				WHERE MaDH = @ma_dh AND Status = N'Đang xử lý')
		BEGIN

			WAITFOR DELAY @delay;

			UPDATE DonHang
			SET Status = N'Đã hủy'
			WHERE MaDH = @ma_dh;

			--Cộng lại sản phẩm trong chi nhánh sản phẩm
			UPDATE ChiNhanh_SanPham
			SET SoLuong_CS = SoLuong_CS + (SELECT TOP 1 dhsp.SoLuong_SD
												FROM DonHang_SanPham dhsp
												WHERE dhsp.MaSP = MaSP 
													AND dhsp.MaDH = MaDH)
			WHERE MaCN = (SELECT TOP 1 dh.MaCN 
							FROM DonHang dh
							WHERE dh.MaDH = @ma_dh)
				AND MaSP IN (SELECT dhsp.MaSP 
								FROM DonHang_SanPham dhsp
								WHERE dhsp.MaDH = @ma_dh);

			PRINT N'Hủy đơn hàng thành công';
			COMMIT TRANSACTION;
			RETURN;
		END
		PRINT N'Hủy đơn hàng thất bại';
		ROLLBACK TRANSACTION;
		RETURN;
	END TRY
	BEGIN CATCH
		PRINT N'Hủy đơn hàng thất bại';
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
GO

EXEC HuyDH 1, '00:00:05'