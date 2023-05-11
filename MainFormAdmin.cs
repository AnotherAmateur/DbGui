using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbGui
{
	public partial class MainFormAdmin : Form
	{
		private DataBaseController db;
		public MainFormAdmin(DataBaseController db)
		{
			this.db = db;
			InitializeComponent();
			InitializeData();
		}

		private void InitializeData()
		{
			string initTable = UpdateAvailableTables().FirstOrDefault();
			RefreshDataGridView(initTable);
		}

		private void tableSelect_Click(object sender, EventArgs e)
		{
			RefreshDataGridView((sender as ToolStripItem).Name);
		}

		private List<string> UpdateAvailableTables()
		{
			var tableNames = new List<string>();
			ToolStripMenuItem fileItem = new ToolStripMenuItem("Таблицы");

			string queryString =
				"SELECT TABLE_NAME " +
				"FROM INFORMATION_SCHEMA.TABLES " +
				"WHERE TABLE_TYPE LIKE '%TABLE%'";

			SqlCommand command = new SqlCommand(queryString, db.sqlConnection);
			try
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var toolStripItem = fileItem.DropDownItems.Add(reader.GetString(0));
						toolStripItem.Name = reader.GetString(0);
						toolStripItem.Click += new EventHandler(tableSelect_Click);
						tableNames.Add(toolStripItem.Name);
					}
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error: " + ex);
			}

			tableSelectionMenuStrip.Items.Add(fileItem);

			return tableNames;
		}

		private void RefreshDataGridView(string tableName)
		{
			//dataGridView.Columns.Clear();
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.ScrollBars = ScrollBars.Both;

			string queryString =
				"SELECT TOP 100 * " +
				$"FROM {tableName} ";

			SqlCommand command = new SqlCommand(queryString, db.sqlConnection);
			try
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					var dataTable = new DataTable();
					dataTable.Load(reader);
					dataGridView.DataSource = dataTable;
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Caught on an Error: " + ex);
			}
		}

		private List<string> GetColumnNames(string tableName)
		{
			List<string> columnsList = new List<string>();

			string queryString =
				"SELECT COLUMN_NAME " +
				"FROM INFORMATION_SCHEMA.COLUMNS " +
				$"WHERE TABLE_NAME = '{tableName}'";

			SqlCommand command = new SqlCommand(queryString, db.sqlConnection);
			try
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						columnsList.Add(reader.GetString(0));
					}
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error: " + ex);
			}

			return columnsList;
		}

		private void dfgToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
