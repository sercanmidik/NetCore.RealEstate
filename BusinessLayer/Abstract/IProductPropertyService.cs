using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IProductPropertyService : IGenericService<ProductProperty>
    {
        public IEnumerable<ProductProperty> BusinessGetProductPropertList();
    }
}
