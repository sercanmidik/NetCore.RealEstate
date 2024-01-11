using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string TaskName { get; set; }
        public string TaskName2 { get; set; }
        public string TaskName3 { get; set; }
        public string TaskName4 { get; set; }
        public bool Status { get; set; }
    }
}
