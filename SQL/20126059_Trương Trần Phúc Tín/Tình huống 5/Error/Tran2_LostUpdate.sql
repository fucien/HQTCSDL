--Procedure gia hạn hợp đồng
CREATE PROCEDURE GiaHanHD_ERROR @ma_hd INT, @so_ngay_them INT, @delay DATETIME
AS
BEGIN TRANSACTION
	DECLARE @ngay_hien_tai DATE;
	--Chọn ngày cuối hợp đồng
	SET @ngay_hien_tai = (SELECT TOP 1 NgayKetThuc FROM HopDong WHERE MaHD = @ma_hd);
	IF @ngay_hien_tai IS NOT NULL
	BEGIN
			
		WAITFOR DELAY @delay;

		--Tăng ngày cuối hợp đồng
		SET @ngay_hien_tai = (SELECT DATEADD(DAY, @so_ngay_them, @ngay_hien_tai));
		--Update lại ngày cuối của hợp đồng
		UPDATE HopDong
		SET NgayKetThuc = @ngay_hien_tai
		WHERE MaHD = @ma_hd;
		UPDATE HopDong
		SET isNotified = 0
		WHERE MaHD = @ma_hd;
	END
	COMMIT TRANSACTION;
GO
EXEC GiaHanHD_ERROR 1, 1, '00:00:05';