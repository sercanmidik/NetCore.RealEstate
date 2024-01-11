using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.ContactUsDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void BusinessDelete(ContactUs entity)
        {
            _contactUsDal.Delete(entity);
        }

        public List<ContactUs> BusinessGetAll()
        {
            return _contactUsDal.GetAll();
        }

        public ContactUs BusinessGetById(int id)
        {
            return _contactUsDal.GetById(id);
        }

        public ResultContactUsDto BusinessGetOneContactUs()
        {
           var value= _contactUsDal.GetOneContactUs();
            ResultContactUsDto result = new ResultContactUsDto()
            {
                ContactUsId = value.ContactUsId,
                Status = value.Status,
                Content = value.Content,
                ImageUrl = value.ImageUrl,
                Title = value.Title,
            };
            return result;
        }

        public List<ContactUs> BusinessGetWhere(Expression<Func<ContactUs, bool>> expression)
        {
            return _contactUsDal.GetWhere(expression);
        }

        public void BusinessInsert(ContactUs entity)
        {
           _contactUsDal.Insert(entity);
        }

        public void BusinessUpdate(ContactUs entity)
        {
            _contactUsDal.Update(entity);
        }
    }
}
