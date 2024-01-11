using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IContactUsDal : IGenericDal<ContactUs>
    {
        public ContactUs GetOneContactUs();
    }

}
