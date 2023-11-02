using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities.Others;
using Entities.Orders;

namespace Entities.Properties
{
    public class PropertyItem : BaseEntity<long>
    {
        public string Title { get; set; }
        public long PropertyId { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }

        public Property Propertiy { get; set; }
        public Status Status { get; set; }


        public ICollection<OrderDetailProperty> OrderDetailProperties { get; set; }
        public ICollection<PropertyItemPrice> propertyItems { get; set; }
    }
    public class PropertyItemsPricesConfiguration : IEntityTypeConfiguration<PropertyItem>
    {
        public void Configure(EntityTypeBuilder<PropertyItem> builder)
        {
            builder.HasOne(p => p.Propertiy).WithMany(c => c.PropertyItems).HasForeignKey(p => p.PropertyId);

            builder.HasOne(p => p.Status).WithMany(c => c.PropertyItems).HasForeignKey(p => p.StatusId);
        }
    }
}
