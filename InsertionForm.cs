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
	public partial class InsertionForm : Form
	{
		private DataBaseController db;

		public InsertionForm(string tableName)
		{
			db = new DataBaseController();
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			InitializeFields(tableName);
		}

		private void InitializeFields(string tableName)
		{
			foreach (string column in GetColumnNames(tableName))
			{
				int clmnLen = column.Length;
				if (clmnLen > 1 && column.Substring(clmnLen - 2, 2).ToLower() == "id")
				{
					continue;
				}

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

		}

		private List<string> GetColumnNames(string tableName)
		{
			List<string> columnsList = new List<string>();

			string queryString =
				"SELECT COLUMN_NAME " +
				"FROM INFORMATION_SCHEMA.COLUMNS " +
				$"WHERE TABLE_NAME = '{tableName}'";

			db.OpenConnection();
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

			db.CloseConnection();

			return columnsList;
		}
	}
}
