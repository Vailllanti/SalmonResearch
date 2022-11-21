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
	public partial class MainForm : Form
	{
		public string Account { set { account = value; } }
		private string account;

		public void SetValue()
		{
			this.welcomeLabel.Text = $"Welcome,{account}";
		}

		public MainForm()
		{ 
			InitializeComponent();
		}

		private void loadForm(object Form)
		{
			if (this.MainPanel.Controls.Count > 0) this.MainPanel.Controls.RemoveAt(0);
			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.MainPanel.Controls.Add(f);
			this.MainPanel.Tag = f;
			f.Show();
		}


		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Owner.Show();
			this.Close();
		}

		private void watershedButton_Click(object sender, EventArgs e)
		{
			loadForm(new WatershedForm());
		}

		private void sampleAreaButton_Click(object sender, EventArgs e)
		{
			loadForm(new SampleAreaForm());
		}

		private void SpeciesButton_Click(object sender, EventArgs e)
		{
			loadForm(new SpeciesForm());
		}

		private void sampleDataButton_Click(object sender, EventArgs e)
		{
			loadForm(new SampleDataForm());
		}

		private void UsersButton_Click(object sender, EventArgs e)
		{
			loadForm(new UsersForm());
		}

		private void LogoutButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void minButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void maxButton_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
			else this.WindowState = FormWindowState.Maximized;                  
		}
		#region 拖曳元件
		private int curr_x=0,curr_y=0;
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
		#endregion
	}
}
