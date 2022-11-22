using SalmonStatistics.Infra.Extenstions;
using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
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

		public string SamplingDate { get; set; }
	}
	public class SampleDataVM
	{
		public int Id { get; set; }

		public int SpeciesId { get; set; }

		public int SampleAreaId { get; set; }

		[Range(0, 9999, ErrorMessage ="請輸入大於0的整數")]
		public int AdultNumber { get; set; }

		[Range(0, 9999, ErrorMessage = "請輸入大於0的整數")]
		public int SubadultNumber { get; set; }

		[Range(0, 9999, ErrorMessage = "請輸入大於0的整數")]
		public int JuvenileNumber { get; set; }

		[Required(ErrorMessage = "採樣日期必填")]
		[DateTimeAttribute(ErrorMessage ="請輸入正確的日期格式，例如1992/10/05")]
		public string SamplingDate { get; set; }
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
				SamplingDate = Convert.ToDateTime(vm.SamplingDate),
			};
		}
	}
}
