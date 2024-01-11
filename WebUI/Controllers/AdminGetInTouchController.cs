using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.GetInTouch;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminGetInTouchController : Controller
    {
        private readonly IGetInTouchService _getInTouchService;

        public AdminGetInTouchController(IGetInTouchService getInTouchService)
        {
            _getInTouchService = getInTouchService;
        }

        public IActionResult Index()
        {
            var brands = _getInTouchService.BusinessGetAll();
            return View(brands);
        }

        [HttpGet]
        public IActionResult CreateGetInTouch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBGetInTouch(CreateGetInTouchDto createGetInTouchDto)
        {
            if (ModelState.IsValid)
            {
                GetInTouch getInTouch = new GetInTouch()
                {
                    Status=true,
                    Address=createGetInTouchDto.Address,
                    Email=createGetInTouchDto.Email,
                    FacebookUrl = createGetInTouchDto.FacebookUrl,
                    FrameString=createGetInTouchDto.FrameString,
                    InstagramUrl = createGetInTouchDto.InstagramUrl,
                    PhoneNumber = createGetInTouchDto.PhoneNumber,
                    TwitterUrl = createGetInTouchDto.TwitterUrl,
                };
                _getInTouchService.BusinessInsert(getInTouch);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateGetInTouch(int id)
        {
            var value = _getInTouchService.BusinessGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateGetInTouch(UpdateGetInTouchDto updateGetInTouchDto)
        {
            if (ModelState.IsValid)
            {
                GetInTouch getInTouch = new GetInTouch()
                {
                    GetInTouchId=updateGetInTouchDto.GetInTouchId,
                    Status = updateGetInTouchDto.Status,
                    Address = updateGetInTouchDto.Address,
                    Email = updateGetInTouchDto.Email,
                    FacebookUrl = updateGetInTouchDto.FacebookUrl,
                    FrameString = updateGetInTouchDto.FrameString,
                    InstagramUrl = updateGetInTouchDto.InstagramUrl,
                    PhoneNumber = updateGetInTouchDto.PhoneNumber,
                    TwitterUrl = updateGetInTouchDto.TwitterUrl,
                };
                _getInTouchService.BusinessUpdate(getInTouch);
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult DeleteGetInTouch(int id)
        {
            var value = _getInTouchService.BusinessGetById(id);
            _getInTouchService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
