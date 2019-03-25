using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Zoo_market
{
	public partial class EditClients : Form
	{
		private readonly int id;
		readonly bool edit;
		public EditClients()
		{
			InitializeComponent();
			клиентыTableAdapter.Fill(dBDataSet.Клиенты);
			edit = false;
		}
		public EditClients(int id, string name, string mail, string count, string discount) : this()
		{
			клиентыTableAdapter.Fill(dBDataSet.Клиенты);
			edit = true;
			this.id = id;
			textBox1.Text = name;
			textBox2.Text = mail;
			textBox3.Text = count;
			textBox4.Text = discount;
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void EditClients_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.dBDataSet.Клиенты);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ErrorProvider error = new ErrorProvider();
			string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

			if (Regex.IsMatch(textBox2.Text, pattern) && textBox1.Text != "" && textBox1.Text != " " && textBox1.Text != null)
			{
				if (edit)
				{
					клиентыTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text), id);
					Close();
				}
				else
				{
					клиентыTableAdapter.Insert(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
					Close();
				}
			}
			else
			{
				MessageBox.Show("Неверный формат почты или не задано ФИО!");
				return;
			}
		}

		private void textBox2_Leave(object sender, EventArgs e)
		{
		//	ErrorProvider error = new ErrorProvider();
		//	string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
		//	if (Regex.IsMatch(textBox2.Text, pattern))
		//	{

		//		error.Clear();
		//	}
		//	else
		//		error.SetError(this.textBox2, "Неверный формат почты");
		}
	}
}
