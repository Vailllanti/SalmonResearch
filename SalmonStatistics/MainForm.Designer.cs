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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.修改流域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護樣區ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護物種ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護採樣資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.檢視資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.年分流域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.年分樣區ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.年分組群組成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改流域ToolStripMenuItem,
            this.維護樣區ToolStripMenuItem,
            this.維護物種ToolStripMenuItem,
            this.維護採樣資料ToolStripMenuItem,
            this.檢視資料ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(791, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 修改流域ToolStripMenuItem
			// 
			this.修改流域ToolStripMenuItem.Name = "修改流域ToolStripMenuItem";
			this.修改流域ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.修改流域ToolStripMenuItem.Text = "編輯採樣流域";
			this.修改流域ToolStripMenuItem.Click += new System.EventHandler(this.修改流域ToolStripMenuItem_Click);
			// 
			// 維護樣區ToolStripMenuItem
			// 
			this.維護樣區ToolStripMenuItem.Name = "維護樣區ToolStripMenuItem";
			this.維護樣區ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.維護樣區ToolStripMenuItem.Text = "編輯樣區";
			this.維護樣區ToolStripMenuItem.Click += new System.EventHandler(this.維護樣區ToolStripMenuItem_Click);
			// 
			// 維護物種ToolStripMenuItem
			// 
			this.維護物種ToolStripMenuItem.Name = "維護物種ToolStripMenuItem";
			this.維護物種ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.維護物種ToolStripMenuItem.Text = "編輯物種";
			this.維護物種ToolStripMenuItem.Click += new System.EventHandler(this.維護物種ToolStripMenuItem_Click);
			// 
			// 維護採樣資料ToolStripMenuItem
			// 
			this.維護採樣資料ToolStripMenuItem.Name = "維護採樣資料ToolStripMenuItem";
			this.維護採樣資料ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.維護採樣資料ToolStripMenuItem.Text = "編輯採樣資料";
			// 
			// 檢視資料ToolStripMenuItem
			// 
			this.檢視資料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.年分流域ToolStripMenuItem,
            this.年分樣區ToolStripMenuItem,
            this.年分組群組成ToolStripMenuItem});
			this.檢視資料ToolStripMenuItem.Name = "檢視資料ToolStripMenuItem";
			this.檢視資料ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.檢視資料ToolStripMenuItem.Text = "檢視資料";
			// 
			// 年分流域ToolStripMenuItem
			// 
			this.年分流域ToolStripMenuItem.Name = "年分流域ToolStripMenuItem";
			this.年分流域ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.年分流域ToolStripMenuItem.Text = "年分-流域";
			// 
			// 年分樣區ToolStripMenuItem
			// 
			this.年分樣區ToolStripMenuItem.Name = "年分樣區ToolStripMenuItem";
			this.年分樣區ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.年分樣區ToolStripMenuItem.Text = "年分-樣區";
			// 
			// 年分組群組成ToolStripMenuItem
			// 
			this.年分組群組成ToolStripMenuItem.Name = "年分組群組成ToolStripMenuItem";
			this.年分組群組成ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.年分組群組成ToolStripMenuItem.Text = "年分-組群組成";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 518);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 修改流域ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護樣區ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護物種ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護採樣資料ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 檢視資料ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 年分流域ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 年分樣區ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 年分組群組成ToolStripMenuItem;
	}
}