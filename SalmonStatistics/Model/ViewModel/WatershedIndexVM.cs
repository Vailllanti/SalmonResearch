using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.ViewModel
{
	public class WatershedIndexVM
	{
		public int Id { get; set; }

		public string RiverName { get; set; }
	}
	public class WatershedVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "流域名稱必填")]
		public string RiverName { get; set; }
	}

	public static class WatershedVMExts 
	{
		public static WatershedDTO ToDTO(this WatershedVM vm)
		{
			return new WatershedDTO
			{
				Id = vm.Id,
				RiverName = vm.RiverName,
			};
		}
	}
}
