using BusinessLayer.Abstract;
using DtoLayer.SliderTitle;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminSliderTitleController : Controller
    {
        private readonly ISliderTitleService _sliderTitleService;

        public AdminSliderTitleController(ISliderTitleService sliderTitleService)
        {
            _sliderTitleService = sliderTitleService;
        }

        public IActionResult Index()
        {
            var values = _sliderTitleService.BusinessGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSliderTitle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSliderTitle(CreateSliderTitleDto createSliderTitleDto)
        {
            if(ModelState.IsValid)
            {
                SliderTitle sliderTitle = new SliderTitle()
                {
                    ImageUrl = createSliderTitleDto.ImageUrl,
                    Content = createSliderTitleDto.Content,
                    Title = createSliderTitleDto.Title,
                    Status = true,
                };
                _sliderTitleService.BusinessInsert(sliderTitle);
                return RedirectToAction("Index");
            }
            return View();
           
        }
        [HttpGet]
        public IActionResult UpdateSliderTitle(int id)
        {
            var value = _sliderTitleService.BusinessGetById(id);
            UpdateSliderTitleDto updateSliderTitleDto = new UpdateSliderTitleDto()
            {
                SliderTitleId = id,
                Content= value.Content,
                Title = value.Title,
                Status = value.Status,
                ImageUrl = value.ImageUrl
            };
            return View(updateSliderTitleDto);
        }
        [HttpPost]
        public IActionResult UpdateSliderTitle(UpdateSliderTitleDto updateSliderTitleDto)
        {
            if(ModelState.IsValid)
            {
                SliderTitle sliderTitle = new SliderTitle()
                {
                    SliderTitleId = updateSliderTitleDto.SliderTitleId,
                    ImageUrl = updateSliderTitleDto.ImageUrl,
                    Content = updateSliderTitleDto.Content,
                    Title = updateSliderTitleDto.Title,
                    Status = updateSliderTitleDto.Status,
                };
                _sliderTitleService.BusinessUpdate(sliderTitle);
                return RedirectToAction("Index");
            }
            return View();
          
        }
        public IActionResult DeleteSliderTitle(int id)
        {
            var value = _sliderTitleService.BusinessGetById(id);
            _sliderTitleService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
