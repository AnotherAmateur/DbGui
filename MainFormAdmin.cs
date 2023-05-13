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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbGui
{
	public partial class MainFormAdmin : Form
	{
		private DataBaseController db;
		private string currentTableName;
		private string columnToSearch;
		SqlDataAdapter sqlDataAdapter;
		DataTable dataTable;


		public MainFormAdmin()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;
			this.db = new DataBaseController();
			this.Text = "Система управления библиотекой";
			this.dataGridView.DataBindingComplete +=
			new DataGridViewBindingCompleteEventHandler(DataBindingComplete);

			InitializeData();
			SetUpAdminOperations();
		}


		private void SetUpAdminOperations()
		{
			////////////////////////////
		}


		private void InitializeData()
		{
			currentTableName = UpdateAvailableTables().FirstOrDefault();
			tableSelectedLabel.Text = currentTableName;
			RefreshDataGridView();
			AddColumnsToSearch();
			var temp = new ToolStripMenuItem();
			temp.Name = dataGridView.Columns[0].Name;
			searchByColumn_Click(temp, null);
		}


		private void tableSelect_Click(object sender, EventArgs e)
		{
			currentTableName = (sender as ToolStripItem).Name;
			tableSelectedLabel.Text = currentTableName;

			RefreshDataGridView();

			AddColumnsToSearch();
			var temp = new ToolStripMenuItem();
			temp.Name = dataGridView.Columns[0].Name;
			searchByColumn_Click(temp, null);
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


		private void RefreshDataGridView()
		{
			//dataGridView.Columns.Clear();

			searchTextBox.Text = "";
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.ScrollBars = ScrollBars.Both;

			string queryString =
				"SELECT TOP 100 * " +
				$"FROM {currentTableName} ";

			sqlDataAdapter = new SqlDataAdapter();
			sqlDataAdapter.SelectCommand = new SqlCommand(queryString, db.sqlConnection);

			dataTable = new DataTable();

			db.OpenConnection();

			sqlDataAdapter.Fill(dataTable);

			db.CloseConnection();

			dataGridView.DataSource = dataTable;


			//try
			//{
			//	using (SqlDataReader reader = command.ExecuteReader())
			//	{
			//		var dataTable = new DataTable();
			//		dataTable.Load(reader);
			//		dataTable.TableName = currentTableName;
			//		dataGridView.DataSource = dataTable;
			//	}
			//}
			//catch (SqlException ex)
			//{
			//	MessageBox.Show("Caught on an Error: " + ex);
			//}

		}


		private void refreshButton_Click(object sender, EventArgs e)
		{
			string currentTableName = ((DataTable)dataGridView.DataSource).TableName;
			RefreshDataGridView();
		}


		private void insertDataButton_Click(object sender, EventArgs e)
		{
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


		private void AddColumnsToSearch()
		{
			searchMenuStrip.Items.Clear();

			ToolStripMenuItem fileItem = new ToolStripMenuItem("Поиск по столбцу");

			foreach (DataGridViewTextBoxColumn item in dataGridView.Columns)
			{
				var toolStripItem = fileItem.DropDownItems.Add(item.Name);
				toolStripItem.Name = item.Name;
				toolStripItem.Click += new EventHandler(searchByColumn_Click);
			}

			searchMenuStrip.Items.Add(fileItem);
		}


		private void searchByColumn_Click(object sender, EventArgs e)
		{
			searchTextBox.Text = "";
			columnToSearch = (sender as ToolStripItem).Name;
			selectedTableLabel.Text = columnToSearch;
		}


		private void searchTextBox_TextChanged(object sender, EventArgs e)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = dataGridView.DataSource;
			bs.Filter = $"Convert({columnToSearch}, 'System.String') like '{searchTextBox.Text}%'";
			dataGridView.DataSource = bs.DataSource;
		}


		private void deleteRowButton_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView.SelectedRows)
			{
				dataGridView.Rows.RemoveAt(row.Index);
			}
		}


		private void saveChangesButton_Click(object sender, EventArgs e)
		{
			var changes = ((DataTable)dataGridView.DataSource).GetChanges();
			if (changes is null)
			{
				MessageBox.Show("Изменений не было");
				return;
			}

			try
			{
				MessageBox.Show("Ожидайте уведомления о завершении фиксации");

				db.OpenConnection();

				sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
				int rowCount = sqlDataAdapter.Update(changes);
				MessageBox.Show($"Обновлено строк: {rowCount.ToString()}");

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Caught on an Error: " + ex);
			}

		}
	}
}
