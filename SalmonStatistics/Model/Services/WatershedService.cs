using ISpan.Utility;
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

		public WatershedVM GetOne(int id)
		{
			string sql = "SELECT * FROM Watershed WHERE Id = @Id";
			var parameter = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			if (dt.Rows.Count == 0) throw new Exception("抱歉，找不到您要的資料");
			WatershedVM model = ToWatershedVM(dt.Rows[0]);

			return model;
		}
		private WatershedVM ToWatershedVM(DataRow row)
		{
			return new WatershedVM
			{
				Id = row.Field<int>("Id"),
				RiverName = row.Field<string>("RiverName"),
			};
		}

		public void Create(WatershedVM model)
		{
			bool isExists = RiverExists(model.RiverName);
			if (isExists) throw new Exception("此流域已在資料庫內");

			string sql = @"insert into Watershed(riverName) 
							values(@rivername)";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, model.RiverName)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool RiverExists(string riverName)
		{
			string sql = @"select count(*) as count from Watershed where riverName = @riverName";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, riverName)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Update(WatershedVM model)
		{
			bool isExists = SameRiverExists(model.RiverName,model.Id);
			if (isExists) throw new Exception("此流域已在資料庫內");

			string sql = @"Update Watershed set riverName = @rivername where Id = @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, model.RiverName)
							.AddInt("Id",model.Id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool SameRiverExists(string riverName,int id)
		{
			string sql = @"select count(*) as count from Watershed where riverName = @riverName and Id != @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, riverName)
							.AddInt("Id", id)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}
	}
}
