using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfSliderTitleDal : GenericRepository<SliderTitle>, ISliderTitleDal
    {
        private readonly RealEstateContext _context;
        public EfSliderTitleDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public List<SliderTitle> GetTrueImage()
        {
            return _context.SliderTitles.Where(x=>x.Status==true).ToList();
        }
    }
}
