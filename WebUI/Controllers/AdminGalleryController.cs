using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.GallaryDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminGalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public AdminGalleryController(IGalleryService gallaryService)
        {
            _galleryService = gallaryService;
        }

        public IActionResult Index()
        {
            var gallery = _galleryService.BusinessGetAll();
            return View(gallery);
        }

        [HttpGet]
        public IActionResult CreateGallery()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGallery(CreateGalleryDto createGalleryDto)
        {
            if (ModelState.IsValid)
            {
                Gallery gallery = new Gallery()
                {
                    ImageUrl = createGalleryDto.ImageUrl,
                    Status=true,
                };
                _galleryService.BusinessInsert(gallery);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateGallery(int id)
        {
            var value = _galleryService.BusinessGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateGallery(UpdateGalleryDto updateGalleryDto)
        {
            if (ModelState.IsValid)
            {
                Gallery gallery = new Gallery()
                {
                   GalleryId = updateGalleryDto.GalleryId,
                   Status = updateGalleryDto.Status,
                   ImageUrl=updateGalleryDto.ImageUrl,
                };
                _galleryService.BusinessUpdate(gallery);
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult DeleteBrand(int id)
        {
            var value = _galleryService.BusinessGetById(id);
            _galleryService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
