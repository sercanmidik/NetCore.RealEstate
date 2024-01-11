using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _CategoryComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CategoryComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.BusinessGetAll();
            return View(values);
        }
    }
}
