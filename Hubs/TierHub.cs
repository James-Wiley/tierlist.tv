using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace tierlist.tv.Hubs
{
    public class TierHub : Hub
    {
        // In-memory user list
        private static ConcurrentDictionary<string, string> ConnectedUsers = new(); // ConnectionId -> Name

        public async Task JoinGame(string name)
        {
            ConnectedUsers[Context.ConnectionId] = name;
            await Clients.Caller.SendAsync("JoinConfirmed", name);
            await Clients.All.SendAsync("UserListUpdated", ConnectedUsers.Values.ToList());
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            ConnectedUsers.TryRemove(Context.ConnectionId, out _);
            await Clients.All.SendAsync("UserListUpdated", ConnectedUsers.Values.ToList());
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendHello(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveHello", user, message);
        }
    }
}
