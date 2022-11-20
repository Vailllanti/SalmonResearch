namespace SalmonStatistics
{
	partial class EditUserForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AccountTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 25);
			this.label1.TabIndex = 11;
			this.label1.Text = "姓名:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(87, 127);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(305, 34);
			this.NameTextBox.TabIndex = 9;
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(328, 181);
			this.updateButton.Margin = new System.Windows.Forms.Padding(5);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(74, 38);
			this.updateButton.TabIndex = 10;
			this.updateButton.Text = "修改";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(87, 83);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(305, 34);
			this.PasswordTextBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "密碼:";
			// 
			// AccountTextBox
			// 
			this.AccountTextBox.Location = new System.Drawing.Point(87, 39);
			this.AccountTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.AccountTextBox.Name = "AccountTextBox";
			this.AccountTextBox.Size = new System.Drawing.Size(305, 34);
			this.AccountTextBox.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 42);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "帳戶:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(254, 180);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(5);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(74, 38);
			this.deleteButton.TabIndex = 10;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 235);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AccountTextBox);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditUserForm";
			this.Text = "編輯使用者";
			this.Load += new System.EventHandler(this.EditUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AccountTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button deleteButton;
	}
}