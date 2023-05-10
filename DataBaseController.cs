using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DbGui
{
	internal static class DataBaseController
	{
		private static SqlConnection conn;
		public static string ExceptionMessage { get; private set; }
		public static bool IsAdministrator { get; private set; }

		public static bool OpenConnection(string login, string password)
		{		
			string connectionString = "Data Source=PURPLESKY;" +
								  "Initial Catalog=LibraryBD;" +
								  $"User id={login};" +
								  $"Password={password};";

			using (SqlConnection cn = new SqlConnection(connectionString))
			{
				try
				{
					cn.Open();
					IsAdministrator = (login.Contains("_admin")) ? true : false;
					Methods.GetSetConnectionString(connectionString);
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
		}

		public static bool CloseConnection()
		{
			if (conn is null is false && conn.State != System.Data.ConnectionState.Closed)
			{
				try
				{
					conn.Close();
					ExceptionMessage = null;
				}
				catch(SqlException ex)
				{
					ExceptionMessage = ex.Message;
					return false;
				}				
			}

			return true;
		}
	}
}

