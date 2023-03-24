using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IBrandRepository
    {
        int Create(Brand brand, out string message);
        bool Update(Brand brand, out string message);
        bool Delete(Brand brand, out string message);
        List<Brand> GetBrands();
    }
}
