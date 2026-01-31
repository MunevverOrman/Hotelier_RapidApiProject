using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {

        private readonly IAppUserService _appUserService;

        public AppUsersController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        //[HttpGet]
        //public IActionResult UserListWithWorklocation()
        //{
        //    var values= _appUserService.TUserListWithWorklocation();
        //    return Ok(values);
        //}
        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }
    }
}
