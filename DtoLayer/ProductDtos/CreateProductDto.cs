using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ProductDtos
{
    public class CreateProductDto
    {
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int Area { get; set; }
        public int RoomCount { get; set; }
        public int HouseAge { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool ShowCase { get; set; }
        public string ImageUrl { get; set; }
    }
}
