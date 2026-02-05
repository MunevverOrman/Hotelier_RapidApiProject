using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Varsayılanlar: API patlarsa dashboard çökmesin
            ViewBag.v1 = 0; // instagram followers
            ViewBag.v2 = 0; // instagram following
            ViewBag.v3 = 0; // twitter followers
            ViewBag.v4 = 0; // twitter following/friends
            ViewBag.v5 = 0; // linkedin followers

            using var client = new HttpClient();

            // 1) Instagram
            try
            {
                using var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/didemgeziyor"),
                };
                request.Headers.Add("x-rapidapi-key", "1ebc8e073bmshd04570e4e39ca91p1969d4jsn23a30b50f463");
                request.Headers.Add("X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com");

                using var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);

                    if (result != null)
                    {
                        ViewBag.v1 = result.followers;
                        ViewBag.v2 = result.following;
                    }
                }
                // else: başarısızsa 0 kalsın (istersen body okuyup loglayabilirsin)
            }
            catch
            {
                // 0 kalsın
            }

            // 2) Twitter
            try
            {
                using var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
                };
                request2.Headers.Add("x-rapidapi-key", "1ebc8e073bmshd04570e4e39ca91p1969d4jsn23a30b50f463");
                request2.Headers.Add("X-RapidAPI-Host", "twitter32.p.rapidapi.com");

                using var response2 = await client.SendAsync(request2);

                if (response2.IsSuccessStatusCode)
                {
                    var body2 = await response2.Content.ReadAsStringAsync();
                    var result2 = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);

                    if (result2?.data?.user_info != null)
                    {
                        ViewBag.v3 = result2.data.user_info.followers_count;
                        ViewBag.v4 = result2.data.user_info.friends_count;
                    }
                }
            }
            catch
            {
                // 0 kalsın
            }

            // 3) LinkedIn
            try
            {
                using var request3 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmurat-y%C3%BCceda%C4%9F-186933149%2F"),
                };
                request3.Headers.Add("x-rapidapi-key", "1ebc8e073bmshd04570e4e39ca91p1969d4jsn23a30b50f463");
                request3.Headers.Add("X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com");

                using var response3 = await client.SendAsync(request3);

                if (response3.IsSuccessStatusCode)
                {
                    var body3 = await response3.Content.ReadAsStringAsync();
                    var result3 = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);

                    if (result3?.data != null)
                    {
                        ViewBag.v5 = result3.data.followers_count;
                    }
                }
            }
            catch
            {
                // 0 kalsın
            }

            return View();
        }
    }
}
