using ConsumeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace ConsumeAPI.Controllers
{
    public class ProFriendsAPIController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7087/api");
        private readonly HttpClient _client;

        public ProFriendsAPIController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ProFriendsAPIViewModel> ProFriendsAPI = new List<ProFriendsAPIViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/ProFriendsAPI/Get").Result;

            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ProFriendsAPI = JsonConvert.DeserializeObject<List<ProFriendsAPIViewModel>>(data);
            }
            return View(ProFriendsAPI);
        }
    }
}
