using SalmonStatistics.Infra.DAOs;
using SalmonStatistics.Model.DTOs;
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
	public partial class UsersForm : Form
	{
		private UsersIndexVM[] Users = null;
		public UsersForm()
		{
			InitializeComponent();
			DisplayUsers();
		}

		private void DisplayUsers()
		{
			Users = new UserDAO().GetAll().Select(dto => dto.ToIndexVM()).ToArray();
			BindData(Users);
		}
		private void BindData(UsersIndexVM[] model)
		{
			dataGridView1.DataSource = model;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			UsersIndexVM row = this.Users[rowIndex];
			int id = row.Id;

			var frm = new EditUserForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
	}
}
