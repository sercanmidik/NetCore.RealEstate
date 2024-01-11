using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductPropertyDal : GenericRepository<ProductProperty>, IProductPropertyDal
    {
        private readonly RealEstateContext _context;
        public EfProductPropertyDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<ProductProperty> GetProductPropertList()
        {
            return _context.ProductProperties.ToList();
        }
    }
}
