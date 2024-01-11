using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfSubCategoryDal : GenericRepository<SubCategory>, ISubCategoryDal
    {
        public EfSubCategoryDal(RealEstateContext context) : base(context)
        {
        }
    }
}
