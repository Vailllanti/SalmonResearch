namespace SalmonStatistics
{
	partial class CreateSampleAreaForm
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
			this.saveButton = new System.Windows.Forms.Button();
			this.areaNameTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.WatershedIdComboBox = new System.Windows.Forms.ComboBox();
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(340, 132);
			this.saveButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(83, 34);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// areaNameTextBox
			// 
			this.areaNameTextBox.Location = new System.Drawing.Point(87, 83);
			this.areaNameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.areaNameTextBox.Name = "areaNameTextBox";
			this.areaNameTextBox.Size = new System.Drawing.Size(335, 34);
			this.areaNameTextBox.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// WatershedIdComboBox
			// 
			this.WatershedIdComboBox.DataSource = this.watershedIndexVMBindingSource;
			this.WatershedIdComboBox.DisplayMember = "RiverName";
			this.WatershedIdComboBox.FormattingEnabled = true;
			this.WatershedIdComboBox.Location = new System.Drawing.Point(87, 36);
			this.WatershedIdComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.WatershedIdComboBox.Name = "WatershedIdComboBox";
			this.WatershedIdComboBox.Size = new System.Drawing.Size(335, 33);
			this.WatershedIdComboBox.TabIndex = 2;
			this.WatershedIdComboBox.ValueMember = "Id";
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 87);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "樣區:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "流域:";
			// 
			// CreateSampleAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 189);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WatershedIdComboBox);
			this.Controls.Add(this.areaNameTextBox);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateSampleAreaForm";
			this.Text = "新增樣區";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox areaNameTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ComboBox WatershedIdComboBox;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}