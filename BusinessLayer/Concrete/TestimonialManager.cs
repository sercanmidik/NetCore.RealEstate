using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.TestimonialDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void BusinessDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonial> BusinessGetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial BusinessGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public IEnumerable<ResultTestimonialDto> BusinessGetTestimonialForTrue()
        {
            var values = _testimonialDal.GetTestimonialForTrue();
            List<ResultTestimonialDto> resultTestimonialDto= new List<ResultTestimonialDto>();
            foreach (var value in values)
            {
                resultTestimonialDto.Add(new ResultTestimonialDto
                {
                    Content=value.Content,
                    Name=value.Name,
                    Status=value.Status,
                    TestimonialId=value.TestimonialId,
                    Title=value.Title,
                    ImageUrl=value.ImageUrl,
                });
            }
            return resultTestimonialDto;
          
        }

        public List<Testimonial> BusinessGetWhere(Expression<Func<Testimonial, bool>> expression)
        {
            return _testimonialDal.GetWhere(expression);
        }

        public void BusinessInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void BusinessUpdate(Testimonial entity)
        {
           _testimonialDal.Update(entity);
        }
    }
}
