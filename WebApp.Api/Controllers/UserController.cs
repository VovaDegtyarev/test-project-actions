using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.BL.Services;

namespace WebApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}

		[HttpGet]
		public async Task<IActionResult> GetUsers()
		{
			var result = userService.GetUsersAsync().GetAwaiter().GetResult();
			
			return Ok(result);
		}


	}
}
