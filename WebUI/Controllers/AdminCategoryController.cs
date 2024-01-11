using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.CategoryDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var category = _categoryService.BusinessGetAll();
            return View(category);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category()
                {
                    Image = createCategoryDto.Image,
                    Name = createCategoryDto.Name,
                    Status = true,
                };
                _categoryService.BusinessInsert(category);
                return RedirectToAction("Index");
            }
          return View();
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.BusinessGetById(id);
            UpdateCategoryDto updateCategoryDto = new UpdateCategoryDto()
            {
                CategoryId = id,
                Status = value.Status,
                Name = value.Name,
                Image = value.Image,

            };
            return View(updateCategoryDto);
        }
        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            if(ModelState.IsValid)
            {
                Category category = new Category()
                {
                    CategoryId = updateCategoryDto.CategoryId,
                    Image = updateCategoryDto.Image,
                    Name = updateCategoryDto.Name,
                    Status = updateCategoryDto.Status,
                };
                _categoryService.BusinessUpdate(category);
                return RedirectToAction("Index");
            }
            return View();
           
        }
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.BusinessGetById(id);
            _categoryService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
