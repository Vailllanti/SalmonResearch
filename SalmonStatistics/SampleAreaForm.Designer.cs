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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.areaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sampleAreaIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddButton = new System.Windows.Forms.Button();
			this.watershedComboBox = new System.Windows.Forms.ComboBox();
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox2 = new System.Windows.Forms.ComboBox();
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
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.areaNameDataGridViewTextBoxColumn,
            this.RiverName});
			this.dataGridView1.DataSource = this.sampleAreaIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(18, 60);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(542, 350);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 60;
			// 
			// areaNameDataGridViewTextBoxColumn
			// 
			this.areaNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.areaNameDataGridViewTextBoxColumn.DataPropertyName = "AreaName";
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
			this.areaNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.areaNameDataGridViewTextBoxColumn.HeaderText = "樣區名稱";
			this.areaNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.areaNameDataGridViewTextBoxColumn.Name = "areaNameDataGridViewTextBoxColumn";
			this.areaNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.areaNameDataGridViewTextBoxColumn.Width = 121;
			// 
			// RiverName
			// 
			this.RiverName.DataPropertyName = "RiverName";
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.RiverName.DefaultCellStyle = dataGridViewCellStyle3;
			this.RiverName.HeaderText = "所屬流域";
			this.RiverName.MinimumWidth = 6;
			this.RiverName.Name = "RiverName";
			this.RiverName.ReadOnly = true;
			// 
			// sampleAreaIndexVMBindingSource
			// 
			this.sampleAreaIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleAreaIndexVM);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.BackColor = System.Drawing.Color.White;
			this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddButton.ForeColor = System.Drawing.Color.Black;
			this.AddButton.Location = new System.Drawing.Point(486, 10);
			this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(74, 38);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "新增";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// watershedComboBox
			// 
			this.watershedComboBox.DataSource = this.watershedIndexVMBindingSource;
			this.watershedComboBox.DisplayMember = "RiverName";
			this.watershedComboBox.FormattingEnabled = true;
			this.watershedComboBox.Location = new System.Drawing.Point(18, 14);
			this.watershedComboBox.Margin = new System.Windows.Forms.Padding(5);
			this.watershedComboBox.Name = "watershedComboBox";
			this.watershedComboBox.Size = new System.Drawing.Size(233, 33);
			this.watershedComboBox.TabIndex = 4;
			this.watershedComboBox.ValueMember = "Id";
			this.watershedComboBox.SelectionChangeCommitted += new System.EventHandler(this.watershedComboBox_SelectionChangeCommitted);
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(-907, 19);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(231, 33);
			this.comboBox2.TabIndex = 4;
			// 
			// SampleAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(578, 430);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.watershedComboBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.AddButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
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
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn areaNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RiverName;
	}
}