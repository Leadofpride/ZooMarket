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
	public partial class AddSet : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\narma\Desktop\ForTest\Zoo-market\DB.mdf;Integrated Security=True";
		public AddSet()
		{
			InitializeComponent();
		}

		private void AddSet_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Подвиды". При необходимости она может быть перемещена или удалена.
			this.подвидыTableAdapter.Fill(this.dBDataSet.Подвиды);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Наборы". При необходимости она может быть перемещена или удалена.
			this.наборыTableAdapter.Fill(this.dBDataSet.Наборы);
			timer1.Interval = 100;
			timer1.Start();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			наборыTableAdapter.Insert(Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue));
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			SqlConnection conn1 = new SqlConnection(ConnectionString);
			conn1.Open();
			string sql1 = "Select Название From Товар Where Id_Товара = " + Convert.ToInt32(comboBox1.SelectedValue) + ";";
			SqlCommand command1 = new SqlCommand(sql1, conn1);
			label3.Text = command1.ExecuteScalar().ToString();
			conn1.Close();

			SqlConnection conn2 = new SqlConnection(ConnectionString);
			conn2.Open();
			string sql2 = "Select Подвид From Подвиды Where Id_Подвида = " + Convert.ToInt32(comboBox2.SelectedValue) + ";";
			SqlCommand command2 = new SqlCommand(sql2, conn2);
			label4.Text = command2.ExecuteScalar().ToString();
			conn2.Close();
		}
	}
}
