using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Default
{
    public class _ProductComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            ProductViewModel model= new ProductViewModel();

            model.ForInProduct = _productService.BusinessShowCaseTrueTakeSix();
            model.ForFieldInProduct=_productService.BusinessShowCaseFeiledTakeSix();
            model.ForPlotInProduct=_productService.BusinessShowCasePlotTakeSix();
            model.ForSellInProduct=_productService.BusinessShowCaseSellTakeSix();
            model.ForRentInProduct=_productService.BusinessShowCaseRentTakeSix();
            return View(model);
        }
    }
}
