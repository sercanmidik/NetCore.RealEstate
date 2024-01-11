using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IGetInTouchDal : IGenericDal<GetInTouch>
    {
        public IQueryable<GetInTouch> GetOneTouchForTrue();
    }

}
