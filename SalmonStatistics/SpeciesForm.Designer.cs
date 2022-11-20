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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.AddButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReferencesUrl = new System.Windows.Forms.DataGridViewLinkColumn();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.speciesIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.BackColor = System.Drawing.Color.White;
			this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddButton.ForeColor = System.Drawing.Color.Black;
			this.AddButton.Location = new System.Drawing.Point(797, 13);
			this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(74, 38);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "新增";
			this.AddButton.UseVisualStyleBackColor = false;
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
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.speciesDataGridViewTextBoxColumn,
            this.ReferencesUrl});
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dataGridView1.DataSource = this.speciesIndexVMBindingSource;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
			this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dataGridView1.Location = new System.Drawing.Point(21, 59);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(850, 583);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 40;
			// 
			// ReferencesUrl
			// 
			this.ReferencesUrl.DataPropertyName = "ReferencesUrl";
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.ReferencesUrl.DefaultCellStyle = dataGridViewCellStyle3;
			this.ReferencesUrl.HeaderText = "參考資料";
			this.ReferencesUrl.MinimumWidth = 6;
			this.ReferencesUrl.Name = "ReferencesUrl";
			this.ReferencesUrl.ReadOnly = true;
			this.ReferencesUrl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ReferencesUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.idDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idDataGridViewTextBoxColumn1.Width = 60;
			// 
			// speciesDataGridViewTextBoxColumn
			// 
			this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.speciesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.speciesDataGridViewTextBoxColumn.HeaderText = "種名";
			this.speciesDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
			this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// speciesIndexVMBindingSource
			// 
			this.speciesIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SpeciesIndexVM);
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// SpeciesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(890, 655);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "SpeciesForm";
			this.Text = "物種管理";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.BindingSource speciesIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewLinkColumn urlDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewLinkColumn ReferencesUrl;
	}
}