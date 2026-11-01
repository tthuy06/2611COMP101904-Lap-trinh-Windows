# Lab 09 - Thiết kế và In thẻ sinh viên

## 📌 Thông tin sinh viên
- **Môn học:** Lập trình trên Windows (COMP1019)
- **Học phần:** Xử lý ảnh và In ấn (PrintDocument)

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Giao diện chia đôi:** Bố cục gồm vùng nhập liệu thông tin cá nhân bên trái và vùng xem trước (`Panel`) trực quan bên ở bên phải.
- **Xử lý ảnh chuyên nghiệp:** Sử dụng `OpenFileDialog` và `PictureBox` (chế độ Zoom) để chọn và hiển thị ảnh đại diện không bị méo tỉ lệ.
- **Preview bằng GDI+:** Tự động vẽ lại thẻ sinh viên theo thời gian thực mỗi khi thông tin thay đổi.
- **In ấn tài liệu (`PrintDocument`):** Tích hợp hộp thoại xem trước `PrintPreviewDialog` và lệnh in `PrintDialog`, đi kèm cơ chế kiểm tra dữ liệu bắt buộc trước khi in.

---

## 🚀 Hướng dẫn chạy chương trình
1. Mở project trong Visual Studio và chạy bằng phím `F5`.
2. Nhập thông tin, chọn ảnh thẻ, nhấn **Xem trước khi in** hoặc **In** để kiểm tra kết quả.
