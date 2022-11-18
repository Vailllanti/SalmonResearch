using ISpan.Utility;
using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.Services
{
	public class SpeciesService
	{
		private SpeciesDAO _dAO;

		public SpeciesService()
		{
			_dAO = new SpeciesDAO();
		}

		public void Create(SpeciesDTO model)
		{
			bool isExists =_dAO.SpeciesExists(model.Species);
			if (isExists) throw new Exception("此物種已在資料庫內");
			_dAO.Create(model);
		}

		public void Update(SpeciesDTO model)
		{
			bool isExists = _dAO.SameSpeciesExists(model);
			if (isExists) throw new Exception("此物種已在資料庫內");
			_dAO.Update(model);
		}

		public void Delete(int id)
		{
			_dAO.Delete(id);
		}
	}
}
