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
	public partial class ViewsForm : Form
	{
		private DataGridView dataGridViewMaster;
		private DataBaseController db;
		private string currentViewName;
		private string columnToSearch;
		SqlDataAdapter sqlDataAdapterMaster;
		DataTable dataTable;


		public ViewsForm()
		{
			InitializeComponent();

			sqlDataAdapterMaster = new SqlDataAdapter();

			dataGridViewMaster = new DataGridView();
			dataGridViewMaster.BackgroundColor = Color.WhiteSmoke;
			dataGridViewMaster.Dock = DockStyle.Fill;
			dataGridViewMaster.AllowUserToAddRows = false;
			dataGridViewMaster.AllowUserToDeleteRows = false;
			dataGridViewMaster.ScrollBars = ScrollBars.Both;
			dataGridViewMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			splitContainer.Orientation = Orientation.Horizontal;
			splitContainer.Panel1.Controls.Add(dataGridViewMaster);
			splitContainer.Panel2Collapsed = false;

			StartPosition = FormStartPosition.CenterScreen;
			db = new DataBaseController();
			Text = "Система управления библиотекой";
			dataGridViewMaster.DataBindingComplete +=
			new DataGridViewBindingCompleteEventHandler(masterDataBindingComplete);			
		}


		private void SetUpAdminOperations()
		{
			if (DataBaseController.UserType is DataBaseController.UserTypes.Other)
			{
				foreach (var tablePermissions in DataBaseController.userPermissionsDict[currentViewName])
				{
					switch (tablePermissions.Key)
					{
						case "delete":
							this.rowsDeleteButton.Enabled = tablePermissions.Value;
							break;
						case "insert":
							this.insertDataButton.Enabled = tablePermissions.Value;
							break;
						case "update":
							dataGridViewMaster.ReadOnly = !tablePermissions.Value;
							break;
						case "select":
							dataGridViewMaster.Visible = tablePermissions.Value;
							break;
						default:
							break;
					}
				}
			}
		}


		private List<string> GetPirmaryKeyColumns(string viewName)
		{
			List<string> result = new List<string>();

			db.OpenConnection();

			string sqlQuery =
				$"SELECT COLUMN_NAME" +
				$" FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE" +
				$" WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 " +
				$"AND table_name = '{viewName}'";

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
			currentViewName = (sender as ToolStripItem).Name;
			tableSelectedLabel.Text = currentViewName;

			RefreshDataGridView();
			AddColumnsToSearch();
			SetUpAdminOperations();

			var temp = new ToolStripMenuItem();
			temp.Name = dataGridViewMaster.Columns[0].Name;
			searchByColumn_Click(temp, null);
		}


		private List<string> UpdateAvailableViews()
		{
			var tableNames = new List<string>();
			ToolStripMenuItem fileItem = new ToolStripMenuItem("Представления");

			string queryString = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS";

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

			viewSelectionMenuStrip.Items.Add(fileItem);
			db.CloseConnection();

			return tableNames;
		}


		private void RefreshDataGridView()
		{
			splitContainer.Panel2Collapsed = true;

			searchTextBox.Text = "";

			string queryString =
				"SELECT TOP 100 * " +
				$"FROM {currentViewName} ";

			sqlDataAdapterMaster.SelectCommand = new SqlCommand(queryString, db.sqlConnection);

			dataTable = new DataTable();

			try
			{
				db.OpenConnection();

				sqlDataAdapterMaster.Fill(dataTable);

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			dataGridViewMaster.DataSource = dataTable;
		}


		private void refreshButton_Click(object sender, EventArgs e)
		{
			RefreshDataGridView();
		}


		private void insertDataButton_Click(object sender, EventArgs e)
		{
			var insertionForm = new InsertionForm(currentViewName);
			insertionForm.Location = this.Location;
			insertionForm.ShowDialog();
		}


		private void masterDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow dGVRow in this.dataGridViewMaster.Rows)
			{
				dGVRow.HeaderCell.Value = $"{dGVRow.Index + 1}";
			}

			this.dataGridViewMaster.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
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
			bs.Filter = $"Convert({columnToSearch}, 'System.String') like '%{searchTextBox.Text}%'";
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

			MessageBox.Show("Ожидайте уведомления о завершении фиксации");

			try
			{
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
			currentViewName = UpdateAvailableViews().FirstOrDefault();
			tableSelectedLabel.Text = currentViewName;
			RefreshDataGridView();
			AddColumnsToSearch();

			var temp = new ToolStripMenuItem();
			temp.Name = dataGridViewMaster.Columns[0].Name;
			searchByColumn_Click(temp, null);
		}


		private void rowsDeleteButton_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridViewMaster.SelectedRows)
			{
				dataGridViewMaster.Rows.RemoveAt(row.Index);
			}
		}

		private void ViewsForm_Load(object sender, EventArgs e)
		{
			currentViewName = UpdateAvailableViews().FirstOrDefault();
			tableSelectedLabel.Text = currentViewName;
			RefreshDataGridView();
			AddColumnsToSearch();
			SetUpAdminOperations();

			var temp = new ToolStripMenuItem();
			temp.Name = dataGridViewMaster.Columns[0].Name;
			searchByColumn_Click(temp, null);
		}
	}
}
