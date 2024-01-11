using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBrandDal : GenericRepository<Brand>, IBrandDal
    {
        private readonly RealEstateContext _realEstateContext;
        public EfBrandDal(RealEstateContext context) : base(context)
        {
            _realEstateContext = context;
        }

        public Brand GetOneBrand()
        {
           return _realEstateContext.Brands.Where(x=>x.Status==true).First();
        }
    }
}
