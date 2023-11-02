using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Properties;

namespace Entities.Products
{
    public class ProductProperty : BaseEntity<long>
    {
        public long ProductId { get; set; }
        public long PropertyId { get; set; }


        public Product Product { get; set; }
        public Property Propertiy { get; set; }
    }


    public class ProductPropertiesConfiguration : IEntityTypeConfiguration<ProductProperty>
    {
        public void Configure(EntityTypeBuilder<ProductProperty> builder)
        {
            builder.HasOne(p => p.Propertiy).WithMany(c => c.ProductProperties).HasForeignKey(p => p.PropertyId);

            builder.HasOne(p => p.Product).WithMany(c => c.ProductProperties).HasForeignKey(p => p.ProductId);
        }
    }
}
