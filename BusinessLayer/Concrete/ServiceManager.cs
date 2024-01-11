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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void BusinessDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> BusinessGetAll()
        {
           return _serviceDal.GetAll();
        }

        public Service BusinessGetById(int id)
        {
           return _serviceDal.GetById(id);
        }

        public Service BusinessGetOneServiceForTrue()
        {
            return _serviceDal.GetOneServiceForTrue();
        }

        public List<Service> BusinessGetWhere(Expression<Func<Service, bool>> expression)
        {
            return _serviceDal.GetWhere(expression);
        }

        public void BusinessInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void BusinessUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
