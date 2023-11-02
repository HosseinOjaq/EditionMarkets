using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities.Products;
using Entities.Others;

namespace Entities.Properties
{
    public class Property : BaseEntity<long>
    {
        public string PropertyTitle { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }


        public Status Status { get; set; }


        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<PropertyItem> PropertyItems { get; set; }
    }
    public class PropertiesConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasOne(p => p.Status).WithMany(c => c.Properties).HasForeignKey(p => p.StatusId);
        }
    }
}
