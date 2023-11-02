using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Entities.Products
{
    public class ProductDescription : BaseEntity<long>
    {
        public string Description { get; set; }
        public long ProductId { get; set; }

        public Product Product { get; set; }
    }


    public class ProductDescriptionsConfiguration : IEntityTypeConfiguration<ProductDescription>
    {
        public void Configure(EntityTypeBuilder<ProductDescription> builder)
        {
            builder.HasOne(p => p.Product).WithMany(c => c.ProductDescriptions).HasForeignKey(p => p.ProductId);

        }
    }
}
