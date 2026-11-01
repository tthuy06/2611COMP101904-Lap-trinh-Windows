**# Lab 06 - Windows Forms Nâng cao & DataGridView (ProductManager)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Thành phần giao diện nâng cao:** Tích hợp `MenuStrip` (File, Quản lý, Trợ giúp), `ToolStrip` các nút thao tác nhanh, `StatusStrip` hiển thị trạng thái và tổng số lượng sản phẩm, kết hợp `ContextMenuStrip` khi nhấn chuột phải vào danh sách.
- **Quản lý dữ liệu (CRUD):** Sử dụng `BindingList<Product>` kết hợp `BindingSource` và `DataGridView` để thực hiện thêm, sửa, xóa, tìm kiếm và làm mới dữ liệu trong bộ nhớ.
- **Xử lý ảnh:** Sử dụng `OpenFileDialog` kết hợp `PictureBox` để chọn và hiển thị hình ảnh sản phẩm trực quan.
- **Validation chuyên nghiệp:** Ứng dụng `ErrorProvider` để kiểm tra lỗi dữ liệu đầu vào (mã sản phẩm không được trùng, đơn giá > 0, số lượng >= 0, ngày nhập không lớn hơn ngày hiện tại).

---

## 🚀 Hướng dẫn chạy chương trình
1. Mở solution project trong Visual Studio.
2. Build và nhấn **F5** để chạy ứng dụng quản lý sản phẩm.**
