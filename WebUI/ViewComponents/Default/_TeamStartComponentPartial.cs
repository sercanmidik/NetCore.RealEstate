using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _TeamStartComponentPartial:ViewComponent
    {
        private readonly ITeamFriendService _friendService;

        public _TeamStartComponentPartial(ITeamFriendService friendService)
        {
            _friendService = friendService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _friendService.BusinessGetFriendStatusTrue();
            return View(values);
        }
    }
}
