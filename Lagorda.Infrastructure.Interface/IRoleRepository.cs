using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IRoleRepository
    {
        List<Role> GetRoles();
    }
}
