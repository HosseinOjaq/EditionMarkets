using Common;
using Data.Contracts;
using Entities.Orders;
using Entities.Products;

namespace Data.Repositories
{
    public class OrderDetailPropertyRepository : Repository<OrderDetailProperty>, IOrderDetailPropertiesRepository, IScopedDependency
    {
        public OrderDetailPropertyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
