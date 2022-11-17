using ISpan.Utility;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Infra.DAOs
{
	public class WatershedDAO
	{
		public IEnumerable<WatershedDTO> GetAll()
		{
			string sql = "select Id,RiverName from Watershed order by Id";
			var dbhelper = new SqlDbHelper("default");
			return dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new WatershedDTO 
				{
					Id = row.Field<int>("Id"),
					RiverName = row.Field<string>("RiverName")
				});

		}

		public WatershedDTO GetOne(int id)
		{
			string sql = "SELECT * FROM Watershed WHERE Id = @Id";
			var parameter = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			if (dt.Rows.Count == 0) throw new Exception("抱歉，找不到您要的資料");
			

			return ToWatershedDTO(dt.Rows[0]);
		}
		private WatershedDTO ToWatershedDTO(DataRow row)
		{
			return new WatershedDTO
			{
				Id = row.Field<int>("Id"),
				RiverName = row.Field<string>("RiverName"),
			};
		}

		public void Create(WatershedDTO model)
		{
			string sql = @"insert into Watershed(riverName) 
							values(@rivername)";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, model.RiverName)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool RiverExists(string riverName)
		{
			string sql = @"select count(*) as count from Watershed where riverName = @riverName";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, riverName)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Update(WatershedDTO model)
		{
			string sql = @"Update Watershed set riverName = @rivername where Id = @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50, model.RiverName)
							.AddInt("Id", model.Id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool SameRiverExists(WatershedDTO model)
		{
			string sql = @"select count(*) as count from Watershed where riverName = @riverName and Id != @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("riverName", 50,model.RiverName)
							.AddInt("Id", model.Id)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}


	}
}
