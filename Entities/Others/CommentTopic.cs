using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities.Products;

namespace Entities.Others
{
    public class CommentTopic : BaseEntity<int>
    {
        public string Title { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }


        public Status Status { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
    }

    public class CommentTopicsConfiguration : IEntityTypeConfiguration<CommentTopic>
    {
        public void Configure(EntityTypeBuilder<CommentTopic> builder)
        {
            builder.HasOne(p => p.Status).WithMany(c => c.CommentTopics).HasForeignKey(p => p.StatusId);
        }
    }
}
