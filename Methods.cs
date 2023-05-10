using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace DbGui
{
	internal static class Methods
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
	}
}
