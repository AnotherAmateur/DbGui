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

			if (DataBaseController.ExceptionMessage is null)
			{
				if (DataBaseController.IsAdministrator == true)
				{
					MessageBox.Show("Вход выполнен. Выданы права администратора.");
					Application.Run(new MainFormAdmin());
				}
				else
				{
					MessageBox.Show("Вход выполнен. Выданы ограниченные права.");
					Application.Run(new MainFormUser());
				}			
			}
		}
	}
}
