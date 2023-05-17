using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		private DataGridView dataGridViewMaster;
		private DataGridView dataGridViewRelated;
		private DataBaseController db;
		private string currentTableName;
		private string relatedTableName;
		private string columnToSearch;
		SqlDataAdapter sqlDataAdapterMaster;
		SqlDataAdapter sqlDataAdapterRelated;
		DataTable dataTable;


		public MainFormAdmin()
		{
			InitializeComponent();

			sqlDataAdapterRelated = new SqlDataAdapter();
			sqlDataAdapterMaster = new SqlDataAdapter();

			dataGridViewMaster = new DataGridView();
			dataGridViewMaster.BackgroundColor = Color.FloralWhite;
			dataGridViewMaster.Dock = DockStyle.Fill;
			dataGridViewMaster.AllowUserToAddRows = false;
			dataGridViewMaster.AllowUserToDeleteRows = false;
			dataGridViewMaster.ScrollBars = ScrollBars.Both;
			dataGridViewMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewRelated = new DataGridView();
			dataGridViewRelated.BackgroundColor = Color.WhiteSmoke;
			dataGridViewRelated.Dock = DockStyle.Fill;
			dataGridViewRelated.AllowUserToAddRows = false;
			dataGridViewRelated.AllowUserToDeleteRows = false;
			dataGridViewRelated.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewRelated.ScrollBars = ScrollBars.Both;

			splitContainer.Orientation = Orientation.Horizontal;
			splitContainer.Panel1.Controls.Add(dataGridViewMaster);
			splitContainer.Panel2.Controls.Add(dataGridViewRelated);
			splitContainer.Panel2Collapsed = false;

			StartPosition = FormStartPosition.CenterScreen;
			db = new DataBaseController();
			Text = "Система управления библиотекой";
			dataGridViewMaster.DataBindingComplete +=
			new DataGridViewBindingCompleteEventHandler(masterDataBindingComplete);
			dataGridViewRelated.DataBindingComplete +=
			new DataGridViewBindingCompleteEventHandler(relatedDataBindingComplete);

			dataGridViewMaster.SelectionChanged += new EventHandler(dataGridViewMaster_SelectionChanged);

			SetUpAdminOperations();

			FillChildernMenu();
		}


		private void SetUpAdminOperations()
		{
			////////////////////////////
			///
			/// 

		}


		private List<string> GetPirmaryKeyColumns(string tableName)
		{
			List<string> result = new List<string>();

			db.OpenConnection();

			string sqlQuery =
				$"SELECT COLUMN_NAME" +
				$" FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE" +
				$" WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 " +
				$"AND table_name = '{tableName}'";

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(sqlQuery, db.sqlConnection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							result.Add(reader.GetString(0));
						}
					}
				}

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return result;
		}


		private void tableSelect_Click(object sender, EventArgs e)
		{
			currentTableName = (sender as ToolStripItem).Name;
			tableSelectedLabel.Text = currentTableName;
			relatedTableName = null;

			RefreshDataGridView();
			FillChildernMenu();
			AddColumnsToSearch();

			splitContainer.Panel2Collapsed = true;
			dataGridViewRelated.DataSource = null;

			var temp = new ToolStripMenuItem();
			temp.Name = dataGridViewMaster.Columns[0].Name;
			searchByColumn_Click(temp, null);

			GetChildTables(currentTableName);
		}


		private List<string> UpdateAvailableTables()
		{
			var tableNames = new List<string>();
			ToolStripMenuItem fileItem = new ToolStripMenuItem("Таблицы");

			string queryString =
				"SELECT TABLE_NAME " +
				"FROM INFORMATION_SCHEMA.TABLES " +
				"WHERE TABLE_TYPE LIKE '%TABLE%'";

			try
			{
				db.OpenConnection();
				SqlCommand command = new SqlCommand(queryString, db.sqlConnection);

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
			relatedTableName = null;

			splitContainer.Panel2Collapsed = true;
			dataGridViewRelated.DataSource = null;

			searchTextBox.Text = "";			

			string queryString =
				"SELECT TOP 100 * " +
				$"FROM {currentTableName} ";

			sqlDataAdapterMaster.SelectCommand = new SqlCommand(queryString, db.sqlConnection);

			dataTable = new DataTable();

			db.OpenConnection();

			sqlDataAdapterMaster.Fill(dataTable);

			db.CloseConnection();

			dataGridViewMaster.DataSource = dataTable;
		}


		private void refreshButton_Click(object sender, EventArgs e)
		{
			string currentTableName = ((DataTable)dataGridViewMaster.DataSource).TableName;
			RefreshDataGridView();
		}


		private void insertDataButton_Click(object sender, EventArgs e)
		{
			var insertionForm = new InsertionForm(currentTableName);
			insertionForm.Location = this.Location;
			insertionForm.Show();
		}


		private void masterDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow dGVRow in this.dataGridViewMaster.Rows)
			{
				dGVRow.HeaderCell.Value = $"{dGVRow.Index + 1}";
			}

			this.dataGridViewMaster.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
		}

		private void relatedDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow dGVRow in this.dataGridViewRelated.Rows)
			{
				dGVRow.HeaderCell.Value = $"{dGVRow.Index + 1}";
			}

			this.dataGridViewRelated.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
		}


		private void AddColumnsToSearch()
		{
			searchMenuStrip.Items.Clear();

			ToolStripMenuItem fileItem = new ToolStripMenuItem("Поиск по столбцу");

			foreach (DataGridViewTextBoxColumn item in dataGridViewMaster.Columns)
			{
				var toolStripItem = fileItem.DropDownItems.Add(item.Name);
				toolStripItem.Name = item.Name;
				toolStripItem.Click += new EventHandler(searchByColumn_Click);
			}

			searchMenuStrip.Items.Add(fileItem);
		}


		private void FillChildernMenu()
		{
			getChildernMenuStrip.Items.Clear();

			ToolStripMenuItem fileItem = new ToolStripMenuItem("Дети");

			foreach (var tableName in GetChildTables(currentTableName))
			{
				var toolStripItem = fileItem.DropDownItems.Add(tableName);
				toolStripItem.Name = tableName;
				toolStripItem.Click += new EventHandler(selectChild_Click);
			}

			getChildernMenuStrip.Items.Add(fileItem);
		}


		private void selectChild_Click(object sender, EventArgs e)
		{
			splitContainer.Panel2Collapsed = false;

			string selectedTableName = ((ToolStripItem)sender).Name;

			string queryString =
				"SELECT TOP 100 * " +
				$"FROM {selectedTableName}";

			sqlDataAdapterRelated = new SqlDataAdapter();
			sqlDataAdapterRelated.SelectCommand = new SqlCommand(queryString, db.sqlConnection);

			dataTable = new DataTable();

			try
			{
				db.OpenConnection();

				sqlDataAdapterRelated.Fill(dataTable);

				db.CloseConnection();

				dataGridViewRelated.DataSource = dataTable;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Caught on an Error: " + ex);
			}

			relatedTableName = selectedTableName;
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
			bs.DataSource = dataGridViewMaster.DataSource;
			bs.Filter = $"Convert({columnToSearch}, 'System.String') like '{searchTextBox.Text}%'";
			dataGridViewMaster.DataSource = bs.DataSource;
		}


		private void deleteRowButton_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridViewMaster.SelectedRows)
			{
				dataGridViewMaster.Rows.RemoveAt(row.Index);
			}
		}


		private void saveChangesButton_Click(object sender, EventArgs e)
		{
			var changes = ((DataTable)dataGridViewMaster.DataSource).GetChanges();
			if (changes is null)
			{
				MessageBox.Show("Изменений не было");
				return;
			}

			try
			{
				MessageBox.Show("Ожидайте уведомления о завершении фиксации");

				db.OpenConnection();

				sqlDataAdapterMaster.UpdateCommand = new SqlCommandBuilder(sqlDataAdapterMaster).GetUpdateCommand();
				int rowCount = sqlDataAdapterMaster.Update(changes);
				MessageBox.Show($"Обновлено строк: {rowCount.ToString()}");

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Caught on an Error: " + ex);
			}

		}


		private void MainFormAdmin_Load(object sender, EventArgs e)
		{
			currentTableName = UpdateAvailableTables().FirstOrDefault();
			tableSelectedLabel.Text = currentTableName;
			RefreshDataGridView();
			AddColumnsToSearch();
			FillChildernMenu();

			var temp = new ToolStripMenuItem();
			temp.Name = dataGridViewMaster.Columns[0].Name;
			searchByColumn_Click(temp, null);
		}


		private List<string> GetChildTables(string parentTableName)
		{
			List<string> result = new List<string>();

			try
			{
				db.OpenConnection();

				string sqlQuery =
				$@"SELECT OBJECT_NAME(fk.parent_object_id) AS ChildTableName
                    FROM sys.foreign_keys fk
                    INNER JOIN sys.tables tbl ON fk.parent_object_id = tbl.object_id
                    INNER JOIN sys.schemas sch ON tbl.schema_id = sch.schema_id
                    WHERE OBJECT_NAME(fk.referenced_object_id) = '{parentTableName}'";

				using (SqlCommand command = new SqlCommand(sqlQuery, db.sqlConnection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							string childTableName = reader["ChildTableName"].ToString();
							result.Add(childTableName);
						}
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Caught on an Error: " + ex);
			}

			return result;
		}


		private void dataGridViewMaster_SelectionChanged(object sender, EventArgs e)
		{
			if ((dataGridViewMaster.CurrentCell is null) is false && dataGridViewMaster.CurrentCell.ColumnIndex >= 0 && (relatedTableName is null) is false)
			{
				string getFKQueryString =
					"SELECT ParentPrimaryKeyColumnName AS PK" +
					", ForeignKeyColumnName AS FK " +
					"FROM (SELECT  OBJECT_NAME(fkc.parent_object_id) AS ChildTableName, " +
					"c1.name AS ForeignKeyColumnName" +
					", c2.name AS ParentPrimaryKeyColumnName " +
					"FROM sys.foreign_keys fk " +
					"INNER JOIN sys.foreign_key_columns fkc ON fk.object_id = fkc.constraint_object_id " +
					"INNER JOIN sys.columns c1 ON fkc.parent_object_id = c1.object_id AND fkc.parent_column_id = c1.column_id " +
					"INNER JOIN sys.columns c2 ON fkc.referenced_object_id = c2.object_id AND fkc.referenced_column_id = c2.column_id " +
					$"WHERE OBJECT_NAME(fk.referenced_object_id) = '{currentTableName}') AS Subquery where Subquery.ChildTableName = '{relatedTableName}'";

				try
				{
					db.OpenConnection();

					Dictionary<string, string> pairsFkPk = new Dictionary<string, string>();
					using (SqlCommand command = new SqlCommand(getFKQueryString, db.sqlConnection))
					{
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								pairsFkPk.Add(reader["FK"] as string, reader["PK"] as string);
							}
						}
					}

					Dictionary<string, string> pairsFkValue = new Dictionary<string, string>();
					foreach (var foreignKey in pairsFkPk.Keys)
					{
						pairsFkValue.Add(foreignKey, dataGridViewMaster.Rows[dataGridViewMaster.CurrentCell.RowIndex].Cells[pairsFkPk[foreignKey]].Value.ToString());
					}

					string queryString = 
						$"SELECT * FROM {relatedTableName} " +
						$"WHERE {String.Join(" AND ", pairsFkValue.Select((item) => $"{item.Key} = {item.Value}"))}";

					sqlDataAdapterRelated.SelectCommand = new SqlCommand(queryString, db.sqlConnection);

					dataTable = new DataTable();

					sqlDataAdapterRelated.Fill(dataTable);

					dataGridViewRelated.DataSource = dataTable;


					db.CloseConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Caught on an Error: " + ex);
				}
			}
		}
	}
}
