using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductPropertyId { get; set; }
        public ProductProperty ProductProperty { get; set; }
        public string ProductValue { get; set; }
    }
}
