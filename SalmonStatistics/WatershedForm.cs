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
	public partial class WatershedForm : Form
	{
		private WatershedIndexVM[] watershed = null;
		public WatershedForm()
		{
			InitializeComponent();
			DisplayWatershed();
		}

		private void DisplayWatershed()
		{
			watershed = new WatershedService().GetAll().ToArray();
			BindData(watershed);
		}
		private void BindData(WatershedIndexVM[] model)
		{
			dataGridView1.DataSource = model;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateWatershedForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayWatershed();
			}
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			WatershedIndexVM row = this.watershed[rowIndex];
			int id = row.Id;

			var frm = new EditWatershedForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayWatershed();
			}

		}
	}
}
