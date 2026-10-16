# Cấu Trúc Dữ Liệu và Giải Thuật - Buổi 01

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Ngọc Bảo Hân
- **Mã số sinh viên:** 31251022117
- **Lớp học phần:** 26C1INF50900706

---
## 2. Hướng dẫn biên dịch và chạy chương trình

### Lệnh chạy
   
Chương trình phát triển bằng **C#** trên nền tảng **.NET 8.0**. Chạy bằng Terminal qua các lệnh:
1. Di chuyển vào thư mục bài cần chạy: `cd Bai1` (hoặc `Bai2`, `Bai3`)
2. Biên dịch và thực thi chương trình: `dotnet run`
3. Nhập dữ liệu đầu vào tuần tự theo hướng dẫn trên màn hình Console.
---

## 3. Mô tả giải pháp

### Bài 1: Nhập xuất và xử lý điều kiện 
* Sử dụng`int.Parse(Console.ReadLine())` nhập riêng từng số. Tính toán trong hàm qua các tham số đầu ra `out`. Tính `sum` và `mean` bằng biểu thức toán (chia `3.0` lấy số thực). Tìm `max` và `min` bằng cấu trúc rẽ nhánh `if - else` tuần tự.
### Bài 2: Hai giá trị lớn nhất phân biệt 
* Duyệt mảng đúng **1 lần** (Θ(n)). Dùng hai biến `int?` khởi tạo bằng `null` để quản lý `max1` và `max2` không cần sắp xếp. Cập nhật hạ cấp `max1` cũ xuống `max2` nếu gặp phần tử lớn hơn `max1`, hoặc cập nhật trực tiếp `max2` nếu phần tử nhỏ hơn `max1` để đảm bảo tính phân biệt.

### Bài 3: Đoạn con liên tiếp có tổng lớn nhất
* **Phiên bản A (`VersionA`):** Dùng 2 vòng lặp lồng nhau (Θ(n²)). Vòng trong cộng dồn liên tiếp từ vị trí vòng ngoài đến cuối mảng vào `currentSum` để tìm tổng lớn nhất.
* **Phiên bản B (`VersionB`):** Dùng thuật toán Kadane (Θ(n)) duyệt mảng một lần. Dùng `Math.Max` chọn giữa cộng tiếp vào chuỗi cũ hay bắt đầu chuỗi mới từ phần tử hiện tại. Khởi tạo biến bằng `arr[0]` giúp xử lý đúng mảng toàn số âm.


---

## 4. Độ phức tạp thời gian và bộ nhớ

| Bài tập | Phiên bản | Độ phức tạp thời gian | Độ phức tạp bộ nhớ phụ |
| :--- | :--- | :--- | :--- |
| **Bài 1** | Mặc định | Θ(1) | Θ(1) |
| **Bài 2** | Duyệt 1 lần | Θ(n) | Θ(1) |
| **Bài 3** | VersionA | Θ(n²) | Θ(1) |
| **Bài 3** | VersionB | Θ(n) | Θ(1) |


---
## 5. Các test case đã sử dụng kiểm thử

### 🔹 Bài 1:
* **Test:** `7`, `2`, `10` → `Lớn nhất: 10; Nhỏ nhất: 2; Tổng: 19; Trung bình: 6.33`
* **Test số âm:** ` -5`, `2`, ` -9` → `Lớn nhất: 2; Nhỏ nhất: -9; Tổng: -12; Trung bình: -4.00`
* **Test số trùng nhau:** ` 5`, ` 5`, ` 8` → `Lớn nhất: 8; Nhỏ nhất: 5; Tổng: 18; Trung bình: 6.00`

### 🔹 Bài 2:
* **Test:** Mảng `[3, 7, 2, 9, 5]` → Kết quả: `9  7`
* **Test trùng lặp:** Mảng `[9, 9, 7, 2, 5]` → Kết quả: `9  7` (Bỏ qua số 9 trùng lặp, lấy số lớn thứ hai phân biệt).
* **Test biên:** Mảng toàn số giống nhau `[4, 4, 4, 4]` → Kết quả: `NO` (Do `max2` giữ nguyên trạng thái `null`).

### 🔹 Bài 3:
* **Test:** Mảng `[-2, 1, -3, 4, -1, 2, 1, -5, 4]` → Phiên bản A và B đều trả về tổng lớn nhất là `6`.
* **Test trường hợp biên:** Mảng `[-8, -3, -6, -2, -5, -4]` → Phiên bản A và B trả về chính xác `-2` (Giá trị lớn nhất, xử lý chuẩn yêu cầu đề bài không bị mặc định bằng 0).
* **Test thực nghiệm:** Sử dụng mảng sinh ngẫu nhiên qua đối tượng `Random` với các kích thước `n = 100`, `n = 1.000`, `n = 10.000`.

---

## 6. Công cụ AI đã sử dụng

* **Tên công cụ:** Trợ lý lập trình AI (Gemini / ChatGPT).
* **Mục đích sử dụng:** 
  * Hỗ trợ tư vấn giải pháp sử dụng kiểu dữ liệu cho phép rỗng `int?` (`Nullable<int>`) trong Bài 2.
  * Chuẩn hóa cấu trúc tài liệu Markdown (`README.md`).
  * Hướng dẫn giải bài 3 với tự phát sinh mảng khi n lớn và khi người dùng tự nhập mảng.