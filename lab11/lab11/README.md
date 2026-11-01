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


<img width="697" height="450" alt="1793544787351_3321905381452441591_3321905381452441591_a2e49ad1b6893915ffecd01b5e8ba6d7" src="https://github.com/user-attachments/assets/af60d9fa-5cdf-42bd-abf7-84aeea95dd84" />
<img width="699" height="451" alt="1793544787082_3321905381452441591_3321905381452441591_afec7341d5443a9bbdd6fc6f0d87c6bb" src="https://github.com/user-attachments/assets/79961ea2-4d5b-4314-bfae-a4eb9c51ad6a" />
<img width="700" height="451" alt="1793544786749_3321905381452441591_3321905381452441591_a9a926fc6bc22004dca1e55979767c14" src="https://github.com/user-attachments/assets/b3912a9d-c62f-45b8-b5ef-27a5d5064331" />
<img width="701" height="459" alt="1793544786308_3321905381452441591_3321905381452441591_d96ad709625bee9118a71b42ad5b8f48" src="https://github.com/user-attachments/assets/6416fd9b-af83-4ac0-9754-97d6620b5928" />
