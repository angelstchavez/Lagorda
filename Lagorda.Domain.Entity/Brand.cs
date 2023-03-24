using System;

namespace Lagorda.Domain.Entity
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
