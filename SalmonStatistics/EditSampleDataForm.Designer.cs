namespace SalmonStatistics
{
	partial class EditSampleDataForm
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.speciesComboBox = new System.Windows.Forms.ComboBox();
			this.areaNameComboBox = new System.Windows.Forms.ComboBox();
			this.samplingDateTextBox = new System.Windows.Forms.TextBox();
			this.JuvenileNumTextBox = new System.Windows.Forms.TextBox();
			this.SubadultNumTextBox = new System.Windows.Forms.TextBox();
			this.AdultNumTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(674, 137);
			this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 21);
			this.label5.TabIndex = 13;
			this.label5.Text = "稚魚";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(582, 137);
			this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 21);
			this.label4.TabIndex = 14;
			this.label4.Text = "亞成魚";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(501, 137);
			this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "成魚";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 112);
			this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 21);
			this.label6.TabIndex = 16;
			this.label6.Text = "採樣日期:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 172);
			this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 21);
			this.label2.TabIndex = 17;
			this.label2.Text = "物種:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 59);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 21);
			this.label1.TabIndex = 18;
			this.label1.Text = "樣區:";
			// 
			// speciesComboBox
			// 
			this.speciesComboBox.DisplayMember = "Species";
			this.speciesComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speciesComboBox.FormattingEnabled = true;
			this.speciesComboBox.Location = new System.Drawing.Point(115, 166);
			this.speciesComboBox.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
			this.speciesComboBox.Name = "speciesComboBox";
			this.speciesComboBox.Size = new System.Drawing.Size(352, 27);
			this.speciesComboBox.TabIndex = 2;
			this.speciesComboBox.ValueMember = "Id";
			// 
			// areaNameComboBox
			// 
			this.areaNameComboBox.DisplayMember = "AreaName";
			this.areaNameComboBox.FormattingEnabled = true;
			this.areaNameComboBox.Location = new System.Drawing.Point(115, 51);
			this.areaNameComboBox.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
			this.areaNameComboBox.Name = "areaNameComboBox";
			this.areaNameComboBox.Size = new System.Drawing.Size(451, 29);
			this.areaNameComboBox.TabIndex = 0;
			this.areaNameComboBox.ValueMember = "Id";
			// 
			// samplingDateTextBox
			// 
			this.samplingDateTextBox.Location = new System.Drawing.Point(115, 109);
			this.samplingDateTextBox.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
			this.samplingDateTextBox.Name = "samplingDateTextBox";
			this.samplingDateTextBox.Size = new System.Drawing.Size(219, 29);
			this.samplingDateTextBox.TabIndex = 1;
			// 
			// JuvenileNumTextBox
			// 
			this.JuvenileNumTextBox.Location = new System.Drawing.Point(666, 164);
			this.JuvenileNumTextBox.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
			this.JuvenileNumTextBox.Name = "JuvenileNumTextBox";
			this.JuvenileNumTextBox.Size = new System.Drawing.Size(61, 29);
			this.JuvenileNumTextBox.TabIndex = 5;
			// 
			// SubadultNumTextBox
			// 
			this.SubadultNumTextBox.Location = new System.Drawing.Point(579, 164);
			this.SubadultNumTextBox.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
			this.SubadultNumTextBox.Name = "SubadultNumTextBox";
			this.SubadultNumTextBox.Size = new System.Drawing.Size(61, 29);
			this.SubadultNumTextBox.TabIndex = 4;
			// 
			// AdultNumTextBox
			// 
			this.AdultNumTextBox.Location = new System.Drawing.Point(492, 165);
			this.AdultNumTextBox.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
			this.AdultNumTextBox.Name = "AdultNumTextBox";
			this.AdultNumTextBox.Size = new System.Drawing.Size(61, 29);
			this.AdultNumTextBox.TabIndex = 3;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(655, 225);
			this.saveButton.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(72, 33);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(557, 225);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(72, 33);
			this.deleteButton.TabIndex = 6;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// EditSampleDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 285);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.speciesComboBox);
			this.Controls.Add(this.areaNameComboBox);
			this.Controls.Add(this.samplingDateTextBox);
			this.Controls.Add(this.JuvenileNumTextBox);
			this.Controls.Add(this.SubadultNumTextBox);
			this.Controls.Add(this.AdultNumTextBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditSampleDataForm";
			this.Text = "編輯採樣資料";
			this.Load += new System.EventHandler(this.EditSampleDataForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox speciesComboBox;
		private System.Windows.Forms.ComboBox areaNameComboBox;
		private System.Windows.Forms.TextBox samplingDateTextBox;
		private System.Windows.Forms.TextBox JuvenileNumTextBox;
		private System.Windows.Forms.TextBox SubadultNumTextBox;
		private System.Windows.Forms.TextBox AdultNumTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button deleteButton;
	}
}