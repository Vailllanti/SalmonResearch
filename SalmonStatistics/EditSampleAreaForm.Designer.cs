namespace SalmonStatistics
{
	partial class EditSampleAreaForm
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
			this.WatershedIdComboBox = new System.Windows.Forms.ComboBox();
			this.areaNameTextBox = new System.Windows.Forms.TextBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// WatershedIdComboBox
			// 
			this.WatershedIdComboBox.DisplayMember = "RiverName";
			this.WatershedIdComboBox.FormattingEnabled = true;
			this.WatershedIdComboBox.Location = new System.Drawing.Point(34, 47);
			this.WatershedIdComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.WatershedIdComboBox.Name = "WatershedIdComboBox";
			this.WatershedIdComboBox.Size = new System.Drawing.Size(284, 24);
			this.WatershedIdComboBox.TabIndex = 5;
			this.WatershedIdComboBox.ValueMember = "Id";
			// 
			// areaNameTextBox
			// 
			this.areaNameTextBox.Location = new System.Drawing.Point(34, 85);
			this.areaNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.areaNameTextBox.Name = "areaNameTextBox";
			this.areaNameTextBox.Size = new System.Drawing.Size(284, 23);
			this.areaNameTextBox.TabIndex = 3;
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(228, 122);
			this.updateButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(90, 36);
			this.updateButton.TabIndex = 4;
			this.updateButton.Text = "保存";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(127, 122);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(90, 36);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditSampleAreaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 194);
			this.Controls.Add(this.WatershedIdComboBox);
			this.Controls.Add(this.areaNameTextBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditSampleAreaForm";
			this.Text = "編輯樣區";
			this.Load += new System.EventHandler(this.EditSampleAreaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox WatershedIdComboBox;
		private System.Windows.Forms.TextBox areaNameTextBox;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}