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


<img width="638" height="478" alt="1793544797418_3321905381452441591_3321905381452441591_b7c86b30d0a09f206dfcadad672500c3" src="https://github.com/user-attachments/assets/e959e77e-72dd-4d25-bf8b-49bd705473c1" />
<img width="642" height="475" alt="1793544797262_3321905381452441591_3321905381452441591_93b3a4791fb8783ec7cefde460ce7d6d" src="https://github.com/user-attachments/assets/011117c9-9d35-4e50-a865-19ccd8d4d5fe" />
<img width="637" height="477" alt="1793544797887_3321905381452441591_3321905381452441591_7d9c63502b4d4b1a71344fc46076c628" src="https://github.com/user-attachments/assets/0ea08271-6740-4eba-a39b-bfa0040c041b" />
