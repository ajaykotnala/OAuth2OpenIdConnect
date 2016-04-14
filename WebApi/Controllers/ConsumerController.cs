using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Model;

namespace WebApi.Controllers
{
    public class ConsumerController : ApiController
    {
        [EnableCors("http://localhost:53120/","*","GET,POST,DELETE,PUT")]
        [Authorize] //comment this line if you want to access api directly from web.
        public IHttpActionResult Get()
        {
            IList<Consumer> consumer = new List<Consumer>();
            consumer.Add(new Consumer() { Name = "Ajay Kotnala", Address = "INDIA", Telephone = "123345456" });
            consumer.Add(new Consumer() { Name = "Gappu Singh", Address = "Bilayat", Telephone = "9878757654" });
            consumer.Add(new Consumer() { Name = "Guggu Grewal", Address = "Vilayat", Telephone = "34546456" });
            return Ok(consumer);
        }
    }
}
