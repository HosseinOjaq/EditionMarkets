using Common;
using Data.Contracts;
using Entities.Others;

namespace Data.Repositories
{
    public class DeliveryTypeRepository : Repository<DeliveryType>, IDeliveryTypeRepository, IScopedDependency
    {
        public DeliveryTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
