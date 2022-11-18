using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.ViewModel
{
	public class SampleDataIndexVM
	{
		public int Id { get; set; }

		public int SpeciesId { get; set; }

		public string Species { get; set; }

		public int SampleAreaId { get; set; }

		public string AreaName { get; set; }

		public int AdultNumber { get; set; }

		public int SubadultNumber { get; set; }

		public int JuvenileNumber { get; set; }

		public DateTime SamplngDate { get; set; }
	}
	public class SampleDataVM
	{
		public int Id { get; set; }

		public int SpeciesId { get; set; }

		public int SampleAreaId { get; set; }

		[Required]
		public int AdultNumber { get; set; }

		[Required]
		public int SubadultNumber { get; set; }

		[Required]
		public int JuvenileNumber { get; set; }

		[Required(ErrorMessage = "採樣日期必填")]
		public DateTime SamplngDate { get; set; }
	}

	public static class SampleDataVMExts
	{
		public static SampleDataDTO ToDTO(this SampleDataVM vm)
		{
			return new SampleDataDTO
			{
				Id = vm.Id,
				SpeciesId = vm.SpeciesId,
				SampleAreaId = vm.SampleAreaId,

				AdultNumber = vm.AdultNumber,
				SubadultNumber = vm.SubadultNumber,
				JuvenileNumber = vm.JuvenileNumber,
				SamplngDate = vm.SamplngDate,
			};
		}
	}
}
