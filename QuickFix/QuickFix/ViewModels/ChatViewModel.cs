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
        string Username => Context.User.Identity.Name;
        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync(
                "MessageReceived",
                new
                {
                    text = $" Hi, {Username}! 👍🏽",
                    id = "greeting",
                    isGreeting = true,
                    user = "👋"
                });

            await Clients.Others.SendAsync(
                "UserLoggedOn",
                new
                {
                    user = Username
                });
        }
        public override async Task OnDisconnectedAsync(Exception ex)
           => await Clients.Others.SendAsync(
               "UserLoggedOff",
               new
               {
                   user = Username
               });

        public async Task PostMessage(string message, string id = null)
        {

            await Clients.All.SendAsync(
                "MessageReceived",
                new
                {
                    text = message,
                    id = UseOrCreateId(id),
                    isEdit = id != null,
                    user = Username
                });
        }

        public async Task UserTyping(bool isTyping)
            => await Clients.Others.SendAsync(
                "UserTyping",
                new
                {
                    isTyping,
                    user = Username
                });

        static string UseOrCreateId(string id)
            => string.IsNullOrWhiteSpace(id)
                ? Guid.NewGuid().ToString()
                : id;
    }
}

