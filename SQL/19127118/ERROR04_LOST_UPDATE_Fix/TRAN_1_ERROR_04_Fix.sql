USE CHUYEN_HANG_ONLINE;

SELECT * FROM ChiNhanh_SanPham

--Cập nhật thêm 10 sản phẩm 2 cho chi nhánh 2 (delay 10s)
EXEC cap_nhat_so_luong_cnsp 2, 2, 10, '00:00:10'