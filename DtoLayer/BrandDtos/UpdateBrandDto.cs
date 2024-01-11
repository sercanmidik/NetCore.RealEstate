using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.BrandDtos
{
    public class UpdateBrandDto
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }

    }
}
