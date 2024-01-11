using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.ProductDetailDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Controllers
{
   
    public class AdminProductDetailController : Controller
    {
        private readonly IProductDetailService _productDetailService;
        private readonly IProductPropertyService _productPropertyService;
        private readonly IProductService _productService;

        public AdminProductDetailController(IProductDetailService productDetailService, IProductPropertyService productPropertyService, IProductService productService)
        {
            _productDetailService = productDetailService;
            _productPropertyService = productPropertyService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productDetails = _productDetailService.BusinessGetAllGroupByAloneProductId();
            return View(productDetails);
        }

        [HttpGet]
        public IActionResult CreateProductDetail()
        {
            ViewBag.products = GetProductList();
            ViewBag.propertylist = GetProductPropertyList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            if (ModelState.IsValid)
            {
                ProductDetail productDetail = new ProductDetail()
                {
                    ProductId = createProductDetailDto.ProductId,
                    ProductPropertyId = createProductDetailDto.ProductPropertyId,
                    ProductValue=createProductDetailDto.PropertyValue
                };
                _productDetailService.BusinessInsert(productDetail);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult LookProductDetailId(int id)
        {
            var value = _productDetailService.BusinessNewGetProductsById(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult UpdateProductDetailId(int id)
        {
            var value = _productDetailService.BusinessNewGetProductsByProductDetailId(id);
            UpdateNewProductDetailDto updateNewProductDetailDto = new UpdateNewProductDetailDto();
            updateNewProductDetailDto.PropertyName = value.PropertyName;
            updateNewProductDetailDto.ProductPropertyId = value.ProductPropertyId;
            updateNewProductDetailDto.ProductId = value.ProductId;
            updateNewProductDetailDto.PropertyValue = value.PropertyValue; ;
            updateNewProductDetailDto.ProductDetailId = value.ProductDetailId;
            return View(updateNewProductDetailDto);
        }
        private SelectList GetProductPropertyList()
        {
            return new SelectList(_productPropertyService.BusinessGetProductPropertList(), "ProductProperyId", "Name");
        }
        private SelectList GetProductList()
        {
            return new SelectList(_productService.BusinessGetAll(), "ProductId", "Title");
        }
        [HttpPost]
        public IActionResult UpdateProductDetail(UpdateNewProductDetailDto updatenewProductDetailDto)
        {
            if (ModelState.IsValid)
            {
                ProductDetail productDetail = new ProductDetail()
                {
                    ProductDetailId=updatenewProductDetailDto.ProductDetailId,
                    ProductPropertyId=updatenewProductDetailDto.ProductPropertyId,
                    ProductId=updatenewProductDetailDto.ProductId,
                    ProductValue= updatenewProductDetailDto.PropertyValue,
                };
                _productDetailService.BusinessUpdate(productDetail);
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult DeleteProductDetail(int id)
        {
            var value = _productDetailService.BusinessGetWhere(x=>x.ProductId==id);
            foreach (var item in value)
            {
                _productDetailService.BusinessDelete(item);
            }
           
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProductProperty(int id)
        {
            var value=_productDetailService.BusinessGetById(id);
            _productDetailService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
