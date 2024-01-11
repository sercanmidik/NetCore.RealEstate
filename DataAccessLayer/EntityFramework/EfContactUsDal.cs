using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        private readonly RealEstateContext _context;
        public EfContactUsDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public ContactUs GetOneContactUs()
        {
            return _context.ContactUses.Where(x=>x.Status==true).First();
        }
    }
}
