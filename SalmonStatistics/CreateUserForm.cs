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
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string account = AccountTextBox.Text;
			string password = PasswordTextBox.Text;
			string name = NameTextBox.Text;

			UserVM model = new UserVM()
			{
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
				new UserService().Create(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因: " + ex.Message);
			}
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
