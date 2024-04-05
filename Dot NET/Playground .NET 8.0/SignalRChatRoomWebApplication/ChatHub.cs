using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChatRoomWebApplication {
    public class ChatHub : Hub {
        // [Authorize(Roles = "Admin")]
        public async Task SendMessage(string user, string message) {
            await Clients.All.SendAsync("ReceiveMessage", user, message + " 014290985");
        }

        public async override Task OnConnectedAsync() {
            await Clients.All.SendAsync("ReceiveMessage", Context.UserIdentifier, "OnConnectedAsync");
        }

        public async override Task OnDisconnectedAsync(Exception? exception) {
            await Clients.All.SendAsync("ReceiveMessage", Context.UserIdentifier, "OnDisconnectedAsync");
        }
    }
}