--Set đơn hàng 8 về tình trạng chưa xử lý
USE CHUYEN_HANG_ONLINE;
UPDATE DonHang
SET Status = N'Đang xử lý', MaTX = NULL
WHERE MaDH = 25;