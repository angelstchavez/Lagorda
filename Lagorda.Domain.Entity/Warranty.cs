using System;

namespace Lagorda.Domain.Entity
{
    public class Warranty
    {
        public int Period { get; set; }
        public WarrantyUnit Unit { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public enum WarrantyUnit
    {
        Day,
        Month,
        Year
    }
}
