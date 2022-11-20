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
			this.minButton = new System.Windows.Forms.Button();
			this.maxButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.watershedButton = new System.Windows.Forms.Button();
			this.sampleAreaButton = new System.Windows.Forms.Button();
			this.SpeciesButton = new System.Windows.Forms.Button();
			this.sampleDataButton = new System.Windows.Forms.Button();
			this.UsersButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.upPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// upPanel
			// 
			this.upPanel.BackColor = System.Drawing.Color.Gray;
			this.upPanel.Controls.Add(this.minButton);
			this.upPanel.Controls.Add(this.maxButton);
			this.upPanel.Controls.Add(this.CloseButton);
			this.upPanel.Controls.Add(this.label1);
			resources.ApplyResources(this.upPanel, "upPanel");
			this.upPanel.Name = "upPanel";
			// 
			// minButton
			// 
			resources.ApplyResources(this.minButton, "minButton");
			this.minButton.BackColor = System.Drawing.Color.Gray;
			this.minButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.minButton.ForeColor = System.Drawing.Color.Transparent;
			this.minButton.Name = "minButton";
			this.minButton.UseVisualStyleBackColor = false;
			this.minButton.Click += new System.EventHandler(this.minButton_Click);
			// 
			// maxButton
			// 
			resources.ApplyResources(this.maxButton, "maxButton");
			this.maxButton.BackColor = System.Drawing.Color.Gray;
			this.maxButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.maxButton.FlatAppearance.BorderSize = 2;
			this.maxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.maxButton.ForeColor = System.Drawing.Color.Transparent;
			this.maxButton.Name = "maxButton";
			this.maxButton.UseVisualStyleBackColor = false;
			this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
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
			this.panel1.Controls.Add(this.watershedButton);
			this.panel1.Controls.Add(this.LogoutButton);
			this.panel1.Controls.Add(this.sampleAreaButton);
			this.panel1.Controls.Add(this.SpeciesButton);
			this.panel1.Controls.Add(this.sampleDataButton);
			this.panel1.Controls.Add(this.UsersButton);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
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
		private System.Windows.Forms.Button minButton;
		private System.Windows.Forms.Button maxButton;
	}
}