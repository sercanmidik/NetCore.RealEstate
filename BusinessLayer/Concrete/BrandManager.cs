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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void BusinessDelete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public List<Brand> BusinessGetAll()
        {
           return _brandDal.GetAll();
        }

        public Brand BusinessGetById(int id)
        {
           return _brandDal.GetById(id);
        }

        public Brand BusinessGetOneBrand()
        {
            return _brandDal.GetOneBrand();
        }

        public List<Brand> BusinessGetWhere(Expression<Func<Brand, bool>> expression)
        {
            return _brandDal.GetWhere(expression);
        }

        public void BusinessInsert(Brand entity)
        {
            _brandDal.Insert(entity);
        }

        public void BusinessUpdate(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
