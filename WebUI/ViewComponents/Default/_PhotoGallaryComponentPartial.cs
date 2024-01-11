using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _PhotoGallaryComponentPartial:ViewComponent
    {
        private readonly IGalleryService _gallaryService;

        public _PhotoGallaryComponentPartial(IGalleryService gallaryService)
        {
            _gallaryService = gallaryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _gallaryService.BusinnessGetGallary();
            return View(values);
        }
    }
}
