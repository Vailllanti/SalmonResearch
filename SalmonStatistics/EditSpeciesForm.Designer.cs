namespace SalmonStatistics
{
	partial class EditSpeciesForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.referencesTextBox = new System.Windows.Forms.TextBox();
			this.speciesTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 99);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "參考資料:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "種名:";
			// 
			// referencesTextBox
			// 
			this.referencesTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.referencesTextBox.Location = new System.Drawing.Point(129, 96);
			this.referencesTextBox.Margin = new System.Windows.Forms.Padding(12);
			this.referencesTextBox.Name = "referencesTextBox";
			this.referencesTextBox.Size = new System.Drawing.Size(340, 34);
			this.referencesTextBox.TabIndex = 6;
			// 
			// speciesTextBox
			// 
			this.speciesTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.speciesTextBox.Location = new System.Drawing.Point(129, 43);
			this.speciesTextBox.Margin = new System.Windows.Forms.Padding(12);
			this.speciesTextBox.Name = "speciesTextBox";
			this.speciesTextBox.Size = new System.Drawing.Size(340, 34);
			this.speciesTextBox.TabIndex = 5;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(390, 149);
			this.saveButton.Margin = new System.Windows.Forms.Padding(12);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(79, 39);
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
			this.deleteButton.Location = new System.Drawing.Point(291, 149);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(12);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 39);
			this.deleteButton.TabIndex = 7;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// EditSpeciesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 208);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.referencesTextBox);
			this.Controls.Add(this.speciesTextBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditSpeciesForm";
			this.Text = "編輯物種";
			this.Load += new System.EventHandler(this.EditSpeciesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox referencesTextBox;
		private System.Windows.Forms.TextBox speciesTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button deleteButton;
	}
}