using BusinessLayer.Abstract;
using DtoLayer.BrandDtos;
using DtoLayer.TeamFriendDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminTeamFriendController : Controller
    {
        private readonly ITeamFriendService _teamFriendService;

        public AdminTeamFriendController(ITeamFriendService teamFriendService)
        {
            _teamFriendService = teamFriendService;
        }

        public IActionResult Index()
        {
            var brands = _teamFriendService.BusinessGetAll();
            return View(brands);
        }

        [HttpGet]
        public IActionResult CreateTeamFriend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeamFriend(CreateTeamFriendDto createTeamFriendDto)
        {
            if (ModelState.IsValid)
            {
                TeamFriend teamFriend = new TeamFriend()
                {
                    FacbookUrl = createTeamFriendDto.FacbookUrl,
                    ImageUrl = createTeamFriendDto.ImageUrl,
                    InstagramUrl = createTeamFriendDto.InstagramUrl,
                    Name = createTeamFriendDto.Name,
                    PhoneNumber = createTeamFriendDto.PhoneNumber,
                    Status = true,
                    Title = createTeamFriendDto.Title,
                    TwitterUrl = createTeamFriendDto.TwitterUrl,
                };
                _teamFriendService.BusinessInsert(teamFriend);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateTeamFriend(int id)
        {
            var value = _teamFriendService.BusinessGetById(id);
            UpdateTeamFriendDto updateTeamFriendDto = new UpdateTeamFriendDto()
            {
                InstagramUrl=value.InstagramUrl,
                Name = value.Name,
                PhoneNumber = value.PhoneNumber,
                Status=value.Status,
                Title=value.Title,
                TwitterUrl = value.TwitterUrl,
                TeamFriendId = id,
                ImageUrl = value.ImageUrl,
                FacbookUrl = value.FacbookUrl
                
            };
            return View(updateTeamFriendDto);
        }
        [HttpPost]
        public IActionResult UpdateTeamFriend(UpdateTeamFriendDto updateTeamFriendDto)
        {
            if (ModelState.IsValid)
            {
                TeamFriend teamFriend = new TeamFriend()
                {
                  FacbookUrl=updateTeamFriendDto.FacbookUrl,
                  ImageUrl=updateTeamFriendDto.ImageUrl,
                  TeamFriendId = updateTeamFriendDto.TeamFriendId,
                  TwitterUrl=updateTeamFriendDto.TwitterUrl,
                  Title = updateTeamFriendDto.Title,
                  Status = updateTeamFriendDto.Status,
                  PhoneNumber = updateTeamFriendDto.PhoneNumber,
                  Name = updateTeamFriendDto.Name,
                  InstagramUrl = updateTeamFriendDto.InstagramUrl,
                };
                _teamFriendService.BusinessUpdate(teamFriend);
                return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult DeleteTeamFriend(int id)
        {
            var value = _teamFriendService.BusinessGetById(id);
            _teamFriendService.BusinessDelete(value);
            return RedirectToAction("Index");
        }
    }
}
