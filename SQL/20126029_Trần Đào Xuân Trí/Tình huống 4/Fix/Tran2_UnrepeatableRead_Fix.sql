CREATE PROCEDURE CapNhatSP @ma_sp INT, @ten_sp NVARCHAR(20), @mo_ta NVARCHAR(30), @gia INT, @delay DATETIME
AS
BEGIN TRANSACTION
	--Nếu tên sản phẩm, mô tả không trống, giá không bị âm -> cập nhật giá trị mới
	--Nếu không thì giữ những giá trị cũ lại
	IF (@ten_sp = '')
		BEGIN
			SET @ten_sp = (SELECT Ten FROM SanPham WHERE MaSP = @ma_sp);
		END
	IF (@mo_ta = '')
		BEGIN
			SET @mo_ta = (SELECT Description FROM SanPham WHERE MaSP = @ma_sp);
		END
	IF (@gia < 0)
		BEGIN
			SET @gia = (SELECT GIA_SP FROM SanPham WHERE MaSP = @ma_sp);
		END
	UPDATE SanPham
	SET Ten = @ten_sp,
		Description = @mo_ta,
		GIA_SP = @gia
	WHERE MaSP = @ma_sp;
	WAITFOR delay @delay;
COMMIT TRANSACTION
GO

EXEC CapNhatSP 1, 'Coq au Vin', 'Traditional French dish of chicken braised with red wine, mushrooms, and garlic.', 250000, '00:00:05';