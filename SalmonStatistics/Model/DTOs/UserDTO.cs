using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.DTOs
{
	public class UserDTO
	{
		public int Id { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }


		public string Name { get; set; }
	}

	public static class UserDTOExts
	{
		public static UserVM ToVM(this UserDTO dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Name = dto.Name,
			};
		}

		public static UsersIndexVM ToIndexVM(this UserDTO dto)
		{
			return new UsersIndexVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Name = dto.Name,
			};
		}
	}
}
