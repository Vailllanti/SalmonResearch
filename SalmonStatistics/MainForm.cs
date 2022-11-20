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
			this.Close();
			this.Owner.Show();
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
	}
}
