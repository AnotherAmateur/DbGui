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
			this.refreshButton = new System.Windows.Forms.Button();
			this.insertDataButton = new System.Windows.Forms.Button();
			this.tableSelectedLabel = new System.Windows.Forms.Label();
			this.searchMenuStrip = new System.Windows.Forms.MenuStrip();
			this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.selectedTableLabel = new System.Windows.Forms.Label();
			this.deleteRowButton = new System.Windows.Forms.Button();
			this.saveChangesButton = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.getChildernMenuStrip = new System.Windows.Forms.MenuStrip();
			this.reportButton = new System.Windows.Forms.Button();
			this.openViewsButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.SuspendLayout();
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
			this.tableSelectionMenuStrip.Size = new System.Drawing.Size(84, 24);
			this.tableSelectionMenuStrip.TabIndex = 0;
			this.tableSelectionMenuStrip.Text = "Таблица";
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.refreshButton.Location = new System.Drawing.Point(767, 13);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(107, 32);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "Обновить таблицу";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// insertDataButton
			// 
			this.insertDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.insertDataButton.Location = new System.Drawing.Point(212, 502);
			this.insertDataButton.Name = "insertDataButton";
			this.insertDataButton.Size = new System.Drawing.Size(105, 32);
			this.insertDataButton.TabIndex = 0;
			this.insertDataButton.Text = "Вставить строку";
			this.insertDataButton.UseVisualStyleBackColor = true;
			this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
			// 
			// tableSelectedLabel
			// 
			this.tableSelectedLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tableSelectedLabel.Location = new System.Drawing.Point(210, 25);
			this.tableSelectedLabel.Name = "tableSelectedLabel";
			this.tableSelectedLabel.Size = new System.Drawing.Size(206, 23);
			this.tableSelectedLabel.TabIndex = 4;
			this.tableSelectedLabel.Text = "None";
			this.tableSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.deleteRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteRowButton.Location = new System.Drawing.Point(13, 502);
			this.deleteRowButton.Name = "deleteRowButton";
			this.deleteRowButton.Size = new System.Drawing.Size(164, 32);
			this.deleteRowButton.TabIndex = 10;
			this.deleteRowButton.Text = "Удалить выделенную строку";
			this.deleteRowButton.UseVisualStyleBackColor = true;
			this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
			// 
			// saveChangesButton
			// 
			this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveChangesButton.Location = new System.Drawing.Point(721, 502);
			this.saveChangesButton.Name = "saveChangesButton";
			this.saveChangesButton.Size = new System.Drawing.Size(154, 32);
			this.saveChangesButton.TabIndex = 11;
			this.saveChangesButton.Text = "Зафиксировать изменения";
			this.saveChangesButton.UseVisualStyleBackColor = true;
			this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(5, 51);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer.Size = new System.Drawing.Size(870, 436);
			this.splitContainer.SplitterDistance = 195;
			this.splitContainer.TabIndex = 13;
			// 
			// getChildernMenuStrip
			// 
			this.getChildernMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.getChildernMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.getChildernMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.getChildernMenuStrip.Location = new System.Drawing.Point(77, 0);
			this.getChildernMenuStrip.Name = "getChildernMenuStrip";
			this.getChildernMenuStrip.Size = new System.Drawing.Size(209, 24);
			this.getChildernMenuStrip.TabIndex = 14;
			this.getChildernMenuStrip.Text = "Выбрать дочернюю таблицу";
			// 
			// reportButton
			// 
			this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reportButton.Location = new System.Drawing.Point(13, 540);
			this.reportButton.Name = "reportButton";
			this.reportButton.Size = new System.Drawing.Size(104, 32);
			this.reportButton.TabIndex = 15;
			this.reportButton.Text = "Составить отчет";
			this.reportButton.UseVisualStyleBackColor = true;
			this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
			// 
			// openViewsButton
			// 
			this.openViewsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openViewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.openViewsButton.Location = new System.Drawing.Point(153, 540);
			this.openViewsButton.Name = "openViewsButton";
			this.openViewsButton.Size = new System.Drawing.Size(164, 32);
			this.openViewsButton.TabIndex = 16;
			this.openViewsButton.Text = "Перейти к представлениям";
			this.openViewsButton.UseVisualStyleBackColor = true;
			this.openViewsButton.Click += new System.EventHandler(this.openViewsButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(151, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Таблица:";
			// 
			// MainFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 595);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.openViewsButton);
			this.Controls.Add(this.reportButton);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.saveChangesButton);
			this.Controls.Add(this.deleteRowButton);
			this.Controls.Add(this.selectedTableLabel);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.insertDataButton);
			this.Controls.Add(this.tableSelectedLabel);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.tableSelectionMenuStrip);
			this.Controls.Add(this.searchMenuStrip);
			this.Controls.Add(this.getChildernMenuStrip);
			this.MainMenuStrip = this.getChildernMenuStrip;
			this.Name = "MainFormAdmin";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainFormAdmin_Load);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip tableSelectionMenuStrip;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Button insertDataButton;
		private System.Windows.Forms.Label tableSelectedLabel;
		private System.Windows.Forms.MenuStrip searchMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label selectedTableLabel;
		private System.Windows.Forms.Button deleteRowButton;
		private System.Windows.Forms.Button saveChangesButton;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.MenuStrip getChildernMenuStrip;
		private System.Windows.Forms.Button reportButton;
		private System.Windows.Forms.Button openViewsButton;
		private System.Windows.Forms.Label label1;
	}
}