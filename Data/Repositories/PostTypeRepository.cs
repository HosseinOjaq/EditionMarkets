using Common;
using Data.Contracts;
using Entities.Orders;

namespace Data.Repositories
{
    public class PostTypeRepository : Repository<PostType>, IPostTypeRepository, IScopedDependency
    {
        public PostTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
