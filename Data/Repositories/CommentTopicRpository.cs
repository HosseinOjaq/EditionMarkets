using Common;
using Data.Contracts;
using Entities.Others;
using Entities.Products;

namespace Data.Repositories
{
    public class CommentTopicRpository : Repository<CommentTopic>, ICommentTopicRpository, IScopedDependency
    {
        public CommentTopicRpository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
