using Lagorda.Domain.Entity;
using System.Collections.Generic;
using System.Data;

namespace Lagorda.Infrastructure.Interface
{
    public interface ISaleRepository
    {
        bool AddStock(int productId, int quantity);
        bool Create(Sale sale, DataTable saleDetails, out string message);
        int GetCorrelative();
        Sale GetSale(string number);
        List<Sale> GetSales();
        List<SaleDetail> GetSaleDetails(int saleId);
        bool SubtractStock(int productId, int quantity);
    }
}
