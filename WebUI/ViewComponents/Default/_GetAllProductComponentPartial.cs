using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Default
{
    public class _GetAllProductComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _GetAllProductComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            GetAllProductViewModel viewModel = new GetAllProductViewModel();
            viewModel.ForFieldInProduct = _productService.BusinessShowCaseFeiled();
            viewModel.ForInProduct = _productService.BusinessShowCaseTrue();
            viewModel.ForRentInProduct=_productService.BusinessShowCaseRent();
            viewModel.ForPlotInProduct = _productService.BusinessShowCasePlot();
            viewModel.ForSellInProduct = _productService.BusinessShowCaseSell();
            return View(viewModel);
        }
    }
}
