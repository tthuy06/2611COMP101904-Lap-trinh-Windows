using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ProductService service = new ProductService();

            // Đăng ký Event lắng nghe thông báo
            service.OnDataChanged += message =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[THÔNG BÁO EVENT]: {message}");
                Console.ResetColor();
            };

            int choice;
            do
            {
                Console.WriteLine("\n===== PRODUCT MANAGER =====");
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim theo ma");
                Console.WriteLine("4. Tim theo ten");
                Console.WriteLine("5. Loc theo khoang gia");
                Console.WriteLine("6. Xoa san pham");
                Console.WriteLine("7. Tinh tong gia tri kho");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập vào một số nguyên hợp lệ!");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n--- THÊM SẢN PHẨM MỚI ---");
                            Console.Write("Nhập mã sản phẩm: ");
                            string ma = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(ma))
                            {
                                Console.WriteLine("Lỗi: Mã sản phẩm không được để trống!");
                                break;
                            }

                            Console.Write("Nhập tên sản phẩm: ");
                            string ten = Console.ReadLine();

                            Console.Write("Nhập đơn giá: ");
                            double gia = double.Parse(Console.ReadLine());

                            Console.Write("Nhập số lượng: ");
                            int sl = int.Parse(Console.ReadLine());

                            Product p = new Product(ma, ten, gia, sl);
                            service.AddProduct(p);
                            break;

                        case 2:
                            Console.WriteLine("\n--- DANH SÁCH SẢN PHẨM ---");
                            var list = service.GetAllProducts();
                            if (list.Count == 0)
                            {
                                Console.WriteLine("Danh sách sản phẩm trống!");
                            }
                            else
                            {
                                foreach (var item in list)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            break;

                        case 3:
                            Console.Write("Nhập mã sản phẩm cần tìm: ");
                            string findMa = Console.ReadLine();
                            var found = service.FindById(findMa);
                            if (found != null)
                            {
                                Console.WriteLine("Đã tìm thấy:");
                                Console.WriteLine(found);
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy sản phẩm có mã này.");
                            }
                            break;

                        case 4:
                            Console.Write("Nhập từ khóa tên sản phẩm: ");
                            string keyword = Console.ReadLine();
                            // Sử dụng Func<Product, bool> thông qua phương thức Search
                            var searchList = service.Search(prod => prod.TenSP.Contains(keyword, StringComparison.OrdinalIgnoreCase));
                            if (searchList.Count > 0)
                            {
                                Console.WriteLine($"Tìm thấy {searchList.Count} sản phẩm phù hợp:");
                                foreach (var item in searchList)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy sản phẩm nào chứa từ khóa trên.");
                            }
                            break;

                        case 5:
                            Console.Write("Nhập giá tối thiểu: ");
                            double minPrice = double.Parse(Console.ReadLine());
                            Console.Write("Nhập giá tối đa: ");
                            double maxPrice = double.Parse(Console.ReadLine());

                            // Sử dụng Func<Product, bool> để lọc theo khoảng giá
                            var filteredList = service.Search(prod => prod.Price >= minPrice && prod.Price <= maxPrice);
                            if (filteredList.Count > 0)
                            {
                                Console.WriteLine($"Các sản phẩm có giá từ {minPrice:N0} đến {maxPrice:N0}:");
                                foreach (var item in filteredList)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Không có sản phẩm nào trong khoảng giá này.");
                            }
                            break;

                        case 6:
                            Console.Write("Nhập mã sản phẩm cần xóa: ");
                            string delMa = Console.ReadLine();
                            service.RemoveProduct(delMa);
                            break;

                        case 7:
                            double totalValue = service.CalculateTotalInventoryValue();
                            Console.WriteLine($"\nTổng giá trị kho hàng: {totalValue:N0} VNĐ");
                            break;

                        case 0:
                            Console.WriteLine("Kết thúc chương trình. Tạm biệt!");
                            break;

                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn từ 0 đến 7.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi định dạng: Bạn vừa nhập ký tự không phải số vào trường số lượng/đơn giá!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Lỗi dữ liệu: {ex.Message}");
                }
                catch (DuplicateProductException ex)
                {
                    Console.WriteLine($"Lỗi trùng mã: {ex.Message}");
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine($"Lỗi không tìm thấy: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi hệ thống: {ex.Message}");
                }

            } while (choice != 0);
        }
    }
}