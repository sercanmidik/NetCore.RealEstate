using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _GetInTouchComponentPartial:ViewComponent
    {
        private readonly IGetInTouchService _getInTouchService;

        public _GetInTouchComponentPartial(IGetInTouchService getInTouchService)
        {
            _getInTouchService = getInTouchService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getInTouchService.BusinessGetOneTouchForTrue();
            return View(value);
        }
    }
}
