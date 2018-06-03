using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRServer.SignalRHub
{
    public class NotificationHub : Hub
    {
        public void SendFileUploadedSucessNotification()
        {
            Clients.All.broadcastMessage();
        }
    }
}