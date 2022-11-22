namespace SalmonStatistics
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.upPanel = new System.Windows.Forms.Panel();
			this.CloseButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.watershedButton = new System.Windows.Forms.Button();
			this.sampleAreaButton = new System.Windows.Forms.Button();
			this.SpeciesButton = new System.Windows.Forms.Button();
			this.sampleDataButton = new System.Windows.Forms.Button();
			this.UsersButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.upPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// upPanel
			// 
			this.upPanel.BackColor = System.Drawing.Color.Gray;
			this.upPanel.Controls.Add(this.CloseButton);
			this.upPanel.Controls.Add(this.label1);
			resources.ApplyResources(this.upPanel, "upPanel");
			this.upPanel.Name = "upPanel";
			this.upPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upPanel_MouseDown);
			this.upPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upPanel_MouseMove);
			this.upPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upPanel_MouseUp);
			// 
			// CloseButton
			// 
			resources.ApplyResources(this.CloseButton, "CloseButton");
			this.CloseButton.BackColor = System.Drawing.Color.Gray;
			this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Name = "label1";
			// 
			// watershedButton
			// 
			this.watershedButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.watershedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			resources.ApplyResources(this.watershedButton, "watershedButton");
			this.watershedButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.watershedButton.Name = "watershedButton";
			this.watershedButton.UseVisualStyleBackColor = false;
			this.watershedButton.Click += new System.EventHandler(this.watershedButton_Click);
			// 
			// sampleAreaButton
			// 
			this.sampleAreaButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.sampleAreaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			resources.ApplyResources(this.sampleAreaButton, "sampleAreaButton");
			this.sampleAreaButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.sampleAreaButton.Name = "sampleAreaButton";
			this.sampleAreaButton.UseVisualStyleBackColor = true;
			this.sampleAreaButton.Click += new System.EventHandler(this.sampleAreaButton_Click);
			// 
			// SpeciesButton
			// 
			this.SpeciesButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.SpeciesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			resources.ApplyResources(this.SpeciesButton, "SpeciesButton");
			this.SpeciesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SpeciesButton.Name = "SpeciesButton";
			this.SpeciesButton.UseVisualStyleBackColor = true;
			this.SpeciesButton.Click += new System.EventHandler(this.SpeciesButton_Click);
			// 
			// sampleDataButton
			// 
			this.sampleDataButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.sampleDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			resources.ApplyResources(this.sampleDataButton, "sampleDataButton");
			this.sampleDataButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sampleDataButton.Name = "sampleDataButton";
			this.sampleDataButton.UseVisualStyleBackColor = true;
			this.sampleDataButton.Click += new System.EventHandler(this.sampleDataButton_Click);
			// 
			// UsersButton
			// 
			this.UsersButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.UsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			resources.ApplyResources(this.UsersButton, "UsersButton");
			this.UsersButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UsersButton.Name = "UsersButton";
			this.UsersButton.UseVisualStyleBackColor = true;
			this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
			// 
			// LogoutButton
			// 
			this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			resources.ApplyResources(this.LogoutButton, "LogoutButton");
			this.LogoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.welcomeLabel);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.watershedButton);
			this.panel1.Controls.Add(this.LogoutButton);
			this.panel1.Controls.Add(this.sampleAreaButton);
			this.panel1.Controls.Add(this.SpeciesButton);
			this.panel1.Controls.Add(this.sampleDataButton);
			this.panel1.Controls.Add(this.UsersButton);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button6
			// 
			resources.ApplyResources(this.button6, "button6");
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button6.FlatAppearance.BorderSize = 2;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button6.ForeColor = System.Drawing.Color.Transparent;
			this.button6.Name = "button6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// button5
			// 
			resources.ApplyResources(this.button5, "button5");
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button5.FlatAppearance.BorderSize = 2;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button5.ForeColor = System.Drawing.Color.Transparent;
			this.button5.Name = "button5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.UsersButton_Click);
			// 
			// button4
			// 
			resources.ApplyResources(this.button4, "button4");
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.BorderSize = 2;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button4.ForeColor = System.Drawing.Color.Transparent;
			this.button4.Name = "button4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.sampleDataButton_Click);
			// 
			// button3
			// 
			resources.ApplyResources(this.button3, "button3");
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.BorderSize = 2;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button3.ForeColor = System.Drawing.Color.Transparent;
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.SpeciesButton_Click);
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button2.ForeColor = System.Drawing.Color.Transparent;
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.sampleAreaButton_Click);
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.watershedButton_Click);
			// 
			// welcomeLabel
			// 
			resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
			this.welcomeLabel.ForeColor = System.Drawing.Color.White;
			this.welcomeLabel.Name = "welcomeLabel";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// MainPanel
			// 
			this.MainPanel.BackColor = System.Drawing.Color.DarkGray;
			resources.ApplyResources(this.MainPanel, "MainPanel");
			this.MainPanel.ForeColor = System.Drawing.SystemColors.Control;
			this.MainPanel.Name = "MainPanel";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.upPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.MaximumSizeChanged += new System.EventHandler(this.maxButton_Click);
			this.MinimumSizeChanged += new System.EventHandler(this.minButton_Click);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.upPanel.ResumeLayout(false);
			this.upPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel upPanel;
		private System.Windows.Forms.Button watershedButton;
		private System.Windows.Forms.Button sampleAreaButton;
		private System.Windows.Forms.Button SpeciesButton;
		private System.Windows.Forms.Button sampleDataButton;
		private System.Windows.Forms.Button UsersButton;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}