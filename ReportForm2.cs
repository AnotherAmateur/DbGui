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

namespace DbGui
{
	public partial class ReportForm2 : Form
	{
		private DataGridView dataGridView;
		DataBaseController db;
		private const string storeProcName = "usp_GetReaderHistory";

		public ReportForm2(string readerTicket)
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterParent;

			dataGridView = new DataGridView();
			dataGridView.Columns.Add("Books", $"Названия книг, прочитанных читателем с номером билета: {readerTicket}");
			dataGridView.Columns[0].Visible = true;
			dataGridView.BackgroundColor = Color.WhiteSmoke;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.ScrollBars = ScrollBars.Both;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;			
			dataGridView.AutoGenerateColumns = false;
			Controls.Add(dataGridView);
			dataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataBindingComplete);

			db = new DataBaseController();

			DisplayBooksList(CallStoredProc(readerTicket));
		}

		private List<string> CallStoredProc(string readerTicket)
		{
			string data = "";

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(storeProcName, db.sqlConnection))
				{
					command.CommandType = CommandType.StoredProcedure;

					SqlParameter inputValue = new SqlParameter();
					inputValue.Direction = ParameterDirection.Input;
					inputValue.SqlDbType = SqlDbType.Int;
					inputValue.ParameterName = "@readerID";
					inputValue.Value = readerTicket;
					command.Parameters.Add(inputValue);

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.Output;
					returnValue.SqlDbType = SqlDbType.NVarChar;
					returnValue.ParameterName = "@booksList";
					returnValue.Size = -1;
					command.Parameters.Add(returnValue);

					command.ExecuteNonQuery();

					data = command.Parameters["@booksList"].Value.ToString();

				}

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return data.Split(';').ToList(); ;
		}


		private void DisplayBooksList(List<string> books)
		{
			foreach (var book in books)
			{
				dataGridView.Rows.Add(book);
			}
		}

		private void dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow dGVRow in this.dataGridView.Rows)
			{
				dGVRow.HeaderCell.Value = $"{dGVRow.Index + 1}";
			}

			this.dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
		}
	}
}
