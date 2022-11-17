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
	public partial class CreateWatershedForm : Form
	{
		public CreateWatershedForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string riverName = riverTextBox.Text;

			WatershedVM model = new WatershedVM()
			{
				RiverName = riverName,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"RiverName",riverTextBox }
			};

			bool isValid = ValidationHelper.Vaildate(model, map, errorProvider1);
			if (!isValid) return;

			WatershedDTO dTO = model.ToDTO();
			try
			{
				new WatershedService().Create(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show("新增失敗，原因: " + ex.Message);
			}
		}
	}
}
