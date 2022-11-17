using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.ViewModel
{
	public class SampleAreaIndexVM
	{
		public int Id { get; set; }

		public string AreaName { get; set; }

		public string RiverName { get; set; }

	}		
	public class SampleAreaVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "樣區名稱必填")]
		public string AreaName { get; set; }

		[Required(ErrorMessage = "流域必選")]
		public int WatershedId { get; set; }
	}

	public static class SampleAreaVMExts
	{
		public static SampleAreaDTO ToDTO(this SampleAreaVM vm)
		{
			return new SampleAreaDTO
			{
				Id = vm.Id,
				AreaName = vm.AreaName,
				WatershedId=vm.WatershedId,
			};
		}
	}
}
