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
	public partial class CreateSampleAreaForm : Form
	{
		public CreateSampleAreaForm()
		{
			InitializeComponent();
			InitForm();
		}
		private void InitForm()
		{
			WatershedIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<WatershedIndexVM> watershed = new WatershedService()
				.GetAll()/*.Prepend(new WatershedIndexVM { Id = 0, RiverName = String.Empty })*/.ToList();
			this.WatershedIdComboBox.DataSource = watershed;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			int WatershedId = ((WatershedIndexVM)WatershedIdComboBox.SelectedItem).Id;
			string areaName = areaNameTextBox.Text;

			SampleAreaVM model = new SampleAreaVM()
			{
				AreaName = areaName,
				WatershedId = WatershedId
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"AreaName",areaNameTextBox }
			};

			bool isValid = ValidationHelper.Vaildate(model, map, errorProvider1);
			if (!isValid) return;
			try
			{
				new SampleAreaService().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因: " + ex.Message);
			}
		}
	}
}
