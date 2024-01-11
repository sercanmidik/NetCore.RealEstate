using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class ProductProperty
    {
        [Key]
        public int ProductProperyId { get; set; }
        public string Name { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
    }
}
