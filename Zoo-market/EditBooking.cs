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
	public partial class EditBooking : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
		public EditBooking()
		{
			InitializeComponent();
			заказыTableAdapter.Fill(dBDataSet.Заказы);
			товарTableAdapter.Fill(dBDataSet.Товар);
			поставщикиTableAdapter.Fill(dBDataSet.Поставщики);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string date = dateTimePicker1.Value.ToString().Split(' ')[0];
			if (textBox3.Text != "" && Convert.ToInt32(textBox3.Text) <= 100 && Convert.ToInt32(textBox3.Text) > 0)
			{
				заказыTableAdapter.Insert(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToDateTime(date), Convert.ToInt32(textBox3.Text));
				Close();
			}
			else
				MessageBox.Show("Не все поля заполены или Количество не в диапозоне от 1 до 100!");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void EditBooking_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
			this.поставщикиTableAdapter.Fill(this.dBDataSet.Поставщики);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Заказы". При необходимости она может быть перемещена или удалена.
			this.заказыTableAdapter.Fill(this.dBDataSet.Заказы);
			timer1.Interval = 100;
			timer1.Start();

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			SqlConnection conn1 = new SqlConnection(ConnectionString);
			conn1.Open();
			string sql1 = "Select Название From Товар Where Id_Товара = " + Convert.ToInt32(comboBox1.SelectedValue) + ";";
			SqlCommand command1 = new SqlCommand(sql1, conn1);
			label5.Text = command1.ExecuteScalar().ToString();
			conn1.Close();

			SqlConnection conn2 = new SqlConnection(ConnectionString);
			conn2.Open();
			string sql2 = "Select [Название фирмы] From Поставщики Where Id_Поставщика = " + Convert.ToInt32(comboBox2.SelectedValue) + ";";
			SqlCommand command2 = new SqlCommand(sql2, conn2);
			label6.Text = command2.ExecuteScalar().ToString();
			conn2.Close();
		}
	}
}
