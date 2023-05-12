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

			try
			{
				DataBaseController.TryLoadUserPermissions();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(-1);
			}

			LoginForm loginForm = new LoginForm();
			Application.Run(loginForm);

			Application.Run(new MainFormAdmin());


			//if (db.IsAdministrator == true)
			//{
			//	//MessageBox.Show("Вход выполнен. Выданы права администратора.");
			//	Application.Run(new MainFormAdmin(db));
			//}
			//else
			//{
			//	//MessageBox.Show("Вход выполнен. Выданы ограниченные права.");
			//	Application.Run(new MainFormUser());
			//}			

		}
	}
}
