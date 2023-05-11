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

		public MainFormAdmin()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.db = new DataBaseController();
			this.Text = "Система управления библиотекой";
			this.dataGridView.DataBindingComplete +=
			new DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
			InitializeData();
			SetUpAdminOperations();
		}

		private void SetUpAdminOperations()
		{
			////////////////////////////
		}


		private void InitializeData()
		{
			string initTable = UpdateAvailableTables().FirstOrDefault();
			tableSelectedLabel.Text = initTable;			
			RefreshDataGridView(initTable);
		}


		private void tableSelect_Click(object sender, EventArgs e)
		{
			string tableName = (sender as ToolStripItem).Name;
			tableSelectedLabel.Text = tableName;
			RefreshDataGridView(tableName);
		}


		private List<string> UpdateAvailableTables()
		{
			var tableNames = new List<string>();
			ToolStripMenuItem fileItem = new ToolStripMenuItem("Таблицы");

			string queryString =
				"SELECT TABLE_NAME " +
				"FROM INFORMATION_SCHEMA.TABLES " +
				"WHERE TABLE_TYPE LIKE '%TABLE%'";


			db.OpenConnection();
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
			db.CloseConnection();

			return tableNames;
		}


		private void RefreshDataGridView(string tableName)
		{
			//dataGridView.Columns.Clear();
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.ScrollBars = ScrollBars.Both;

			string queryString =
				"SELECT TOP 50 * " +
				$"FROM {tableName} ";

			db.OpenConnection();
			SqlCommand command = new SqlCommand(queryString, db.sqlConnection);
			try
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					var dataTable = new DataTable();
					dataTable.Load(reader);
					dataTable.TableName = tableName;
					dataGridView.DataSource = dataTable;
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Caught on an Error: " + ex);
			}

			db.CloseConnection();
		}


		private void refreshButton_Click(object sender, EventArgs e)
		{
			string currentTableName = ((DataTable)dataGridView.DataSource).TableName;
			RefreshDataGridView(currentTableName);
		}


		private void insertDataButton_Click(object sender, EventArgs e)
		{
			string currentTableName = ((DataTable)dataGridView.DataSource).TableName;
			var insertionForm = new InsertionForm(currentTableName);
			insertionForm.Location = this.Location;
			insertionForm.Show();
		}


		private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow dGVRow in this.dataGridView.Rows)
			{
				dGVRow.HeaderCell.Value = $"{dGVRow.Index + 1}";
			}

			this.dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
		}
	}
}
