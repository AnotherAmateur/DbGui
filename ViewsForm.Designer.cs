namespace DbGui
{
	partial class ViewsForm
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
			this.viewSelectionMenuStrip = new System.Windows.Forms.MenuStrip();
			this.refreshViewButton = new System.Windows.Forms.Button();
			this.insertDataButton = new System.Windows.Forms.Button();
			this.tableSelectedLabel = new System.Windows.Forms.Label();
			this.searchMenuStrip = new System.Windows.Forms.MenuStrip();
			this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.selectedTableLabel = new System.Windows.Forms.Label();
			this.saveChangesButton = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.viewHeaderLabel = new System.Windows.Forms.Label();
			this.rowsDeleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// viewSelectionMenuStrip
			// 
			this.viewSelectionMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewSelectionMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.viewSelectionMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.viewSelectionMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.viewSelectionMenuStrip.Name = "viewSelectionMenuStrip";
			this.viewSelectionMenuStrip.Size = new System.Drawing.Size(209, 24);
			this.viewSelectionMenuStrip.TabIndex = 0;
			this.viewSelectionMenuStrip.Text = "Таблица";
			// 
			// refreshViewButton
			// 
			this.refreshViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.refreshViewButton.Location = new System.Drawing.Point(729, 12);
			this.refreshViewButton.Name = "refreshViewButton";
			this.refreshViewButton.Size = new System.Drawing.Size(145, 33);
			this.refreshViewButton.TabIndex = 2;
			this.refreshViewButton.Text = "Обновить представление";
			this.refreshViewButton.UseVisualStyleBackColor = true;
			this.refreshViewButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// insertDataButton
			// 
			this.insertDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.insertDataButton.Location = new System.Drawing.Point(5, 544);
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
			this.tableSelectedLabel.Location = new System.Drawing.Point(97, 30);
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
			// saveChangesButton
			// 
			this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveChangesButton.Location = new System.Drawing.Point(720, 544);
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
			this.splitContainer.Size = new System.Drawing.Size(870, 471);
			this.splitContainer.SplitterDistance = 300;
			this.splitContainer.TabIndex = 13;
			// 
			// viewHeaderLabel
			// 
			this.viewHeaderLabel.AutoSize = true;
			this.viewHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.viewHeaderLabel.Location = new System.Drawing.Point(2, 35);
			this.viewHeaderLabel.Name = "viewHeaderLabel";
			this.viewHeaderLabel.Size = new System.Drawing.Size(89, 13);
			this.viewHeaderLabel.TabIndex = 17;
			this.viewHeaderLabel.Text = "Представление:";
			// 
			// rowsDeleteButton
			// 
			this.rowsDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rowsDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.rowsDeleteButton.Location = new System.Drawing.Point(116, 544);
			this.rowsDeleteButton.Name = "rowsDeleteButton";
			this.rowsDeleteButton.Size = new System.Drawing.Size(167, 32);
			this.rowsDeleteButton.TabIndex = 18;
			this.rowsDeleteButton.Text = "Удалить выделенную строку";
			this.rowsDeleteButton.UseVisualStyleBackColor = true;
			this.rowsDeleteButton.Click += new System.EventHandler(this.rowsDeleteButton_Click);
			// 
			// ViewsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 601);
			this.Controls.Add(this.rowsDeleteButton);
			this.Controls.Add(this.viewHeaderLabel);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.saveChangesButton);
			this.Controls.Add(this.selectedTableLabel);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.insertDataButton);
			this.Controls.Add(this.tableSelectedLabel);
			this.Controls.Add(this.refreshViewButton);
			this.Controls.Add(this.viewSelectionMenuStrip);
			this.Controls.Add(this.searchMenuStrip);
			this.Name = "ViewsForm";
			this.Text = "Представления";
			this.Load += new System.EventHandler(this.ViewsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip viewSelectionMenuStrip;
		private System.Windows.Forms.Button refreshViewButton;
		private System.Windows.Forms.Button insertDataButton;
		private System.Windows.Forms.Label tableSelectedLabel;
		private System.Windows.Forms.MenuStrip searchMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label selectedTableLabel;
		private System.Windows.Forms.Button saveChangesButton;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label viewHeaderLabel;
		private System.Windows.Forms.Button rowsDeleteButton;
	}
}