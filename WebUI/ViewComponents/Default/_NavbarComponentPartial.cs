using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _NavbarComponentPartial:ViewComponent
    {
        private readonly IBrandService _brandService;

        public _NavbarComponentPartial(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _brandService.BusinessGetOneBrand();
            return View(value);
        }
    }
}
