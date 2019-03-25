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
using System.Net.Mail;

namespace Zoo_market
{
	public partial class GetBooking : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
		private readonly int idza;
		int newcount;
		public GetBooking()
		{
			InitializeComponent();
			заказыTableAdapter.Fill(dBDataSet.Заказы);
			товарTableAdapter.Fill(dBDataSet.Товар);
			поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
		}
		public GetBooking(int idza, int idto, int idpo, int count) : this()
		{
			this.idza = idza;
			textBox1.Text = idto.ToString();
			textBox2.Text = idpo.ToString();
			textBox3.Text = count.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			newcount = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text);
			SqlConnection conn1 = new SqlConnection(ConnectionString);
			conn1.Open();
			string sql1 = "UPDATE Товар SET  [Количество] = " + newcount.ToString() + " WHERE Id_Товара = " + Convert.ToInt32(textBox1.Text) + ";";
			SqlCommand command = new SqlCommand(sql1, conn1);
			int n1 = command.ExecuteNonQuery();
			conn1.Close();

			SqlConnection conn2 = new SqlConnection(ConnectionString);
			conn2.Open();
			string sql2 = "DELETE FROM Заказы WHERE Id_Товара = " + Convert.ToInt32(textBox1.Text) + ";";
			SqlCommand command2 = new SqlCommand(sql2, conn2);
			int n2 = command2.ExecuteNonQuery();
			conn2.Close();

			if (textBox4.Text == "Корм")
			{
				SqlConnection conn3 = new SqlConnection(ConnectionString);
				conn3.Open();
				string sql3 = @"SELECT  Почта From Клиенты, Покупки, Чеки, Наборы, Животные
				WHERE Покупки.Id_Чека = Чеки.Id_Чека AND
				Чеки.Id_Клиента = Клиенты.Id_Клиента AND Покупки.Id_Товара = Наборы.Id_Товара AND Наборы.Id_Товара = Животные.Id_Товара AND Наборы.Id_Подвида = "+ Convert.ToInt32(textBox6.Text) +";";
				SqlCommand command3 = new SqlCommand(sql3, conn3);
				SqlDataReader reader = command3.ExecuteReader();

				while (reader.Read())
				{
					if(reader[0].ToString() != "")
					{
						MailMessage mail = new MailMessage("narmania01pride@gmail.com", reader[0].ToString(),"Новая поставка", "Новая поставка корма для Вашего питомца! Ждем Вас у нас в зоо-магазине 'NARMANDIA'.");
						SmtpClient client = new SmtpClient("smtp.gmail.com");
						client.Port = 587;
						client.Credentials = new System.Net.NetworkCredential("narmania01pride@gmail.com", "248163264pride");
						client.EnableSsl = true;
						client.Send(mail);
					}
				}
				reader.Close();
				conn3.Close();

			}
			Close();
		}

		private void GetBooking_Load(object sender, EventArgs e)
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
			string sql1 = "Select Название From Товар Where Id_Товара = " + Convert.ToInt32(textBox1.Text) + ";";
			SqlCommand command1 = new SqlCommand(sql1, conn1);
			label4.Text = command1.ExecuteScalar().ToString();
			conn1.Close();

			SqlConnection conn2 = new SqlConnection(ConnectionString);
			conn2.Open();
			string sql2 = "Select [Название фирмы] From Поставщики Where Id_Поставщика = " + Convert.ToInt32(textBox2.Text) + ";";
			SqlCommand command2 = new SqlCommand(sql2, conn2);
			label5.Text = command2.ExecuteScalar().ToString();
			conn2.Close();

			SqlConnection conn3 = new SqlConnection(ConnectionString);
			conn3.Open();
			string sql3 = "Select Категория From Товар Where Id_Товара = " + Convert.ToInt32(textBox1.Text) + ";";
			SqlCommand command3 = new SqlCommand(sql3, conn3);
			textBox4.Text = command3.ExecuteScalar().ToString();
			conn3.Close();

			SqlConnection conn4 = new SqlConnection(ConnectionString);
			conn4.Open();
			string sql4 = "Select Количество From Товар Where Id_Товара = " + Convert.ToInt32(textBox1.Text) + ";";
			SqlCommand command4 = new SqlCommand(sql4, conn4);
			textBox5.Text = command4.ExecuteScalar().ToString();
			conn4.Close();

			if(textBox4.Text == "Корм")
			{
				SqlConnection conn5 = new SqlConnection(ConnectionString);
				conn5.Open();
				string sql5 = "Select Наборы.Id_Подвида From Наборы, Корм Where Наборы.Id_Товара = "+Convert.ToInt32(textBox1.Text) + " AND Наборы.Id_Товара = Корм.Id_Товара;";
				SqlCommand command5 = new SqlCommand(sql5, conn5);
				textBox6.Text = command5.ExecuteScalar().ToString();
				conn5.Close();
			}

			if (textBox4.Text == "Животные")
			{
				SqlConnection conn5 = new SqlConnection(ConnectionString);
				conn5.Open();
				string sql5 = "Select Наборы.Id_Подвида From Наборы, Животные Where Наборы.Id_Товара = " + Convert.ToInt32(textBox1.Text) + " AND Наборы.Id_Товара = Животные.Id_Товара;";
				SqlCommand command5 = new SqlCommand(sql5, conn5);
				textBox6.Text = command5.ExecuteScalar().ToString();
				conn5.Close();
			}
		}
	}
}
