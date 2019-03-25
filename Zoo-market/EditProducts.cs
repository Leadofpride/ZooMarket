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
	public partial class EditProducts : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
		private readonly int id;
		readonly bool edit;
		public EditProducts()
		{
			InitializeComponent();
		    товарTableAdapter.Fill(dBDataSet.Товар);
			животныеTableAdapter.Fill(dBDataSet.Животные);
			кормTableAdapter.Fill(dBDataSet.Корм);
			подвидыTableAdapter.Fill(dBDataSet.Подвиды);
			edit = false;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			textBox4.Text = "Животные";
			label6.Visible = true;
			label7.Visible = true;
			label8.Visible = true;
			textBox6.Visible = true;
			dateTimePicker1.Visible = true;
			comboBox1.Visible = true;

			label9.Visible = false;
			label10.Visible = false;
			label11.Visible = false;
			label12.Visible = false;
			textBox7.Visible = false;
			comboBox2.Visible = false;
			textBox8.Visible = false;
			comboBox3.Visible = false;

			button3.Visible = false;
			button1.Enabled = true;
			button2.Enabled = true;

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			textBox4.Text = "Корм";
			label6.Visible = false;
			label7.Visible = false;
			label8.Visible = false;
			textBox6.Visible = false;
			dateTimePicker1.Visible = false;
			comboBox1.Visible = false;

			label9.Visible = true;
			label10.Visible = true;
			label11.Visible = true;
			label12.Visible = true;
			textBox7.Visible = true;
			comboBox2.Visible = true;
			textBox8.Visible = true;
			comboBox3.Visible = true;

			button3.Visible = false;
			button1.Enabled = true;
			button2.Enabled = true;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			textBox4.Text = "Другое";
			label6.Visible = false;
			label7.Visible = false;
			label8.Visible = false;
			textBox6.Visible = false;
			dateTimePicker1.Visible = false;
			comboBox1.Visible = false;

			label9.Visible = false;
			label10.Visible = false;
			label11.Visible = false;
			label12.Visible = false;
			textBox7.Visible = false;
			comboBox2.Visible = false;
			textBox8.Visible = false;
			comboBox3.Visible = false;

			button3.Visible = true;
			button1.Enabled = false;
			button2.Enabled = false;

		}

		private void EditProducts_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Корм". При необходимости она может быть перемещена или удалена.
			this.кормTableAdapter.Fill(this.dBDataSet.Корм);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Животные". При необходимости она может быть перемещена или удалена.
			this.животныеTableAdapter.Fill(this.dBDataSet.Животные);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Подвиды". При необходимости она может быть перемещена или удалена.
			this.подвидыTableAdapter.Fill(this.dBDataSet.Подвиды);
			dateTimePicker1.MaxDate = DateTime.Today;
			timer1.Interval = 100;
			timer1.Start();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox3.Text != "" && textBox5.Text != "")
			{
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;
				radioButton3.Enabled = false;
				textBox1.Enabled = false;
				textBox3.Enabled = false;
				textBox5.Enabled = false;
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Visible = true;
				textBox6.Enabled = false;
				textBox7.Enabled = false;
				textBox8.Enabled = true;
				comboBox1.Enabled = true;
				comboBox2.Enabled = true;
				comboBox3.Enabled = true;
				dateTimePicker1.Enabled = true;
				label13.Visible = true;
				SqlConnection conn = new SqlConnection(ConnectionString);
				conn.Open();
				string sql = "Select Max(Id_Товара) From Товар;";
				SqlCommand command = new SqlCommand(sql, conn);
				int newid = Convert.ToInt32(command.ExecuteScalar()) + 1;
				textBox6.Text = newid.ToString();
			    textBox7.Text = newid.ToString();
				conn.Close();
				товарTableAdapter.Insert(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox3.Text), textBox4.Text, textBox5.Text);

			}
			else
				MessageBox.Show("Не все поля запонены!");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				if (textBox6.Text != "" && comboBox1.SelectedValue.ToString() != "")
				{
					животныеTableAdapter.Insert(Convert.ToInt32(textBox6.Text), dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue));
					Close();
				}
				else
					MessageBox.Show("Не все поля заполнены!");
			}
			if (radioButton2.Checked == true)
			{
				if (textBox7.Text != "" && textBox8.Text != "")
				{
					кормTableAdapter.Insert(Convert.ToInt32(textBox7.Text), comboBox2.SelectedItem.ToString(), Convert.ToInt32(textBox8.Text), Convert.ToInt32(comboBox3.SelectedValue));
					Close();
				}
				else
					MessageBox.Show("Не все поля заполнены!");
			}
			if (radioButton3.Checked == true)
			{
				if (textBox1.Text != "" && textBox3.Text != "" && textBox5.Text != "")
				{
					товарTableAdapter.Insert(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox3.Text), textBox4.Text, textBox5.Text);
					Close();
				}
				else
					MessageBox.Show("Не все поля запонены!");
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				SqlConnection conn1 = new SqlConnection(ConnectionString);
				conn1.Open();
				string sql1 = "Select Подвид From Подвиды Where Id_Подвида = " + Convert.ToInt32(comboBox1.SelectedValue) + ";";
				SqlCommand command1 = new SqlCommand(sql1, conn1);
				var xx = (command1.ExecuteScalar());
				Debug.Write(xx);
				label13.Text = command1.ExecuteScalar().ToString();
				conn1.Close();
			}
			if (radioButton2.Checked == true)
			{
				SqlConnection conn1 = new SqlConnection(ConnectionString);
				conn1.Open();
				string sql1 = "Select Подвид From Подвиды Where Id_Подвида = " + Convert.ToInt32(comboBox3.SelectedValue) + ";";
				SqlCommand command1 = new SqlCommand(sql1, conn1);
				label13.Text = command1.ExecuteScalar().ToString();
				conn1.Close();
			}
		}
	}
}
