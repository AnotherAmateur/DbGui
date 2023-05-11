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
			this.refreshButton = new System.Windows.Forms.Button();
			this.insertDataButton = new System.Windows.Forms.Button();
			this.tableSelectedLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tableSelectionMenuStrip
			// 
			this.tableSelectionMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableSelectionMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.tableSelectionMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.tableSelectionMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.tableSelectionMenuStrip.Name = "tableSelectionMenuStrip";
			this.tableSelectionMenuStrip.Size = new System.Drawing.Size(209, 24);
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
			this.dataGridView.Size = new System.Drawing.Size(838, 347);
			this.dataGridView.TabIndex = 1;
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.Location = new System.Drawing.Point(769, 12);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "Обновить таблицу";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// insertDataButton
			// 
			this.insertDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.insertDataButton.Location = new System.Drawing.Point(644, 439);
			this.insertDataButton.Name = "insertDataButton";
			this.insertDataButton.Size = new System.Drawing.Size(113, 23);
			this.insertDataButton.TabIndex = 0;
			this.insertDataButton.Text = "Вставить строку";
			this.insertDataButton.UseVisualStyleBackColor = true;
			this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
			// 
			// tableSelectedLabel
			// 
			this.tableSelectedLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tableSelectedLabel.Location = new System.Drawing.Point(142, 25);
			this.tableSelectedLabel.Name = "tableSelectedLabel";
			this.tableSelectedLabel.Size = new System.Drawing.Size(174, 23);
			this.tableSelectedLabel.TabIndex = 4;
			this.tableSelectedLabel.Text = "None";
			this.tableSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 521);
			this.Controls.Add(this.insertDataButton);
			this.Controls.Add(this.tableSelectedLabel);
			this.Controls.Add(this.refreshButton);
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
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Button insertDataButton;
		private System.Windows.Forms.Label tableSelectedLabel;
	}
}