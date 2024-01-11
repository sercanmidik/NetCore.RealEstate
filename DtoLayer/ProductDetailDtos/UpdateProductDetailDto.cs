using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ProductDetailDtos
{
    public class UpdateProductDetailDto
    {
        public int ProductDetailId { get; set; }
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public string Value { get; set; }
    }
}
