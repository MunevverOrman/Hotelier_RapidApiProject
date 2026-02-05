using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage=await client.GetAsync("https://localhost:44398/api/DashboardWidgets/Staffcount");
            
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                ViewBag.staffCount=jsonData;

            
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2=await client2.GetAsync("https://localhost:44398/api/DashboardWidgets/Bookingcount");
           var jsonData2=await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.bookingCount = jsonData2;

            var client3=_httpClientFactory.CreateClient();
            var responseMessage3=await client3.GetAsync("https://localhost:44398/api/DashboardWidgets/AppUsercount");
            var jsonData3=await responseMessage3.Content.ReadAsStringAsync();               
                ViewBag.appUserCount = jsonData3;

            var client4=_httpClientFactory.CreateClient();
            var responseMessage4=await client4.GetAsync("https://localhost:44398/api/DashboardWidgets/Roomcount");
            var jsonData4=await responseMessage4.Content.ReadAsStringAsync();               
                ViewBag.roomCount = jsonData4;


            return View();
        }



    }
}
