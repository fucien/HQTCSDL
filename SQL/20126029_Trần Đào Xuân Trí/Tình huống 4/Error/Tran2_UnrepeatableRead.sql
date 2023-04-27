-- create proceduce taixe update order status
CREATE PROC Update_order @ma_kh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	WAITFOR DELAY @delay;

	UPDATE DonHang
	SET Status = N'Thành công'
	WHERE MaKH = @ma_kh AND Status = N'Đang giao';
COMMIT TRANSACTION;
GO

EXEC Update_order 1, '00:00:05';