using System;

namespace Lagorda.Domain.Entity
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime CreatedAt { get; set; }

        public decimal Subtotal
        {
            get { return SalePrice * Quantity; }
        }

        public decimal Total
        {
            get { return Subtotal; }
        }
    }
}
