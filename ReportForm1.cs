using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DbGui
{
	public partial class ReportForm1 : Form
	{
		private DataGridView dataGridView;
		DataBaseController db;
		private const string storeProcName = "usp_GetDebtorsList";

		public ReportForm1()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterParent;

			dataGridView = new DataGridView();
			dataGridView.BackgroundColor = Color.WhiteSmoke;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.ScrollBars = ScrollBars.Both;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			Controls.Add(dataGridView);

			db = new DataBaseController();
			DisplayDebtorsTable(CallStoredProc());
		}

		private List<string> CallStoredProc()
		{
			string data = "";

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(storeProcName, db.sqlConnection))
				{
					command.CommandType = CommandType.StoredProcedure;

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.Output;
					returnValue.SqlDbType = SqlDbType.NVarChar;
					returnValue.ParameterName = "@ticketsList";
					returnValue.Size = -1;
					command.Parameters.Add(returnValue);

					command.ExecuteNonQuery();

					data = command.Parameters["@ticketsList"].Value.ToString();
					
				}

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}

			return data.Split(';').ToList(); ;
		}


		private void DisplayDebtorsTable(List<string> ticketsList)
		{
			string readersTable = "Readers";
			string sqlQuery = $"SELECT * FROM {readersTable} WHERE TicketNumber IN ({String.Join(", ", ticketsList)})";

			try
			{
				db.OpenConnection();

				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
				sqlDataAdapter.SelectCommand = new SqlCommand(sqlQuery, db.sqlConnection);

				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);

				dataGridView.DataSource = dataTable;

				db.CloseConnection();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}
		}
	}
}
