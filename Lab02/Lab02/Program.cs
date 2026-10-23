using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] a = null; // Khởi tạo mảng ban đầu là null để kiểm tra việc nhập mảng
        int choice;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap mang");
            Console.WriteLine("2. Xuat mang");
            Console.WriteLine("3. Tinh tong");
            Console.WriteLine("4. Tim max/min");
            Console.WriteLine("5. Dem chan/le");
            Console.WriteLine("6. Sap xep tang dan");
            Console.WriteLine("7. Tim kiem");
            Console.WriteLine("0. Thoat");

            choice = NhapSoNguyen("Chon chuc nang: ");

            switch (choice)
            {
                case 1:
                    a = NhapMang();
                    break;
                case 2:
                    if (KiemTraMang(a)) XuatMang(a);
                    break;
                case 3:
                    if (KiemTraMang(a))
                    {
                        Console.WriteLine($"Tong cac phan tu trong mang la: {TinhTong(a)}");
                    }
                    break;
                case 4:
                    if (KiemTraMang(a))
                    {
                        Console.WriteLine($"Gia tri lon nhat (Max): {TimMax(a)}");
                        Console.WriteLine($"Gia tri nho nhat (Min): {TimMin(a)}");
                    }
                    break;
                case 5:
                    if (KiemTraMang(a))
                    {
                        Console.WriteLine($"So luong phan tu chan: {DemChan(a)}");
                        Console.WriteLine($"So luong phan tu le: {DemLe(a)}");
                    }
                    break;
                case 6:
                    if (KiemTraMang(a))
                    {
                        SapXepTangDan(a);
                        Console.WriteLine("Mang sau khi sap xep tang dan:");
                        XuatMang(a);
                    }
                    break;
                case 7:
                    if (KiemTraMang(a))
                    {
                        int x = NhapSoNguyen("Nhap gia tri x can tim: ");
                        int index = Timkiem(a, x);
                        if (index != -1)
                            Console.WriteLine($"Tim thay x = {x} tai vi trí dau tien la: {index} (tính từ 0)");
                        else
                            Console.WriteLine($"Khong tim thay x = {x} trong mang.");
                    }
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le! Vui long chon tu 0 den 7.");
                    break;
            }
        } while (choice != 0);
    }

    // --- CÁC PHƯƠNG THỨC HỖ TRỢ KIỂM TRA & NHẬP DỮ LIỆU ---
    static int NhapSoNguyen(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Loi: Vui long nhap vao mot so nguyen hop le!");
        }
    }

    static int NhapSoNguyenDuong(string message)
    {
        int n;
        while (true)
        {
            n = NhapSoNguyen(message);
            if (n > 0) return n;
            Console.WriteLine("Loi: Gia tri phai la so nguyen duong (> 0). Vui long nhap lai!");
        }
    }

    static bool KiemTraMang(int[] a)
    {
        if (a == null)
        {
            Console.WriteLine("Thong bao: Ban chua nhap mang! Vui long chon chuc nang 1 truoc.");
            return false;
        }
        return true;
    }

    // --- CÁC PHƯƠNG THỨC XỬ LÝ MẢNG ---
    static int[] NhapMang()
    {
        int n = NhapSoNguyenDuong("Nhap so luong phan tu n: ");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = NhapSoNguyen($"Nhap phan tu a[{i}]: ");
        }
        Console.WriteLine("Nhap mang thanh cong!");
        return a;
    }

    static void XuatMang(int[] a)
    {
        Console.WriteLine("Cac phan tu trong mang la: " + string.Join(" ", a));
    }

    static int TinhTong(int[] a)
    {
        int sum = 0;
        foreach (int x in a) sum += x;
        return sum;
    }

    static int TimMax(int[] a)
    {
        int max = a[0];
        foreach (int x in a)
        {
            if (x > max) max = x;
        }
        return max;
    }

    static int TimMin(int[] a)
    {
        int min = a[0];
        foreach (int x in a)
        {
            if (x < min) min = x;
        }
        return min;
    }

    static int DemChan(int[] a)
    {
        int count = 0;
        foreach (int x in a)
        {
            if (x % 2 == 0) count++;
        }
        return count;
    }

    static int DemLe(int[] a)
    {
        int count = 0;
        foreach (int x in a)
        {
            if (x % 2 != 0) count++;
        }
        return count;
    }

    static void SapXepTangDan(int[] a)
    {
        Array.Sort(a);
    }

    static int Timkiem(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x) return i;
        }
        return -1;
    }
}