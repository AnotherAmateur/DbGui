using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbGui
{
	public partial class MainFormAdmin : Form
	{
		string connectionString;
		public MainFormAdmin()
		{
			connectionString = Methods.GetSetConnectionString();
			InitializeComponent();
			InitializeData();
		}

		private void InitializeData()
		{
			
		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void dfgToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
