using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        private readonly RealEstateContext _context;
        public EfTestimonialDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Testimonial> GetTestimonialForTrue()
        {
            return _context.Testimonials.Where(x=>x.Status==true).ToList();
        }
    }
}
