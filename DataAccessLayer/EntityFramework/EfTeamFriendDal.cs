using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfTeamFriendDal : GenericRepository<TeamFriend>, ITeamFriendDal
    {
        private readonly RealEstateContext _realEstateContext;
        public EfTeamFriendDal(RealEstateContext context) : base(context)
        {
            _realEstateContext = context;
        }

        public List<TeamFriend> GetFriendStatusTrue()
        {
            return _realEstateContext.TeamFriends.Where(x=>x.Status==true).ToList();
        }
    }
}
