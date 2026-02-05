using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/didemgeziyor"),
                Headers =
    {
        { "x-rapidapi-key", "1ebc8e073bmshd04570e4e39ca91p1969d4jsn23a30b50f463" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                //ViewBag.v1 = resultInstagramFollowersDto.followers;
                //ViewBag.v2 = resultInstagramFollowersDto.following;
                return View(resultInstagramFollowersDto);
            }
        }
    }
}
