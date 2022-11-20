using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.ViewModel
{
	public class SpeciesIndexVM
	{
		public int Id { get; set; }

		public string Species { get; set; }

		public string ReferencesUrl { get; set; }
	}

	public class SpeciesVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "物種學名必填")]
		public string Species { get; set; }

		[Url(ErrorMessage ="請輸入正確的網址格式")]
		public string ReferencesUrl { get; set; }
	}

	public static class SpeciesVMExts 
	{
		public static SpeciesDTO ToDTO(this SpeciesVM vm)
		{
			return new SpeciesDTO
			{
				Id = vm.Id,
				Species = vm.Species,
				ReferencesUrl = vm.ReferencesUrl,
			};
		}
	}
}

