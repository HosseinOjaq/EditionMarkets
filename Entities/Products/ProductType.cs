using System.Collections.Generic;

namespace Entities.Products
{
    public class ProductType : BaseEntity<long>
    {
        public string Title { get; set; }


        public ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
