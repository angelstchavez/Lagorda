using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IPermissionRepository
    {
        List<Permission> GetPermissions(int userId);
    }
}
