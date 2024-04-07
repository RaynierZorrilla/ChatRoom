using Microsoft.AspNetCore.SignalR;


namespace ChatRoom
{
	public class Chathub : Hub
	{
		public async Task SendMessage( string room, string user, string message)
		{
			//Enviamos un mensaje asincronico a todos los integrantes de la sala
			await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
		}

		public async Task AddToGroup(string room)
		{
			//Añadir persona a la sala
			await Groups.AddToGroupAsync(Context.ConnectionId, room);
			await Clients.Group(room).SendAsync("ShowWho",
				$"Se Conectó {Context.ConnectionId}");
		}
	}
}
