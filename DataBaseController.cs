using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DbGui
{
	public class DataBaseController
	{
		public SqlConnection sqlConnection { get; private set; }
		public string ExceptionMessage { get; private set; }
		public bool IsAdministrator { get; private set; }

		public bool OpenConnection(string login, string password)
		{
			if (login == "")
			{
				login = "admin";
				password = "1234";
			}

			string connectionString = "Data Source=PURPLESKY;" +
								  "Initial Catalog=LibraryBD;" +
								  $"User id={login};" +
								  $"Password={password};";


			SqlConnection cn = new SqlConnection(connectionString);
			try
			{
				cn.Open();
				IsAdministrator = (login.Contains("_admin")) ? true : false;
				//Methods.GetSetConnectionString(connectionString);
				sqlConnection = cn;
				ExceptionMessage = null;

				return true;
				//this.Invoke(new Action(() => this.Close()));
			}
			catch (Exception ex)
			{
				ExceptionMessage = $"Not connected, error: {ex.Message}";
				return false;
			}
		}

		public bool CloseConnection()
		{
			if (sqlConnection is null is false && sqlConnection.State != System.Data.ConnectionState.Closed)
			{
				try
				{
					sqlConnection.Close();
					ExceptionMessage = null;
				}
				catch (SqlException ex)
				{
					ExceptionMessage = ex.Message;
					return false;
				}
			}

			return true;
		}
	}
}

