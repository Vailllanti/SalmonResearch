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
	public partial class EditSampleDataForm : Form
	{
		private int id;

		public EditSampleDataForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}
		private void EditSampleDataForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{

			SampleDataDTO dto = new SampleDataDAO().GetOne(id);

			SampleDataVM model = dto.ToVM();

			areaNameComboBox.SelectedItem = ((List<SampleAreaVM>)areaNameComboBox.DataSource)
													.FirstOrDefault(x => x.Id == model.SampleAreaId);
			speciesComboBox.SelectedItem = ((List<SpeciesVM>)speciesComboBox.DataSource)
													.FirstOrDefault(x => x.Id == model.SpeciesId);
			samplingDateTextBox.Text = model.SamplingDate;
			AdultNumTextBox.Text = model.AdultNumber.ToString();
			SubadultNumTextBox.Text = model.SubadultNumber.ToString();
			JuvenileNumTextBox.Text = model.JuvenileNumber.ToString();
		}

		private void InitForm()
		{
			areaNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			speciesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var areaName = new SampleAreaDAO().GetAll(id).Select(dto => dto.ToVM()).ToList();
			var species = new SpeciesDAO().GetAll().Select(dto => dto.ToVM()).ToList();

			this.areaNameComboBox.DataSource = areaName;
			this.speciesComboBox.DataSource = species;
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("確定刪除?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			new SampleDataService().Delete(id);

			this.DialogResult = DialogResult.OK;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			int sampleAreaId = ((SampleAreaVM)areaNameComboBox.SelectedItem).Id;
			int speciesId = ((SpeciesVM)speciesComboBox.SelectedItem).Id;
			string samplingDate = samplingDateTextBox.Text;
			string adultNum = AdultNumTextBox.Text;
			string subadultNum = SubadultNumTextBox.Text;
			string JuvenileNum = JuvenileNumTextBox.Text;

			SampleDataVM model = new SampleDataVM()
			{
				Id = id,
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
				{"SamplngDate",samplingDateTextBox },
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			SampleDataDTO dTO = model.ToDTO();
			try
			{
				new SampleDataService().Update(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因: " + ex.Message);
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

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

		private void upPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isWndMove = false;
		}
	}
}
