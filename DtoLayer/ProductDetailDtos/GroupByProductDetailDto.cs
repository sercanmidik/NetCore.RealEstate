using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ProductDetailDtos
{
    public class GroupByProductDetailDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
