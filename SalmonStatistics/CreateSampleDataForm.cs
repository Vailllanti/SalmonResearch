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
			string adultNum = String.IsNullOrEmpty(sumAdultTextBox.Text) ? AdultNumTextBox.Text : sumAdultTextBox.Text;
			string subadultNum = String.IsNullOrEmpty(sumSubadultTextBox.Text) ? SubadultNumTextBox.Text : sumSubadultTextBox.Text;
			string JuvenileNum = String.IsNullOrEmpty(sumJuvenileTextBox.Text) ? JuvenileNumTextBox.Text : sumJuvenileTextBox.Text;

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
				//this.DialogResult = DialogResult.OK;
				//SampleDataForm parentForm = (SampleDataForm)this.Owner;
				//parentForm.Reset();
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因: " + ex.Message);
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void accumulateButton_Click(object sender, EventArgs e)
		{
			preAdultTextBox.Text = AdultNumTextBox.Text;
			preSubadultTextBox.Text = SubadultNumTextBox.Text;
			preJuvenileTextBox.Text = JuvenileNumTextBox.Text;

			sumAdultTextBox.Text = (sumAdultTextBox.Text.ToInt(0) + AdultNumTextBox.Text.ToInt(0)).ToString();
			sumSubadultTextBox.Text = (sumSubadultTextBox.Text.ToInt(0) + SubadultNumTextBox.Text.ToInt(0)).ToString();
			sumJuvenileTextBox.Text = (sumJuvenileTextBox.Text.ToInt(0) + JuvenileNumTextBox.Text.ToInt(0)).ToString();

			AdultNumTextBox.Clear();
			SubadultNumTextBox.Clear();
			JuvenileNumTextBox.Clear();
		}

		#region 拖曳元件
		private int curr_x = 0, curr_y = 0;
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

		private void samplingDateTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			samplingDateTextBox.Clear();
		}


		private void upPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isWndMove = false;
		}
		#endregion
	}
}
