# Lab 10 - Thiết kế CSDL EduManagerDB (SQL Server)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Cấu trúc quan hệ:** Thiết kế hoàn chỉnh database `EduManagerDB` gồm 6 bảng chính: `KHOA`, `LOP`, `SINHVIEN`, `MONHOC`, `KETQUA`, và `TAIKHOAN`.
- **Ràng buộc toàn vẹn:** Thiết lập đầy đủ khóa chính (`Primary Key`), khóa ngoại (`Foreign Key`), ràng buộc kiểm tra điểm số từ 0 đến 10, giới tính (Nam/Nữ) và số tín chỉ > 0.
- **Truy vấn nâng cao:** Hoàn thiện các câu lệnh `SELECT`, `JOIN`, `GROUP BY`, `UPDATE`, `DELETE` và kiểm thử các trường hợp vi phạm ràng buộc dữ liệu.

---

## 📁 Danh sách script nộp kèm
1. `01_CreateDatabase.sql` - Script khởi tạo cấu trúc database và bảng.
2. `02_InsertSampleData.sql` - Script chèn dữ liệu mẫu chuẩn quan hệ.
3. `03_Queries.sql` - Các câu lệnh truy vấn và kiểm thử ràng buộc.
