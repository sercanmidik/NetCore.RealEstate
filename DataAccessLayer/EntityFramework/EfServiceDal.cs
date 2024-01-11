using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        private readonly RealEstateContext _context;
        public EfServiceDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public Service GetOneServiceForTrue()
        {
           return _context.Services.Where(x=>x.Status==true).First();
        }
    }
}
