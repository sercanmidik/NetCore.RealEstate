using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _HeaderComponentPartial:ViewComponent
    {
        private readonly ISliderTitleService _sliderTitleService;

        public _HeaderComponentPartial(ISliderTitleService sliderTitleService)
        {
            _sliderTitleService = sliderTitleService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_sliderTitleService.BusinessGetTrueImage();
            return View(values);
        }
    }
}
