using BusinessLayer.Abstract;
using DtoLayer.SliderTitle;
using DtoLayer.SubCategoryDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminSubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;

        public AdminSubCategoryController(ISubCategoryService sliderTitleService)
        {
            _subCategoryService = sliderTitleService;
        }

        public IActionResult Index()
        {
            var values = _subCategoryService.BusinessGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSubCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSubCategory(CreateSubCategoryDto createSubCategoryDto)
        {
            if(ModelState.IsValid)
            {
                SubCategory subCategory = new SubCategory()
                {
                    Name = createSubCategoryDto.Name,
                    Status = true,
                };
                _subCategoryService.BusinessInsert(subCategory);
                return RedirectToAction("Index");
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult UpdateSubCategory(int id)
        {
            var value = _subCategoryService.BusinessGetById(id);
            UpdateSubCategoryDto updateSubCategoryDto = new UpdateSubCategoryDto()
            {
                Name=value.Name,
                Status = value.Status,
                SubCategoryId=id,
               
            };
            return View(updateSubCategoryDto);
        }
        [HttpPost]
        public IActionResult UpdateSubCategory(UpdateSubCategoryDto updateSubCategoryDto)
        {
            if(ModelState.IsValid)
            {
                SubCategory subCategory = new SubCategory()
                {
                    SubCategoryId = updateSubCategoryDto.SubCategoryId,
                    Status = updateSubCategoryDto.Status,
                    Name = updateSubCategoryDto.Name,
                };
                _subCategoryService.BusinessUpdate(subCategory);
                return RedirectToAction("Index");
            }
            return View();
           
        }
        public IActionResult DeleteSubCategory(int id)
        {
            var value = _subCategoryService.BusinessGetById(id);
            _subCategoryService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
