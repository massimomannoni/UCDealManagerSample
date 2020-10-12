
using System.Threading.Tasks;

namespace UCDealManagerSample.Domain.Deals
{
    public interface IDealRepository
    {
        Task Create(Deal deal);
    }
}
