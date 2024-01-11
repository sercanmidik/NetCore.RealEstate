using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void BusinessDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> BusinessGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category BusinessGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> BusinessGetWhere(Expression<Func<Category, bool>> expression)
        {
            return _categoryDal.GetWhere(expression);
        }

        public void BusinessInsert(Category entity)
        {
           _categoryDal.Insert(entity);
        }

        public void BusinessUpdate(Category entity)
        {
            _categoryDal.Update(entity);    
        }
    }
}
