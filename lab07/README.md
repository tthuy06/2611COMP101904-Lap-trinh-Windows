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
