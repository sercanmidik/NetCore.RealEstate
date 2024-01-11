using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _AboutComponentPartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _AboutComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _serviceService.BusinessGetOneServiceForTrue();
            return View(value);
        }
    }
}
