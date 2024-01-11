using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly RealEstateContext _context;
        public EfProductDal(RealEstateContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetAllWithInclude()
        {
            return _context.Products.Include("Category").Include("SubCategory").ToList();
        }

        public List<Product> ShowCaseFeiled()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x => x.Status == true && x.Category.Name == "Tarla").ToList();
        }

        public List<Product> ShowCaseFeiledTakeSix()
        {
           return _context.Products.Include("Category").Include("SubCategory").Where(x=> x.Status==true && x.Category.Name=="Tarla").Take(6).ToList();
        }

        public List<Product> ShowCasePlot()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x =>  x.Status == true && x.Category.Name == "Arsa").ToList();
        }

        public List<Product> ShowCasePlotTakeSix()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x =>  x.Status == true && x.Category.Name == "Arsa").Take(6).ToList();
        }

        public List<Product> ShowCaseRent()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x =>  x.Status == true && x.SubCategory.Name == "Kiralık").ToList();
        }

        public List<Product> ShowCaseRentTakeSix()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x =>  x.Status == true && x.SubCategory.Name == "Kiralık").Take(6).ToList();
        }

        public List<Product> ShowCaseSell()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x => x.Status == true && x.SubCategory.Name == "Satılık").ToList();
        }

        public List<Product> ShowCaseSellTakeSix()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x => x.Status == true && x.SubCategory.Name == "Satılık").Take(6).ToList();
        }

        public List<Product> ShowCaseTrue()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x =>  x.Status == true).ToList();
        }

        public List<Product> ShowCaseTrueTakeSix()
        {
            return _context.Products.Include("Category").Include("SubCategory").Where(x=>x.ShowCase==true && x.Status==true).Take(6).ToList();
        }
    }
}
