using DtoLayer.ProductDtos;
using EntityLayer.Entity;

namespace WebUI.Models
{
    public class ProductViewModel
    {
        public List<ResultProductDto> ForSellInProduct { get; set; }
        public List<ResultProductDto> ForRentInProduct { get; set; }
        public List<ResultProductDto> ForPlotInProduct { get; set; }
        public List<ResultProductDto> ForFieldInProduct { get; set; }
        public List<ResultProductDto> ForInProduct { get; set; }
    }
}
