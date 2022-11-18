using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.Services
{
	public class SampleDataService
	{
		private SampleDataDAO _dAO;

		public SampleDataService()
		{
			_dAO = new SampleDataDAO();
		}

		public void Create(SampleDataDTO model)
		{
			//bool isExists = _dAO.DataExists(model.AreaName);
			//if (isExists) throw new Exception("此流域已在資料庫內");

			_dAO.Create(model);
		}

		public void Update(SampleDataDTO model)
		{
			//bool isExists = _dAO.SameDataExists(model.AreaName, model.Id);
			//if (isExists) throw new Exception("此樣區已在資料庫內");

			_dAO.Update(model);
		}

		public void Delete(int id)
		{
			_dAO.Delete(id);
		}
	}
}
