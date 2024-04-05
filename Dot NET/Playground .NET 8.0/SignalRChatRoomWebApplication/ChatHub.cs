using Microsoft.AspNetCore.SignalR;

namespace SignalRChatRoomWebApplication {
    public class ChatHub : Hub {
        public async Task SendMessage(string user, string message) {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}