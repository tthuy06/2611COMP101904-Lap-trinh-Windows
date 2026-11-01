# Lab 12 - Quản lý kết quả học tập (Stored Procedure & Transaction)


## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---
## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Data Binding:** Sử dụng `DataTable`, `SqlDataAdapter` và `BindingSource` để đổ dữ liệu linh hoạt vào `ComboBox` và `DataGridView`.
- **Stored Procedure:** Viết các thủ tục lưu trữ trên SQL Server phục vụ việc lấy danh sách lớp, môn học, danh sách sinh viên theo lớp/môn và lưu điểm (`sp_KetQua_Save`).
- **Giao dịch an toàn (Transaction):** 
  - Cho phép nhập điểm hàng loạt cho cả lớp.
  - Sử dụng `SqlTransaction` để đảm bảo tính nguyên tử (Atomicity): Nếu tất cả điểm hợp lệ -> `Commit` lưu xuống CSDL; nếu có bất kỳ dòng nào lỗi -> `Rollback` hủy toàn bộ thao tác, không lưu dữ liệu rác.

---

## 🚀 Hướng dẫn chạy chương trình
1. Chạy script SQL tạo database `QLSinhVienLab12` và các stored procedure yêu cầu.
2. Mở ứng dụng, chọn Lớp, chọn Môn học, tải danh sách sinh viên, nhập điểm và bấm **Lưu tất cả**.
