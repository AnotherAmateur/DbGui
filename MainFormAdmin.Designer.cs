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
			this.dataInsertionGroupBox = new System.Windows.Forms.GroupBox();
			this.insertDataButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.dataInsertionGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableSelectionMenuStrip
			// 
			this.tableSelectionMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableSelectionMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.tableSelectionMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.tableSelectionMenuStrip.Name = "tableSelectionMenuStrip";
			this.tableSelectionMenuStrip.Size = new System.Drawing.Size(177, 24);
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
			this.dataGridView.Size = new System.Drawing.Size(764, 301);
			this.dataGridView.TabIndex = 1;
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.Location = new System.Drawing.Point(701, 1);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "Обновить таблицу";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// dataInsertionGroupBox
			// 
			this.dataInsertionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataInsertionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.dataInsertionGroupBox.Controls.Add(this.insertDataButton);
			this.dataInsertionGroupBox.Enabled = false;
			this.dataInsertionGroupBox.Location = new System.Drawing.Point(12, 358);
			this.dataInsertionGroupBox.MaximumSize = new System.Drawing.Size(9999, 40);
			this.dataInsertionGroupBox.MinimumSize = new System.Drawing.Size(0, 40);
			this.dataInsertionGroupBox.Name = "dataInsertionGroupBox";
			this.dataInsertionGroupBox.Size = new System.Drawing.Size(764, 40);
			this.dataInsertionGroupBox.TabIndex = 3;
			this.dataInsertionGroupBox.TabStop = false;
			this.dataInsertionGroupBox.Text = "Вставка в таблицу";
			// 
			// insertDataButton
			// 
			this.insertDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.insertDataButton.Location = new System.Drawing.Point(661, 11);
			this.insertDataButton.Name = "insertDataButton";
			this.insertDataButton.Size = new System.Drawing.Size(97, 23);
			this.insertDataButton.TabIndex = 0;
			this.insertDataButton.Text = "Вставить";
			this.insertDataButton.UseVisualStyleBackColor = true;
			this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
			// 
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 475);
			this.Controls.Add(this.dataInsertionGroupBox);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.tableSelectionMenuStrip);
			this.Name = "MainFormAdmin";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.dataInsertionGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip tableSelectionMenuStrip;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.GroupBox dataInsertionGroupBox;
		private System.Windows.Forms.Button insertDataButton;
	}
}