﻿USE CHUYEN_HANG_ONLINE;

--Cấp quyền cho tài khoản đăng nhập
GO
EXEC SP_ADDLOGIN 'DANGNHAP','DANGNHAP','CHUYEN_HANG_ONLINE';
CREATE USER DANGNHAP FOR LOGIN DANGNHAP;
GRANT SELECT ON TaiKhoan TO DANGNHAP;
GRANT SELECT ON DoiTac TO DANGNHAP;
GRANT SELECT ON KhachHang TO DANGNHAP;
GRANT SELECT ON TaiXe TO DANGNHAP;
GRANT EXECUTE ON OBJECT::dbo.dang_nhap TO DANGNHAP;

--Cấp quyền cho role đối tác
GO
EXEC SP_ADDLOGIN 'DOITAC1','DOITAC1','CHUYEN_HANG_ONLINE';
CREATE USER DOITAC1 FOR LOGIN DOITAC1;
EXEC SP_ADDROLE 'DOITAC';
EXEC SP_ADDROLEMEMBER 'DOITAC','DOITAC1';
GRANT SELECT, INSERT, UPDATE, DELETE ON SanPham TO DOITAC;
GRANT SELECT, INSERT, UPDATE, DELETE ON ChiNhanh_SanPham TO DOITAC;
GRANT SELECT, INSERT, UPDATE, DELETE ON DonHang_SanPham TO DOITAC;
GRANT SELECT, INSERT, UPDATE ON HopDong TO DOITAC;
GRANT SELECT, UPDATE ON DonHang TO DOITAC;
GRANT SELECT, UPDATE ON DoiTac TO DOITAC;
GRANT SELECT, UPDATE ON ChiNhanh TO DOITAC;
--GRANT EXECUTE ON dbo.chi_nhanh_chua_ki_hd TO DOITAC
GRANT EXECUTE ON dbo.GiaHanHD_ERROR TO DOITAC
GRANT EXECUTE ON dbo.GiaHanHD TO DOITAC
GRANT EXECUTE ON dbo.CapNhatSP TO DOITAC
GRANT EXECUTE ON dbo.CapNhatSoLuongSP_ERROR TO DOITAC
GRANT EXECUTE ON dbo.CapNhatSoLuongSP TO DOITAC
GRANT EXECUTE ON dbo.DoiTacThongKe_ERROR TO DOITAC
GRANT EXECUTE ON dbo.DoiTacThongKe TO DOITAC

--Cấp quyền khách hàng
GO
EXEC SP_ADDLOGIN 'KHACHHANG1','KHACHHANG1','CHUYEN_HANG_ONLINE';
CREATE USER KHACHHANG1 FOR LOGIN KHACHHANG1;
EXEC SP_ADDROLE 'KHACHHANG';
EXEC SP_ADDROLEMEMBER 'KHACHHANG','KHACHHANG1';
GRANT SELECT ON DoiTac TO KHACHHANG;
GRANT SELECT ON ChiNhanh TO KHACHHANG;
GRANT SELECT ON SanPham TO KHACHHANG;
GRANT SELECT ON ChiNhanh_SanPham TO KHACHHANG;
GRANT SELECT, INSERT ON DonHang TO KHACHHANG;
GRANT SELECT, INSERT ON DonHang_SanPham TO KHACHHANG;
GRANT EXECUTE ON TYPE::SAN_PHAM_SO_LUONG TO KHACHHANG;
GRANT SELECT, UPDATE ON KhachHang TO KHACHHANG;
GRANT EXECUTE ON dbo.Thongke_KH_ERROR TO KHACHHANG
GRANT EXECUTE ON dbo.Thongke_KH TO KHACHHANG
GRANT EXECUTE ON dbo.TaoDonDatHang TO KHACHHANG
GRANT EXECUTE ON dbo.TaoDonDatHang_ERROR TO KHACHHANG
GRANT EXECUTE ON dbo.Thongke_KH TO KHACHHANG
GRANT EXECUTE ON dbo.HuyDH_ERROR TO KHACHHANG
GRANT EXECUTE ON dbo.HuyDH TO KHACHHANG

--Cấp quyền tài xế
GO
EXEC SP_ADDLOGIN 'TAIXE1','TAIXE1','CHUYEN_HANG_ONLINE';
CREATE USER TAIXE1 FOR LOGIN TAIXE1;
EXEC SP_ADDROLE 'TAIXE';
EXEC SP_ADDROLEMEMBER 'TAIXE','TAIXE1';
GRANT SELECT, UPDATE ON TaiXe TO TAIXE;
GRANT SELECT, UPDATE ON DonHang TO TAIXE;
GRANT SELECT ON DonHang_SanPham to TAIXE;
GRANT EXECUTE ON dbo.GetThongKe_ERROR TO TAIXE
GRANT EXECUTE ON dbo.GetThongKe TO TAIXE
GRANT EXECUTE ON dbo.NhanDH_ERROR TO TAIXE
GRANT EXECUTE ON dbo.NhanDH TO TAIXE


--Cấp quyền cho nhân viên
GO
EXEC SP_ADDLOGIN 'NHANVIEN1','NHANVIEN1','CHUYEN_HANG_ONLINE';
CREATE USER NHANVIEN1 FOR LOGIN NHANVIEN1;
EXEC SP_ADDROLE 'NHANVIEN';
EXEC SP_ADDROLEMEMBER 'NHANVIEN','NHANVIEN1';
GRANT SELECT ON DoiTac TO NHANVIEN;
GRANT SELECT, UPDATE ON HopDong TO NHANVIEN;



--Cấp quyền cho quản trị viên
--QTV: quản trị viên
EXEC SP_ADDLOGIN 'QTV1','QTV1','CHUYEN_HANG_ONLINE';
CREATE USER QTV1 FOR LOGIN QTV1;
ALTER ROLE db_datareader
	ADD MEMBER QTV1;
ALTER ROLE db_datawriter
	ADD MEMBER QTV1;

