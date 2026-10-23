using System;
using System.Collections.Generic;

namespace Lab04
{
    public class ProductService
    {
        private Repository<Product> repository = new Repository<Product>();

        // Định nghĩa Event thông báo khi dữ liệu thay đổi
        public event Action<string> OnDataChanged;

        public void AddProduct(Product p)
        {
            repository.Add(p);
            // Phát sự kiện thành công
            OnDataChanged?.Invoke($"Đã thêm thành công sản phẩm: {p.MaSP} - {p.TenSP}");
        }

        public void RemoveProduct(string maSP)
        {
            repository.Remove(maSP);
            // Phát sự kiện thành công
            OnDataChanged?.Invoke($"Đã xóa thành công sản phẩm có mã: {maSP}");
        }

        public Product FindById(string maSP)
        {
            return repository.FindById(maSP);
        }

        // Sử dụng Func<Product, bool> theo yêu cầu Lab
        public List<Product> Search(Func<Product, bool> predicate)
        {
            return repository.Find(predicate);
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAll();
        }

        public double CalculateTotalInventoryValue()
        {
            double total = 0;
            foreach (var p in repository.GetAll())
            {
                total += p.Price * p.Quantity;
            }
            return total;
        }
    }
}