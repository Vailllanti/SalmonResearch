using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.DTOs
{
	public class WatershedDTO
	{
		public int Id { get; set; }

		public string RiverName { get; set; }
	}

	public static class WatershedDTOExts
	{
		public static WatershedVM ToVM(this WatershedDTO dto)
		{
			return new WatershedVM
			{
				Id = dto.Id,
				RiverName = dto.RiverName,
			};
		}

		public static WatershedIndexVM ToIndexVM(this WatershedDTO dto)
		{
			return new WatershedIndexVM
			{
				Id = dto.Id,
				RiverName = dto.RiverName,
			};
		}
	}

}
