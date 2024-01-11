using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ProductDetailDtos
{
    public class CreateProductDetailDto
    {
        public int ProductId { get; set; }
        public int ProductPropertyId { get; set; }
        public string PropertyValue { get; set; }
    }
}
