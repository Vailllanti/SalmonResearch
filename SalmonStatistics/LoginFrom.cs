using SalmonStatistics.Infra.Extenstions;
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
	public partial class LoginFrom : Form
	{
		public LoginFrom()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM
			{
				Account = accountTextBox.Text,
				Password = passwordTextBox.Text
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			accountTextBox.Text = String.Empty;
			passwordTextBox.Text = String.Empty;

			var frm = new MainForm();
			frm.Owner = this;

			frm.Show();
			this.Hide();
		}
	}
}
