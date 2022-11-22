using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.DTOs
{
	public class SampleDataDTO
	{
		public int Id { get; set; }

		public int SpeciesId { get; set; }

		public string Species { get; set; }

		public int SampleAreaId { get; set; }

		public string AreaName { get; set; }

		public int AdultNumber { get; set; }

		public int SubadultNumber { get; set; }

		public int JuvenileNumber { get; set; }

		public DateTime SamplingDate { get; set; }
	}

	public static class SampleDataDTOExts
	{
		public static SampleDataVM ToVM(this SampleDataDTO dto)
		{
			return new SampleDataVM
			{
				Id = dto.Id,
				SpeciesId = dto.SpeciesId,
				SampleAreaId = dto.SampleAreaId,

				AdultNumber = dto.AdultNumber,
				SubadultNumber = dto.SubadultNumber,
				JuvenileNumber = dto.JuvenileNumber,
				SamplingDate = dto.SamplingDate.ToString("yyyy/MM/dd"),
			};
		}

		public static SampleDataIndexVM ToIndexVM(this SampleDataDTO dto)
		{
			return new SampleDataIndexVM
			{
				Id = dto.Id,
				SpeciesId = dto.SpeciesId,
				Species = dto.Species,
				SampleAreaId = dto.SampleAreaId,
				AreaName = dto.AreaName,

				AdultNumber = dto.AdultNumber,
				SubadultNumber = dto.SubadultNumber,
				JuvenileNumber = dto.JuvenileNumber,
				SamplingDate = dto.SamplingDate.ToString("yyyy/MM/dd"),
			};
		}
	}
}
