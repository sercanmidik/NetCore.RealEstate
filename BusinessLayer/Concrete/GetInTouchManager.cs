using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.GetInTouch;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GetInTouchManager : IGetInTouchService
    {
        private readonly IGetInTouchDal _getInTouchDal;

        public GetInTouchManager(IGetInTouchDal getInTouchDal)
        {
            _getInTouchDal = getInTouchDal;
        }

        public void BusinessDelete(GetInTouch entity)
        {
            _getInTouchDal.Delete(entity);  
        }

        public List<GetInTouch> BusinessGetAll()
        {
            return _getInTouchDal.GetAll();
        }

        public GetInTouch BusinessGetById(int id)
        {
            return _getInTouchDal.GetById(id);
        }

        public ResultGetInTouchDto BusinessGetOneTouchForTrue()
        {
            var value = _getInTouchDal.GetOneTouchForTrue().Where(x => x.Status == true).FirstOrDefault();
            if (value != null)
            {
                ResultGetInTouchDto result = new ResultGetInTouchDto()
                {
                    Address = value.Address,
                    Status = value.Status,
                    PhoneNumber = value.PhoneNumber,
                    Email = value.Email,
                    InstagramUrl = value.InstagramUrl,
                    GetInTouchId = value.GetInTouchId,
                    FacebookUrl = value.FacebookUrl,
                    TwitterUrl = value.TwitterUrl,
                    FrameString=value.FrameString,
                };
                return result;
            }

            return new ResultGetInTouchDto();

        }

        public List<GetInTouch> BusinessGetWhere(Expression<Func<GetInTouch, bool>> expression)
        {
            return _getInTouchDal.GetWhere(expression);
        }

        public void BusinessInsert(GetInTouch entity)
        {
            _getInTouchDal.Insert(entity);
        }

        public void BusinessUpdate(GetInTouch entity)
        {
            _getInTouchDal.Update(entity);
        }
    }
}
