namespace SalmonStatistics
{
	partial class SampleAreaForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.sampleAreaIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddButton = new System.Windows.Forms.Button();
			this.watershedComboBox = new System.Windows.Forms.ComboBox();
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchButton = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.areaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
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
            this.areaNameDataGridViewTextBoxColumn,
            this.RiverName});
			this.dataGridView1.DataSource = this.sampleAreaIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(11, 51);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(778, 388);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// sampleAreaIndexVMBindingSource
			// 
			this.sampleAreaIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleAreaIndexVM);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddButton.Location = new System.Drawing.Point(724, 9);
			this.AddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(65, 34);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "新增";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// watershedComboBox
			// 
			this.watershedComboBox.DataSource = this.watershedIndexVMBindingSource;
			this.watershedComboBox.DisplayMember = "RiverName";
			this.watershedComboBox.FormattingEnabled = true;
			this.watershedComboBox.Location = new System.Drawing.Point(12, 19);
			this.watershedComboBox.Name = "watershedComboBox";
			this.watershedComboBox.Size = new System.Drawing.Size(140, 20);
			this.watershedComboBox.TabIndex = 4;
			this.watershedComboBox.ValueMember = "Id";
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// searchButton
			// 
			this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(168, 9);
			this.searchButton.Margin = new System.Windows.Forms.Padding(2);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(65, 34);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(-544, 11);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(140, 20);
			this.comboBox2.TabIndex = 4;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 40;
			// 
			// areaNameDataGridViewTextBoxColumn
			// 
			this.areaNameDataGridViewTextBoxColumn.DataPropertyName = "AreaName";
			this.areaNameDataGridViewTextBoxColumn.HeaderText = "樣區名稱";
			this.areaNameDataGridViewTextBoxColumn.Name = "areaNameDataGridViewTextBoxColumn";
			this.areaNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// RiverName
			// 
			this.RiverName.DataPropertyName = "RiverName";
			this.RiverName.HeaderText = "所屬流域";
			this.RiverName.Name = "RiverName";
			this.RiverName.ReadOnly = true;
			// 
			// SampleAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.watershedComboBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.AddButton);
			this.Name = "SampleAreaForm";
			this.Text = "樣區管理";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ComboBox watershedComboBox;
		private System.Windows.Forms.BindingSource sampleAreaIndexVMBindingSource;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn areaNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RiverName;
	}
}