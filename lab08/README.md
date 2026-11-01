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


<img width="982" height="646" alt="Ảnh chụp màn hình 2026-11-01 160323 - Sao chép" src="https://github.com/user-attachments/assets/1c6e0e47-327b-435d-b1ed-a6dab355839f" />
<img width="995" height="647" alt="Ảnh chụp màn hình 2026-11-01 160337 - Sao chép" src="https://github.com/user-attachments/assets/028ddbbb-290b-47fc-994a-7cd95fa26243" />
<img width="991" height="647" alt="Ảnh chụp màn hình 2026-11-01 160245 - Sao chép" src="https://github.com/user-attachments/assets/820a4e9e-cccb-42f4-9a9f-7fc05dcb2561" />
<img width="997" height="647" alt="Ảnh chụp màn hình 2026-11-01 160251 - Sao chép" src="https://github.com/user-attachments/assets/95e6071e-7b3a-44b0-bac6-9492e6ef6a6e" />
<img width="1015" height="663" alt="Ảnh chụp màn hình 2026-11-01 160259 - Sao chép" src="https://github.com/user-attachments/assets/2aefc4a0-90d0-4af8-baca-671999d74540" />
<img width="1000" height="660" alt="Ảnh chụp màn hình 2026-11-01 160307 - Sao chép" src="https://github.com/user-attachments/assets/79904edf-dc14-4394-9716-0e36096846a7" />
