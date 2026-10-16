# Kết Quả Thực Nghiệm - Bài 3

## Bảng kết quả 

| Kích thước (n) | Θ(n²) | Kadane Θ(n) | Nhận xét |
| :--- | :--- | :--- | :--- |
| **100** | 0.0525 ms | 0.0076  ms | Thời gian của cả hai phiên bản đều rất nhỏ (dưới 0.1 ms) do kích thước dữ liệu quá nhỏ.|
| **1.000** | ...... ms | ...... ms | Phiên bản Θ(n²) tăng thời gian chạy (5.0144 ms), trong khi Kadane Θ(n) duy trì tốc độ (0.0149 ms), nhanh hơn phiên bản A khoảng 336 lần.|
| **10.000** | ...... ms | ...... ms | Khi dữ liệu tăng lên 10 lần, phiên bản Θ(n²) tốn thời gian rất lớn do vòng lặp lồng (241.3104 ms, tăng gần 48 lần so với mức 1.000). Ngược lại, Kadane Θ(n) xử lý nhanh (0.1351 ms, nhanh hơn phiên bản A tới 1.786 lần).|

---

## Câu hỏi báo cáo

### 1. Hai thuật toán có trả về cùng kết quả trên tất cả test case không?
- Có. Cả hai bản đều cùng giải một bài toán. Do VersionB khởi tạo bằng arr[0] nên xử lý chính xác mảng toàn số âm, kết quả đồng nhất 100% với VersionA.

### 2. Khi n tăng 10 lần, thời gian của mỗi thuật toán thay đổi như thế nào?
- Theo số liệu thực tế, VersionA  tăng vọt gần 48 lần (từ 5.01 ms lên 241.31 ms). Trong khi đó, VersionB chỉ tăng khoảng 9 lần (từ 0.015 ms lên 0.135 ms).
### 3. Vì sao kết quả đo thực tế có thể dao động giữa các lần chạy?
- *Trả lời:* Do cơ chế lập lịch tiến trình của Hệ điều hành bị ảnh hưởng bởi ứng dụng ngầm, cơ chế thu gom rác tự động của .NET, và thời gian biên dịch động ở lần thực thi đầu tiên.

### 4. Nếu cần trả về cả vị trí đầu và cuối của đoạn con, chương trình phải bổ sung thông tin nào?
- *Trả lời:* Cần bổ sung biến chỉ số start và end để lưu lại vị trí chính thức của đoạn con lớn nhất, kèm một biến tạm s_temp để theo vết điểm bắt đầu mới mỗi khi currentMax chọn bắt đầu một chuỗi độc lập từ arr[i].
