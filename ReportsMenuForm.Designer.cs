namespace DbGui
{
	partial class ReportsMenuForm
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
			this.getAuthorsCopiesByPublisherRadioButton = new System.Windows.Forms.RadioButton();
			this.getReaderHistoryRadioButton = new System.Windows.Forms.RadioButton();
			this.getDebtorsListRadioButton = new System.Windows.Forms.RadioButton();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.acceptButton = new System.Windows.Forms.Button();
			this.publisherTextBox = new System.Windows.Forms.TextBox();
			this.readerTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// getAuthorsCopiesByPublisherRadioButton
			// 
			this.getAuthorsCopiesByPublisherRadioButton.AutoSize = true;
			this.getAuthorsCopiesByPublisherRadioButton.Location = new System.Drawing.Point(288, 35);
			this.getAuthorsCopiesByPublisherRadioButton.Name = "getAuthorsCopiesByPublisherRadioButton";
			this.getAuthorsCopiesByPublisherRadioButton.Size = new System.Drawing.Size(168, 17);
			this.getAuthorsCopiesByPublisherRadioButton.TabIndex = 0;
			this.getAuthorsCopiesByPublisherRadioButton.TabStop = true;
			this.getAuthorsCopiesByPublisherRadioButton.Text = "GetAuthorsCopiesByPublisher ";
			this.getAuthorsCopiesByPublisherRadioButton.UseVisualStyleBackColor = true;
			// 
			// getReaderHistoryRadioButton
			// 
			this.getReaderHistoryRadioButton.AutoSize = true;
			this.getReaderHistoryRadioButton.Location = new System.Drawing.Point(288, 151);
			this.getReaderHistoryRadioButton.Name = "getReaderHistoryRadioButton";
			this.getReaderHistoryRadioButton.Size = new System.Drawing.Size(112, 17);
			this.getReaderHistoryRadioButton.TabIndex = 1;
			this.getReaderHistoryRadioButton.TabStop = true;
			this.getReaderHistoryRadioButton.Text = "GetReaderHistory ";
			this.getReaderHistoryRadioButton.UseVisualStyleBackColor = true;
			// 
			// getDebtorsListRadioButton
			// 
			this.getDebtorsListRadioButton.AutoSize = true;
			this.getDebtorsListRadioButton.Location = new System.Drawing.Point(288, 270);
			this.getDebtorsListRadioButton.Name = "getDebtorsListRadioButton";
			this.getDebtorsListRadioButton.Size = new System.Drawing.Size(95, 17);
			this.getDebtorsListRadioButton.TabIndex = 2;
			this.getDebtorsListRadioButton.TabStop = true;
			this.getDebtorsListRadioButton.Text = "GetDebtorsList";
			this.getDebtorsListRadioButton.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.richTextBox1.Location = new System.Drawing.Point(86, 58);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(569, 56);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "По рег. номеру издателя построить список авторов вместе с количеством книг этих а" +
    "второв, изданных указанным издателем";
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Location = new System.Drawing.Point(86, 174);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(529, 54);
			this.richTextBox2.TabIndex = 4;
			this.richTextBox2.Text = "По заданному читателю возвращает все записи о выдаче книг этому читателю";
			// 
			// richTextBox3
			// 
			this.richTextBox3.BackColor = System.Drawing.SystemColors.Menu;
			this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox3.Location = new System.Drawing.Point(86, 293);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(539, 50);
			this.richTextBox3.TabIndex = 5;
			this.richTextBox3.Text = "Построить список читателей, просрочивщих возврат книг";
			// 
			// acceptButton
			// 
			this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.acceptButton.Location = new System.Drawing.Point(580, 379);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(75, 23);
			this.acceptButton.TabIndex = 6;
			this.acceptButton.Text = "Выполнить";
			this.acceptButton.UseVisualStyleBackColor = true;
			this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
			// 
			// publisherTextBox
			// 
			this.publisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.publisherTextBox.Location = new System.Drawing.Point(462, 32);
			this.publisherTextBox.Name = "publisherTextBox";
			this.publisherTextBox.Size = new System.Drawing.Size(192, 20);
			this.publisherTextBox.TabIndex = 7;
			// 
			// readerTextBox
			// 
			this.readerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.readerTextBox.Location = new System.Drawing.Point(462, 148);
			this.readerTextBox.Name = "readerTextBox";
			this.readerTextBox.Size = new System.Drawing.Size(192, 20);
			this.readerTextBox.TabIndex = 8;
			// 
			// ReportsMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 442);
			this.Controls.Add(this.readerTextBox);
			this.Controls.Add(this.publisherTextBox);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.getDebtorsListRadioButton);
			this.Controls.Add(this.getReaderHistoryRadioButton);
			this.Controls.Add(this.getAuthorsCopiesByPublisherRadioButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ReportsMenuForm";
			this.Text = "ReportsMenuForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton getAuthorsCopiesByPublisherRadioButton;
		private System.Windows.Forms.RadioButton getReaderHistoryRadioButton;
		private System.Windows.Forms.RadioButton getDebtorsListRadioButton;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.TextBox publisherTextBox;
		private System.Windows.Forms.TextBox readerTextBox;
	}
}