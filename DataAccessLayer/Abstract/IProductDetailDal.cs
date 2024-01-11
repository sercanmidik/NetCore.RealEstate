using DtoLayer.ProductDetailDtos;
using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IProductDetailDal : IGenericDal<ProductDetail>
    {
       public IEnumerable<ProductDetail> GetProductsById(int productId);
        public IEnumerable<ProductDetail> GetAllProducts();
        public IEnumerable<ResultProductDetailGroupByDto> GetAllGroupByProductId();
        public IEnumerable<ResultProductDetailGroupByDto> GetAllGroupByAloneProductId();
        public ProductDetail GetByProductDetailWithProductAndProductProperty(int productDetailId);
    }

}
