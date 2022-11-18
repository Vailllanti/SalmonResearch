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
			this.SamplngDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.watershedComboBox.Location = new System.Drawing.Point(20, 27);
			this.watershedComboBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.watershedComboBox.Name = "watershedComboBox";
			this.watershedComboBox.Size = new System.Drawing.Size(284, 29);
			this.watershedComboBox.TabIndex = 8;
			this.watershedComboBox.ValueMember = "Id";
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(317, 26);
			this.searchButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(54, 29);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = true;
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
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.SampleArea,
            this.SpeciesName,
            this.AdultNumber,
            this.SubadultNumber,
            this.JuvenileNumber,
            this.SamplngDate});
			this.dataGridView1.DataSource = this.sampleDataIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(20, 78);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1093, 560);
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
			this.addButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.Location = new System.Drawing.Point(1056, 27);
			this.addButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(54, 29);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "新增";
			this.addButton.UseVisualStyleBackColor = true;
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
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 40;
			// 
			// SampleArea
			// 
			this.SampleArea.DataPropertyName = "AreaName";
			this.SampleArea.HeaderText = "樣區";
			this.SampleArea.Name = "SampleArea";
			this.SampleArea.ReadOnly = true;
			this.SampleArea.Width = 200;
			// 
			// SpeciesName
			// 
			this.SpeciesName.DataPropertyName = "Species";
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeciesName.DefaultCellStyle = dataGridViewCellStyle1;
			this.SpeciesName.HeaderText = "物種";
			this.SpeciesName.Name = "SpeciesName";
			this.SpeciesName.ReadOnly = true;
			this.SpeciesName.Width = 300;
			// 
			// AdultNumber
			// 
			this.AdultNumber.DataPropertyName = "AdultNumber";
			this.AdultNumber.HeaderText = "成魚數";
			this.AdultNumber.Name = "AdultNumber";
			this.AdultNumber.ReadOnly = true;
			// 
			// SubadultNumber
			// 
			this.SubadultNumber.DataPropertyName = "SubadultNumber";
			this.SubadultNumber.HeaderText = "亞成魚數";
			this.SubadultNumber.Name = "SubadultNumber";
			this.SubadultNumber.ReadOnly = true;
			// 
			// JuvenileNumber
			// 
			this.JuvenileNumber.DataPropertyName = "JuvenileNumber";
			this.JuvenileNumber.HeaderText = "稚魚數";
			this.JuvenileNumber.Name = "JuvenileNumber";
			this.JuvenileNumber.ReadOnly = true;
			// 
			// SamplngDate
			// 
			this.SamplngDate.DataPropertyName = "SamplngDate";
			this.SamplngDate.HeaderText = "採樣時間";
			this.SamplngDate.Name = "SamplngDate";
			this.SamplngDate.ReadOnly = true;
			this.SamplngDate.Width = 200;
			// 
			// SampleDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1133, 661);
			this.Controls.Add(this.watershedComboBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
		private System.Windows.Forms.DataGridViewTextBoxColumn SamplngDate;
	}
}