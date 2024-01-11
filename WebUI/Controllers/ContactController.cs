using BusinessLayer.Abstract;
using DtoLayer.ContactDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IGetInTouchService _getInTouchService;

        public ContactController(IContactService contactService, IGetInTouchService inTouchService)
        {
            _contactService = contactService;
            _getInTouchService = inTouchService;
        }

        public IActionResult Index()
        {
            
            var value = _getInTouchService.BusinessGetOneTouchForTrue();
            return View(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            if(ModelState.IsValid)
            {
                Contact contact = new Contact()
                {
                    Date = DateTime.Now,
                    Email = createContactDto.Email,
                    Message = createContactDto.Message,
                    Name = createContactDto.Name,
                    Status = true,
                    Subject = createContactDto.Subject,
                };
                _contactService.BusinessInsert(contact);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
