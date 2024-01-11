using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.ProductPropertyDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminProductPropertyController : Controller
    {
        private readonly IProductPropertyService _productProperyService;

        public AdminProductPropertyController(IProductPropertyService productProperyService)
        {
            _productProperyService = productProperyService;
        }

        public IActionResult Index()
        {
            var productProperty = _productProperyService.BusinessGetAll();
            return View(productProperty);
        }

        [HttpGet]
        public IActionResult CreateProductProperty()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProductProperty(CreateProductPropertyDto createProductPropertyDto)
        {
            if (ModelState.IsValid)
            {
                ProductProperty productProperty = new ProductProperty()
                {
                    Name = createProductPropertyDto.Name,
                };
                _productProperyService.BusinessInsert(productProperty);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateProductProperty(int id)
        {
            var value = _productProperyService.BusinessGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBrand(UpdateProductPropertyDto updateProductPropertyDto)
        {
            if (ModelState.IsValid)
            {
                ProductProperty productProperty = new ProductProperty()
                {
                    Name=updateProductPropertyDto.Name,
                    ProductProperyId=updateProductPropertyDto.ProductProperyId,
                };
                _productProperyService.BusinessUpdate(productProperty);
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult DeleteBrand(int id)
        {
            var value = _productProperyService.BusinessGetById(id);
            _productProperyService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
