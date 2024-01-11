using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IGalleryDal : IGenericDal<Gallery>
    {
        public IQueryable<Gallery> GetGallary();
    }

}
