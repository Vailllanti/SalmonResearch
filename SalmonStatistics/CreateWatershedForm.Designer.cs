namespace SalmonStatistics
{
	partial class CreateWatershedForm
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
			this.riverTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(182, 115);
			this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(88, 31);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// riverTextBox
			// 
			this.riverTextBox.Location = new System.Drawing.Point(38, 56);
			this.riverTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.riverTextBox.Name = "riverTextBox";
			this.riverTextBox.Size = new System.Drawing.Size(230, 23);
			this.riverTextBox.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateWatershedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 183);
			this.Controls.Add(this.riverTextBox);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateWatershedForm";
			this.Text = "新增採樣流域";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox riverTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}