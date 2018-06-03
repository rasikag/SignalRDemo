using Microsoft.AspNet.SignalR;
using SignalRServer.SignalRHub;
using System.Web.Http;

namespace SignalRServer.Controllers
{
    [Route("demo")]
    public class DemoController : ApiController
    {
        [Route("trigger-event")]
        public IHttpActionResult TriggerEvent()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            hubContext.Clients.All.broadCastMessage("your message here");
            return Ok();
        }
    }
}
