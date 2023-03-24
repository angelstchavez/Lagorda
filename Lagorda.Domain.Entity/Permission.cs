using System;

namespace Lagorda.Domain.Entity
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public Role Role { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
