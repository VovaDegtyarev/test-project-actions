using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DAL.Models;

namespace WebApp.BL.Services
{
	public class UserService : IUserService
	{
		public async Task<List<User>> GetUsersAsync()
		{
			var result = GetUsersList();

			return result;
		}


		public static List<User> GetUsersList()
		{
			var list = new List<User>();

			list.Add(new User 
			{
				Id = Guid.NewGuid(),
				Name = "Ivan",
				LastName = "Ivanov"
			});

			list.Add(new User
			{
				Id = Guid.NewGuid(),
				Name = "Petr",
				LastName = "Petrov"
			});

			list.Add(new User
			{
				Id = Guid.NewGuid(),
				Name = "Admin",
				LastName = "Admin"
			});

			return list;
		}

	}
}
