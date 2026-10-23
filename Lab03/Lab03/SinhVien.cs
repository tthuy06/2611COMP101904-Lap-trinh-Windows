
using System;

namespace Lab03
{
    public class SinhVien : Nguoi
    {
        public string MaSinhVien { get; set; }
        public string MaLop { get; set; }

        private double diemTrungBinh;
        public double DiemTrungBinh
        {
            get => diemTrungBinh;
            set
            {
                if (value >= 0 && value <= 10)
                    diemTrungBinh = value;
                else
                    throw new ArgumentException("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!");
            }
        }

        public SinhVien() { }

        public SinhVien(string maSinhVien, string hoTen, string ngaySinh, string maLop, double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh; // Sẽ gọi qua property để kiểm tra validation
        }

        // Phương thức xếp loại học lực dựa vào điểm trung bình
        public string XepLoai()
        {
            if (DiemTrungBinh >= 8.5) return "Giỏi";
            if (DiemTrungBinh >= 6.5) return "Khá";
            if (DiemTrungBinh >= 5.0) return "Trung bình";
            return "Yếu";
        }

        public override void LayThongTin()
        {
            Console.Write($"Mã SV: {MaSinhVien} | ");
            base.LayThongTin();
            Console.Write($" | Lớp: {MaLop} | Điểm TB: {DiemTrungBinh:F2} | Xếp loại: {XepLoai()}");
        }
    }
}