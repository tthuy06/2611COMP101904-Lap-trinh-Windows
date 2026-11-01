# Lab 08 - Ứng dụng Paint đơn giản (GDI+)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Tương tác chuột:** Xử lý thành thạo các sự kiện `MouseDown`, `MouseMove`, `MouseUp` trên vùng canvas để vẽ tương tác thời gian thực.
- **Đa dạng công cụ vẽ:** Hỗ trợ vẽ tự do (`Pen`), đường thẳng (`Line`), hình chữ nhật (`Rectangle`), và hình ellipse (`Ellipse`) theo mọi hướng kéo chuột.
- **Tùy chỉnh linh hoạt:** Tích hợp `ColorDialog` để đổi màu nét vẽ, `NumericUpDown` chỉnh độ dày từ 1 đến 20, cùng các chức năng `Undo` (xóa nét gần nhất) và `Clear` (xóa toàn bộ).
- **Kiến trúc lưu trữ:** Lưu trữ danh sách đối tượng vẽ vào `List<DrawItem>` và vẽ lại ổn định trong sự kiện `Paint` của Panel, đảm bảo không bị mất hình khi resize cửa sổ.

---

## 🚀 Hướng dẫn chạy chương trình
1. Mở project Paint bằng Visual Studio.
2. Nhấn `F5`, chọn chế độ vẽ, chọn màu/độ dày trên thanh công cụ và kéo chuột trên vùng canvas để trải nghiệm.
