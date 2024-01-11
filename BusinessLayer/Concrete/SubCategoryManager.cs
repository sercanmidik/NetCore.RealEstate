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
    public class SubCategoryManager : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void BusinessDelete(SubCategory entity)
        {
            _subCategoryDal.Delete(entity);
        }

        public List<SubCategory> BusinessGetAll()
        {
            return _subCategoryDal.GetAll();
        }

        public SubCategory BusinessGetById(int id)
        {
            return _subCategoryDal.GetById(id);
        }

        public List<SubCategory> BusinessGetWhere(Expression<Func<SubCategory, bool>> expression)
        {
            return _subCategoryDal.GetWhere(expression);
        }

        public void BusinessInsert(SubCategory entity)
        {
            _subCategoryDal.Insert(entity);
        }

        public void BusinessUpdate(SubCategory entity)
        {
            _subCategoryDal.Update(entity);
        }
    }
}
