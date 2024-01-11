using DtoLayer.ContactUsDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService : IGenericService<ContactUs>
    {
        public ResultContactUsDto BusinessGetOneContactUs();
    }
    
}
