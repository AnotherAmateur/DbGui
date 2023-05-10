using Microsoft.Win32.SafeHandles;
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
	public partial class LoginForm : Form
	{
		public bool LoginSuccess { get; set; }

		public LoginForm()
		{
			LoginSuccess = false;
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
			string connectionString = "Data Source=PURPLESKY;" +
									  "Initial Catalog=LibraryBD;" +
									  $"User id={loginTextBox.Text};" +
									  $"Password={passwordTextBox.Text};";

			Thread connectThread = new Thread(() =>
			{
				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					try
					{
						cn.Open();
						LoginSuccess = true;
						Program.ConnectionString = connectionString;

						this.Invoke(new Action(() => this.Close()));
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Not connected, error: {ex.Message}");
					}
				}
			});

			connectThread.Start();
		}
	}
}
