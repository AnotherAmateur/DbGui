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
			this.searchMenuStrip = new System.Windows.Forms.MenuStrip();
			this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.selectedTableLabel = new System.Windows.Forms.Label();
			this.deleteRowButton = new System.Windows.Forms.Button();
			this.saveChangesButton = new System.Windows.Forms.Button();
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
			this.tableSelectionMenuStrip.Size = new System.Drawing.Size(80, 24);
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
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.refreshButton.Location = new System.Drawing.Point(775, 9);
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
			this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.insertDataButton.Location = new System.Drawing.Point(182, 404);
			this.insertDataButton.Name = "insertDataButton";
			this.insertDataButton.Size = new System.Drawing.Size(102, 24);
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
			// searchMenuStrip
			// 
			this.searchMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.searchMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.searchMenuStrip.Location = new System.Drawing.Point(338, 0);
			this.searchMenuStrip.Name = "searchMenuStrip";
			this.searchMenuStrip.Size = new System.Drawing.Size(209, 24);
			this.searchMenuStrip.TabIndex = 7;
			this.searchMenuStrip.Text = "Поиск";
			// 
			// таблицыToolStripMenuItem
			// 
			this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
			this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.таблицыToolStripMenuItem.Text = "Таблицы";
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(473, 0);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(226, 20);
			this.searchTextBox.TabIndex = 8;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// selectedTableLabel
			// 
			this.selectedTableLabel.AutoSize = true;
			this.selectedTableLabel.Location = new System.Drawing.Point(486, 23);
			this.selectedTableLabel.Name = "selectedTableLabel";
			this.selectedTableLabel.Size = new System.Drawing.Size(33, 13);
			this.selectedTableLabel.TabIndex = 9;
			this.selectedTableLabel.Text = "None";
			// 
			// deleteRowButton
			// 
			this.deleteRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteRowButton.Location = new System.Drawing.Point(12, 404);
			this.deleteRowButton.Name = "deleteRowButton";
			this.deleteRowButton.Size = new System.Drawing.Size(164, 24);
			this.deleteRowButton.TabIndex = 10;
			this.deleteRowButton.Text = "Удалить выделенную строку";
			this.deleteRowButton.UseVisualStyleBackColor = true;
			this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
			// 
			// saveChangesButton
			// 
			this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveChangesButton.Location = new System.Drawing.Point(696, 404);
			this.saveChangesButton.Name = "saveChangesButton";
			this.saveChangesButton.Size = new System.Drawing.Size(154, 24);
			this.saveChangesButton.TabIndex = 11;
			this.saveChangesButton.Text = "Зафиксировать изменения";
			this.saveChangesButton.UseVisualStyleBackColor = true;
			this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
			// 
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 521);
			this.Controls.Add(this.saveChangesButton);
			this.Controls.Add(this.deleteRowButton);
			this.Controls.Add(this.selectedTableLabel);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.insertDataButton);
			this.Controls.Add(this.tableSelectedLabel);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.tableSelectionMenuStrip);
			this.Controls.Add(this.searchMenuStrip);
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
		private System.Windows.Forms.MenuStrip searchMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label selectedTableLabel;
		private System.Windows.Forms.Button deleteRowButton;
		private System.Windows.Forms.Button saveChangesButton;
	}
}