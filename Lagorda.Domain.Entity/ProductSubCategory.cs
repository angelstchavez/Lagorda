using System;

namespace Lagorda.Domain.Entity
{
    public class ProductSubCategory
    {
        public int ProductSubCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
