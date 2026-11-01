# Lab 07 - SDI, MDI và Ứng dụng nhiều Form (ShopManagerMini)

## 📌 Thông tin sinh viên
* **Họ tên:** Nguyễn Thanh Thủy
* **MSSV:** 50.01.104.160
* **Lớp:** 50.CNTT.C

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Đăng nhập hệ thống (`FrmLogin`):** Xây dựng màn hình đăng nhập, kiểm tra tài khoản mẫu (`admin`/`123`, `user`/`123`), truyền thông tin phân quyền (`Admin`/`User`) sang Form chính.
- **Giao diện MDI (`FrmMain`):** Thiết lập `IsMdiContainer = true`, tích hợp `MenuStrip`, `StatusStrip` hiển thị thông tin người dùng, thời gian và điều phối các Form con.
- **Quản lý không trùng lặp:** Lập trình kiểm tra trạng thái các Form con (Sản phẩm, Khách hàng, Giới thiệu); nếu Form đã mở thì kích hoạt lại thay vì tạo mới.
- **Xử lý nghiệp vụ:** Tích hợp module quản lý sản phẩm và khách hàng hoàn chỉnh với các thao tác CRUD trong bộ nhớ.

---

## 🚀 Hướng dẫn chạy chương trình
1. Khởi chạy project `ShopManagerMini` trên Visual Studio.
2. Đăng nhập bằng tài khoản mẫu (`admin` / `123`) để vào giao diện quản lý chính.

<img width="432" height="282" alt="Ảnh chụp màn hình 2026-10-31 171100" src="https://github.com/user-attachments/assets/496452a2-dc60-487c-ab7a-34fc51ab651c" />
<img width="840" height="675" alt="Ảnh chụp màn hình 2026-10-31 171123" src="https://github.com/user-attachments/assets/72973b6c-c58c-40a0-ab13-776a57360070" />
<img width="835" height="607" alt="Ảnh chụp màn hình 2026-10-31 171131" src="https://github.com/user-attachments/assets/be0b7f1a-6ce6-44c8-aead-03b9ba5acec3" />
<img width="842" height="678" alt="Ảnh chụp màn hình 2026-10-31 171156" src="https://github.com/user-attachments/assets/34165de5-7dda-4380-8edf-a2bc4f05fb79" />
<img width="1035" height="698" alt="Ảnh chụp màn hình 2026-10-31 171424" src="https://github.com/user-attachments/assets/c785d32d-f4bf-4422-99b3-87b69b3844a1" />
<img width="1042" height="696" alt="Ảnh chụp màn hình 2026-10-31 171431" src="https://github.com/user-attachments/assets/f6a23785-ea3c-4b55-93d5-52235d5c8f77" />
<img width="1041" height="682" alt="Ảnh chụp màn hình 2026-10-31 171437" src="https://github.com/user-attachments/assets/d4ec6e21-cc03-42dd-bd7d-a38b64c04c68" />
<img width="1032" height="690" alt="Ảnh chụp màn hình 2026-10-31 171535" src="https://github.com/user-attachments/assets/d0166feb-a681-484d-95f1-a913b468894f" />
<img width="1041" height="697" alt="Ảnh chụp màn hình 2026-10-31 171714" src="https://github.com/user-attachments/assets/183b21a5-4c79-41f4-8209-7dc42b4e302a" />
<img width="440" height="280" alt="Ảnh chụp màn hình 2026-10-31 171750" src="https://github.com/user-attachments/assets/d993a8ff-c3dd-42b1-ad6a-f93294837382" />
