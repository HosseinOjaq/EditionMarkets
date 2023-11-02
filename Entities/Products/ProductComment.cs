using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Others;
using Entities.Users;

namespace Entities.Products
{
    public class ProductComment : BaseEntity<long>
    {
        public long UserId { get; set; }
        public int CommentTopicId { get; set; }
        public int CommentRate { get; set; }
        public string Description { get; set; }
        public int QualityRating { get; set; }
        public int AffordableRating { get; set; }
        public long ProductId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
        public CommentTopic CommentTopic { get; set; }
    }

    public class ProductCommentsConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasOne(p => p.Product).WithMany(c => c.ProductComments).HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.User).WithMany(c => c.ProductComments).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.CommentTopic).WithMany(c => c.ProductComments).HasForeignKey(p => p.CommentTopicId);

        }
    }
}
