using ISpan.Utility;
using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.Services
{
	public class SampleAreaService
	{
		private SampleAreaDAO _dAO;

		public SampleAreaService()
		{
			_dAO = new SampleAreaDAO();
		}
	
		public void Create(SampleAreaDTO model)
		{
			bool isExists = _dAO.AreaExists(model.AreaName);
			if (isExists) throw new Exception("此流域已在資料庫內");

			_dAO.Create(model);
		}

		public void Update(SampleAreaDTO model)
		{
			bool isExists = _dAO.SameAreaExists(model.AreaName, model.Id);
			if (isExists) throw new Exception("此樣區已在資料庫內");

			_dAO.Update(model);
		}
		
		public void Delete(int id)
		{
			_dAO.Delete(id);
		}
	}
}
