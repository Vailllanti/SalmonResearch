using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Infra.Extenstions;
using SalmonStatistics.Model.DTOs;
using SalmonStatistics.Model.Services;
using SalmonStatistics.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmonStatistics
{
	public partial class EditUserForm : Form
	{
		private int id;
		public EditUserForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}
		private void EditUserForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			UserDTO dTO = new UserDAO().GetOne(id);

			UserVM model = dTO.ToVM();

			AccountTextBox.Text = model.Account;
			PasswordTextBox.Text = model.Password;
			NameTextBox.Text = model.Name;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string account = AccountTextBox.Text;
			string password = PasswordTextBox.Text;
			string name = NameTextBox.Text;

			UserVM model = new UserVM()
			{
				Id = id,
				Account = account,
				Password = password,
				Name = name,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account",AccountTextBox },
				{"Password",PasswordTextBox},
				{"Name",NameTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			UserDTO dTO = model.ToDTO();
			try
			{
				new UserService().Update(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因: " + ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("確定刪除?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			new UserService().Delete(id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
