using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public List<Product> GetAllWithInclude();
        public List<Product> ShowCaseTrueTakeSix();
        public List<Product> ShowCaseSellTakeSix();
        public List<Product> ShowCaseRentTakeSix();
        public List<Product> ShowCaseFeiledTakeSix();
        public List<Product> ShowCasePlotTakeSix();

        public List<Product> ShowCaseTrue();
        public List<Product> ShowCaseSell();
        public List<Product> ShowCaseRent();
        public List<Product> ShowCaseFeiled();
        public List<Product> ShowCasePlot();
    }

}
