--Procedure tài xế tiếp nhận đơn hàng

CREATE PROCEDURE NhanDH @ma_tx INT, @ma_dh INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION
	--Nếu đơn hàng đã có tài xế khác tiếp nhận
	IF NOT EXISTS (SELECT *
				FROM DonHang WITH (UPDLOCK)
				WHERE MaDH = @ma_dh AND MaTX IS NULL 
						AND Status = N'Đang xử lý')
	BEGIN	
		PRINT N'Nhận đơn hàng thất bại'
		ROLLBACK TRANSACTION;
		RETURN;
	END

	--Delay để gây ra lỗi
	WAITFOR DELAY @delay;

	UPDATE DonHang
	SET MaTX = @ma_tx, Status = N'Đang giao'
	WHERE MaDH = @ma_dh;

	PRINT N'Nhận đơn hàng thành công'
COMMIT TRANSACTION
GO

exec NhanDH 1, 1, '00:00:05'