using System;
using System.Collections.Generic;

namespace Lagorda.Domain.Entity
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public User User { get; set; }
        public Provider Provider { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public List<SaleDetail> SaleDetails { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
