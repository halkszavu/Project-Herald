using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		[HttpPost]
		public IActionResult Post([FromBody] LoginRequest request)
		{
			if(Logins.ContainsKey(request.Username) && Logins[request.Username] == request.Password)
			{
				return Ok(new LoginResponse { Token = "token" });
			}
			else
			{
				return Unauthorized();
			}
		}

		private Dictionary<string, string> Logins = new()
		{
			{ "admin", "admin" },
			{ "user", "user" },
			{ "numeric", "1234" },
		};
	}

	public class LoginRequest
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class LoginResponse
	{
		public string Token { get; set; }
	}
}
