namespace SalmonStatistics
{
	partial class CreateSampleDataForm
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
			this.areaNameComboBox = new System.Windows.Forms.ComboBox();
			this.sampleAreaIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AdultNumTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.SubadultNumTextBox = new System.Windows.Forms.TextBox();
			this.JuvenileNumTextBox = new System.Windows.Forms.TextBox();
			this.speciesComboBox = new System.Windows.Forms.ComboBox();
			this.speciesIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.samplingDateTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.watershedComboBox = new System.Windows.Forms.ComboBox();
			this.watershedIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// areaNameComboBox
			// 
			this.areaNameComboBox.DataSource = this.sampleAreaIndexVMBindingSource;
			this.areaNameComboBox.DisplayMember = "AreaName";
			this.areaNameComboBox.FormattingEnabled = true;
			this.areaNameComboBox.Location = new System.Drawing.Point(114, 83);
			this.areaNameComboBox.Margin = new System.Windows.Forms.Padding(7);
			this.areaNameComboBox.Name = "areaNameComboBox";
			this.areaNameComboBox.Size = new System.Drawing.Size(305, 33);
			this.areaNameComboBox.TabIndex = 1;
			this.areaNameComboBox.ValueMember = "Id";
			// 
			// sampleAreaIndexVMBindingSource
			// 
			this.sampleAreaIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleAreaIndexVM);
			// 
			// AdultNumTextBox
			// 
			this.AdultNumTextBox.Location = new System.Drawing.Point(388, 193);
			this.AdultNumTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.AdultNumTextBox.Name = "AdultNumTextBox";
			this.AdultNumTextBox.Size = new System.Drawing.Size(66, 34);
			this.AdultNumTextBox.TabIndex = 4;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(542, 241);
			this.saveButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(76, 32);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// SubadultNumTextBox
			// 
			this.SubadultNumTextBox.Location = new System.Drawing.Point(470, 193);
			this.SubadultNumTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.SubadultNumTextBox.Name = "SubadultNumTextBox";
			this.SubadultNumTextBox.Size = new System.Drawing.Size(66, 34);
			this.SubadultNumTextBox.TabIndex = 5;
			// 
			// JuvenileNumTextBox
			// 
			this.JuvenileNumTextBox.Location = new System.Drawing.Point(552, 194);
			this.JuvenileNumTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.JuvenileNumTextBox.Name = "JuvenileNumTextBox";
			this.JuvenileNumTextBox.Size = new System.Drawing.Size(66, 34);
			this.JuvenileNumTextBox.TabIndex = 6;
			// 
			// speciesComboBox
			// 
			this.speciesComboBox.DataSource = this.speciesIndexVMBindingSource;
			this.speciesComboBox.DisplayMember = "Species";
			this.speciesComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speciesComboBox.FormattingEnabled = true;
			this.speciesComboBox.Location = new System.Drawing.Point(114, 194);
			this.speciesComboBox.Margin = new System.Windows.Forms.Padding(7);
			this.speciesComboBox.Name = "speciesComboBox";
			this.speciesComboBox.Size = new System.Drawing.Size(246, 30);
			this.speciesComboBox.TabIndex = 3;
			this.speciesComboBox.ValueMember = "Id";
			// 
			// speciesIndexVMBindingSource
			// 
			this.speciesIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SpeciesIndexVM);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "樣區:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 194);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "物種:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(396, 164);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "成魚";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(468, 163);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "亞成魚";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(559, 164);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "稚魚";
			// 
			// samplingDateTextBox
			// 
			this.samplingDateTextBox.Location = new System.Drawing.Point(114, 149);
			this.samplingDateTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.samplingDateTextBox.Name = "samplingDateTextBox";
			this.samplingDateTextBox.Size = new System.Drawing.Size(166, 34);
			this.samplingDateTextBox.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 152);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 25);
			this.label6.TabIndex = 6;
			this.label6.Text = "採樣日期:";
			// 
			// watershedComboBox
			// 
			this.watershedComboBox.DataSource = this.watershedIndexVMBindingSource;
			this.watershedComboBox.DisplayMember = "RiverName";
			this.watershedComboBox.FormattingEnabled = true;
			this.watershedComboBox.Location = new System.Drawing.Point(114, 40);
			this.watershedComboBox.Margin = new System.Windows.Forms.Padding(7);
			this.watershedComboBox.Name = "watershedComboBox";
			this.watershedComboBox.Size = new System.Drawing.Size(166, 33);
			this.watershedComboBox.TabIndex = 0;
			this.watershedComboBox.ValueMember = "Id";
			this.watershedComboBox.SelectionChangeCommitted += new System.EventHandler(this.watershedComboBox_SelectionChangeCommitted);
			// 
			// watershedIndexVMBindingSource
			// 
			this.watershedIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.WatershedIndexVM);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 43);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "採樣流域:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateSampleDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 311);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.speciesComboBox);
			this.Controls.Add(this.watershedComboBox);
			this.Controls.Add(this.areaNameComboBox);
			this.Controls.Add(this.samplingDateTextBox);
			this.Controls.Add(this.JuvenileNumTextBox);
			this.Controls.Add(this.SubadultNumTextBox);
			this.Controls.Add(this.AdultNumTextBox);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateSampleDataForm";
			this.Text = "新增採樣資料";
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox areaNameComboBox;
		private System.Windows.Forms.TextBox AdultNumTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox SubadultNumTextBox;
		private System.Windows.Forms.TextBox JuvenileNumTextBox;
		private System.Windows.Forms.ComboBox speciesComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox samplingDateTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox watershedComboBox;
		private System.Windows.Forms.BindingSource sampleAreaIndexVMBindingSource;
		private System.Windows.Forms.BindingSource watershedIndexVMBindingSource;
		private System.Windows.Forms.BindingSource speciesIndexVMBindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}