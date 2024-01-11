using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Default
{
    public class _SearchComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public _SearchComponentPartial(ISubCategoryService subCategoryService, ICategoryService categoryService)
        {
            _subCategoryService = subCategoryService;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            SearchViewModel searchViewModel = new SearchViewModel();
            searchViewModel.SubCategories = _subCategoryService.BusinessGetAll();
            searchViewModel.Categories=_categoryService.BusinessGetAll();
            return View(searchViewModel);
        }
    }
}
