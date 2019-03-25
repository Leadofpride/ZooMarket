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
	public partial class UpdateProducts : Form
	{
		private int id;
		bool edit;
		public UpdateProducts()
		{
			InitializeComponent();
			товарTableAdapter.Fill(dBDataSet.Товар);
			edit = false;
		}
		public UpdateProducts(int id, string title, int count, decimal price, string category, string description) : this()
		{
			товарTableAdapter.Fill(dBDataSet.Товар);
			edit = true;
			this.id = id;
			textBox1.Text = title;
			textBox2.Text = count.ToString();
			textBox3.Text = price.ToString();
			textBox4.Text = category;
			textBox5.Text = description;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text !="" && textBox3.Text !="" && textBox4.Text != "" && textBox5.Text != "")
			{
				товарTableAdapter.UpdateQuery(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox3.Text), textBox4.Text, textBox5.Text,id);
				Close();
			}
			else
				MessageBox.Show("Не все поля введены!");
			return;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void UpdateProducts_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);

		}
	}
}
