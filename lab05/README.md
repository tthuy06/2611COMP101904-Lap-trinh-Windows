# Lab 05 - Windows Forms Cơ bản (CourseRegistrationApp)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
Ứng dụng được thiết kế nhằm làm quen với nền tảng C# WinForms và các control giao diện cơ bản:
- **Giao diện & Bố cục:** Sử dụng `GroupBox` để phân chia rõ nhóm *Thông tin học viên* và *Thông tin khóa học*. Các control được đặt tên theo đúng quy ước (`txtHoTen`, `txtSoDienThoai`, `dtpNgaySinh`, `chkNhanEmail`, `cboKhoaHoc`, `radOnline`, `radOffline`, `numSoThang`, `lblTongTien`).
- **Xử lý sự kiện (Form Load):** Tự động nạp danh sách khóa học kèm mức học phí/tháng, chọn sẵn khóa học đầu tiên, hình thức *Online*, thiết lập số tháng từ 1 đến 12 và hiển thị học phí ban đầu.
- **Tính toán học phí động:** Tự động cập nhật tổng học phí ngay khi thay đổi khóa học hoặc số tháng (`numSoThang`).
- **Validation & MessageBox:** Kiểm tra bắt buộc nhập họ tên, số điện thoại (10 chữ số hợp lệ), chọn khóa học; xuất phiếu đăng ký hoàn chỉnh bằng `MessageBox`.
- **Nút Làm mới & Thoát:** Đưa form về trạng thái ban đầu sạch sẽ và có hộp thoại xác nhận khi thoát chương trình.

---

## 🚀 Hướng dẫn chạy chương trình
1. Mở file giải pháp **`.sln`** của Lab 05 bằng phần mềm **Visual Studio**.
2. Nhấn `Ctrl + Shift + B` để build project.
3. Nhấn **F5** để khởi chạy ứng dụng.

<img width="1077" height="482" alt="Ảnh chụp màn hình 2026-10-31 151435" src="https://github.com/user-attachments/assets/37c42bd9-eb6f-4bda-9ce4-9668ddecf5d3" />
<img width="1082" height="482" alt="Ảnh chụp màn hình 2026-10-31 151458" src="https://github.com/user-attachments/assets/1820fa2c-f34c-4382-a0d0-d20984e87958" />
<img width="1082" height="478" alt="Ảnh chụp màn hình 2026-10-31 151514" src="https://github.com/user-attachments/assets/3472bef0-4498-4536-9866-c691deca7941" />
<img width="1091" height="920" alt="Ảnh chụp màn hình 2026-10-31 150402" src="https://github.com/user-attachments/assets/f302998f-f5aa-4a65-9326-4e11996e3882" />
<img width="1081" height="482" alt="Ảnh chụp màn hình 2026-10-31 151409" src="https://github.com/user-attachments/assets/2f6df944-9c69-49f1-b900-f68709079807" />
