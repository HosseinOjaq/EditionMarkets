using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Properties;

namespace Entities.Orders
{
    public class OrderDetailProperty : BaseEntity<long>
    {
        public long OrderDetailId { get; set; }
        public long PropertyItemId { get; set; }

        public PropertyItem PropertyItem { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }

    public class OrderDetailPropertiesConfiguration : IEntityTypeConfiguration<OrderDetailProperty>
    {
        public void Configure(EntityTypeBuilder<OrderDetailProperty> builder)
        {
            builder.HasOne(p => p.OrderDetail).WithMany(c => c.OrderDetailProperties).HasForeignKey(p => p.OrderDetailId);

            builder.HasOne(p => p.PropertyItem).WithMany(c => c.OrderDetailProperties).HasForeignKey(p => p.PropertyItemId);
        }
    }
}
