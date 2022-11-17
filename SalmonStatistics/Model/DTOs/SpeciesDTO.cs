using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.DTOs
{
	public class SpeciesDTO
	{
		public int Id { get; set; }

		public string Species { get; set; }

		public string Url { get; set; }
	}

	public static class SpeciesDTOExts
	{
		public static SpeciesVM ToVM(this SpeciesDTO dto)
		{
			return new SpeciesVM
			{
				Id = dto.Id,
				Species = dto.Species,
				Url = dto.Url,
			};
		}

		public static SpeciesIndexVM ToIndexVM(this SpeciesDTO dto)
		{
			return new SpeciesIndexVM
			{
				Id = dto.Id,
				Species = dto.Species,
				Url = dto.Url,
			};
		}
	}
}
