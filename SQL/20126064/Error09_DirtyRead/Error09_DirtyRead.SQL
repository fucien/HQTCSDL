CREATE PROCEDURE Admin_lock_error @tk varchar(20), @delay DATETIME
AS
BEGIN TRANSACTION
	Update TaiKhoan set Lock = 1 where TaiKhoan = @tk
	WAITFOR DELAY @delay;
COMMIT TRANSACTION;
GO

CREATE PROCEDURE dang_nhap @tai_khoan VARCHAR(20), @mat_khau VARCHAR(50)
AS
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
BEGIN TRANSACTION
	DECLARE @loai_tk CHAR(2);
	SET @loai_tk = NULL;
	--Lấy ra loại tài khoản
	SET @loai_tk = (SELECT TOP 1 tk.Loai
					FROM TaiKhoan tk
					WHERE tk.TaiKhoan = @tai_khoan AND tk.Pass = @mat_khau AND tk.Lock = 0)
	IF @loai_tk IS NOT NULL
		BEGIN
			--Trả về mã (đối tác/khách hàng/tài xế) tương ứng với loại tài khoản đó
			IF @loai_tk = 'DT'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', dt.MaDT AS 'ma', dt.TenDT as 'name' FROM DoiTac dt WHERE dt.TaiKhoan = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'KH'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', kh.MaKH AS 'ma', kh.HoTen as 'name' FROM KhachHang kh WHERE kh.TaiKhoan = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'TX'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', tx.MaTX AS 'ma', tx.HoTen as 'name' FROM TaiXe tx WHERE tx.TaiKhoan = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'AD'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', ad.MaAD   AS 'ma',ad.Ten as 'name' FROM Admin ad WHERE ad.TaiKhoan = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'NV'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', nv.MaNV  AS 'ma',nv.Ten as 'name' FROM NhanVien nv WHERE nv.TaiKhoan = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
		END
COMMIT TRANSACTION
GO
