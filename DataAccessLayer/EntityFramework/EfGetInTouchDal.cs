using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfGetInTouchDal : GenericRepository<GetInTouch>, IGetInTouchDal
    {
        private readonly RealEstateContext _context;
        public EfGetInTouchDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<GetInTouch> GetOneTouchForTrue()
        {
            return _context.GetInTouches;
        }
    }
}
