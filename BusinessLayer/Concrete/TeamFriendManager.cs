using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.TeamFriendDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamFriendManager : ITeamFriendService
    {
        private readonly ITeamFriendDal _teamFriendDal;

        public TeamFriendManager(ITeamFriendDal teamFriendDal)
        {
            _teamFriendDal = teamFriendDal;
        }

        public void BusinessDelete(TeamFriend entity)
        {
            _teamFriendDal.Delete(entity);
        }

        public List<TeamFriend> BusinessGetAll()
        {
            return _teamFriendDal.GetAll();
        }

        public TeamFriend BusinessGetById(int id)
        {
            return _teamFriendDal.GetById(id);
        }

        public List<ResultTeamFriendDto> BusinessGetFriendStatusTrue()
        {
            var values=_teamFriendDal.GetFriendStatusTrue();
            List<ResultTeamFriendDto> result=new List<ResultTeamFriendDto>();
            foreach (var item in values)
            {
                result.Add(new ResultTeamFriendDto
                {
                    Status=item.Status,
                    FacbookUrl=item.FacbookUrl,
                    ImageUrl=item.ImageUrl,
                    InstagramUrl=item.InstagramUrl,
                    Name=item.Name,
                    TeamFriendId=item.TeamFriendId,
                    Title=item.Title,
                    TwitterUrl=item.TwitterUrl,
                    PhoneNumber=item.PhoneNumber
                });
                    
            }
            return result;
        }

        public List<TeamFriend> BusinessGetWhere(Expression<Func<TeamFriend, bool>> expression)
        {
            return _teamFriendDal.GetWhere(expression);
        }

        public void BusinessInsert(TeamFriend entity)
        {
            _teamFriendDal.Insert(entity);
        }

        public void BusinessUpdate(TeamFriend entity)
        {
            _teamFriendDal.Update(entity);
        }
    }
}
