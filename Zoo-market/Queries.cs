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
using System.Diagnostics;

namespace Zoo_market
{
	public partial class Queries : Form
	{

		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";

		public Queries()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string date1 = dateTimePicker1.Value.ToString().Split(' ')[0];
			string date11 = date1[6].ToString() + date1[7].ToString()+ date1[8].ToString()+ date1[9].ToString()+ date1[5].ToString()+ date1[3].ToString()+ date1[4].ToString()+ date1[2].ToString()+ date1[0].ToString()+ date1[1].ToString();
			string date2 = dateTimePicker2.Value.ToString().Split(' ')[0];
			string date12 = date2[6].ToString() + date2[7].ToString() + date2[8].ToString() + date2[9].ToString() + date2[5].ToString() + date2[3].ToString() + date2[4].ToString() + date2[2].ToString() + date2[0].ToString() + date2[1].ToString();

			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();

				String request = @"SELECT sum((Цена * [Покупки].[Количество])) AS Прибыль From Товар,Покупки,Чеки Where ( ([Товар].[Id_Товара] = [Покупки].[Id_Товара]) AND 
			            (Чеки.Id_Чека = Покупки.Id_Чека) AND ([Чеки].[Дата формирования] >= '" + date11 + "') AND ([Чеки].[Дата формирования] <= '" + date12 + "') );";
				SqlDataAdapter oda1 = new SqlDataAdapter(request, sqlconn);
				DataTable dt = new DataTable();
				oda1.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}


		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda2 = new SqlDataAdapter("SELECT ФИО, Скидка From Клиенты WHERE [Количество чеков]>=5;", sqlconn);
				DataTable dt = new DataTable();
				oda2.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda3 = new SqlDataAdapter(@" SELECT  ФИО, Товар.Id_Товара, Название From Товар, Клиенты, Покупки, Чеки, Животные
WHERE Покупки.Id_Чека = Чеки.Id_Чека AND
Чеки.Id_Клиента = Клиенты.Id_Клиента AND Покупки.Id_Товара = Товар.Id_Товара AND Товар.Id_Товара = Животные.Id_Товара;", sqlconn);
				DataTable dt = new DataTable();
				oda3.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void Queries_Load(object sender, EventArgs e)
		{
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.Value.ToShortDateString();
			dateTimePicker1.MaxDate = DateTime.Today;
			dateTimePicker2.CustomFormat = "yyyy.MM.dd";
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.Value.ToShortDateString();
			dateTimePicker2.MaxDate = DateTime.Today;
		}
	}
}
