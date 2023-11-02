using System.Collections.Generic;
using Entities.Orders;
using Entities.Products;
using Entities.Properties;

namespace Entities.Others
{
    public class Status : BaseEntity<int>
    {
        public string StatusTitle { get; set; }


        public ICollection<CommentTopic> CommentTopics { get; set; }
        public ICollection<DeliveryType> DeliveryTypes { get; set; }
        public ICollection<PostType> postTypes { get; set; }
        public ICollection<ProductFile> ProductFiles { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductSalesType> ProductSalesTypes { get; set; }
        public ICollection<Property> Properties { get; set; }
        public ICollection<PropertyItem> PropertyItems { get; set; }
    }
}
