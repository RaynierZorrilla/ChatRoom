using Microsoft.AspNetCore.Mvc;

namespace ChatRoom.Controllers
{
	public class ChatController : Controller
	{
		public static Dictionary<int, string> Rooms =
				new Dictionary<int, string>()
				{
					{ 1, "Sala 1 - Dudas Nómina"},
					{ 2, "Sala 2 - FAQ"},
					{ 3, "Sala 3 - Soporte Técnico"},
					{ 4, "Sala 4 - Quejas o Sugerencias"}
				};

		public IActionResult RoomList()
		{
			return View();
		}

		public IActionResult Room(int room)
		{
			return View("Room", room);
		}
	}
}
