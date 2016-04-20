using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using WebApi.Model;

namespace WebApi.Controllers
{
    public class ConsumerController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/Get")]
        //  [Authorize] //comment this line if you want to access api directly from web.
        // [AcceptVerbs("HEAD,GET")]
        public IHttpActionResult Get()
        {
            //HttpResponseMessage response;
            //if (HttpContext.Current.Request.HttpMethod == "HEAD")
            //{
            //    response = new HttpResponseMessage(HttpStatusCode.OK);
            //    var memoryStream = new MemoryStream();
            //    response.Content= new StreamContent(memoryStream);
            //    response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            //    return Ok(response);
            //}

            IList<Consumer> consumer = new List<Consumer>();
            consumer.Add(new Consumer() { Name = "Ajay Kotnala", Address = "INDIA", Telephone = "123345456" });
            consumer.Add(new Consumer() { Name = "Gappu Singh", Address = "Bilayat", Telephone = "9878757654" });
            consumer.Add(new Consumer() { Name = "Guggu Grewal", Address = "Vilayat", Telephone = "34546456" });
            return Ok(consumer);
        }

        //[EnableCors("http://localhost:62627", "*","GET,POST,DELETE,PUT")]
        //[EnableCors("*", "*", "GET, POST, PATCH, OPTIONS")]
    }
}
