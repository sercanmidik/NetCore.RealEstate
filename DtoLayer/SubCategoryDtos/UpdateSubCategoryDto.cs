using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.SubCategoryDtos
{
    public class UpdateSubCategoryDto
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
