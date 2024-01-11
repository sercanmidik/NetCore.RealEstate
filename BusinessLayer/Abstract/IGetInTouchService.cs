using DtoLayer.GetInTouch;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IGetInTouchService : IGenericService<GetInTouch>
    {
        public ResultGetInTouchDto BusinessGetOneTouchForTrue();
    }
    
}
