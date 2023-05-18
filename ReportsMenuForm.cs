using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DbGui
{
	public partial class ReportsMenuForm : Form
	{
		public ReportsMenuForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterParent;
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
			if (checkedButton is null)
			{
				MessageBox.Show("Не выбрана процедура");
				return;
			}

			this.WindowState = FormWindowState.Minimized;		
			switch (checkedButton.Name)
			{
				case "getDebtorsListRadioButton":					
					(new ReportForm1()).ShowDialog();
					break;
				case "getReaderHistoryRadioButton":
					//storeProcName = "usp_GetReaderHistory";
					//(new ReportForm2(this.readerTextBox.Text)).ShowDialog();
					break;
				case "getAuthorsCopiesByPublisherRadioButton":
					//storeProcName = "usp_GetAuthorsCopiesByPublisher";
					//(new ReportForm3(this.publisherTextBox.Text)).ShowDialog();
					break;
				default:
					break;
			}

			this.WindowState = FormWindowState.Normal;
		}
	}
}
