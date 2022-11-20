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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmonStatistics
{
	public partial class CreateSampleDataForm : Form
	{
		private List<SampleAreaVM> areaName;

		//private SampleAreaDAO Refresh()
		//{

		//	return new SampleAreaDAO()
		//	   .GetAll(((WatershedVM)watershedComboBox.SelectedItem).Id).
		//	   Select(dto => dto.ToVM()).ToList(); ;
		//}

		public CreateSampleDataForm()
		{
			InitializeComponent();
			InitForm();
		}
		private void InitForm()
		{
			watershedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			areaNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			speciesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var watershed = new WatershedDAO()
				.GetAll().Select(dto => dto.ToVM()).ToList();
			this.watershedComboBox.DataSource = watershed;

			areaName = new SampleAreaDAO()
			   .GetAll(((WatershedVM)watershedComboBox.SelectedItem).Id).
			   Select(dto => dto.ToVM()).ToList();
			this.areaNameComboBox.DataSource = areaName;

			var species = new SpeciesDAO().GetAll().Select(dto => dto.ToVM()).ToList();
			this.speciesComboBox.DataSource = species;

		}
		private void watershedComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			areaName = new SampleAreaDAO()
				.GetAll(((WatershedVM)watershedComboBox.SelectedItem).Id).
				Select(dto => dto.ToVM()).ToList();
			this.areaNameComboBox.DataSource = areaName;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			int sampleAreaId =((SampleAreaVM)areaNameComboBox.SelectedItem).Id;
			string samplingDate = samplingDateTextBox.Text;
			int speciesId = ((SpeciesVM)speciesComboBox.SelectedItem).Id;
			string adultNum = AdultNumTextBox.Text;
			string subadultNum = SubadultNumTextBox.Text;
			string JuvenileNum = JuvenileNumTextBox.Text;

			SampleDataVM model = new SampleDataVM()
			{
				SampleAreaId = sampleAreaId,
				SpeciesId = speciesId,
				SamplingDate = samplingDate,
				AdultNumber = adultNum.ToInt(-1),
				SubadultNumber = subadultNum.ToInt(-1),
				JuvenileNumber = JuvenileNum.ToInt(-1),
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"AdultNumber",AdultNumTextBox },
				{"SubadultNumber",SubadultNumTextBox },
				{"JuvenileNumber",JuvenileNumTextBox },
				{"SamplingDate",samplingDateTextBox },
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			SampleDataDTO dTO = model.ToDTO();

			try
			{
				new SampleDataService().Create(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因: " + ex.Message);
			}
		}
	}
}
