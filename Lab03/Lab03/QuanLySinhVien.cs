    using Lab03;
    using System;
    using System.Collections.Generic;
    using System.Linq;

namespace Lab03
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();

        // 1. Thêm sinh viên (kiểm tra mã không trùng)
        public bool ThemSinhVien(SinhVien sv)
        {
            if (danhSachSV.Any(s => s.MaSinhVien.Equals(sv.MaSinhVien, StringComparison.OrdinalIgnoreCase)))
            {
                return false; // Mã đã tồn tại
            }
            danhSachSV.Add(sv);
            return true;
        }

        // 2. Xuất danh sách[cite: 15]
        public void XuatDanhSach()
        {
            if (danhSachSV.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên trống!");
                return;
            }
            foreach (var sv in danhSachSV)
            {
                sv.LayThongTin();
                Console.WriteLine();
            }
        }

        // 3. Tìm theo mã[cite: 15]
        public SinhVien TimTheoMa(string maSV)
        {
            return danhSachSV.FirstOrDefault(s => s.MaSinhVien.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        // 4. Tìm theo tên (sử dụng LINQ chứa từ khóa)[cite: 15]
        public List<SinhVien> TimTheoTen(string keyword)
        {
            return danhSachSV.Where(s => s.HoTen.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // 5. Sửa điểm[cite: 15]
        public bool SuaDiem(string maSV, double diemMoi)
        {
            var sv = TimTheoMa(maSV);
            if (sv != null)
            {
                sv.DiemTrungBinh = diemMoi;
                return true;
            }
            return false;
        }

        // 6. Xóa sinh viên[cite: 15]
        public bool XoaSinhVien(string maSV)
        {
            var sv = TimTheoMa(maSV);
            if (sv != null)
            {
                danhSachSV.Remove(sv);
                return true;
            }
            return false;
        }

        // 7. Sắp xếp theo điểm giảm dần bằng LINQ[cite: 15]
        public List<SinhVien> SapXepTheoDiemGiamDan()
        {
            return danhSachSV.OrderByDescending(s => s.DiemTrungBinh).ToList();
        }

        // 8. Lọc sinh viên đạt (điểm >= 5.0) bằng LINQ[cite: 15]
        public List<SinhVien> LocSinhVienDat()
        {
            return danhSachSV.Where(s => s.DiemTrungBinh >= 5.0).ToList();
        }
    }
}