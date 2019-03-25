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
	public partial class Buy : Form
	{

		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
		private readonly int id;
		decimal sum;
		int minus;
		int kolvo;
		public Buy()
		{
			InitializeComponent();
			чекиTableAdapter.Fill(dBDataSet.Чеки);
			покупкиTableAdapter.Fill(dBDataSet.Покупки);
			товарTableAdapter.Fill(dBDataSet.Товар);
			продавцыTableAdapter.Fill(dBDataSet.Продавцы);
			клиентыTableAdapter.Fill(dBDataSet.Клиенты);
		}

		private void Buy_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Чеки". При необходимости она может быть перемещена или удалена.
			this.чекиTableAdapter.Fill(this.dBDataSet.Чеки);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Покупки". При необходимости она может быть перемещена или удалена.
			this.покупкиTableAdapter.Fill(this.dBDataSet.Покупки);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
			this.продавцыTableAdapter.Fill(this.dBDataSet.Продавцы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.dBDataSet.Клиенты);
			timer1.Interval = 100;
			timer1.Start();

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			SqlConnection conn1 = new SqlConnection(ConnectionString);
			conn1.Open();
			string sql1 = "Select ФИО From Клиенты Where Id_Клиента = " + Convert.ToInt32(comboBox1.SelectedValue) + ";";
			SqlCommand command1 = new SqlCommand(sql1, conn1);
			label4.Text = command1.ExecuteScalar().ToString();
			conn1.Close();

			SqlConnection conn2 = new SqlConnection(ConnectionString);
			conn2.Open();
			string sql2 = "Select ФИО From Продавцы Where Id_Продавца = " + Convert.ToInt32(comboBox2.SelectedValue) + ";";
			SqlCommand command2 = new SqlCommand(sql2, conn2);
			label5.Text = command2.ExecuteScalar().ToString();
			conn2.Close();

			SqlConnection conn3 = new SqlConnection(ConnectionString);
			conn3.Open();
			string sql3 = "Select Название From Товар Where Id_Товара = " + Convert.ToInt32(comboBox3.SelectedValue) + ";";
			SqlCommand command3 = new SqlCommand(sql3, conn3);
			label8.Text = command3.ExecuteScalar().ToString();
			conn3.Close();

			SqlConnection conn4 = new SqlConnection(ConnectionString);
			conn4.Open();
			string sql4 = "Select Количество From Товар Where Id_Товара = " + Convert.ToInt32(comboBox3.SelectedValue) + ";";
			SqlCommand command4 = new SqlCommand(sql4, conn4);
			textBox3.Text = command4.ExecuteScalar().ToString();
			conn4.Close();

			SqlConnection conn5 = new SqlConnection(ConnectionString);
			conn5.Open();
			string sql5 = "Select Цена From Товар Where Id_Товара = " + Convert.ToInt32(comboBox3.SelectedValue) + ";";
			SqlCommand command5 = new SqlCommand(sql5, conn5);
			textBox4.Text = command5.ExecuteScalar().ToString();
			conn5.Close();

			SqlConnection conn6 = new SqlConnection(ConnectionString);
			conn6.Open();
			string sql6 = "Select [Количество чеков] From Клиенты Where Id_Клиента = " + Convert.ToInt32(comboBox1.SelectedValue) + ";";
			SqlCommand command6 = new SqlCommand(sql6, conn6);
			textBox6.Text = command6.ExecuteScalar().ToString();
			conn6.Close();

			if(Convert.ToInt32(textBox6.Text) >= 5)
			{
				textBox2.Text = 10.ToString();
			}
			else
				textBox2.Text = 0.ToString();
			sum = Convert.ToDecimal(listBox1.SelectedItem) * Convert.ToDecimal(textBox4.Text);
			sum = sum - sum / 100 * Convert.ToInt32(textBox2.Text);
			textBox5.Text = sum.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			comboBox1.Enabled = false;
			comboBox2.Enabled = false;
			button1.Enabled = false;
			button2.Enabled = false;
			textBox2.Enabled = false;
			textBox6.Enabled = false;
			comboBox3.Enabled = true;
			listBox1.Enabled = true;
			textBox3.Enabled = true;
			textBox4.Enabled = true;
			textBox5.Enabled = true;
			button3.Enabled = true;

			SqlConnection conn = new SqlConnection(ConnectionString);
			conn.Open();
			string sql = "Select Max(Id_Чека) From Чеки;";
			SqlCommand command = new SqlCommand(sql, conn);
			int newid = Convert.ToInt32(command.ExecuteScalar()) + 1;
			textBox1.Text = newid.ToString();
			conn.Close();
			string date = dateTimePicker1.Value.ToString().Split(' ')[0];
			чекиTableAdapter.Insert(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToDateTime(date));
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			minus = Convert.ToInt32(textBox3.Text) - Convert.ToInt32(listBox1.SelectedItem);
			kolvo = Convert.ToInt32(textBox6.Text) + 1;
			if (Convert.ToInt32(listBox1.SelectedItem) != 0 && Convert.ToInt32(listBox1.SelectedItem) > 0 && Convert.ToInt32(listBox1.SelectedItem) <= Convert.ToInt32(textBox3.Text))
			{
				покупкиTableAdapter.Insert(Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(textBox1.Text), Convert.ToInt32(listBox1.SelectedItem));
				SqlConnection conn = new SqlConnection(ConnectionString);
				conn.Open();
				string sql = "UPDATE Товар SET  [Количество] = "+ minus.ToString() +" WHERE Id_Товара = "+ comboBox3.SelectedValue.ToString() + ";";
				SqlCommand command = new SqlCommand(sql, conn);
				int n = command.ExecuteNonQuery();
				conn.Close();
				SqlConnection conn1 = new SqlConnection(ConnectionString);
				conn1.Open();
				string sql1 = "UPDATE Клиенты SET  [Количество чеков] = " + kolvo.ToString() + " WHERE Id_Клиента = " + comboBox1.SelectedValue.ToString() + ";";
				SqlCommand command1 = new SqlCommand(sql1, conn1);
				int n1 = command1.ExecuteNonQuery();
				conn1.Close();
				SqlConnection conn2 = new SqlConnection(ConnectionString);
				conn2.Open();
				string sql2 = "UPDATE Клиенты SET  [Скидка] = " + textBox2.Text + " WHERE Id_Клиента = " + comboBox1.SelectedValue.ToString() + ";";
				SqlCommand command2 = new SqlCommand(sql2, conn2);
				int n2 = command2.ExecuteNonQuery();
				conn2.Close();
				MessageBox.Show("Спасибо за покупку!");
				Close();

			}
			else
				MessageBox.Show("Ошибка заполнения!");
		}

		private void Buy_FormClosing(object sender, FormClosingEventArgs e)
		{
			чекиTableAdapter.Update(dBDataSet);
			клиентыTableAdapter.Update(dBDataSet);
			товарTableAdapter.Update(dBDataSet);
			продавцыTableAdapter.Update(dBDataSet);
			покупкиTableAdapter.Update(dBDataSet);
		}
	}
	
}
