using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfGalleryDal : GenericRepository<Gallery>, IGalleryDal
    {
        private readonly RealEstateContext _context;
        public EfGalleryDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Gallery> GetGallary()
        {
            return _context.Galleries;
        }
    }
}
