using Microsoft.AspNetCore.SignalR;
using QuickFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.ViewModels
{
    public class ChatViewModel : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("recieveMessage", message);
    }
}
