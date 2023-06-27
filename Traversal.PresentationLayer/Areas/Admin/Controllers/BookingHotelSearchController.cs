using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Traversal.PresentationLayer.Areas.Admin.Models;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=AED&dest_id=-553173&locale=tr&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
                Headers =
    {
        { "X-RapidAPI-Key", "b555c5ce48msh829147e03d3c901p17b01cjsnb0346ad61158" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync(); ;
                var bodyReplace = body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
                return View(values.results);
            }
        }
    }
}
