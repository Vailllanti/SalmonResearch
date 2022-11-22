using ISpan.Utility;
using SalmonStatistics.Infra.DAOs;
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
	public partial class SampleAreaForm : Form
	{
		private SampleAreaIndexVM[] sampleArea = null;
		public SampleAreaForm()
		{
			InitializeComponent();
			InitForm();
			DisplaySampleArea();
		}
		private void InitForm()
		{ 
			watershedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var watershed = new WatershedDAO()
				.GetAll().Prepend(new WatershedDTO { Id = 0, RiverName = String.Empty }).Select(dto => dto.ToIndexVM()).ToList();
			
			this.watershedComboBox.DataSource = watershed;
		}
	

		private void DisplaySampleArea()
		{
			sampleArea = new SampleAreaDAO().GetAll(((WatershedIndexVM)watershedComboBox.SelectedItem).Id)
						.Select(dto=>dto.ToIndexVM()).ToArray();
			BindData(sampleArea);
		}
		private void BindData(SampleAreaIndexVM[] model)
		{
			dataGridView1.DataSource = model;
		}


		private void AddButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateSampleAreaForm(this);
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplaySampleArea();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			SampleAreaIndexVM row = this.sampleArea[rowIndex];
			int id = row.Id;

			var frm = new EditSampleAreaForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplaySampleArea();
			}
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplaySampleArea();
		}

		private void watershedComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			DisplaySampleArea();
		}

		public void Reflash(int id)
		{
			sampleArea = new SampleAreaDAO().GetAll(id).Select(dto => dto.ToIndexVM()).ToArray();
			BindData(sampleArea);
			watershedComboBox.SelectedIndex = id;
		}
	}
}
