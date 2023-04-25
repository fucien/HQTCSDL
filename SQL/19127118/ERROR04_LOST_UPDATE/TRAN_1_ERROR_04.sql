USE CHUYEN_HANG_ONLINE;

--Cập nhật thêm 10 sản phẩm 2 cho chi nhánh 2 (delay 10s)
EXEC CapNhatSoLuongSP_ERROR 2, 2, 10, '00:00:10'

SELECT * FROM ChiNhanh_SanPham
