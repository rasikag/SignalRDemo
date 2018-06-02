using System.Web.Http;

namespace SignalRServer.Controllers
{
    [Route("demo")]
    public class DemoController : ApiController
    {
        [Route("trigger-event")]
        public IHttpActionResult TriggerEvent()
        {
            return Ok();
        }
    }
}
