using ISpan.Utility;
using SalmonStatistics.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Infra.DAOs
{
	public class SpeciesDAO
	{
		public IEnumerable<SpeciesDTO> GetAll()
		{
			string sql = "select * from Species order by Id";
			var dbhelper = new SqlDbHelper("default");
			return dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new SpeciesDTO
				{
					Id = row.Field<int>("Id"),
					Species = row.Field<string>("Species"),
					ReferencesUrl = row.Field<string>("ReferencesUrl"),
				});

		}

		public SpeciesDTO GetOne(int id)
		{
			string sql = "SELECT * FROM Species WHERE Id = @Id";
			var parameter = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			if (dt.Rows.Count == 0) throw new Exception("抱歉，找不到您要的資料");


			return ToSpeciesDTO(dt.Rows[0]);
		}
		private SpeciesDTO ToSpeciesDTO(DataRow row)
		{
			return new SpeciesDTO
			{
				Id = row.Field<int>("Id"),
				Species = row.Field<string>("Species"),
				ReferencesUrl = row.Field<string>("ReferencesUrl"),
			};
		}

		public void Create(SpeciesDTO model)
		{
			string sql = @"insert into Species(Species,ReferencesUrl) 
							values(@Species,@ReferencesUrl)";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, model.Species)
							.AddNVarchar("ReferencesUrl",100,model.ReferencesUrl)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool SpeciesExists(string Species)
		{
			string sql = @"select count(*) as count from Species where Species = @Species";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, Species)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Update(SpeciesDTO model)
		{
			string sql = @"Update Species set Species = @Species, ReferencesUrl = @ReferencesUrl where Id = @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, model.Species)
							.AddNVarchar("ReferencesUrl",100,model.ReferencesUrl)
							.AddInt("Id", model.Id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public bool SameSpeciesExists(SpeciesDTO model)
		{
			string sql = @"select count(*) as count from Species where Species = @Species and Id != @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, model.Species)
							.AddInt("Id", model.Id)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Species WHERE Id=@Id";
			var parameters = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
