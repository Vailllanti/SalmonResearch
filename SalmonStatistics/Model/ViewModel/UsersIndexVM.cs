using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.ViewModel
{
	public class UsersIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Name { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }


		[Required(ErrorMessage = "姓名必填")]
		[StringLength(5, ErrorMessage = "姓名最多五個字")]
		public string Name { get; set; }
	}

	public static class UserVMExts
	{
		public static UserDTO ToDTO(this UserVM vm)
		{
			return new UserDTO
			{
				Id = vm.Id,
				Account = vm.Account,
				Password = vm.Password,
				Name = vm.Name
			};
		}
	}
}
