using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		[HttpPost]
		public IActionResult Post([FromBody] LoginRequest request)
		{
			if(request.Username == "admin" && request.Password == "admin")
			{
				return Ok(new LoginResponse { Token = "token" });
			}
			else
			{
				return Unauthorized();
			}
		}
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
