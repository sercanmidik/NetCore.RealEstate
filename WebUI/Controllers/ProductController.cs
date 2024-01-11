using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;

        public ProductController(IProductDetailService productDetailService, IProductService productService)
        {
            _productDetailService = productDetailService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ProductDetail(int id)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel.ProductDetailDtos = _productDetailService.BusinessGetProductsById(id).ToList();
            var product=_productService.BusinessGetById(id);
            viewModel.Adress = product.Address;
            viewModel.Description = product.Description;
            viewModel.Title = product.Title;
            viewModel.Price = product.Price.ToString();
            
            return View(viewModel);
        }
    }
}
