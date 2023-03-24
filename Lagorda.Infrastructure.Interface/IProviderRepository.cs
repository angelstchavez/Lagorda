using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IProviderRepository
    {
        int Create(Provider provider, out string message);
        bool Update(Provider provider, out string message);
        bool Delete(Provider provider, out string message);
        List<Provider> GetProviders();
    }
}
