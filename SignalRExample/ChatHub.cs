using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRExample
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.Hello("tim","SignalR");
        }

        public void Message(string name,string message)
        {
            Clients.All.Message(name, message);
        }

        public void SendMessageWithID(string name,string message)
        {
            Clients.Caller.SendMessageWithID(name, message, Context.ConnectionId);
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}