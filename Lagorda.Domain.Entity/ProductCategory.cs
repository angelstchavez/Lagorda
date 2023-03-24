using System;

namespace Lagorda.Domain.Entity
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
