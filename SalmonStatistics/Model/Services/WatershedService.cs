using ISpan.Utility;
using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmonStatistics.Model.Services
{
	public class WatershedService
	{
		private WatershedDAO _dao;

		public WatershedService()
		{
			_dao = new WatershedDAO();
		}


		public void Create(WatershedDTO model)
		{
			bool isExists = _dao.RiverExists(model.RiverName);
			if (isExists) throw new Exception("此流域已在資料庫內");

			new WatershedDAO().Create(model);
		}

		public void Update(WatershedDTO model)
		{
			bool isExists = _dao.SameRiverExists(model);
			if (isExists) throw new Exception("此流域已在資料庫內");

			new WatershedDAO().Update(model);
		}
	}
}
