using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealChat.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message, string color)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),color);
        }

    }
}
