using Common;
using Data.Contracts;
using Entities.Properties;

namespace Data.Repositories
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository, IScopedDependency
    {
        public PropertyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
