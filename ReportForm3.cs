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
	public partial class ReportForm3 : Form
	{
		private DataGridView dataGridView;
		DataBaseController db;
		private const string storeProcName = "usp_GetAuthorsCopiesByPublisher";

		public ReportForm3(string publisher)
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterParent;

			dataGridView = new DataGridView();
			dataGridView.Columns.Add("", $"Авторы");
			dataGridView.Columns.Add("", $"Число копий книг автора, напечатанных издателем c рег. номером: {publisher}");
			//dataGridView.Columns[0].Visible = true;
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

			DisplayData(CallStoredProc(publisher));
		}

		private Dictionary<string, int> CallStoredProc(string publisher)
		{
			string data = "";
			Dictionary<string, int> result = new Dictionary<string, int>();

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(storeProcName, db.sqlConnection))
				{
					command.CommandType = CommandType.StoredProcedure;

					SqlParameter inputValue = new SqlParameter();
					inputValue.Direction = ParameterDirection.Input;
					inputValue.SqlDbType = SqlDbType.Int;
					inputValue.ParameterName = "@publisherRegNum";
					inputValue.Value = publisher;
					command.Parameters.Add(inputValue);

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.Output;
					returnValue.SqlDbType = SqlDbType.NVarChar;
					returnValue.ParameterName = "@authorsCopiesList";
					returnValue.Size = -1;
					command.Parameters.Add(returnValue);

					command.ExecuteNonQuery();

					data = command.Parameters["@authorsCopiesList"].Value.ToString();
				}

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			foreach (var item in data.Split(';'))
			{
				if (item.Length < 2)
				{
					break;
				}

				string[] tmp = item.Split('/');
				result.Add(tmp[0], int.Parse(tmp[1]));
			}

			return result;
		}


		private void DisplayData(Dictionary<string, int> authorsCopies)
		{
			foreach (var item in authorsCopies)
			{
				dataGridView.Rows.Add(item.Key, item.Value);
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
