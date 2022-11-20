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
	public class UserDAO
	{
		public IEnumerable<UserDTO> GetAll()
		{
			string sql = @"Select * From Users Order by Id";

			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new UserDTO
				{
					Id = row.Field<int>("Id"),
					Account = row.Field<string>("Account"),
					Name = row.Field<string>("Name")
				});
		}

		public bool AccountExists(string account)
		{
			string sql = @"Select Count(*) as count From Users Where Account=@Account";

			var parameters = new SqlParameterBulider()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(UserDTO model)
		{
			string sql = @"Select Count(*) as count From Users where Account=@Account and Id!=@Id";

			var parameters = new SqlParameterBulider()
				.AddNVarchar("Account", 50, model.Account)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Create(UserDTO model)
		{
			string sql = "Insert into Users (Account,Password, Name) values(@Account,@Password, @Name)";

			var parameters = new SqlParameterBulider()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(UserDTO model)
		{
			string sql = "Update Users set Account=@Account, Password=@Password, Name=@Name where Id=@Id";

			var parameters = new SqlParameterBulider()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = "DELETE From Users where Id=@Id";

			var parameters = new SqlParameterBulider()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public UserDTO Get(string account)
		{
			string sql = "Select * From Users where Account=@Account";
			var parameters = new SqlParameterBulider()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			return ToUserDTO(data.Rows[0]);
		}

		public UserDTO GetOne(int id)
		{
			string sql = "Select * From Users where Id=@Id";
			var parameters = new SqlParameterBulider()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
			}

			return ToUserDTO(data.Rows[0]);
		}

		private UserDTO ToUserDTO(DataRow row)
		{
			return new UserDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
	}
}
