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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Button();
			this.accumulateLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.preJuvenileTextBox = new System.Windows.Forms.TextBox();
			this.preAdultTextBox = new System.Windows.Forms.TextBox();
			this.sumJuvenileTextBox = new System.Windows.Forms.TextBox();
			this.preSubadultTextBox = new System.Windows.Forms.TextBox();
			this.sumAdultTextBox = new System.Windows.Forms.TextBox();
			this.sumSubadultTextBox = new System.Windows.Forms.TextBox();
			this.accumulateButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// areaNameComboBox
			// 
			this.areaNameComboBox.DataSource = this.sampleAreaIndexVMBindingSource;
			this.areaNameComboBox.DisplayMember = "AreaName";
			this.areaNameComboBox.FormattingEnabled = true;
			this.areaNameComboBox.Location = new System.Drawing.Point(109, 102);
			this.areaNameComboBox.Margin = new System.Windows.Forms.Padding(7);
			this.areaNameComboBox.Name = "areaNameComboBox";
			this.areaNameComboBox.Size = new System.Drawing.Size(246, 29);
			this.areaNameComboBox.TabIndex = 1;
			this.areaNameComboBox.ValueMember = "Id";
			// 
			// sampleAreaIndexVMBindingSource
			// 
			this.sampleAreaIndexVMBindingSource.DataSource = typeof(SalmonStatistics.Model.ViewModel.SampleAreaIndexVM);
			// 
			// AdultNumTextBox
			// 
			this.AdultNumTextBox.Location = new System.Drawing.Point(384, 245);
			this.AdultNumTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.AdultNumTextBox.MaxLength = 4;
			this.AdultNumTextBox.Name = "AdultNumTextBox";
			this.AdultNumTextBox.Size = new System.Drawing.Size(70, 29);
			this.AdultNumTextBox.TabIndex = 4;
			this.AdultNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// saveButton
			// 
			this.saveButton.ForeColor = System.Drawing.Color.Black;
			this.saveButton.Location = new System.Drawing.Point(553, 291);
			this.saveButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(74, 38);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// SubadultNumTextBox
			// 
			this.SubadultNumTextBox.Location = new System.Drawing.Point(470, 244);
			this.SubadultNumTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.SubadultNumTextBox.MaxLength = 4;
			this.SubadultNumTextBox.Name = "SubadultNumTextBox";
			this.SubadultNumTextBox.Size = new System.Drawing.Size(70, 29);
			this.SubadultNumTextBox.TabIndex = 5;
			this.SubadultNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// JuvenileNumTextBox
			// 
			this.JuvenileNumTextBox.Location = new System.Drawing.Point(556, 245);
			this.JuvenileNumTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.JuvenileNumTextBox.MaxLength = 4;
			this.JuvenileNumTextBox.Name = "JuvenileNumTextBox";
			this.JuvenileNumTextBox.Size = new System.Drawing.Size(70, 29);
			this.JuvenileNumTextBox.TabIndex = 6;
			this.JuvenileNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// speciesComboBox
			// 
			this.speciesComboBox.DataSource = this.speciesIndexVMBindingSource;
			this.speciesComboBox.DisplayMember = "Species";
			this.speciesComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speciesComboBox.FormattingEnabled = true;
			this.speciesComboBox.Location = new System.Drawing.Point(109, 246);
			this.speciesComboBox.Margin = new System.Windows.Forms.Padding(7);
			this.speciesComboBox.Name = "speciesComboBox";
			this.speciesComboBox.Size = new System.Drawing.Size(246, 27);
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
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 105);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "樣區:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(23, 249);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "物種:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(398, 222);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "成魚";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(471, 221);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "亞成魚";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(557, 223);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 21);
			this.label5.TabIndex = 6;
			this.label5.Text = "稚魚";
			// 
			// samplingDateTextBox
			// 
			this.samplingDateTextBox.Location = new System.Drawing.Point(109, 201);
			this.samplingDateTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.samplingDateTextBox.Name = "samplingDateTextBox";
			this.samplingDateTextBox.Size = new System.Drawing.Size(166, 29);
			this.samplingDateTextBox.TabIndex = 2;
			this.samplingDateTextBox.Text = "西元年/月/日";
			this.samplingDateTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.samplingDateTextBox_MouseClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(23, 204);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "採樣日期:";
			// 
			// watershedComboBox
			// 
			this.watershedComboBox.DataSource = this.watershedIndexVMBindingSource;
			this.watershedComboBox.DisplayMember = "RiverName";
			this.watershedComboBox.FormattingEnabled = true;
			this.watershedComboBox.Location = new System.Drawing.Point(109, 59);
			this.watershedComboBox.Margin = new System.Windows.Forms.Padding(7);
			this.watershedComboBox.Name = "watershedComboBox";
			this.watershedComboBox.Size = new System.Drawing.Size(166, 29);
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
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(23, 62);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 21);
			this.label7.TabIndex = 6;
			this.label7.Text = "採樣流域:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.CloseButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 30);
			this.panel1.TabIndex = 14;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upPanel_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upPanel_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upPanel_MouseUp);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(3, 6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 21);
			this.label8.TabIndex = 14;
			this.label8.Text = "新增採樣資料";
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.BackColor = System.Drawing.Color.Gray;
			this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
			this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CloseButton.Location = new System.Drawing.Point(636, 1);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(26, 28);
			this.CloseButton.TabIndex = 14;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// accumulateLabel
			// 
			this.accumulateLabel.AutoSize = true;
			this.accumulateLabel.Location = new System.Drawing.Point(104, 22);
			this.accumulateLabel.Name = "accumulateLabel";
			this.accumulateLabel.Size = new System.Drawing.Size(42, 21);
			this.accumulateLabel.TabIndex = 15;
			this.accumulateLabel.Text = "總數";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.accumulateLabel);
			this.groupBox1.Controls.Add(this.preJuvenileTextBox);
			this.groupBox1.Controls.Add(this.preAdultTextBox);
			this.groupBox1.Controls.Add(this.sumJuvenileTextBox);
			this.groupBox1.Controls.Add(this.preSubadultTextBox);
			this.groupBox1.Controls.Add(this.sumAdultTextBox);
			this.groupBox1.Controls.Add(this.sumSubadultTextBox);
			this.groupBox1.Location = new System.Drawing.Point(377, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 171);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "累加器";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(89, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 21);
			this.label9.TabIndex = 16;
			this.label9.Text = "上回輸入";
			// 
			// preJuvenileTextBox
			// 
			this.preJuvenileTextBox.Location = new System.Drawing.Point(183, 125);
			this.preJuvenileTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.preJuvenileTextBox.MaxLength = 4;
			this.preJuvenileTextBox.Name = "preJuvenileTextBox";
			this.preJuvenileTextBox.ReadOnly = true;
			this.preJuvenileTextBox.Size = new System.Drawing.Size(70, 29);
			this.preJuvenileTextBox.TabIndex = 6;
			this.preJuvenileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// preAdultTextBox
			// 
			this.preAdultTextBox.Location = new System.Drawing.Point(7, 124);
			this.preAdultTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.preAdultTextBox.MaxLength = 4;
			this.preAdultTextBox.Name = "preAdultTextBox";
			this.preAdultTextBox.ReadOnly = true;
			this.preAdultTextBox.Size = new System.Drawing.Size(70, 29);
			this.preAdultTextBox.TabIndex = 4;
			this.preAdultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sumJuvenileTextBox
			// 
			this.sumJuvenileTextBox.Location = new System.Drawing.Point(179, 50);
			this.sumJuvenileTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.sumJuvenileTextBox.MaxLength = 4;
			this.sumJuvenileTextBox.Name = "sumJuvenileTextBox";
			this.sumJuvenileTextBox.ReadOnly = true;
			this.sumJuvenileTextBox.Size = new System.Drawing.Size(70, 29);
			this.sumJuvenileTextBox.TabIndex = 6;
			this.sumJuvenileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// preSubadultTextBox
			// 
			this.preSubadultTextBox.Location = new System.Drawing.Point(93, 125);
			this.preSubadultTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.preSubadultTextBox.MaxLength = 4;
			this.preSubadultTextBox.Name = "preSubadultTextBox";
			this.preSubadultTextBox.ReadOnly = true;
			this.preSubadultTextBox.Size = new System.Drawing.Size(70, 29);
			this.preSubadultTextBox.TabIndex = 5;
			this.preSubadultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sumAdultTextBox
			// 
			this.sumAdultTextBox.Location = new System.Drawing.Point(7, 49);
			this.sumAdultTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.sumAdultTextBox.MaxLength = 4;
			this.sumAdultTextBox.Name = "sumAdultTextBox";
			this.sumAdultTextBox.ReadOnly = true;
			this.sumAdultTextBox.Size = new System.Drawing.Size(70, 29);
			this.sumAdultTextBox.TabIndex = 4;
			this.sumAdultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sumSubadultTextBox
			// 
			this.sumSubadultTextBox.Location = new System.Drawing.Point(93, 50);
			this.sumSubadultTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.sumSubadultTextBox.MaxLength = 4;
			this.sumSubadultTextBox.Name = "sumSubadultTextBox";
			this.sumSubadultTextBox.ReadOnly = true;
			this.sumSubadultTextBox.Size = new System.Drawing.Size(70, 29);
			this.sumSubadultTextBox.TabIndex = 5;
			this.sumSubadultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// accumulateButton
			// 
			this.accumulateButton.ForeColor = System.Drawing.Color.Black;
			this.accumulateButton.Location = new System.Drawing.Point(475, 291);
			this.accumulateButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.accumulateButton.Name = "accumulateButton";
			this.accumulateButton.Size = new System.Drawing.Size(74, 38);
			this.accumulateButton.TabIndex = 7;
			this.accumulateButton.Text = "累加";
			this.accumulateButton.UseVisualStyleBackColor = true;
			this.accumulateButton.Click += new System.EventHandler(this.accumulateButton_Click);
			// 
			// CreateSampleDataForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(664, 355);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
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
			this.Controls.Add(this.accumulateButton);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateSampleDataForm";
			this.Text = "新增採樣資料";
			((System.ComponentModel.ISupportInitialize)(this.sampleAreaIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speciesIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.watershedIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label accumulateLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox preJuvenileTextBox;
		private System.Windows.Forms.TextBox preAdultTextBox;
		private System.Windows.Forms.TextBox sumJuvenileTextBox;
		private System.Windows.Forms.TextBox preSubadultTextBox;
		private System.Windows.Forms.TextBox sumAdultTextBox;
		private System.Windows.Forms.TextBox sumSubadultTextBox;
		private System.Windows.Forms.Button accumulateButton;
	}
}