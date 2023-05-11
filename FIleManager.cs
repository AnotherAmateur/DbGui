using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace DbGui
{
	internal static class FileManager
	{
		private static string connSettingName = "connectionString";

		public static string GetSetConnectionString(string value = null)
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			var entry = config.AppSettings.Settings[connSettingName];

			// save the connection string to the appconfig file
			if (value is null == false)
			{
				if (entry is null)
				{
					config.AppSettings.Settings.Add(connSettingName, value);
				}
				else
				{
					config.AppSettings.Settings[connSettingName].Value = value;
				}

				config.Save(ConfigurationSaveMode.Modified);
			}
			// return the connection string from the appconfig file
			else if (entry is null == false)
			{
				return config.AppSettings.Settings[connSettingName].Value;
			}

			return null;
		}

		public static Dictionary<string, Dictionary<string, bool>> GetUserPermission()
		{
			var dict = new Dictionary<string, Dictionary<string, bool>>();
			string filePath = "UserPermissions.dict";

			try
			{
				using (var sr = new StreamReader(filePath))
				{
					while (!sr.EndOfStream)
					{
						string[] input = sr.ReadLine().Split('/', (char)StringSplitOptions.RemoveEmptyEntries);
						dict.Add(input[0], new Dictionary<string, bool>());

						for (int i = 1; i < input.Length; i++)
						{
							string[] temp = input[i].Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
							dict[input[0]].Add(temp[0], Convert.ToBoolean(int.Parse(temp[1])));
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return dict;
		}

	}
}
