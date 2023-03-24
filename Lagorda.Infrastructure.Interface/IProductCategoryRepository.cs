using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IProductCategoryRepository
    {
        int Create(ProductCategory productCategory, out string message);
        bool Update(ProductCategory productCategory, out string message);
        bool Delete(ProductCategory productCategory, out string message);
        List<ProductCategory> GetProductCategories();
    }
}
