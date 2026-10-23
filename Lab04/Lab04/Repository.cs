using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04
{
    public class Repository<T> where T : IEntity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            if (items.Any(i => i.Id.Equals(item.Id, StringComparison.OrdinalIgnoreCase)))
            {
                throw new DuplicateProductException($"Sản phẩm có mã '{item.Id}' đã tồn tại trong hệ thống!");
            }
            items.Add(item);
        }

        public void Remove(string id)
        {
            var item = FindById(id);
            if (item == null)
            {
                throw new ProductNotFoundException($"Không tìm thấy sản phẩm có mã '{id}' để xóa!");
            }
            items.Remove(item);
        }

        public T FindById(string id)
        {
            return items.FirstOrDefault(i => i.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        // Sử dụng Func<T, bool> để tìm kiếm/lọc linh hoạt
        public List<T> Find(Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }

        public List<T> GetAll()
        {
            return items;
        }
    }
}