namespace DbGui
{
	partial class MainFormAdmin
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
			this.dfgdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "Таблица";
			// 
			// dfgdToolStripMenuItem
			// 
			this.dfgdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgToolStripMenuItem});
			this.dfgdToolStripMenuItem.Name = "dfgdToolStripMenuItem";
			this.dfgdToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.dfgdToolStripMenuItem.Text = "dfgd";
			// 
			// dfgToolStripMenuItem
			// 
			this.dfgToolStripMenuItem.Name = "dfgToolStripMenuItem";
			this.dfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.dfgToolStripMenuItem.Text = "dfg";
			this.dfgToolStripMenuItem.Click += new System.EventHandler(this.dfgToolStripMenuItem_Click);
			// 
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.Name = "MainFormAdmin";
			this.Text = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dfgdToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dfgToolStripMenuItem;
	}
}