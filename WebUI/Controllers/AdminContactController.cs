using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.ContactDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.BusinessGetAll();
            return View(contacts);
        }
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.BusinessGetById(id);
            _contactService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
