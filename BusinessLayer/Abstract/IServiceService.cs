using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IServiceService : IGenericService<Service>
    {
        public Service BusinessGetOneServiceForTrue();
    }
    
}
