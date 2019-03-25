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
	public partial class Search : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
		public Search()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			//try
			//{
			//	SqlConnection sqlconn = new SqlConnection(ConnectionString);
			//	sqlconn.Open();
			//	SqlDataAdapter oda6 = new SqlDataAdapter(@"SELECT * From Товар Where Название LIKE N'" + textBox1.Text + "%' ;", sqlconn);
			//	DataTable dt = new DataTable();
			//	oda6.Fill(dt);
			//	dataGridView1.DataSource = dt;
			//	sqlconn.Close();
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(@"Error: " + ex.Message);
			//}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			//try
			//{
			//	SqlConnection sqlconn = new SqlConnection(ConnectionString);
			//	sqlconn.Open();
			//	SqlDataAdapter oda6 = new SqlDataAdapter(@"SELECT * From Клиенты Where ФИО LIKE N'" + textBox1.Text + "%' ;", sqlconn);
			//	DataTable dt = new DataTable();
			//	oda6.Fill(dt);
			//	dataGridView1.DataSource = dt;
			//	sqlconn.Close();
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(@"Error: " + ex.Message);
			//}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				try
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					sqlconn.Open();
					SqlDataAdapter oda6 = new SqlDataAdapter(@"SELECT * From Товар Where Название LIKE N'%" + textBox1.Text + "%' ;", sqlconn);
					DataTable dt = new DataTable();
					oda6.Fill(dt);
					dataGridView1.DataSource = dt;
					sqlconn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(@"Error: " + ex.Message);
				}
			}
			if (radioButton2.Checked == true){
				try
				{
					SqlConnection sqlconn = new SqlConnection(ConnectionString);
					sqlconn.Open();
					SqlDataAdapter oda6 = new SqlDataAdapter(@"SELECT * From Клиенты Where ФИО LIKE N'%" + textBox1.Text + "%' ;", sqlconn);
					DataTable dt = new DataTable();
					oda6.Fill(dt);
					dataGridView1.DataSource = dt;
					sqlconn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(@"Error: " + ex.Message);
				}
			}

		}

		private void Search_Load(object sender, EventArgs e)
		{
			timer1.Interval = 100;
			timer1.Start();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			label2.Text = "OFF";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Start();
			label2.Text = "ON";
		}
	}
}
