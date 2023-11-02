using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Entities.Users;

namespace Entities.Orders
{
    public class Order : BaseEntity<long>
    {
        public long UserId { get; set; }
        public string OrderTitle { get; set; }
        public bool IsFinaly { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public decimal SumPrices { get; set; }
        public string CustomerPhone { get; set; }


        public User User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
    public class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(p => p.User).WithMany(c => c.Orders).HasForeignKey(p => p.UserId);

        }
    }
}
