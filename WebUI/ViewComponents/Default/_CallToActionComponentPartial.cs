using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _CallToActionComponentPartial:ViewComponent
    {
        private readonly IContactUsService _contactUsService;

        public _CallToActionComponentPartial(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.BusinessGetOneContactUs();
            return View(value);
        }
    }
}
