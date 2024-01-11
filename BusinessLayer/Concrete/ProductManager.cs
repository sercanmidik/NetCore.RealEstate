using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.ProductDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void BusinessDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public List<Product> BusinessGetAll()
        {
            return _productDal.GetAll();
        }

        public Product BusinessGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void BusinessInsert(Product entity)
        {
           _productDal.Insert(entity);
        }

        public List<ResultProductDto> BusinessShowCaseFeiledTakeSix()
        {
            var values = _productDal.ShowCaseFeiledTakeSix();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName=item.Category.Name,
                    Description=item.Description,
                    HouseAge=item.HouseAge,
                    Price=item.Price,
                    ProductId=item.ProductId,
                    RoomCount=item.RoomCount,
                    ShowCase=item.ShowCase,
                    Status = item.Status,
                    SubCategoryName=item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,

                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCasePlotTakeSix()
        {
            var values = _productDal.ShowCasePlotTakeSix();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,

                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCaseRentTakeSix()
        {
            var values = _productDal.ShowCaseRentTakeSix();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCaseSellTakeSix()
        {
            var values = _productDal.ShowCaseSellTakeSix();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCaseTrueTakeSix()
        {
            var values = _productDal.ShowCaseTrueTakeSix();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public void BusinessUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public List<ResultProductDto> BusinessGetAllWithInclude()
        {
            var values = _productDal.GetAllWithInclude();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<Product> BusinessGetWhere(Expression<Func<Product, bool>> expression)
        {
            return _productDal.GetWhere(expression);
        }

        public List<ResultProductDto> BusinessShowCaseTrue()
        {
            var values = _productDal.ShowCaseTrue();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCaseSell()
        {
            var values = _productDal.ShowCaseSell();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCaseRent()
        {
            var values = _productDal.ShowCaseRent();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCaseFeiled()
        {
            var values = _productDal.ShowCaseFeiled();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }

        public List<ResultProductDto> BusinessShowCasePlot()
        {
            var values = _productDal.ShowCasePlot();
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    Address = item.Address,
                    Area = item.Area,
                    CategoryName = item.Category.Name,
                    Description = item.Description,
                    HouseAge = item.HouseAge,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    RoomCount = item.RoomCount,
                    ShowCase = item.ShowCase,
                    Status = item.Status,
                    SubCategoryName = item.SubCategory.Name,
                    Title = item.Title,
                    ImageUrl = item.ImageUrl,
                });
            }
            return resultProductDtos;
        }
    }
}
