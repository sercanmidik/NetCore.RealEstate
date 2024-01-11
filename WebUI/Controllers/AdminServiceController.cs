using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.ServiceDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public AdminServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var services = _serviceService.BusinessGetAll();
            return View(services);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(CreateServiceDto createServiceDto)
        {
            if(ModelState.IsValid)
            {
                Service service = new Service()
                {
                    Content = createServiceDto.Content,
                    ImageUrl = createServiceDto.ImageUrl,
                    Status = true,
                    TaskName = createServiceDto.TaskName,
                    TaskName2 = createServiceDto.TaskName2,
                    TaskName3 = createServiceDto.TaskName3,
                    TaskName4 = createServiceDto.TaskName4,
                    Title = createServiceDto.Title,

                };
                _serviceService.BusinessInsert(service);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.BusinessGetById(id);
            UpdateServiceDto updateServiceDto = new UpdateServiceDto()
            {
                ServiceId = id,
                Status = value.Status,
                Title = value.Title,
                TaskName4 = value.TaskName4,
                TaskName3 = value.TaskName3,
                TaskName2 = value.TaskName2,
                TaskName = value.TaskName,
                Content = value.Content,
                ImageUrl = value.ImageUrl
            };
            return View(updateServiceDto);
        }
        [HttpPost]
        public IActionResult UpdateService(UpdateServiceDto updateServiceDto)
        {
            if(ModelState.IsValid)
            {
                Service service = new Service()
                {
                    ServiceId = updateServiceDto.ServiceId,
                    Content = updateServiceDto.Content,
                    ImageUrl = updateServiceDto.ImageUrl,
                    Status = updateServiceDto.Status,
                    TaskName = updateServiceDto.TaskName,
                    TaskName2 = updateServiceDto.TaskName2,
                    TaskName3 = updateServiceDto.TaskName3,
                    TaskName4 = updateServiceDto.TaskName4,
                    Title = updateServiceDto.Title,

                };
                _serviceService.BusinessUpdate(service);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.BusinessGetById(id);
            _serviceService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
