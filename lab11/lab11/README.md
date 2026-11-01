# Lab 11 - ADO.NET và CRUD với SQL Server (Quản lý lớp học)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Kết nối trực tiếp:** Giao tiếp ứng dụng WinForms với cơ sở dữ liệu `EduManagerDB` trên SQL Server thông qua thư viện `Microsoft.Data.SqlClient`.
- **Thực hiện CRUD an toàn:** Xây dựng tính năng Thêm, Sửa, Xóa, Tìm kiếm lớp học. **100% các câu lệnh SQL đều sử dụng `SqlParameter`**, tuyệt đối không nối chuỗi để phòng chống SQL Injection.
- **Validation chặt chẽ:** Kiểm tra lỗi rỗng dữ liệu, trùng mã lớp và bắt lỗi ràng buộc khóa ngoại khi xóa lớp đang chứa sinh viên.

---

## 🚀 Hướng dẫn chạy chương trình
1. Cấu hình lại chuỗi kết nối (`ConnectionString`) trong code cho phù hợp với SQL Server trên máy cá nhân.
2. Build và chạy project để tương tác trực tiếp với dữ liệu trong database.
