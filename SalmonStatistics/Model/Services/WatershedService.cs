using ISpan.Utility;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.Services
{
	public class WatershedService
	{
		public IEnumerable<WatershedIndexVM> GetAll() 
		{
			string sql = "select Id,RiverName from Watershed order by Id";
			var dbhelper = new SqlDbHelper("default");
			return dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}

		private WatershedIndexVM ParseToIndexVM(DataRow row)
		{
			return new WatershedIndexVM
			{
				Id = row.Field<int>("Id"),
				RiverName = row.Field<string>("RiverName")
			};
		}
	}
}
