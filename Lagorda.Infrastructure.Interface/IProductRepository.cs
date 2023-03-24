using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IProductRepository
    {
        int Create(Product product, out string message);
        bool Update(Product product, out string message);
        bool Delete(Product product, out string message);
        List<Product> GetProducts();
    }
}
