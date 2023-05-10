using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbGui
{
	internal static class Program
	{
		public static string ConnectionString { get; set; }

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			LoginForm loginForm = new LoginForm();
			Application.Run(loginForm);

			if (loginForm.LoginSuccess == true)
			{
				Application.Run(new MainForm());
			}
		}
	}
}
