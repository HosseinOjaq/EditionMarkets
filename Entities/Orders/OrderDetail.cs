using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities.Products;

namespace Entities.Orders
{
    public class OrderDetail : BaseEntity<long>
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public int ProductLength { get; set; }
        public int ProductWidth { get; set; }
        public bool IsNeedToDesignOnline { get; set; }


        public Product Product { get; set; }
        public Order Order { get; set; }


        public ICollection<OrderDetailProperty> OrderDetailProperties { get; set; }
    }
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(p => p.Product).WithMany(c => c.OrderDetails).HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Order).WithMany(c => c.OrderDetails).HasForeignKey(p => p.ProductId);
        }
    }
}
