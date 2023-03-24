using System;
using System.Collections.Generic;

namespace Lagorda.Domain.Entity
{
    public class Sale
    {
        public int SaleId { get; set; }
        public User User { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string CustomerDocument { get; set; }
        public string CustomerName { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public List<SaleDetail> SaleDetails { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
