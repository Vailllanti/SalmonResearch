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
	public partial class LoginForm : Form
	{
		public LoginForm()
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
			frm.Account = model.Account;
			
			frm.Owner = this;

			frm.Show();
			frm.SetValue();
			this.Hide();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private int curr_x = 0, curr_y = 0;
		private bool isWndMove;

		private void upPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.curr_x = e.X;
				this.curr_y = e.Y;
				this.isWndMove = true;
			}
		}

		private void upPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isWndMove)
				this.Location = new Point(this.Left + e.X - this.curr_x, this.Top + e.Y - this.curr_y);
		}

		private void upPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isWndMove = false;
		}
	}
}
