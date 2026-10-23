using System;

namespace Lab03
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }

        public Nguoi() { }

        public Nguoi(string hoTen, string ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public virtual void LayThongTin()
        {
            Console.Write($"Họ tên: {HoTen} | Ngày sinh: {NgaySinh}");
        }
    }
}
