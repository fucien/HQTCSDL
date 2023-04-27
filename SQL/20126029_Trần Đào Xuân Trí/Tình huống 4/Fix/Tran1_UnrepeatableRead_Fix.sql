--Store procedure để khách hàng thống kê đơn hàng
CREATE PROC Thongke_KH_ERROR @ma_kh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	SELECT 'total', COUNT(dh.MaDH), SUM(dh.Gia), SUM(dh.PhiVanChuyen)
	FROM DonHang dh
	WHERE dh.MaKH = @ma_kh;

	SELECT 'shipping', COUNT(dh.MaDH), SUM(dh.Gia), SUM(dh.PhiVanChuyen)
	FROM DonHang dh
	WHERE dh.MaKH = @ma_kh AND dh.Status = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MaDH) , SUM(dh.Gia), SUM(dh.PhiVanChuyen)
	FROM DonHang dh
	WHERE dh.MaKH = @ma_kh AND dh.Status = N'Thành công';
COMMIT TRANSACTION;
GO

EXEC Thongke_KH_ERROR 1, '00:00:05';