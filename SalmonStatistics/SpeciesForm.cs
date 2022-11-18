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
	public partial class SpeciesForm : Form
	{
		private SpeciesIndexVM[] species = null;
		public SpeciesForm()
		{
			InitializeComponent();
			DisplaySpecies();
		}
		private void DisplaySpecies()
		{
			species = new SpeciesDAO().GetAll().Select(dto => dto.ToIndexVM()).ToArray();
			BindData(species);
		}
		private void BindData(SpeciesIndexVM[] model)
		{
			dataGridView1.DataSource = model;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateSpeciesForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplaySpecies();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			SpeciesIndexVM row = this.species[rowIndex];
			int id = row.Id;

			var frm = new EditSpeciesForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplaySpecies();
			}
		}
	}
}
