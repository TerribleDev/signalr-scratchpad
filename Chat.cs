using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRYo
{
    public class Chat : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.InvokeAsync("Send", "From Server " + message);
        }
    }
}