namespace SalmonStatistics
{
	partial class SampleDataForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.watershedComboBox = new System.Windows.Forms.ComboBox();
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.sampleDataIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addButton = new System.Windows.Forms.Button();
			this.speciesIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sampleAreaIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sampleDataIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SampleArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpeciesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AdultNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubadultNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JuvenileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SamplingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDataIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDataIndexVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// watershedComboBox
			// 
			this.watershedComboBox.DataSource = this.watershedIndexVMBindingSource;
			this.watershedComboBox.DisplayMember = "RiverName";
			this.watershedComboBox.FormattingEnabled = true;
			this.watershedComboBox.Location = new System.Drawing.Point(20, 18);
			this.watershedComboBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.watershedComboBox.Name = "watershedComboBox";
			this.watershedComboBox.Size = new System.Drawing.Size(233, 29);
			this.watershedComboBox.TabIndex = 8;
			this.watershedComboBox.ValueMember = "Id";
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// searchButton
			// 
			this.searchButton.BackColor = System.Drawing.Color.White;
			this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.ForeColor = System.Drawing.Color.Black;
			this.searchButton.Location = new System.Drawing.Point(262, 14);
			this.searchButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(74, 38);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
			this.dataGridView1.ColumnHeadersHeight = 29;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.SampleArea,
            this.SpeciesName,
            this.AdultNumber,
            this.SubadultNumber,
            this.JuvenileNumber,
            this.SamplingDate});
			this.dataGridView1.DataSource = this.sampleDataIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(20, 65);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1093, 573);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// sampleDataIndexVMBindingSource
			// 
			this.sampleDataIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleDataIndexVM);
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.BackColor = System.Drawing.Color.White;
			this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.ForeColor = System.Drawing.Color.Black;
			this.addButton.Location = new System.Drawing.Point(1039, 13);
			this.addButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(74, 38);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "新增";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// speciesIndexVMBindingSource
			// 
			this.speciesIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SpeciesIndexVM);
			// 
			// sampleAreaIndexVMBindingSource
			// 
			this.sampleAreaIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleAreaIndexVM);
			// 
			// sampleDataIndexVMBindingSource1
			// 
			this.sampleDataIndexVMBindingSource1.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleDataIndexVM);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.idDataGridViewTextBoxColumn.FillWeight = 74.86631F;
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// SampleArea
			// 
			this.SampleArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SampleArea.DataPropertyName = "AreaName";
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.SampleArea.DefaultCellStyle = dataGridViewCellStyle2;
			this.SampleArea.FillWeight = 104.1889F;
			this.SampleArea.HeaderText = "樣區";
			this.SampleArea.MinimumWidth = 6;
			this.SampleArea.Name = "SampleArea";
			this.SampleArea.ReadOnly = true;
			this.SampleArea.Width = 67;
			// 
			// SpeciesName
			// 
			this.SpeciesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SpeciesName.DataPropertyName = "Species";
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.SpeciesName.DefaultCellStyle = dataGridViewCellStyle3;
			this.SpeciesName.FillWeight = 104.1889F;
			this.SpeciesName.HeaderText = "物種";
			this.SpeciesName.MinimumWidth = 6;
			this.SpeciesName.Name = "SpeciesName";
			this.SpeciesName.ReadOnly = true;
			this.SpeciesName.Width = 67;
			// 
			// AdultNumber
			// 
			this.AdultNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.AdultNumber.DataPropertyName = "AdultNumber";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.AdultNumber.DefaultCellStyle = dataGridViewCellStyle4;
			this.AdultNumber.FillWeight = 104.1889F;
			this.AdultNumber.HeaderText = "成魚數";
			this.AdultNumber.MinimumWidth = 6;
			this.AdultNumber.Name = "AdultNumber";
			this.AdultNumber.ReadOnly = true;
			this.AdultNumber.Width = 83;
			// 
			// SubadultNumber
			// 
			this.SubadultNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SubadultNumber.DataPropertyName = "SubadultNumber";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
			this.SubadultNumber.DefaultCellStyle = dataGridViewCellStyle5;
			this.SubadultNumber.FillWeight = 104.1889F;
			this.SubadultNumber.HeaderText = "亞成魚數";
			this.SubadultNumber.MinimumWidth = 6;
			this.SubadultNumber.Name = "SubadultNumber";
			this.SubadultNumber.ReadOnly = true;
			this.SubadultNumber.Width = 99;
			// 
			// JuvenileNumber
			// 
			this.JuvenileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.JuvenileNumber.DataPropertyName = "JuvenileNumber";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			this.JuvenileNumber.DefaultCellStyle = dataGridViewCellStyle6;
			this.JuvenileNumber.FillWeight = 104.1889F;
			this.JuvenileNumber.HeaderText = "稚魚數";
			this.JuvenileNumber.MinimumWidth = 6;
			this.JuvenileNumber.Name = "JuvenileNumber";
			this.JuvenileNumber.ReadOnly = true;
			this.JuvenileNumber.Width = 83;
			// 
			// SamplingDate
			// 
			this.SamplingDate.DataPropertyName = "SamplingDate";
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			this.SamplingDate.DefaultCellStyle = dataGridViewCellStyle7;
			this.SamplingDate.FillWeight = 104.1889F;
			this.SamplingDate.HeaderText = "採樣時間";
			this.SamplingDate.MinimumWidth = 6;
			this.SamplingDate.Name = "SamplingDate";
			this.SamplingDate.ReadOnly = true;
			// 
			// SampleDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(1133, 661);
			this.Controls.Add(this.watershedComboBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "SampleDataForm";
			this.Text = "採樣資料管理";
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDataIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDataIndexVMBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox watershedComboBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.BindingSource sampleDataIndexVMBindingSource;
		private System.Windows.Forms.BindingSource speciesIndexVMBindingSource;
		private System.Windows.Forms.BindingSource sampleAreaIndexVMBindingSource;
		private System.Windows.Forms.BindingSource sampleDataIndexVMBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SampleArea;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeciesName;
		private System.Windows.Forms.DataGridViewTextBoxColumn AdultNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubadultNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn JuvenileNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn SamplingDate;
	}
}