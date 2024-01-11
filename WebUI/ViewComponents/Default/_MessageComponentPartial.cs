using DtoLayer.ContactDtos;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _MessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CreateContactDto contactDto = new CreateContactDto();
            return View(contactDto);
        }
    }
}
