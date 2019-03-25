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
	public partial class EditSub : Form
	{
		private readonly int id;
		readonly bool edit;
		public EditSub()
		{
			InitializeComponent();
			подвидыTableAdapter.Fill(dBDataSet.Подвиды);
			edit = false;
		}
		public EditSub(int id, string name) : this()
		{
			подвидыTableAdapter.Fill(dBDataSet.Подвиды);
			edit = true;
			this.id = id;
			textBox1.Text = name;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void EditSub_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Подвиды". При необходимости она может быть перемещена или удалена.
			this.подвидыTableAdapter.Fill(this.dBDataSet.Подвиды);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (edit)
			{
				подвидыTableAdapter.UpdateQuery(textBox1.Text, id);
			}
			else
			{
				подвидыTableAdapter.Insert(textBox1.Text);
			}
			Close();
		}
	}
}
