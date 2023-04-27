--Store procedure để tài xế thống kê đơn hàng
CREATE PROC GetThongKe_ERROR @ma_tx INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	SELECT 'total', COUNT(dh.MaDH), SUM(dh.Gia), SUM(dh.PhiVanChuyen)
	FROM DonHang dh
	WHERE dh.MaTX = @ma_tx;

	SELECT 'shipping', COUNT(dh.MaDH), SUM(dh.Gia), SUM(dh.PhiVanChuyen)
	FROM DonHang dh
	WHERE dh.MaTX = @ma_tx AND dh.Status = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MaDH) , SUM(dh.Gia), SUM(dh.PhiVanChuyen)
	FROM DonHang dh
	WHERE dh.MaTX = @ma_tx AND dh.Status = N'Thành công';
COMMIT TRANSACTION;
GO
EXEC GetThongKe_ERROR 1, '00:00:05';