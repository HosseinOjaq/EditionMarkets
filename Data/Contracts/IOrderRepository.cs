using Data.Repositories;
using Entities.Orders;

namespace Data.Contracts
{
    public interface IOrderRepository:IRepository<Order>
    {
    }
}
