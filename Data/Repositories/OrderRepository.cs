using Common;
using Data.Contracts;
using Entities.Orders;

namespace Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository, IScopedDependency
    {
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
