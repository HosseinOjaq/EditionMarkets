using Entities.Orders;
using Entities.Products;
using Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Users
{
    public class User : IdentityUser<long>, IEntity<long>
    {

        public User()
        {
            IsActive = true;
        }
        [StringLength(100)]
        public string? FullName { get; set; }
        public GenderType? Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }


        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<UserAddress> UserAddresses { get; set; }
        public int Age { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.UserName).IsRequired().HasMaxLength(100);

        }
    }

    public enum GenderType
    {
        [Display(Name = "مرد")]
        Male = 1,

        [Display(Name = "زن")]
        Female = 2
    }
}
