using System;

namespace Lagorda.Domain.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public Brand Brand { get; set; }
        public ProductSubCategory ProductSubCategory { get; set; }
        public Warranty Warranty { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
