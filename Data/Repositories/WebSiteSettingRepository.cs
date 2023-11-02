using Common;
using Data.Contracts;
using Entities.Others;

namespace Data.Repositories
{
    public class WebSiteSettingRepository : Repository<WebSiteSetting>, IWebSiteSettingRepository, IScopedDependency
    {
        public WebSiteSettingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
