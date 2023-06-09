﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbGui
{
	public partial class InsertionForm : Form
	{
		private DataBaseController db;
		private string tableName;
		private List<string> columnList;

		public InsertionForm(string tableName)
		{
			this.tableName = tableName;
			db = new DataBaseController();
			columnList = GetColumnNames();
			InitializeComponent();
			StartPosition = FormStartPosition.CenterParent;
			InitializeFields();
		}

		private void InitializeFields()
		{
			foreach (string column in columnList)
			{
				Label label = new Label();
				label.Text = column;
				label.Dock = DockStyle.Fill;
				label.TextAlign = ContentAlignment.MiddleRight;
				TextBox textBox = new TextBox();
				textBox.Name = column;
				textBox.Dock = DockStyle.Fill;

				tableLayoutPanel.Controls.Add(label, 0, tableLayoutPanel.RowCount - 1);
				tableLayoutPanel.Controls.Add(textBox, 1, tableLayoutPanel.RowCount - 1);

				tableLayoutPanel.RowCount++;
			}

			this.MinimumSize = new System.Drawing.Size(this.Width, tableLayoutPanel.Height + 150);
		}


		private List<string> GetPirmaryKeyColumns()
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


		private List<string> GetColumnNames()
		{
			List<string> columnsList = new List<string>();

			string queryGetColumns =
				"SELECT COLUMN_NAME " +
				"FROM INFORMATION_SCHEMA.COLUMNS " +
				$"WHERE TABLE_NAME = '{tableName}'";

			string queryCheckIdentityProp =
				"SELECT COLUMN_NAME " +
				"FROM INFORMATION_SCHEMA.COLUMNS " +
				$"WHERE TABLE_NAME = '{tableName}' AND COLUMN_NAME " +
				$"IN (SELECT name FROM sys.identity_columns WHERE OBJECT_NAME(object_id) = '{tableName}')";

			bool haveIdentityProp;

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(queryCheckIdentityProp, db.sqlConnection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						haveIdentityProp = reader.Read();
					}
				}

				using (SqlCommand command = new SqlCommand(queryGetColumns, db.sqlConnection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							string column = reader.GetString(0);
							if (haveIdentityProp && GetPirmaryKeyColumns().Contains(column))
							{
								continue;
							}

							columnsList.Add(column);
						}
					}
				}

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return columnsList;
		}


		private void insertButton_Click(object sender, EventArgs e)
		{
			List<string> values = new List<string>(columnList.Count());
			Dictionary<string, string> columnsType = GetColumnsType();

			string queryString =
				$"INSERT INTO {tableName} " +
				$"({string.Join(", ", columnList)}) " +
				$"VALUES ({string.Join(", ", columnList.Select(c => $"CONVERT({columnsType[c]}, @{c})"))})";

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(queryString, db.sqlConnection))
				{
					foreach (string column in columnList)
					{
						string value = tableLayoutPanel.Controls[column].Text;

						if (value.Length == 0)
						{
							var nullValue = DBNull.Value;
							command.Parameters.AddWithValue($"@{column}", nullValue);
							continue;
						}

						command.Parameters.AddWithValue($"@{column}", value);
					}

					command.ExecuteNonQuery();
				}

				db.CloseConnection();

				MessageBox.Show("Успешно!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private Dictionary<string, string> GetColumnsType()
		{
			Dictionary<string, string> columnsType = new Dictionary<string, string>();

			string queryString =
				"SELECT COLUMN_NAME" +
				", DATA_TYPE " +
				"FROM INFORMATION_SCHEMA.COLUMNS " +
				$"WHERE TABLE_NAME = '{tableName}'";

			try
			{
				db.OpenConnection();

				using (SqlCommand command = new SqlCommand(queryString, db.sqlConnection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							columnsType.Add(reader.GetString(0), reader.GetString(1));
						}
					}
				}

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return columnsType;
		}
	}
}
