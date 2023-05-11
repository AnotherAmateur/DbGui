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
			this.tableSelectionMenuStrip = new System.Windows.Forms.MenuStrip();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tableSelectionMenuStrip
			// 
			this.tableSelectionMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.tableSelectionMenuStrip.Name = "tableSelectionMenuStrip";
			this.tableSelectionMenuStrip.Size = new System.Drawing.Size(800, 24);
			this.tableSelectionMenuStrip.TabIndex = 0;
			this.tableSelectionMenuStrip.Text = "Таблица";
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView.Location = new System.Drawing.Point(12, 51);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(776, 276);
			this.dataGridView.TabIndex = 1;
			// 
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.tableSelectionMenuStrip);
			this.Name = "MainFormAdmin";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip tableSelectionMenuStrip;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}