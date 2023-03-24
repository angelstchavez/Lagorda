using Lagorda.Domain.Entity;
using System.Collections.Generic;
using System.Data;

namespace Lagorda.Infrastructure.Interface
{
    public interface IPurchaseRepository
    {
        bool Create(Purchase purchase, DataTable purchaseDetails, out string message);
        int GetCorrelative();
        List<Purchase> GetPurchases();
    }
}
