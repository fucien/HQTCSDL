﻿USE CHUYEN_HANG_ONLINE;

--Đơn hàng gồm 5 sản phẩm 2
DECLARE @spsl SAN_PHAM_SO_LUONG;
INSERT INTO @spsl
VALUES (2, 5);
--Tạo đơn hàng với 5 sản phẩm 2 (delay 0s)
EXEC tao_don_dat_hang 2, 1, N'Vận chuyển nhanh', 'TPHCM', 30000, '00:00:00', @spsl