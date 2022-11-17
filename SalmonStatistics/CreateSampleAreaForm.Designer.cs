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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(216, 134);
			this.saveButton.Margin = new System.Windows.Forms.Padding(5);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(81, 26);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// areaNameTextBox
			// 
			this.areaNameTextBox.Location = new System.Drawing.Point(44, 81);
			this.areaNameTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.areaNameTextBox.Name = "areaNameTextBox";
			this.areaNameTextBox.Size = new System.Drawing.Size(252, 23);
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
			this.WatershedIdComboBox.Location = new System.Drawing.Point(44, 32);
			this.WatershedIdComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.WatershedIdComboBox.Name = "WatershedIdComboBox";
			this.WatershedIdComboBox.Size = new System.Drawing.Size(252, 24);
			this.WatershedIdComboBox.TabIndex = 2;
			this.WatershedIdComboBox.ValueMember = "Id";
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// CreateSampleAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 205);
			this.Controls.Add(this.WatershedIdComboBox);
			this.Controls.Add(this.areaNameTextBox);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
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
	}
}