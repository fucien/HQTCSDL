﻿--Tạo database
CREATE DATABASE CHUYEN_HANG_ONLINE
GO
USE CHUYEN_HANG_ONLINE
GO

--Tạo bảng tài khoản
CREATE TABLE TaiKhoan
(
	TaiKhoan VARCHAR(20) PRIMARY KEY,
	Pass VARCHAR(50) NOT NULL,
	NgayDK DATE DEFAULT GETDATE(),
	Loai CHAR(2),
	Lock BIT DEFAULT 0,
)
GO

--Tạo bảng đối tác
CREATE TABLE DoiTac
(
	MaDT INT PRIMARY KEY IDENTITY(1, 1),
	TaiKhoan VARCHAR(20) UNIQUE NOT NULL,
	TenDT NVARCHAR(20) NOT NULL,
	DaiDien NVARCHAR(30) NOT NULL,
	ThanhPho NVARCHAR(15) NOT NULL,
	Quan NVARCHAR(15) NOT NULL,
	DiaChi NVARCHAR(30) UNIQUE NOT NULL,
	SoChiNhanh INT DEFAULT 0,
	LoaiAmThuc NVARCHAR(20),
	Sdt VARCHAR(10) UNIQUE NOT NULL,
	Email VARCHAR(30) UNIQUE NOT NULL,
	--Khóa ngoại tới tài khoản của đối tác
	CONSTRAINT FK_DT_TK FOREIGN KEY(TaiKhoan) REFERENCES TaiKhoan(TaiKhoan) ON DELETE CASCADE
)
GO

--Tạo bảng hợp đồng
CREATE TABLE HopDong
(
	MaHD INT PRIMARY KEY IDENTITY(1, 1),
	MaDT INT NOT NULL,
	MaSoThue VARCHAR(15) NOT NULL,
	NguoiDaiDien NVARCHAR(30) NOT NULL,
	NgayBatDau DATE DEFAULT GETDATE(),
	NgayKetThuc DATE DEFAULT GETDATE(),
	HD_Status BIT DEFAULT 0,
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_HD_DT FOREIGN KEY(MaDT) REFERENCES DoiTac(MaDT) ON DELETE CASCADE
)
GO

--Tạo bảng chi nhánh
CREATE TABLE ChiNhanh
(
	MaCN INT PRIMARY KEY IDENTITY(1, 1),
	MaDT INT NOT NULL, 
	MaHD INT,
	Ten NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(30) UNIQUE NOT NULL,
	Sdt VARCHAR(10) UNIQUE NOT NULL,
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_CN_DT FOREIGN KEY(MaDT) REFERENCES DoiTac(MaDT) ON DELETE CASCADE,
	--Khóa ngoại tới hợp đồng
	CONSTRAINT FK_CN_HD FOREIGN KEY(MaHD) REFERENCES HopDong(MaHD)
)
GO

--Tạo bảng sản phẩm
CREATE TABLE SanPham
(
	MaSP INT PRIMARY KEY IDENTITY(1, 1),
	MaDT INT NOT NULL,
	Ten NVARCHAR(50) NOT NULL,
	Description NVARCHAR(100) DEFAULT '',
	GIA_SP INT NOT NULL CONSTRAINT CHK_SP_GIA_SP CHECK (GIA_SP >= 0),
	CONSTRAINT FK_SP_DT FOREIGN KEY (MaDT) REFERENCES DoiTac(MaDT) ON DELETE CASCADE
)
GO

--Tạo bảng chi nhánh sản phẩm
CREATE TABLE ChiNhanh_SanPham
(
	MaSP INT NOT NULL,
	MaCN INT NOT NULL,
	SoLuong_CS INT NOT NULL DEFAULT 0 CONSTRAINT CHK_CHI_NHANH_SP_SO_LUONG CHECK (SoLuong_CS >= 0),
	PRIMARY KEY (MaSP, MaCN),
	--Khóa ngoại tới sản phẩm
	CONSTRAINT FK_CNSP_SP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP) ON DELETE CASCADE,
	--Khóa ngoại tới chi nhánh chứa sản phẩm
	CONSTRAINT FK_CNSP_CN FOREIGN KEY (MaCN) REFERENCES ChiNhanh(MaCN)
)
GO

--Tạo bảng khách hàng
CREATE TABLE KhachHang
(
	MaKH INT PRIMARY KEY IDENTITY(1, 1),
	TaiKhoan VARCHAR(20) UNIQUE NOT NULL,
	HoTen NVARCHAR(30) NOT NULL,
	DiaChi NVARCHAR(30),
	SDT VARCHAR(10) UNIQUE NOT NULL,
	Email VARCHAR(30) UNIQUE NOT NULL,
	--Khóa ngoại tới tài khoản khách hàng
	CONSTRAINT FK_KH_TK FOREIGN KEY (TaiKhoan) REFERENCES TaiKhoan(TaiKhoan) ON DELETE CASCADE
)
GO

--Tạo bảng tài xế
CREATE TABLE TaiXe
(
	MaTX INT PRIMARY KEY IDENTITY(1, 1),
	TaiKhoan VARCHAR(20) UNIQUE NOT NULL,
	HoTen NVARCHAR(30) NOT NULL,
	CMND  CHAR(10) UNIQUE NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	BienSo CHAR(15) NOT NULL,
	KhuVuc NVARCHAR(20) NOT NULL,
	Email VARCHAR(30) NOT NULL,
	Bank VARCHAR(20) NOT NULL,
	--Khóa ngoại tới tài khoản tài xế
	CONSTRAINT FK_TX_TK FOREIGN KEY (TaiKhoan) REFERENCES TaiKhoan(TaiKhoan) ON DELETE CASCADE
)
GO

--Tạo bảng đơn hàng
CREATE TABLE DonHang
(
	MaDH INT PRIMARY KEY IDENTITY(1, 1),
	MaCN INT NOT NULL,
	MaKH INT NOT NULL,
	MaTX INT,
	CachThanhToan NVARCHAR(30) NOT NULL,
	DiaChi	NVARCHAR(30) NOT NULL,
	Status NVARCHAR(15) NOT NULL DEFAULT N'Đang xử lý',
	Gia INT NOT NULL CONSTRAINT CHK_DH_PHI_SP CHECK (Gia >= 0),
	PhiVanChuyen INT NOT NULL CONSTRAINT CHK_DH_PHI_VC CHECK (PhiVanChuyen >= 0),
	--Khóa ngoại tới chi nhánh
	CONSTRAINT FK_DH_CN FOREIGN KEY(MaCN) REFERENCES ChiNhanh(MaCN),
	--Khóa ngoại tới khách hàng
	CONSTRAINT FK_DH_KH FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE,
	--Khóa ngoại tới tài xế
	CONSTRAINT FK_DH_TX FOREIGN KEY(MaTX) REFERENCES TaiXe(MaTX)
)
GO


--Tạo bảng đơn hàng sản phẩm
CREATE TABLE DonHang_SanPham
(
	MaDH INT NOT NULL,
	MaSP INT NOT NULL,
	SoLuong_SD INT NOT NULL CONSTRAINT CHK_DHSP_SL CHECK (SoLuong_SD > 0),
	Gia_SD INT NOT NULL CONSTRAINT CHK_DHSP_GIA CHECK (Gia_SD >= 0),
	PRIMARY KEY(MaDH, MaSP),
	CONSTRAINT FK_DHSP_DH FOREIGN KEY(MaDH) REFERENCES DonHang(MaDH) ON DELETE CASCADE,
	CONSTRAINT FK_DHSP_SP FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
)
GO

CREATE INDEX ID_DOI_TAC_TK ON DoiTac(TaiKhoan);
CREATE INDEX ID_CHI_NHANH_DT ON ChiNhanh(MaDT);
CREATE INDEX ID_HOP_DONG_DT ON HopDong(MaDT);
CREATE INDEX ID_SAN_PHAM_MA_DT ON SanPham(MaDT);
CREATE INDEX ID_CHI_NHANH_SP ON ChiNhanh_SanPham(MaCN);
CREATE INDEX ID_KHACH_HANG_TK ON KhachHang(TaiKhoan);
CREATE INDEX ID_TAI_XE_TK ON TaiXe(TaiKhoan);
CREATE INDEX ID_DON_HANG_CN ON DonHang(MaCN);
CREATE INDEX ID_DON_HANG_KH ON DonHang(MaKH);
CREATE INDEX ID_DON_HANG_TX ON DonHang(MaTX);
CREATE INDEX ID_DHSP_DH ON DonHang_SanPham(MaDH);