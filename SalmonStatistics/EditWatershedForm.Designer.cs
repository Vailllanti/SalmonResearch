namespace SalmonStatistics
{
	partial class EditWatershedForm
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
			this.updateButton = new System.Windows.Forms.Button();
			this.riverTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(188, 105);
			this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(88, 31);
			this.updateButton.TabIndex = 1;
			this.updateButton.Text = "修改";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// riverTextBox
			// 
			this.riverTextBox.Location = new System.Drawing.Point(44, 47);
			this.riverTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.riverTextBox.Name = "riverTextBox";
			this.riverTextBox.Size = new System.Drawing.Size(230, 23);
			this.riverTextBox.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditWatershedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 175);
			this.Controls.Add(this.riverTextBox);
			this.Controls.Add(this.updateButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditWatershedForm";
			this.Text = "編輯採樣流域";
			this.Load += new System.EventHandler(this.EditWatershedForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox riverTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}