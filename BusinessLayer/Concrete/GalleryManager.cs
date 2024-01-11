using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.GallaryDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GalleryManager : IGalleryService
    {
        private readonly IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void BusinessDelete(Gallery entity)
        {
            _galleryDal.Delete(entity);
        }

        public List<Gallery> BusinessGetAll()
        {
            return _galleryDal.GetAll();
        }

        public Gallery BusinessGetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public List<Gallery> BusinessGetWhere(Expression<Func<Gallery, bool>> expression)
        {
            return _galleryDal.GetWhere(expression);
        }

        public void BusinessInsert(Gallery entity)
        {
            _galleryDal.Insert(entity);
        }

        public void BusinessUpdate(Gallery entity)
        {
            _galleryDal.Update(entity);
        }

        public IEnumerable<ResultGalleryDto> BusinnessGetGallary()
        {
            var values = _galleryDal.GetGallary().Where(x => x.Status == true).Take(6).ToList();
            List<ResultGalleryDto> result= new List<ResultGalleryDto>();
            foreach (var item in values)
            {
                result.Add(new ResultGalleryDto
                {
                    GalleryId = item.GalleryId,
                    ImageUrl = item.ImageUrl,
                    Status=item.Status,
                });
            }
            return result;
        }
    }
}
