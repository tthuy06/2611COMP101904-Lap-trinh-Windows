using System;
using System.Collections.Generic;

namespace QuanLyNhanVien
{
    // 1. Lớp cơ sở NhanVien
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        private double luongCoBan;
        public double LuongCoBan
        {
            get => luongCoBan;
            set => luongCoBan = value > 0 ? value : 1000000; // Đảm bảo > 0
        }

        public NhanVien(string maNV, string hoTen, double luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Mã NV: {MaNV} | Họ tên: {HoTen} | Lương cơ bản: {LuongCoBan:N0} VNĐ | Tổng lương: {TinhLuong():N0} VNĐ");
        }
    }

    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;
        public int SoNgayLamViec
        {
            get => soNgayLamViec;
            set => soNgayLamViec = (value >= 0 && value <= 31) ? value : 0;
        }

        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec)
            : base(maNV, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;
        }

        public override void HienThiThongTin()
        {
            Console.Write("[Nhân viên Văn phòng] ");
            Console.WriteLine($"Mã NV: {MaNV} | Họ tên: {HoTen} | Ngày làm: {SoNgayLamViec} | Tổng lương: {TinhLuong():N0} VNĐ");
        }
    }

    public class NhanVienKinhDoanh : NhanVien
    {
        private double doanhSo;
        public double DoanhSo
        {
            get => doanhSo;
            set => doanhSo = value >= 0 ? value : 0;
        }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo)
            : base(maNV, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }

        public override void HienThiThongTin()
        {
            Console.Write("[Nhân viên Kinh doanh] ");
            Console.WriteLine($"Mã NV: {MaNV} | Họ tên: {HoTen} | Doanh số: {DoanhSo:N0} | Tổng lương: {TinhLuong():N0} VNĐ");
        }
    }

    public class NhanVienThoiVu : NhanVien
    {
        public double SoGioLam { get; set; }
        public double LuongTheoGio { get; set; }

        public NhanVienThoiVu(string maNV, string hoTen, double soGioLam, double luongTheoGio)
            : base(maNV, hoTen, 0) 
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            Console.Write("[Nhân viên Thời vụ] ");
            Console.WriteLine($"Mã NV: {MaNV} | Họ tên: {HoTen} | Số giờ: {SoGioLam} | Lương/giờ: {LuongTheoGio:N0} | Tổng lương: {TinhLuong():N0} VNĐ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<NhanVien> danhSach = new List<NhanVien>();


            danhSach.Add(new NhanVienVanPhong("VP01", "Nguyễn Văn An", 5000000, 22));
            danhSach.Add(new NhanVienVanPhong("VP02", "Trần Thị Bình", 6000000, 25));
            danhSach.Add(new NhanVienKinhDoanh("KD01", "Lê Hoàng Cường", 4000000, 50000000));
            danhSach.Add(new NhanVienKinhDoanh("KD02", "Phạm Thị Dung", 4500000, 80000000));
            danhSach.Add(new NhanVienThoiVu("TV01", "Hoàng Văn Em", 120, 40000));

            int choice;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xuất danh sách nhân viên");
                Console.WriteLine("2. Tìm nhân viên theo mã");
                Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("4. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập số!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
                        foreach (var nv in danhSach)
                        {
                            nv.HienThiThongTin();
                        }
                        break;

                    case 2:
                        Console.Write("Nhập mã nhân viên cần tìm: ");
                        string ma = Console.ReadLine();
                        var found = danhSach.Find(nv => nv.MaNV.Equals(ma, StringComparison.OrdinalIgnoreCase));
                        if (found != null)
                        {
                            Console.WriteLine("Đã tìm thấy:");
                            found.HienThiThongTin();
                        }
                        else
                        {
                            Console.WriteLine($"Không tìm thấy nhân viên có mã: {ma}");
                        }
                        break;

                    case 3:
                        if (danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sách trống!");
                            break;
                        }
                        NhanVien maxNv = danhSach[0];
                        foreach (var nv in danhSach)
                        {
                            if (nv.TinhLuong() > maxNv.TinhLuong())
                            {
                                maxNv = nv;
                            }
                        }
                        Console.WriteLine("\n--- NHÂN VIÊN CÓ LƯƠNG CAO NHẤT ---");
                        maxNv.HienThiThongTin();
                        break;

                    case 4:
                        double tongLuong = 0;
                        foreach (var nv in danhSach)
                        {
                            tongLuong += nv.TinhLuong();
                        }
                        Console.WriteLine($"\nTổng lương công ty phải trả: {tongLuong:N0} VNĐ");
                        break;

                    case 0:
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        break;

                    default:
                        Console.WriteLine("Chức năng không tồn tại. Vui lòng chọn từ 0 đến 4.");
                        break;
                }

            } while (choice != 0);
        }
    }
}