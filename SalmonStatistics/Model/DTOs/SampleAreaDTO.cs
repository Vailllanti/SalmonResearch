using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.DTOs
{
	public class SampleAreaDTO
	{
		public int Id { get; set; }

		public string AreaName { get; set; }

		public string RiverName { get; set; }

		public int WatershedId { get; set; }
	}

	public static class SampleAreaDTOExts
	{
		public static SampleAreaVM ToVM(this SampleAreaDTO dto)
		{
			return new SampleAreaVM
			{
				Id = dto.Id,
				AreaName = dto.AreaName,
				WatershedId = dto.WatershedId,
			};
		}

		public static SampleAreaIndexVM ToIndexVM(this SampleAreaDTO dto) 
		{
			return new SampleAreaIndexVM
			{
				Id = dto.Id,
				AreaName = dto.AreaName,
				RiverName = dto.RiverName,
			};
		}
	}
}
