using Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ProductsDtos
{
    public class ProductFilsDto
    {
        public string ProductTitle { get; set; }
        public long SubCategoryId { get; set; }
        public int StatusId { get; set; }
        public long ProductTypeId { get; set; }
        public string ProductDescription { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int ProductCode { get; set; }
        public int ProductSalesTypeId { get; set; }

        public ProductFile ProductFiles { get; set; }
    }
}
