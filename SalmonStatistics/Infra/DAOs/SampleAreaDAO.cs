using ISpan.Utility;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Infra.DAOs
{
	public class SampleAreaDAO
	{
		public IEnumerable<SampleAreaDTO> GetAll(int id)
		{
			string sql = @"select sa.Id,sa.AreaName,w.RiverName from SampleArea sa 
									join Watershed w on w.Id = sa.WatershedId ";

			SqlParameter[] parameters = new SqlParameter[] { };

			int watershedyId = id;

			if (watershedyId > 0)
			{
				sql += " where watershedId = @watershedId";
				parameters = new SqlParameterBulider()
					.AddInt("watershedId", watershedyId)
					.Build();
			}

			var dbhelper = new SqlDbHelper("default");
			return dbhelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => new SampleAreaDTO 
				{
					Id = row.Field<int>("Id"),
					AreaName = row.Field<string>("AreaName"),
					RiverName = row.Field<string>("RiverName")
				});
		}

		public SampleAreaDTO GetOne(int id)
		{
			string sql = "SELECT * FROM SampleArea WHERE Id = @Id";
			var parameter = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			if (dt.Rows.Count == 0) throw new Exception("抱歉，找不到您要的資料");

			return ToSampleAreaDTO(dt.Rows[0]);
		}
		private SampleAreaDTO ToSampleAreaDTO(DataRow row)
		{
			return new SampleAreaDTO
			{
				Id = row.Field<int>("Id"),
				AreaName = row.Field<string>("AreaName"),
				WatershedId = row.Field<int>("WatershedId")
			};
		}

		public void Create(SampleAreaDTO model)
		{
			string sql = @"insert into SampleArea(AreaName,watershedId) 
							values(@AreaName,@watershedId)";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("AreaName", 50, model.AreaName)
							.AddInt("watershedId", model.WatershedId)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool AreaExists(string riverName)
		{
			string sql = @"select count(*) as count from SampleArea where AreaName = @AreaName";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("AreaName", 50, riverName)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Update(SampleAreaDTO model)
		{

			string sql = @"Update SampleArea set AreaName = @AreaName,WatershedId=@WatershedId where Id = @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("AreaName", 50, model.AreaName)
							.AddInt("WatershedId", model.WatershedId)
							.AddInt("Id", model.Id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool SameAreaExists(string AreaName, int id)
		{
			string sql = @"select count(*) as count from SampleArea where AreaName = @AreaName and Id != @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("AreaName", 50, AreaName)
							.AddInt("Id", id)
							.Build();
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM SampleArea WHERE Id=@Id";
			var parameters = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
