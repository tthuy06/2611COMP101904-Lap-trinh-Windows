using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            QuanLySinhVien qlsv = new QuanLySinhVien();
            int choice;

            do
            {
                Console.WriteLine("\n===== QUAN LY SINH VIEN =====");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim sinh vien theo ma");
                Console.WriteLine("4. Tim sinh vien theo ten");
                Console.WriteLine("5. Sua diem trung binh");
                Console.WriteLine("6. Xoa sinh vien");
                Console.WriteLine("7. Sap xep theo diem giam dan");
                Console.WriteLine("8. Loc sinh vien dat");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Loi: Vui long nhap vao mot so nguyen hop le!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n--- THEM SINH VIEN ---");
                        Console.Write("Nhap ma sinh vien: ");
                        string maSV = Console.ReadLine();
                        Console.Write("Nhap ho ten: ");
                        string hoTen = Console.ReadLine();
                        Console.Write("Nhap ngay sinh: ");
                        string ngaySinh = Console.ReadLine();
                        Console.Write("Nhap ma lop: ");
                        string maLop = Console.ReadLine();

                        double dtb = NhapDiemTrungBinh();

                        try
                        {
                            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, maLop, dtb);
                            bool kq = qlsv.ThemSinhVien(sv);
                            if (kq)
                                Console.WriteLine("Them sinh vien thanh cong!");
                            else
                                Console.WriteLine("Loi: Ma sinh vien nay da ton tai trong danh sach!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Loi: {ex.Message}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- DANH SACH SINH VIEN ---");
                        qlsv.XuatDanhSach();
                        break;

                    case 3:
                        Console.Write("Nhap ma sinh vien can tim: ");
                        string maTim = Console.ReadLine();
                        var foundSV = qlsv.TimTheoMa(maTim);
                        if (foundSV != null)
                        {
                            Console.WriteLine("Da tim thay:");
                            foundSV.LayThongTin();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Khong tìm thấy sinh viên có mã này.");
                        }
                        break;

                    case 4:
                        Console.Write("Nhap tu khoa ho ten can tim: ");
                        string keyword = Console.ReadLine();
                        var listName = qlsv.TimTheoTen(keyword);
                        if (listName.Count > 0)
                        {
                            Console.WriteLine($"Tim thay {listName.Count} sinh vien phù hợp:");
                            foreach (var s in listName)
                            {
                                s.LayThongTin();
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong tìm thấy sinh viên chứa từ khóa trên.");
                        }
                        break;

                    case 5:
                        Console.Write("Nhap ma sinh vien can sua diem: ");
                        string maSua = Console.ReadLine();
                        double diemMoi = NhapDiemTrungBinh();
                        try
                        {
                            if (qlsv.SuaDiem(maSua, diemMoi))
                                Console.WriteLine("Cap nhat điểm thành công!");
                            else
                                Console.WriteLine("Không tìm thấy mã sinh viên để sửa.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Loi: {ex.Message}");
                        }
                        break;

                    case 6:
                        Console.Write("Nhap ma sinh vien can xoa: ");
                        string maXoa = Console.ReadLine();
                        if (qlsv.XoaSinhVien(maXoa))
                            Console.WriteLine("Xoa sinh vien thành công!");
                        else
                            Console.WriteLine("Khong tìm thấy mã sinh viên cần xóa.");
                        break;

                    case 7:
                        Console.WriteLine("\n--- DANH SACH SAP XEP DIEM GIAM DAN ---");
                        var listSort = qlsv.SapXepTheoDiemGiamDan();
                        foreach (var s in listSort)
                        {
                            s.LayThongTin();
                            Console.WriteLine();
                        }
                        break;

                    case 8:
                        Console.WriteLine("\n--- DANH SACH SINH VIEN ĐẠT (DTB >= 5.0) ---");
                        var listPass = qlsv.LocSinhVienDat();
                        if (listPass.Count == 0)
                            Console.WriteLine("Không có sinh viên nào đạt.");
                        else
                        {
                            foreach (var s in listPass)
                            {
                                s.LayThongTin();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh. Tam biet!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long chọn từ 0 đến 8.");
                        break;
                }
            } while (choice != 0);
        }

        // Hàm hỗ trợ nhập điểm an toàn, bắt lỗi ngoài khoảng 0-10
        static double NhapDiemTrungBinh()
        {
            double dtb;
            while (true)
            {
                Console.Write("Nhap diem trung binh (0 - 10): ");
                if (double.TryParse(Console.ReadLine(), out dtb))
                {
                    if (dtb >= 0 && dtb <= 10) return dtb;
                    Console.WriteLine("Loi: Điểm phải nằm trong khoảng từ 0 đến 10[cite: 15]!");
                }
                else
                {
                    Console.WriteLine("Loi: Vui long nhap vao mot so thuc hop le!");
                }
            }
        }
    }
}