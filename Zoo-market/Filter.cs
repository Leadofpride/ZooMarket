using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zoo_market
{
	public partial class Filter : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";

		public Filter()
		{
			InitializeComponent();
		}

		private void Filter_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda5 = new SqlDataAdapter(@"SELECT * FROM Товар, Животные WHERE Товар.Id_Товара = Животные.Id_Товара;", sqlconn);
				DataTable dt = new DataTable();
				oda5.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda5 = new SqlDataAdapter(@"SELECT * FROM Товар, Корм WHERE Товар.Id_Товара = Корм.Id_Товара;", sqlconn);
				DataTable dt = new DataTable();
				oda5.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda5 = new SqlDataAdapter(@"Select * From Товар Where Товар.Категория Like N'%Другое%';", sqlconn);
				DataTable dt = new DataTable();
				oda5.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}
	}
}
