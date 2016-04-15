using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using MVCClient.Helpers;
using MVCClient.Model;
using Newtonsoft.Json;

namespace MVCClient.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var httpClient = HttpClientHelper.GetClient();
            var rspApi = await httpClient.GetAsync("consumer").ConfigureAwait(false);
            var vm = new ConsumerViewModel();
            vm.consumers = new List<Consumer>();
            if (rspApi.IsSuccessStatusCode)
            {
                var lstTripsAsString = await rspApi.Content.ReadAsStringAsync().ConfigureAwait(false);

                vm = new ConsumerViewModel();
                vm.consumers = JsonConvert.DeserializeObject<IList<Consumer>>(lstTripsAsString).ToList();

                return View(vm.consumers);
            }
            //else
            //{
            //    return View("Error",
            //             new HandleErrorInfo(ExceptionHelper.GetExceptionFromResponse(rspTrips),
            //            "Trips", "Index"));
            //}
            return View(vm.consumers);
        }
    }
}