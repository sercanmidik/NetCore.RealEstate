using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.ProductDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;

namespace WebUI.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public AdminProductController(IProductService productService, ICategoryService categoryService, ISubCategoryService subCategoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }
        private SelectList GetCategoriesList()
        {
            return new SelectList(_categoryService.BusinessGetWhere(x=>x.Status==true), "CategoryId", "Name");
        }
        private SelectList GetSubCategoriesList()
        {
            return new SelectList(_subCategoryService.BusinessGetWhere(x => x.Status == true), "SubCategoryId", "Name");
        }

        public IActionResult Index()
        {
            var product = _productService.BusinessGetAllWithInclude();
            return View(product);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            ViewBag.category = GetCategoriesList();
            ViewBag.subcategory = GetSubCategoriesList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            if(ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Status = true,
                    Address = createProductDto.Address,
                    Area = createProductDto.Area,
                    CategoryId = createProductDto.CategoryId,
                    Description = createProductDto.Description,
                    HouseAge = createProductDto.HouseAge,
                    ImageUrl = createProductDto.ImageUrl,
                    Price = createProductDto.Price,
                    RoomCount = createProductDto.RoomCount,
                    ShowCase = createProductDto.ShowCase,
                    SubCategoryId = createProductDto.SubCategoryId,
                    Title = createProductDto.Title,
                };
                _productService.BusinessInsert(product);
                return RedirectToAction("Index");
            }
            return View();
           
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _productService.BusinessGetById(id);
            UpdateProductDto product = new UpdateProductDto()
            {
                Status = value.Status,
                Address = value.Address,
                Area = value.Area,
                CategoryId = value.CategoryId,
                Description = value.Description,
                HouseAge = value.HouseAge,
                ImageUrl = value.ImageUrl,
                Price = value.Price,
                RoomCount = value.RoomCount,
                ShowCase = value.ShowCase,
                SubCategoryId = value.SubCategoryId,
                Title = value.Title,
                ProductId = value.ProductId,
            };
            ViewBag.category = GetCategoriesList();
            ViewBag.subcategory = GetSubCategoriesList();
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    Status = updateProductDto.Status,
                    Address = updateProductDto.Address,
                    Area = updateProductDto.Area,
                    CategoryId = updateProductDto.CategoryId,
                    Description = updateProductDto.Description,
                    HouseAge = updateProductDto.HouseAge,
                    ImageUrl = updateProductDto.ImageUrl,
                    Price = updateProductDto.Price,
                    RoomCount = updateProductDto.RoomCount,
                    ShowCase = updateProductDto.ShowCase,
                    SubCategoryId = updateProductDto.SubCategoryId,
                    Title = updateProductDto.Title,
                    ProductId = updateProductDto.ProductId,

                };
                _productService.BusinessUpdate(product);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.BusinessGetById(id);
            _productService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
