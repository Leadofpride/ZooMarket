using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_market
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
			{
				if (textBox1.Text == Convert.ToString(dataGridView1[2, i].Value) && textBox2.Text == Convert.ToString(dataGridView1[3, i].Value))
				{
					label3.Text = Convert.ToString(dataGridView1[1, i].Value);
					Form1 form = new Form1();
					Main main = new Main(label3.Text);
					Form1.ActiveForm.Visible = false;
					main.Show();
					break;
				}
				 else if (i == dataGridView1.Rows.Count - 1 || textBox1.Text == "" || textBox2.Text == "")
				 {
					MessageBox.Show("Неправильный логин или пароль");
					return;
				 }

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
			this.продавцыTableAdapter.Fill(this.dBDataSet.Продавцы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
			this.продавцыTableAdapter.Fill(this.dBDataSet.Продавцы);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "admin";
			textBox2.Text = "pass";
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyData == Keys.A)
			//	button2.Visible = false;
		}
	}
}
