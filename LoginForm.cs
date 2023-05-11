using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbGui
{
	public partial class LoginForm : Form
	{
		private DataBaseController db;
		public LoginForm(DataBaseController db)
		{
			this.db = db;
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (db.OpenConnection(loginTextBox.Text, passwordTextBox.Text) is true)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show(db.ExceptionMessage);
			}			
		}

		private void LoginForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		}

		private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				loginButton_Click(null, null);
			}
		}

		private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				loginButton_Click(null, null);
			}
		}
	}
}
