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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void BusinessDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> BusinessGetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact BusinessGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> BusinessGetWhere(Expression<Func<Contact, bool>> expression)
        {
           return  _contactDal.GetWhere(expression);
        }

        public void BusinessInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void BusinessUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
