# Báo cáo Bài tập Lab 04 - Lập trình Windows (C# WinForms)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

# Mô tả bài toán
Ứng dụng C# WinForms quản lý đăng ký khóa học áp dụng giao diện trực quan, xử lý sự kiện linh hoạt và kiểm soát dữ liệu đầu vào chặt chẽ.

## Các yêu cầu kỹ thuật đã thực hiện
- **Cấu trúc dữ liệu & Giao diện:** Sử dụng `Dictionary` kết hợp cấu trúc `KhoaHocInfo` để quản lý thông tin học phí và mô tả chi tiết của từng khóa học, hiển thị linh hoạt lên `ComboBox`.
- **Đóng gói & Xử lý sự kiện:** Tự động tính toán tổng học phí dựa theo công thức học phí một tháng nhân với số tháng đăng ký (`NumericUpDown`), cập nhật tức thì khi người dùng thay đổi lựa chọn.
- **Validation (Kiểm tra dữ liệu):** 
  - Chuẩn hóa khoảng trắng và đếm ký tự họ tên, giới hạn tối đa 50 ký tự hiển thị trực tiếp lên `lblDemKyTu`.
  - Kiểm tra bắt buộc nhập họ tên, số điện thoại (chỉ chứa ký tự số và đúng định dạng 10 chữ số) và chọn khóa học.
- **Quản lý form & Tương tác:** Xây dựng đầy đủ các chức năng form load mặc định (chọn sẵn khóa học đầu tiên, hình thức Online, số tháng từ 1 đến 12), nút Làm mới (`Reset`) đưa form về trạng thái ban đầu, và hộp thoại xác nhận khi thoát ứng dụng.
- **Xuất phiếu đăng ký:** Hiển thị chi tiết toàn bộ thông tin học viên, khóa học, hình thức, thời gian và tổng học phí qua `MessageBox` khi đăng ký thành công.

## Hướng dẫn chạy chương trình
1. Mở file giải pháp `.sln` của dự án Lab 04 bằng phần mềm **Visual Studio**.
2. Nhấn tổ hợp phím `Ctrl + Shift + B` để biên dịch project, sau đó nhấn phím `F5` hoặc nút **Start** để chạy chương trình.
   <img width="1082" height="436" alt="lab 04" src="https://github.com/user-attachments/assets/99f2d65a-56b5-4c60-9619-164d4e7619fa" />
<img width="1472" height="363" alt="lab 04 (2)" src="https://github.com/user-attachments/assets/c40f7396-d827-48a9-8f0c-56900362d193" />
<img width="537" height="293" alt="lab 04 (3)" src="https://github.com/user-attachments/assets/6f4e77e0-6914-4c62-9fd7-96d22371a25a" />
<img width="1477" height="345" alt="lab 04 (4)" src="https://github.com/user-attachments/assets/79b46f82-c581-49ad-bf90-1db11de1cef7" />
<img width="1472" height="412" alt="lab 04 (5)" src="https://github.com/user-attachments/assets/92a7dc69-763e-4aa8-a6b8-d0b5db910442" />
<img width="656" height="301" alt="lab 04 (6)" src="https://github.com/user-attachments/assets/e03c6989-d6f7-42c9-8b9e-e860ad0bf0d2" />
