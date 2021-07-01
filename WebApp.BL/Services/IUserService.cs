using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DAL.Models;

namespace WebApp.BL.Services
{
	public interface IUserService
	{
		Task<List<User>> GetUsersAsync();
	}
}
