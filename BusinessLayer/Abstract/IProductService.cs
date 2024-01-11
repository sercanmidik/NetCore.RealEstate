using DtoLayer.ProductDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<ResultProductDto> BusinessGetAllWithInclude();
        public List<ResultProductDto> BusinessShowCaseTrueTakeSix();
        public List<ResultProductDto> BusinessShowCaseSellTakeSix();
        public List<ResultProductDto> BusinessShowCaseRentTakeSix();
        public List<ResultProductDto> BusinessShowCaseFeiledTakeSix();
        public List<ResultProductDto> BusinessShowCasePlotTakeSix();

        public List<ResultProductDto> BusinessShowCaseTrue();
        public List<ResultProductDto> BusinessShowCaseSell();
        public List<ResultProductDto> BusinessShowCaseRent();
        public List<ResultProductDto> BusinessShowCaseFeiled();
        public List<ResultProductDto> BusinessShowCasePlot();

    }

}
