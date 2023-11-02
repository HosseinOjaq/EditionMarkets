using Common;
using Data.Contracts;
using Entities.Orders;

namespace Data.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository, IScopedDependency
    {
        public OrderDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
