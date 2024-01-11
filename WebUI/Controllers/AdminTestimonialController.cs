using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.TestimonialDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebUI.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public AdminTestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var brands = _testimonialService.BusinessGetAll();
            return View(brands);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            if (ModelState.IsValid)
            {
                Testimonial testimonial = new Testimonial()
                {
                    ImageUrl = createTestimonialDto.ImageUrl,
                    Name = createTestimonialDto.Name,
                    Title= createTestimonialDto.Title,
                    Content=createTestimonialDto.Content,
                    Status = true,
                };
                _testimonialService.BusinessInsert(testimonial);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _testimonialService.BusinessGetById(id);
            UpdateTestimonialDto testimonial = new UpdateTestimonialDto()
            {
                ImageUrl = value.ImageUrl,
                Name = value.Name,
                Title = value.Title,
                Content = value.Content,
                Status = value.Status,
                TestimonialId=id,
            };
            return View(testimonial);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            if (ModelState.IsValid)
            {
                Testimonial testimonial = new Testimonial()
                {
                    ImageUrl = updateTestimonialDto.ImageUrl,
                    Name = updateTestimonialDto.Name,
                    Title = updateTestimonialDto.Title,
                    Content = updateTestimonialDto.Content,
                    Status = updateTestimonialDto.Status,
                    TestimonialId = updateTestimonialDto.TestimonialId,
                };
                _testimonialService.BusinessUpdate(testimonial);
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.BusinessGetById(id);
            _testimonialService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
