using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWithWorkLocationsController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserWithWorkLocationsController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult UsersListWithWorklocations()
        {
            //var values = _appUserService.TUsersListWithWorklocations();
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation)
                         .Select (y=>new AppUserWorkLocationViewModel
                         {
                            Name = y.Name,
                            Surname = y.Surname,
                            WorkLocationId = y.WorkLocationId,
                            WorkLocationName = y.WorkLocation.WorkLocationName,
                            City = y.City,
                            Country = y.Country,
                            ImageUrl = y.ImageUrl

                         }).ToList();
            return Ok(values);
        }
    }
}
