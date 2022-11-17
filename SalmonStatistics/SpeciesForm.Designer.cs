namespace SalmonStatistics
{
	partial class SpeciesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AddButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.speciesIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddButton.Location = new System.Drawing.Point(468, 6);
			this.AddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(64, 27);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "新增";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Species,
            this.Url});
			this.dataGridView1.DataSource = this.speciesIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(11, 37);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(521, 364);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// speciesIndexVMBindingSource
			// 
			this.speciesIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SpeciesIndexVM);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 40;
			// 
			// Species
			// 
			this.Species.DataPropertyName = "Species";
			this.Species.HeaderText = "物種學名";
			this.Species.Name = "Species";
			this.Species.ReadOnly = true;
			// 
			// Url
			// 
			this.Url.DataPropertyName = "Url";
			this.Url.HeaderText = "參考資料";
			this.Url.Name = "Url";
			this.Url.ReadOnly = true;
			this.Url.Width = 500;
			// 
			// SpeciesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 412);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.AddButton);
			this.Name = "SpeciesForm";
			this.Text = "SpeciesForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Species;
		private System.Windows.Forms.DataGridViewTextBoxColumn Url;
		private System.Windows.Forms.BindingSource speciesIndexVMBindingSource;
	}
}