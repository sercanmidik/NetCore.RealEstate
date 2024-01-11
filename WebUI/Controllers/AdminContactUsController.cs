using BusinessLayer.Abstract;
using DtoLayer.CategoryDtos;
using DtoLayer.ContactUsDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public AdminContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var category = _contactUsService.BusinessGetAll();
            return View(category);
        }

        [HttpGet]
        public IActionResult CreateContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContactUs(CreateContactUsDto createContactUsDto)
        {
            if (ModelState.IsValid)
            {
                ContactUs category = new ContactUs()
                {
                   
                };
                _contactUsService.BusinessInsert(category);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateContactUs(int id)
        {
            var value = _contactUsService.BusinessGetById(id);
            UpdateContactUsDto updateCategoryDto = new UpdateContactUsDto()
            {

            };
            return View(updateCategoryDto);
        }
        [HttpPost]
        public IActionResult UpdateContactUs(UpdateContactUsDto updateContactUsDto)
        {
            if (ModelState.IsValid)
            {
                ContactUs category = new ContactUs()
                {
                    
                };
                _contactUsService.BusinessUpdate(category);
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult DeleteCategory(int id)
        {
            var value = _contactUsService.BusinessGetById(id);
            _contactUsService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
