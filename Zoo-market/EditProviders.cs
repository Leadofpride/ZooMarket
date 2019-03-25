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
	public partial class EditProviders : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";

		private int id;
	    bool edit;
		private int idtov;
		public EditProviders()
		{
			InitializeComponent();
			товарTableAdapter.Fill(dBDataSet.Товар);
			поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
			edit = false;
		}
		public EditProviders(int id, string firma, int idtov) : this(){
			товарTableAdapter.Fill(dBDataSet.Товар);
			поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
			edit = true;
			this.id = id;
			textBox1.Text = firma;
			this.idtov = idtov;
			
		}

		private void EditProviders_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
			this.поставщикиTableAdapter.Fill(this.dBDataSet.Поставщики);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);
			comboBox1.SelectedValue = idtov;
			if (edit == false) {
				comboBox1.SelectedValue = 1;
			}
			button2.Enabled = false;
			timer1.Interval = 100;
			timer1.Start();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (edit)
			{
				if (textBox1.Text != "")
				{
					поставщикиTableAdapter.UpdateQuery(textBox1.Text, Convert.ToInt32(comboBox1.SelectedValue), id);
					Close();
				}
				else
					MessageBox.Show(" Не все поля введены!");
				return;
			}
			else
			{
				if (textBox1.Text != "")
				{
					поставщикиTableAdapter.Insert(textBox1.Text, Convert.ToInt32(comboBox1.SelectedValue));
					Close();
				}
				else
					MessageBox.Show(" Не все поля введены!");
				return;

			}
			
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
		}
	}
}
