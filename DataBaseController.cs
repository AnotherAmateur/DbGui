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
		public static Dictionary<string, Dictionary<string, bool>> userPermissionsDict { get; private set; }
		public static bool IsAdministrator { get; private set; }

		public DataBaseController() { }

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
				FileManager.GetSetConnectionString(connectionString);
				sqlConnection = cn;

				return true;
				//this.Invoke(new Action(() => this.Close()));
			}
			catch (Exception ex)
			{
				throw new Exception($"OpenConnection Error: {ex.Message}");
			}
		}

		public bool OpenConnection()
		{
			string connectionString = FileManager.GetSetConnectionString();

			SqlConnection cn = new SqlConnection(connectionString);
			try
			{
				cn.Open();
				sqlConnection = cn;

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception($"OpenConnection Error: {ex.Message}");
			}
		}


		public bool CloseConnection()
		{
			if (sqlConnection is null is false && sqlConnection.State != System.Data.ConnectionState.Closed)
			{
				try
				{
					sqlConnection.Close();
				}
				catch (SqlException ex)
				{
					throw new Exception($"CloseConnection Error: {ex.Message}");
				}
			}

			return true;
		}

		public static bool TryLoadUserPermissions()
		{
			try
			{
				userPermissionsDict = FileManager.GetUserPermission();
			}
			catch (Exception ex)
			{
				throw new Exception($"Can`t load user permissions: {ex.Message}");
			}

			return true;
		}
	}
}

