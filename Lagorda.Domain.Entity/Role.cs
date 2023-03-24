using System;

namespace Lagorda.Domain.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; } = String.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
