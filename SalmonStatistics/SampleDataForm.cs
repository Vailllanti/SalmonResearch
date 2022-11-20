﻿using SalmonStatistics.Infra.DAOs;
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
	public partial class SampleDataForm : Form
	{
		private SampleDataIndexVM[] sampleData = null;

		public SampleDataForm()
		{
			InitializeComponent();
			InitForm();
			DisplaySampleData();
		}

		private void InitForm()
		{
			watershedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var watershed = new WatershedDAO()
				.GetAll().Prepend(new WatershedDTO { Id = 0, RiverName = String.Empty }).Select(dto => dto.ToIndexVM()).ToList();
			this.watershedComboBox.DataSource = watershed;
		}


		private void DisplaySampleData()
		{
			sampleData = new SampleDataDAO().GetAll(((WatershedIndexVM)watershedComboBox.SelectedItem).Id)
						.Select(dto => dto.ToIndexVM()).ToArray();
			BindData(sampleData);
		}

		private void BindData(SampleDataIndexVM[] model)
		{
			dataGridView1.DataSource = model;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateSampleDataForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplaySampleData();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			SampleDataIndexVM row = this.sampleData[rowIndex];
			int id = row.Id;

			var frm = new EditSampleDataForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplaySampleData();
			}
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplaySampleData();
		}
	}
}