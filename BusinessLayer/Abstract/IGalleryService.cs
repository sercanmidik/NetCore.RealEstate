using DtoLayer.GallaryDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IGalleryService : IGenericService<Gallery>
    {
        public IEnumerable<ResultGalleryDto> BusinnessGetGallary();
    }
    
}
