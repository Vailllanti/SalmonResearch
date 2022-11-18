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
			WatershedDTO dTO = new WatershedDAO().GetOne(id);

			WatershedVM model = dTO.ToVM();

			riverTextBox.Text = model.RiverName;
		}

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

			WatershedDTO dTO = model.ToDTO();
			try
			{
				new WatershedService().Update(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因: " + ex.Message);
			}
		}
	}
}
