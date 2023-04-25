USE CHUYEN_HANG_ONLINE;

--Đơn hàng gồm 100 sản phẩm 3
DECLARE @spsl SAN_PHAM_SO_LUONG;
INSERT INTO @spsl
VALUES (3, 100);
--Tạo đơn hàng với 100 sản phẩm 3 (delay 10s)
EXEC TaoDonDatHang 2, 1, N'Vận chuyển nhanh', 'TPHCM', 30000, '00:00:10', @spsl

SELECT * FROM DonHang WHERE MaDH = 15;
SELECT SUM(SoLuong_SD * Gia_SD) FROM DonHang_SanPham WHERE MaDH = 15;