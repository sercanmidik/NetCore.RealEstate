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
    public class ProductPropertyManager : IProductPropertyService
    {
        private readonly IProductPropertyDal _productProperyDal;

        public ProductPropertyManager(IProductPropertyDal productProperyDal)
        {
            _productProperyDal = productProperyDal;
        }

        public void BusinessDelete(ProductProperty entity)
        {
            _productProperyDal.Delete(entity);
        }

        public List<ProductProperty> BusinessGetAll()
        {
            return _productProperyDal.GetAll();
        }

        public ProductProperty BusinessGetById(int id)
        {
           return _productProperyDal.GetById(id);
        }

        public IEnumerable<ProductProperty> BusinessGetProductPropertList()
        {
            return _productProperyDal.GetProductPropertList();
        }

        public List<ProductProperty> BusinessGetWhere(Expression<Func<ProductProperty, bool>> expression)
        {
           return _productProperyDal.GetWhere(expression);
        }

        public void BusinessInsert(ProductProperty entity)
        {
            _productProperyDal.Insert(entity);
        }

        public void BusinessUpdate(ProductProperty entity)
        {
            _productProperyDal.Update(entity);
        }
    }
}
