﻿using SalmonStatistics.Infra.DAOs;
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
	public partial class EditSpeciesForm : Form
	{
		private int id;

		public EditSpeciesForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void EditSpeciesForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			SpeciesDTO dTO = new SpeciesDAO().GetOne(id);

			SpeciesVM model = dTO.ToVM();

			speciesTextBox.Text = model.Species;
			referencesTextBox.Text = model.ReferencesUrl;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string species = speciesTextBox.Text;
			string referencesUrl = referencesTextBox.Text;

			SpeciesVM model = new SpeciesVM()
			{
				Id = id,
				Species = species,
				ReferencesUrl = referencesUrl
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Species",speciesTextBox },
				{"ReferencesUrl",referencesTextBox },
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			SpeciesDTO dTO = model.ToDTO();
			try
			{
				new SpeciesService().Update(dTO);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因: " + ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("確定刪除?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			new SpeciesService().Delete(id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
