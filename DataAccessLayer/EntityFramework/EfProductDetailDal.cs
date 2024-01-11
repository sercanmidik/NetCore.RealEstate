using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using DtoLayer.ProductDetailDtos;
using EntityLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDetailDal : GenericRepository<ProductDetail>, IProductDetailDal
    {
        private readonly RealEstateContext _realEstateContext;
        public EfProductDetailDal(RealEstateContext context) : base(context)
        {
            _realEstateContext = context;
        }

        public IEnumerable<ResultProductDetailGroupByDto> GetAllGroupByAloneProductId()
        {
            var result = _realEstateContext.ProductDetails
                    .GroupBy(x => x.ProductId)
                    .Select(g => new ResultProductDetailGroupByDto
                    {
                        ProductId = g.Key
                    })
                    .ToList();
            return result;
        }

        public IEnumerable<ResultProductDetailGroupByDto> GetAllGroupByProductId()
        {
            var result = _realEstateContext.ProductDetails
                .Include("ProductProperty").Include("Product")
                    .GroupBy(x => x.ProductId)
                    .Select(g => new ResultProductDetailGroupByDto
                    {
                        ProductId = g.Key
                    })
                    .ToList();
            return result;
        }

        public IEnumerable<ProductDetail> GetAllProducts()
        {
            return _realEstateContext.ProductDetails.Include("ProductProperty").Include("Product").ToList();
        }

        public ProductDetail GetByProductDetailWithProductAndProductProperty(int productDetailId)
        {
            return _realEstateContext.ProductDetails.Include("ProductProperty").Include("Product").Where(x=>x.ProductDetailId==productDetailId).First();
        }

        public IEnumerable<ProductDetail> GetProductsById(int productId)
        {
           return _realEstateContext.ProductDetails.Include("ProductProperty").Include("Product").Where(x=>x.ProductId == productId).OrderBy(x=>x.ProductPropertyId).ToList();
        }
    }
}
