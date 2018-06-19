using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SampleSignalRService
{
    public class ChatHub : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.SendAsync("Receive", message);
        }
    }
}