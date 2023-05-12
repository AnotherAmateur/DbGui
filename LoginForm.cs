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
		public LoginForm()
		{			
			InitializeComponent();
			this.Text = "Система управления библиотекой";
			StartPosition = FormStartPosition.CenterScreen;
			db = new DataBaseController();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try { db.OpenConnection(loginTextBox.Text, passwordTextBox.Text); this.Close();
				db.CloseConnection();
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Login failed. {ex.Message}");
			}			
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
