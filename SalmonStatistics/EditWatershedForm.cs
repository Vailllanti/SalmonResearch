﻿using ISpan.Utility;
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
	public partial class EditWatershedForm : Form
	{
		private int id;
		public EditWatershedForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}
		private void EditWatershedForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			//string sql = "SELECT * FROM Watershed WHERE Id = @Id";
			//var parameter = new SqlParameterBulider()
			//				.AddInt("Id", id)
			//				.Build();

			//DataTable dt = new SqlDbHelper("default").Select(sql, parameter);

			//if (dt.Rows.Count == 0)
			//{
			//	MessageBox.Show("抱歉，找不到您要的資料");
			//	this.DialogResult = DialogResult.Abort;
			//	return;
			//}
			//WatershedVM model = ToWatershedVM(dt.Rows[0]);
			try
			{
				var model = new WatershedService().GetOne(id);
				riverTextBox.Text = model.RiverName;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		//private WatershedVM ToWatershedVM(DataRow row)
		//{
		//	return new WatershedVM
		//	{
		//		Id = row.Field<int>("Id"),
		//		RiverName = row.Field<string>("RiverName"),
		//	};
		//}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string riverName = riverTextBox.Text;

			WatershedVM model = new WatershedVM()
			{
				RiverName = riverName,
				Id=id,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"RiverName",riverTextBox }
			};

			bool isValid = ValidationHelper.Vaildate(model, map, errorProvider1);
			if (!isValid) return;
			try
			{
				new WatershedService().Update(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因: " + ex.Message);
			}
		}
	}
}
