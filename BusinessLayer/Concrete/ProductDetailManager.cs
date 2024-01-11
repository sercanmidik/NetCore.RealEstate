using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.ProductDetailDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductDetailManager : IProductDetailService
    {
        private readonly IProductDetailDal _productDetailDal;
        private readonly IProductDal _productDal;

        public ProductDetailManager(IProductDetailDal productDetailDal, IProductDal productDal)
        {
            _productDetailDal = productDetailDal;
            _productDal = productDal;
        }

        public void BusinessDelete(ProductDetail entity)
        {
            _productDetailDal.Delete(entity);
        }

        public List<ProductDetail> BusinessGetAll()
        {
            return _productDetailDal.GetAll();
        }

        public IEnumerable<ResultProductDetailDto> BusinessGetAllProducts()
        {
            var values=_productDetailDal.GetAllProducts();
            List<ResultProductDetailDto> resultProductDetailDtos = new List<ResultProductDetailDto>();
            foreach (var value in values)
            {
                resultProductDetailDtos.Add(new ResultProductDetailDto
                {
                    ProductDetailId=value.ProductDetailId,
                    Adress=value.Product.Address,
                    Description=value.Product.Description,
                    Price=value.Product.Price.ToString(),
                    ProductId=value.Product.ProductId,
                    PropertyName=value.ProductProperty.Name,
                    PropertyValue=value.ProductValue,
                    Title=value.Product.Title,
                });
            }
            return resultProductDetailDtos;
        }

        public ProductDetail BusinessGetById(int id)
        {
            return _productDetailDal.GetById(id);   
        }

        public IEnumerable<ResultProductDetailDto> BusinessGetProductsById(int productId)
        {
            var values=_productDetailDal.GetProductsById(productId);
            List<ResultProductDetailDto> result = new List<ResultProductDetailDto>();
            foreach (var item in values)
            {
                result.Add(new ResultProductDetailDto
                {
                    ProductDetailId=item.ProductDetailId,
                    Adress=item.Product.Address,
                    Description=item.Product.Description,
                    Price=item.Product.Price.ToString(),
                    ProductId=item.Product.ProductId,
                    PropertyName=item.ProductProperty.Name,
                    PropertyValue=item.ProductValue,
                    Title=item.Product.Title,
                });
            }
            return result;
        }

        public List<ProductDetail> BusinessGetWhere(Expression<Func<ProductDetail, bool>> expression)
        {
            return _productDetailDal.GetWhere(expression);
        }

        public void BusinessInsert(ProductDetail entity)
        {
            _productDetailDal.Insert(entity);
        }

        public void BusinessUpdate(ProductDetail entity)
        {
            _productDetailDal.Update(entity);
        }

        public IEnumerable<ResultProductDetailDto> BusinessGetAllGroupByProductId()
        {
            List<ResultProductDetailDto> resultProductDetailDtos = new List<ResultProductDetailDto>();
            var productIds = _productDetailDal.GetAllGroupByProductId();
            foreach (var item in productIds)
            {
                var result=_productDetailDal.GetProductsById(item.ProductId);
                foreach (var item1 in result)
                {
                    resultProductDetailDtos.Add(new ResultProductDetailDto
                    {
                        Adress=item1.Product.Address,
                        ProductId=item1.Product.ProductId,
                        Description=item1.Product.Description,
                        Price=item1.Product.Price.ToString(),
                        ProductDetailId=item1.ProductDetailId,
                        PropertyName=item1.ProductProperty.Name,
                        PropertyValue=item1.ProductValue.ToString(),
                        Title=item1.Product.Title,
                    });
                }
            }
            return resultProductDetailDtos;
        }

        public IEnumerable<GroupByProductDetailDto> BusinessGetAllGroupByAloneProductId()
        {
            List<GroupByProductDetailDto> groupByProductDetailDto = new List<GroupByProductDetailDto>();
            var productsId = _productDetailDal.GetAllGroupByAloneProductId();
            foreach (var item in productsId)
            {
                var productDetail=_productDal.GetById(item.ProductId);
                groupByProductDetailDto.Add(new GroupByProductDetailDto
                {
                    ProductId = item.ProductId,
                    Adress=productDetail.Address,
                    Description=productDetail.Description,
                    Price=productDetail.Price.ToString(),
                    Title=productDetail.Title,
                });
                
            }
            return groupByProductDetailDto;
        }

        public IEnumerable<ResultNewProductDetailDto> BusinessNewGetProductsById(int productId)
        {
            var values = _productDetailDal.GetProductsById(productId);
            List<ResultNewProductDetailDto> result = new List<ResultNewProductDetailDto>();
            foreach (var item in values)
            {
                result.Add(new ResultNewProductDetailDto
                {
                    ProductDetailId = item.ProductDetailId,
                    PropertyName=item.ProductProperty.Name,
                    PropertyValue=item.ProductValue,
                });
            }
            return result;
        }

        public ResultNewProductDetailDto BusinessNewGetProductsByProductDetailId(int productDetailId)
        {
            var values = _productDetailDal.GetByProductDetailWithProductAndProductProperty(productDetailId);
            ResultNewProductDetailDto result = new ResultNewProductDetailDto();
            result.ProductDetailId = productDetailId;
            result.ProductId = values.ProductId;
            result.PropertyName = values.ProductProperty.Name;
            result.ProductPropertyId = values.ProductPropertyId;
            result.PropertyValue = values.ProductValue;
            return result;
        }
    }
}
