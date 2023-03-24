using Lagorda.Domain.Entity;

namespace Lagorda.Infrastructure.Interface
{
    public interface IWarrantyRepository
    {
        int Create(Warranty warranty, out string message);
        bool Update(Warranty warranty, out string message);
        bool Delete(Warranty warranty, out string message);
    }
}
