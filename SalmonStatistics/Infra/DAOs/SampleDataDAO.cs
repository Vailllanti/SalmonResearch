using ISpan.Utility;
using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Infra.DAOs
{
	public class SampleDataDAO
	{
		public IEnumerable<SampleDataDTO> GetAll(int id)
		{
			string sql = @"select * 
							from SampleData d 
							join SampleArea a on a.Id = d.SampleAreaId
							join Species s on s.Id = d.SpeciesId
							join Watershed w on w.Id = a.WatershedId";

			SqlParameter[] parameters = new SqlParameter[] { };

			int SampleAreaId = id;

			if (SampleAreaId > 0)
			{
				sql += " where SampleAreaId = @SampleAreaId";
				parameters = new SqlParameterBulider()
					.AddInt("SampleAreaId", SampleAreaId)
					.Build();
			}

			var dbhelper = new SqlDbHelper("default");
			return dbhelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => new SampleDataDTO
				{
					Id = row.Field<int>("Id"),
					SpeciesId = row.Field<int>("SpeciesId"),
					Species = row.Field<string>("Species"),
					SampleAreaId = row.Field<int>("SampleAreaId"),
					AreaName = row.Field<string>("AreaName"),
					AdultNumber = row.Field<int>("AdultNumber"),
					SubadultNumber = row.Field<int>("SubadultNumber"),
					JuvenileNumber = row.Field<int>("JuvenileNumber"),
					SamplngDate = row.Field<DateTime>("SamplngDate"),
				});
		}

		public SampleDataDTO GetOne(int id)
		{
			string sql = @"SELECT * from SampleData WHERE Id = @Id";
			var parameter = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			if (dt.Rows.Count == 0) throw new Exception("抱歉，找不到您要的資料");

			return ToSampleDataDTO(dt.Rows[0]);
		}
		private SampleDataDTO ToSampleDataDTO(DataRow row)
		{
			return new SampleDataDTO
			{
				Id = row.Field<int>("Id"),
				SpeciesId = row.Field<int>("SpeciesId"),
				SampleAreaId = row.Field<int>("SampleAreaId"),
				AdultNumber = row.Field<int>("AdultNumber"),
				SubadultNumber = row.Field<int>("SubadultNumber"),
				JuvenileNumber = row.Field<int>("JuvenileNumber"),
				SamplngDate = row.Field<DateTime>("SamplngDate"),
			};
		}

		public void Create(SampleDataDTO model)
		{
			string sql = @"insert into SampleData
(SpeciesId,SampleAreaId,AdultNumber,SubadultNumber,JuvenileNumber,SamplngDate) 
values(@SpeciesId,@SampleAreaId,@AdultNumber,@SubadultNumber,@JuvenileNumber,@SamplngDate)";

			var parameters = new SqlParameterBulider()
							.AddInt("SpeciesId", model.SpeciesId)
							.AddInt("SampleAreaId", model.SampleAreaId)
							.AddInt("AdultNumber", model.AdultNumber)
							.AddInt("SubadultNumber", model.SubadultNumber)
							.AddInt("JuvenileNumber", model.JuvenileNumber)
							.AddDatetime("SamplngDate",model.SamplngDate)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool AreaExists(string riverName)
		{
			string sql = @"select count(*) as count from SampleData where AreaName = @AreaName";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("AreaName", 50, riverName)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Update(SampleDataDTO model)
		{

			string sql = @"Update SampleData set 
SpeciesId=@SpeciesId,SampleAreaId=@SampleAreaId,AdultNumber=@AdultNumber,SubadultNumber=@SubadultNumber
,JuvenileNumber=@JuvenileNumber,SamplngDate=@SamplngDate where Id = @Id";

			var parameters = new SqlParameterBulider()
							.AddInt("SpeciesId", model.SpeciesId)
							.AddInt("SampleAreaId", model.SampleAreaId)
							.AddInt("AdultNumber", model.AdultNumber)
							.AddInt("SubadultNumber", model.SubadultNumber)
							.AddInt("JuvenileNumber", model.JuvenileNumber)
							.AddDatetime("SamplngDate", model.SamplngDate)
							.AddInt("Id", model.Id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool SameAreaExists(string AreaName, int id)
		{
			string sql = @"select count(*) as count from SampleData where AreaName = @AreaName and Id != @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("AreaName", 50, AreaName)
							.AddInt("Id", id)
							.Build();
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM SampleData WHERE Id=@Id";
			var parameters = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
