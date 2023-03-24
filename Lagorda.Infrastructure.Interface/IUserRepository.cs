using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IUserRepository
    {
        int Create(User user, out string message);
        bool Update(User user, out string message);
        bool Delete(User user, out string message);
        List<User> GetUsers();
        List<User> ValidateUsers();
    }
}
