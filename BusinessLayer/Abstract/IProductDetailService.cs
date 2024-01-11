using DtoLayer.ProductDetailDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IProductDetailService : IGenericService<ProductDetail>
    {
        public IEnumerable<ResultProductDetailDto> BusinessGetProductsById(int productId);
        public IEnumerable<ResultProductDetailDto> BusinessGetAllProducts();
        public IEnumerable<ResultProductDetailDto> BusinessGetAllGroupByProductId();
        public IEnumerable<GroupByProductDetailDto> BusinessGetAllGroupByAloneProductId();
        public IEnumerable<ResultNewProductDetailDto> BusinessNewGetProductsById(int productId);
        public ResultNewProductDetailDto BusinessNewGetProductsByProductDetailId(int productDetailId);
    }
}
