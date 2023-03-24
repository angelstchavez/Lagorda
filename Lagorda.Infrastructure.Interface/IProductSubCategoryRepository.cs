using Lagorda.Domain.Entity;
using System.Collections.Generic;

namespace Lagorda.Infrastructure.Interface
{
    public interface IProductSubCategoryRepository
    {
        int Create(ProductSubCategory productSubCategory, out string message);
        bool Update(ProductSubCategory productSubCategory, out string message);
        bool Delete(ProductSubCategory productSubCategory, out string message);
        List<ProductSubCategory> GetProductSubCategories();
    }
}
