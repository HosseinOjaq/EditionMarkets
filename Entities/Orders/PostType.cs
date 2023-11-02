using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Others;

namespace Entities.Orders
{
    public class PostType : BaseEntity<int>
    {
        public string Title { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }


        public Status Status { get; set; }
    }
    public class PostTypesConfiguration : IEntityTypeConfiguration<PostType>
    {
        public void Configure(EntityTypeBuilder<PostType> builder)
        {
            builder.HasOne(p => p.Status).WithMany(c => c.postTypes).HasForeignKey(p => p.StatusId);
        }
    }
}
