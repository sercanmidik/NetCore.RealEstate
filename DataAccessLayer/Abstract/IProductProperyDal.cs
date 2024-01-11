using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IProductPropertyDal : IGenericDal<ProductProperty>
    {
        public IEnumerable<ProductProperty> GetProductPropertList();
    }

}
