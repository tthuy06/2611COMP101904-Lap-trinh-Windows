# Lab 13 - Báo cáo sinh viên bằng LINQ và Xuất file

## 📌 Thông tin sinh viên
- **Môn học:** Lập trình trên Windows (COMP1019)
- **Học phần:** Xử lý tập hợp dữ liệu nâng cao bằng LINQ

---

## 🛠️ Nội dung chính & Yêu cầu kỹ thuật
- **Mô hình dữ liệu (`SinhVien`):** Xây dựng lớp sinh viên với thuộc tính chỉ đọc `KetQua` tự động phân loại "Đạt" (Điểm >= 5) hoặc "Không đạt".
- **Truy vấn LINQ mạnh mẽ:** 
  - Lọc dữ liệu theo lớp, điều kiện kết quả học tập và từ khóa tìm kiếm (`Where`).
  - Sắp xếp danh sách giảm dần theo điểm trung bình (`OrderByDescending`).
  - Nhóm dữ liệu và tính toán thống kê tổng số sinh viên, số đạt, số không đạt, điểm trung bình theo từng lớp (`GroupBy`, `Average`).
- **Xuất báo cáo:** Tích hợp `SaveFileDialog` hỗ trợ xuất toàn bộ dữ liệu báo cáo đang hiển thị ra file định dạng CSV hoặc TXT một cách mượt mà, chuyên nghiệp.

---

## 🚀 Hướng dẫn chạy chương trình
1. Khởi chạy project trong Visual Studio.
2. Chọn tiêu chí lọc trên giao diện và nhấn **Xem báo cáo** hoặc **Thống kê**, sau đó có thể bấm **Xuất file** để lưu kết quả báo cáo.

   <img width="644" height="494" alt="1793544806977_3321905381452441591_3321905381452441591_9248ab9731fb7b435350fda63c26d145" src="https://github.com/user-attachments/assets/5acf72ce-2058-4538-9017-e0a75bb6f9e7" />
<img width="644" height="493" alt="1793544806427_3321905381452441591_3321905381452441591_239d34f18f6416b7e09532a8ffeba01f" src="https://github.com/user-attachments/assets/6424253b-0781-4e87-a8f8-529ecdbd8273" />
<img width="643" height="489" alt="1793544806597_3321905381452441591_3321905381452441591_571a2b3d03f50e0c801bb3bba6b7f7f7" src="https://github.com/user-attachments/assets/90581ffa-1e0d-4091-b38e-0d2583c9d29b" />
<img width="638" height="493" alt="1793544807541_3321905381452441591_3321905381452441591_15b87f68fc8718d6687afa8dff8bacba" src="https://github.com/user-attachments/assets/a38085fb-c144-4dd3-8eec-d4da25d3d19f" />
<img width="642" height="491" alt="1793544807328_3321905381452441591_3321905381452441591_c6f9941a894bcfb9cf14857c0fa905e3" src="https://github.com/user-attachments/assets/d8af7478-f280-4b4a-b1c4-181660fac7f1" />
