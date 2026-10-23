using System;

namespace Lab04
{
    public class Product : IEntity
    {
        public string MaSP { get; set; }
        public string Id => MaSP; // Triển khai từ IEntity

        public string TenSP { get; set; }

        private double price;
        public double Price
        {
            get => price;
            set => price = value >= 0 ? value : throw new ArgumentException("Đơn giá không được âm!");
        }

        private int quantity;
        public int Quantity
        {
            get => quantity;
            set => quantity = value >= 0 ? value : throw new ArgumentException("Số lượng không được âm!");
        }

        public Product() { }

        public Product(string maSP, string tenSP, double price, int quantity)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Mã SP: {MaSP,-8} | Tên SP: {TenSP,-20} | Đơn giá: {Price,10:N0} VNĐ | Số lượng: {Quantity,5} | Thành tiền: {Price * Quantity,12:N0} VNĐ";
        }
    }
}