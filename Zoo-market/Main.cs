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
using System.Media;
using System.IO;

namespace Zoo_market
{
	public partial class Main : Form
	{
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";

		public Main()
		{
			InitializeComponent();
		}
		public Main(string x) : this()
		{
			label2.Text = "Пользователь:" + " " + x;
		}
		private void Main_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Чеки". При необходимости она может быть перемещена или удалена.
			this.чекиTableAdapter.Fill(this.dBDataSet.Чеки);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Товар". При необходимости она может быть перемещена или удалена.
			this.товарTableAdapter.Fill(this.dBDataSet.Товар);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
			this.продавцыTableAdapter.Fill(this.dBDataSet.Продавцы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
			this.поставщикиTableAdapter.Fill(this.dBDataSet.Поставщики);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Покупки". При необходимости она может быть перемещена или удалена.
			this.покупкиTableAdapter.Fill(this.dBDataSet.Покупки);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Подвиды". При необходимости она может быть перемещена или удалена.
			this.подвидыTableAdapter.Fill(this.dBDataSet.Подвиды);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Наборы". При необходимости она может быть перемещена или удалена.
			this.наборыTableAdapter.Fill(this.dBDataSet.Наборы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Корм". При необходимости она может быть перемещена или удалена.
			this.кормTableAdapter.Fill(this.dBDataSet.Корм);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.dBDataSet.Клиенты);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Заказы". При необходимости она может быть перемещена или удалена.
			this.заказыTableAdapter.Fill(this.dBDataSet.Заказы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Животные". При необходимости она может быть перемещена или удалена.
			this.животныеTableAdapter.Fill(this.dBDataSet.Животные);
			timer1.Interval = 100;
			timer1.Start();
			dataGridView1.AutoGenerateColumns = true;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			if (label2.Text != "Пользователь: Нармания В. В.")
			{
				продавцыToolStripMenuItem.Enabled = false;
				editQueryToolStripMenuItem.Enabled = false;
			}
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			животныеTableAdapter.Update(dBDataSet);
			заказыTableAdapter.Update(dBDataSet);
			чекиTableAdapter.Update(dBDataSet);
			клиентыTableAdapter.Update(dBDataSet);
			кормTableAdapter.Update(dBDataSet);
			товарTableAdapter.Update(dBDataSet);
			поставщикиTableAdapter.Update(dBDataSet);
			продавцыTableAdapter.Update(dBDataSet);
			покупкиTableAdapter.Update(dBDataSet);
			подвидыTableAdapter.Update(dBDataSet);
			наборыTableAdapter.Update(dBDataSet);
			Application.Exit();
		}

		private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = товарBindingSource;
			dataGridView1.DataSource = товарBindingSource;
			label1.Text = "Товары";
			button1.Visible = true;
			button1.Text = "Добавить товар";
			button2.Visible = false;
			button3.Visible = true;
			button4.Visible = true;
			button5.Visible = false;
			button4.Enabled = true;
			button6.Visible = false;
		}

		private void животныеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = животныеBindingSource;
			dataGridView1.DataSource = животныеBindingSource;
			label1.Text = "Животные";
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void подвидыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = подвидыBindingSource;
			dataGridView1.DataSource = подвидыBindingSource;
			label1.Text = "Подвиды";
			
			button1.Visible = true;
			button2.Visible = false;
			button3.Visible = true;
			button1.Text = "Добавить подвид";

			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;

		}

		private void кормToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = кормBindingSource;
			dataGridView1.DataSource = кормBindingSource;
			label1.Text = "Корм";
			
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;

			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void наборыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = наборыBindingSource;
			dataGridView1.DataSource = наборыBindingSource;
			label1.Text = "Наборы";
			
			button1.Visible = true;
			button1.Text = "Добавить набор";
			button2.Visible = true;
			button2.Text = "Удалить набор";
			button3.Visible = false;
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible= false;
			button6.Visible = false;
		}

		private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = клиентыBindingSource;
			dataGridView1.DataSource = клиентыBindingSource;
			label1.Text = "Клиенты";
			button1.Visible = true;
			button2.Visible = false;
			button3.Visible = true;
			button1.Text = "Добавить клиента";
			button2.Text = "Удалить клиента";
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void чекиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = чекиBindingSource;
			dataGridView1.DataSource = чекиBindingSource;
			label1.Text = "Чеки";
			
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void покупкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = покупкиBindingSource;
			dataGridView1.DataSource = покупкиBindingSource;
			label1.Text = "Покупки";
			
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = поставщикиBindingSource;
			dataGridView1.DataSource = поставщикиBindingSource;
			label1.Text = "Поставщики";
			button1.Visible = true;
			button2.Visible = true;
			button3.Visible = true;
			button1.Text = "Добавить поставщика";
			button2.Text = "Удалить поставщика";
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void закаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = заказыBindingSource;
			dataGridView1.DataSource = заказыBindingSource;
			label1.Text = "Заказы";
			
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			button4.Visible = false;
			button5.Visible = true;
			button6.Visible = true;
		}

		private void продавцыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bindingNavigator1.BindingSource = продавцыBindingSource;
			dataGridView1.DataSource = продавцыBindingSource;
			label1.Text = "Продавцы";
			
			button1.Visible = true;
			button2.Visible = true;
			button3.Visible = true;
			button1.Text = "Добавить продавца";
			button2.Text = "Удалить продавца";
			//button4.Visible = false;
			//button5.Visible = false;
			button4.Enabled = false;
			button5.Visible = false;
			button6.Visible = false;
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void editQueryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditQuery edit = new EditQuery();
			edit.Show();
		}

		private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Queries query = new Queries();
			query.Show();
		}

		private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Reports reports = new Reports();
			reports.Show();
		}
		private bool edit=true;

		private void button2_Click(object sender, EventArgs e)
		{
			if (label1.Text == "Поставщики") {
				DialogResult result = MessageBox.Show("Подтвердить удаление?","Сообщение", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					if (!edit) return;
					поставщикиTableAdapter.DeleteQuery(
					Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
					);
					поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
					dBDataSet.AcceptChanges();
				}
				else
					return;
			}
			if (label1.Text == "Продавцы")
			{
				DialogResult result = MessageBox.Show("Подтвердить удаление?", "Сообщение", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					if (!edit) return;
					продавцыTableAdapter.DeleteQuery(
					Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
					);
					продавцыTableAdapter.Fill(dBDataSet.Продавцы);
					dBDataSet.AcceptChanges();
				}
				else
					return;
			}
			if (label1.Text == "Наборы")
			{
				DialogResult result = MessageBox.Show("Подтвердить удаление?", "Сообщение", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					if (!edit) return;
					наборыTableAdapter.DeleteQuery(
					Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
					);
				 наборыTableAdapter.Fill(dBDataSet.Наборы);
					dBDataSet.AcceptChanges();
				}
				else
					return;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (label1.Text == "Поставщики")
			{
				var editproviders = new EditProviders();
				editproviders.ShowDialog();
				поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Продавцы")
			{
				var editsellers = new EditSellers();
				editsellers.ShowDialog();
				продавцыTableAdapter.Fill(dBDataSet.Продавцы);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Клиенты")
			{
				var editclients = new EditClients();
				editclients.ShowDialog();
				клиентыTableAdapter.Fill(dBDataSet.Клиенты);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Подвиды")
			{
				var editsub = new EditSub();
				editsub.ShowDialog();
				подвидыTableAdapter.Fill(dBDataSet.Подвиды);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Товары")
			{
				var editproducts = new EditProducts();
				editproducts.ShowDialog();
				товарTableAdapter.Fill(dBDataSet.Товар);
				животныеTableAdapter.Fill(dBDataSet.Животные);
				кормTableAdapter.Fill(dBDataSet.Корм);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Наборы")
			{
				var addset = new AddSet();
				addset.ShowDialog();
				наборыTableAdapter.Fill(dBDataSet.Наборы);
				товарTableAdapter.Fill(dBDataSet.Товар);
				подвидыTableAdapter.Fill(dBDataSet.Подвиды);
				dBDataSet.AcceptChanges();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (label1.Text == "Поставщики") {
				if (!edit) return;
				var st = new DBDataSet.ПоставщикиDataTable();
				поставщикиTableAdapter.FillBy(st,
				Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
				object[] row = st.Rows[0].ItemArray;

				var edt = new EditProviders(
					Convert.ToInt32(row[0]),
					row[1].ToString(),
					Convert.ToInt32(row[2])
				);
				edt.ShowDialog();
				поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Продавцы")
			{
				if (!edit) return;
				var st1 = new DBDataSet.ПродавцыDataTable();
				продавцыTableAdapter.FillBy(st1,
				Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
				object[] row = st1.Rows[0].ItemArray;
				var edt1 = new EditSellers(
				Convert.ToInt32(row[0]),
				row[1].ToString(),
				row[2].ToString(),
				row[3].ToString()
				);
				edt1.ShowDialog();
				продавцыTableAdapter.Fill(dBDataSet.Продавцы);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Клиенты")
			{
				if (!edit) return;
				var st1 = new DBDataSet.КлиентыDataTable();
				клиентыTableAdapter.FillBy(st1,
				Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
				object[] row = st1.Rows[0].ItemArray;
				var edt1 = new EditClients(
				Convert.ToInt32(row[0]),
				row[1].ToString(),
				row[2].ToString(),
				row[3].ToString(),
				row[4].ToString()
				);
				edt1.ShowDialog();
				клиентыTableAdapter.Fill(dBDataSet.Клиенты);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Подвиды")
			{
				if (!edit) return;
				var st1 = new DBDataSet.ПодвидыDataTable();
				подвидыTableAdapter.FillBy(st1,
				Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
				object[] row = st1.Rows[0].ItemArray;
				var edt1 = new EditSub(
				Convert.ToInt32(row[0]),
				row[1].ToString()
				);
				edt1.ShowDialog();
				подвидыTableAdapter.Fill(dBDataSet.Подвиды);
				dBDataSet.AcceptChanges();
			}
			if (label1.Text == "Товары")
			{
				if (!edit) return;
				var st1 = new DBDataSet.ТоварDataTable();
				товарTableAdapter.FillBy(st1,
				Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
				object[] row = st1.Rows[0].ItemArray;
				var edt1 = new UpdateProducts(
				Convert.ToInt32(row[0]),
				row[1].ToString(),
				Convert.ToInt32(row[2]),
				Convert.ToDecimal(row[3]),
				row[4].ToString(),
				row[5].ToString()
				);
				edt1.ShowDialog();
				товарTableAdapter.Fill(dBDataSet.Товар);
				dBDataSet.AcceptChanges();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//for (int i = 0; i < dataGridView1.RowCount; i++)
			//{
			//	dataGridView1.Rows[i].Selected = false;
			//	for (int j = 0; j < dataGridView1.ColumnCount; j++)
			//	{
			//		if (dataGridView1.Rows[i].Cells[j] != null)
			//			dataGridView1.Rows[i].Selected = false;
			//	}
			//}
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		private void фильтрацияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Filter filter = new Filter();
			filter.Show();
		}

		private void поискToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Search search = new Search();
			search.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var editbooking = new EditBooking();
			editbooking.ShowDialog();
			заказыTableAdapter.Fill(dBDataSet.Заказы);
			dBDataSet.AcceptChanges();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var buy = new Buy();
			buy.ShowDialog();
			чекиTableAdapter.Fill(dBDataSet.Чеки);
			покупкиTableAdapter.Fill(dBDataSet.Покупки);
			товарTableAdapter.Fill(dBDataSet.Товар);
			продавцыTableAdapter.Fill(dBDataSet.Продавцы);
			клиентыTableAdapter.Fill(dBDataSet.Клиенты);
			dBDataSet.AcceptChanges();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label3.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
			label4.Text = DateTime.Now.Day.ToString("00") + "." + DateTime.Now.Month.ToString("00");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!edit) return;
			var st = new DBDataSet.ЗаказыDataTable();
			заказыTableAdapter.FillBy(st,
			Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
			object[] row = st.Rows[0].ItemArray;

			var edt = new GetBooking(
				Convert.ToInt32(row[0]),
				Convert.ToInt32(row[1]),
				Convert.ToInt32(row[2]),
				Convert.ToInt32(row[4])
			);
			edt.ShowDialog();
			заказыTableAdapter.Fill(dBDataSet.Заказы);
			товарTableAdapter.Fill(dBDataSet.Товар);
			поставщикиTableAdapter.Fill(dBDataSet.Поставщики);
			dBDataSet.AcceptChanges();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			SoundPlayer player = new SoundPlayer(@"C:\Users\narma\Desktop\ForTest\Wolf.wav");
			player.Play();
		}

		private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\Users\narma\Desktop\ForTest\Vidos.webm");
		}
	}
}
