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
	public partial class EditSellers : Form
	{
		private readonly int id;
		readonly bool edit;
		public EditSellers()
		{
			InitializeComponent();
			продавцыTableAdapter.Fill(dBDataSet.Продавцы);
			edit = false;
		}
		public EditSellers(int id, string name, string login, string pass) : this()
		{
			продавцыTableAdapter.Fill(dBDataSet.Продавцы);
			edit = true;
			this.id = id;
			textBox1.Text = name;
			textBox2.Text = login;
			textBox3.Text = pass;
		}

		private void EditSellers_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
			this.продавцыTableAdapter.Fill(this.dBDataSet.Продавцы);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (edit)
			{
				продавцыTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, id);
			}
			else
			{
				продавцыTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text);
			}
			Close();
		}
	

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
