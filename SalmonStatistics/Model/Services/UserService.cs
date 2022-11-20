using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonStatistics.Model.Services
{
	public class UserService
	{
		private UserDAO _dao;

		public UserService()
		{
			_dao = new UserDAO();
		}

		public void Create(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Create(model);

		}


		public void Update(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Update(model);
		}

		public void Delete(int id)
		{
			_dao.Delete(id);
		}

		public bool Authenticate(LoginVM model)
		{
			var user = _dao.Get(model.Account);
			if (user == null) return false;

			return (user.Password == model.Password);
		}
	}
}
