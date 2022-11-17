using ISpan.Utility;
using SalmonStatistics.Infra.DAOs;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmonStatistics
{
	public partial class EditSampleAreaForm : Form
	{
		private int id;

		public EditSampleAreaForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}

		private void EditSampleAreaForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			
			SampleAreaDTO dto = new SampleAreaDAO().GetOne(id);

			SampleAreaVM model = dto.ToVM();

			WatershedIdComboBox.SelectedItem = ((List<WatershedVM>)WatershedIdComboBox.DataSource)
													.FirstOrDefault(x => x.Id == model.WatershedId);
			areaNameTextBox.Text = model.AreaName;
		}

		private void InitForm()
		{
			WatershedIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			//var sql = "select * from Watershed order by Id";
			//var dpHelper = new SqlDbHelper("default");

			//List<WatershedVM> Watershed = dpHelper.Select(sql, null)
			//					.AsEnumerable()
			//					.Select(row => ToWatershedVM(row))
			//					.ToList();
			var Watershed = new WatershedDAO().GetAll().ToList();

			this.WatershedIdComboBox.DataSource = Watershed;
		}
		//private WatershedVM ToWatershedVM(DataRow row)
		//{
		//	return new WatershedVM
		//	{
		//		Id = row.Field<int>("Id"),
		//		RiverName = row.Field<string>("RiverName"),
		//	};
		//}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("確定刪除?", "刪除紀錄",MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			new SampleAreaService().Delete(id);
			//string sql = @"DELETE FROM SampleArea WHERE Id=@Id";
			//var parameters = new SqlParameterBulider()
			//				.AddInt("Id", this.id)
			//				.Build();

			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			this.DialogResult = DialogResult.OK;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			int watershedId = ((WatershedVM)WatershedIdComboBox.SelectedItem).Id;
			string areaName = areaNameTextBox.Text;

			SampleAreaVM model = new SampleAreaVM()
			{
				Id=id,
				AreaName = areaName,
				WatershedId = watershedId,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"AreaName",areaNameTextBox }
			};

			bool isValid = ValidationHelper.Vaildate(model, map, errorProvider1);
			if (!isValid) return;
			SampleAreaDTO dTO = model.ToDTO();

			try
			{
				new SampleAreaService().Update(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因: " + ex.Message);
			}
		}
	}
}
