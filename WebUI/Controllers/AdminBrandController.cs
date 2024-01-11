using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminBrandController : Controller
    {
        private readonly IBrandService _brandService;

        public AdminBrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var brands = _brandService.BusinessGetAll();
            return View(brands);
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(CreateBrandDto createBrandDto)
        {
            if(ModelState.IsValid)
            {
                Brand brand = new Brand()
                {
                    ImageUrl = createBrandDto.ImageUrl,
                    Name = createBrandDto.Name,
                    Status = true,
                };
                _brandService.BusinessInsert(brand);
                return RedirectToAction("Index");
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var value=_brandService.BusinessGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            if(ModelState.IsValid)
            {
                Brand brand = new Brand()
                {
                    BrandId = updateBrandDto.BrandId,
                    ImageUrl = updateBrandDto.ImageUrl,
                    Name = updateBrandDto.Name,
                    Status = updateBrandDto.Status
                };
                _brandService.BusinessUpdate(brand);
                return RedirectToAction("Index");

            }
            return View();
            
        }
        public IActionResult DeleteBrand(int id)
        {
             var value= _brandService.BusinessGetById(id);
            _brandService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
