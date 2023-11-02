using Common;
using Data.Contracts;
using Entities.Others;

namespace Data.Repositories
{
    public class StatusRepository : Repository<Status>, IStatusRepository, IScopedDependency
    {
        public StatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
