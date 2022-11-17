using ISpan.Utility;
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
		public IEnumerable<SpeciesIndexVM> GetAll()
		{
			string sql = "select Id,Species,Url from Species order by Id";
			var dbhelper = new SqlDbHelper("default");
			return dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}
		private SpeciesIndexVM ParseToIndexVM(DataRow row)
		{
			return new SpeciesIndexVM
			{
				Id = row.Field<int>("Id"),
				Species = row.Field<string>("Species"),
				Url = row.Field<string>("URL"),
			};
		}

		public SpeciesVM GetOne(int id)
		{
			string sql = "SELECT * FROM Species WHERE Id = @Id";
			var parameter = new SqlParameterBulider()
							.AddInt("Id", id)
							.Build();

			DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			if (dt.Rows.Count == 0) throw new Exception("抱歉，找不到您要的資料");
			SpeciesVM model = ToSpeciesVM(dt.Rows[0]);

			return model;
		}
		private SpeciesVM ToSpeciesVM(DataRow row)
		{
			return new SpeciesVM
			{
				Id = row.Field<int>("Id"),
				Species = row.Field<string>("Species"),
				Url=row.Field<string>("URL"),
			};
		}

		public void Create(SpeciesVM model)
		{
			bool isExists = SpeciesExists(model.Species);
			if (isExists) throw new Exception("此物種已在資料庫內");

			string sql = @"insert into Species(Species,Url) 
							values(@Species,@Url)";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, model.Species)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool SpeciesExists(string species)
		{
			string sql = @"select count(*) as count from Species where Species = @Species";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, species)
							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}

		public void Update(SpeciesVM model)
		{
			bool isExists = SameSpeciesExists(model.Species, model.Id);
			if (isExists) throw new Exception("此物種已在資料庫內");

			string sql = @"Update Species set Species = @Species, Url= @ url where Id = @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, model.Species)
							.AddInt("Id", model.Id)
							.AddNVarchar("Url",100,model.Url)
							.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool SameSpeciesExists(string species, int id )
		{
			string sql = @"select count(*) as count from Species where Species = @Species and Id != @Id";

			var parameters = new SqlParameterBulider()
							.AddNVarchar("Species", 50, species)
							.AddInt("Id", id)

							.Build(); ;
			DataTable dataTable = new SqlDbHelper("default").Select(sql, parameters);
			return dataTable.Rows[0].Field<int>("count") > 0;
		}
	}
}
