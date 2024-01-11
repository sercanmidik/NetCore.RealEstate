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
    public class SliderTitleManager : ISliderTitleService
    {
        private readonly ISliderTitleDal _sliderTitleDal;

        public SliderTitleManager(ISliderTitleDal sliderTitleDal)
        {
            _sliderTitleDal = sliderTitleDal;
        }

        public void BusinessDelete(SliderTitle entity)
        {
           _sliderTitleDal.Delete(entity);
        }

        public List<SliderTitle> BusinessGetAll()
        {
           return _sliderTitleDal.GetAll();
        }

        public SliderTitle BusinessGetById(int id)
        {
            return _sliderTitleDal.GetById(id);
        }

        public List<SliderTitle> BusinessGetTrueImage()
        {
            return _sliderTitleDal.GetTrueImage();
        }

        public List<SliderTitle> BusinessGetWhere(Expression<Func<SliderTitle, bool>> expression)
        {
            return _sliderTitleDal.GetWhere(expression);
        }

        public void BusinessInsert(SliderTitle entity)
        {
            _sliderTitleDal.Insert(entity);
        }

        public void BusinessUpdate(SliderTitle entity)
        {
           _sliderTitleDal.Update(entity);
        }
    }
}
