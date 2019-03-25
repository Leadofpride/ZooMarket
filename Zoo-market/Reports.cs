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
using System.Reflection;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Zoo_market
{
	public partial class Reports : Form
	{
		int count = 0;
		const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
		public Reports()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			count = 1;
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda1 = new SqlDataAdapter("SELECT Id_Поставщика, [Название фирмы], Название From Поставщики,Товар WHERE Поставщики.Id_Товара = Товар.Id_Товара;", sqlconn);
				DataTable dt = new DataTable();
				oda1.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			count = 2;
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda2 = new SqlDataAdapter("SELECT TOP(1) Продавцы.ФИО AS 'Лучший работник', Count([Чеки].[Id_Продавца]) AS 'Количество продаж' From Продавцы, Чеки where Продавцы.Id_Продавца = Чеки.Id_Продавца Group by Продавцы.ФИО Order by Count([Чеки].[Id_Продавца]) DESC;", sqlconn);
				DataTable dt = new DataTable();
				oda2.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			count = 3;
			try
			{
				SqlConnection sqlconn = new SqlConnection(ConnectionString);
				sqlconn.Open();
				SqlDataAdapter oda3 = new SqlDataAdapter(@"SELECT TOP(3) Название, Count(Покупки.Id_Товара) AS 'Количество покупок' From Товар, Покупки Where Покупки.Id_Товара = Товар.Id_Товара Group by Название Order by Count(Покупки.Id_Товара) DESC; ", sqlconn);
				DataTable dt = new DataTable();
				oda3.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlconn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Error: " + ex.Message);
			}
		}

		private void Reports_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			File.Delete(@"SaveExcel.xlsx");
			SaveTableExcel(dataGridView1);
			System.Diagnostics.Process.Start(@"SaveExcel.xlsx");
		}

		void SaveTableExcel(DataGridView Excel_Save)
		{

			string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "SaveExcel.xlsx";
			int rowExcel = 0;
			Excel.Application excelapp = new Excel.Application();
			Excel.Workbook workbook = excelapp.Workbooks.Add();
			Excel.Worksheet worksheet = workbook.ActiveSheet;

			if (count == 3)
			{
				worksheet.Columns["A"].ColumnWidth = 25;
				worksheet.Columns["B"].ColumnWidth = 20;
				
				worksheet.Cells[2, "A"] = "Название";
				worksheet.Cells[2, "B"] = "Количество покупок";

				rowExcel = 3;
				for (int i = 0; i < Excel_Save.Rows.Count; i++)
				{
					worksheet.Cells[rowExcel, "A"] = Excel_Save.Rows[i].Cells["Название"].Value;
					worksheet.Cells[rowExcel, "B"] = Excel_Save.Rows[i].Cells["Количество покупок"].Value;
					++rowExcel;
				}
				Excel.Range tRange = worksheet.UsedRange;
				tRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
				tRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
				worksheet.Cells[1, "A"] = "Отчет 'Топ-3 товара'";
				worksheet.Cells[rowExcel, "A"] = "Дата формирования" + " " + DateTime.Today.ToString().Split(' ')[0]; 
			}
			if (count == 2)
			{
				worksheet.Columns["A"].ColumnWidth = 25;
				worksheet.Columns["B"].ColumnWidth = 20;
				worksheet.Cells[2, "A"] = "Лучший работник";
				worksheet.Cells[2, "B"] = "Количество продаж";

				rowExcel = 3;
				for (int i = 0; i < Excel_Save.Rows.Count; i++)
				{
					worksheet.Cells[rowExcel, "A"] = Excel_Save.Rows[i].Cells["Лучший работник"].Value;
					worksheet.Cells[rowExcel, "B"] = Excel_Save.Rows[i].Cells["Количество продаж"].Value;
					++rowExcel;
				}
				Excel.Range tRange = worksheet.UsedRange;
				tRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
				tRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
				worksheet.Cells[1, "A"] = "Отчет 'Лучший работник'";
				worksheet.Cells[rowExcel, "A"] = "Дата формирования" + " " + DateTime.Today.ToString().Split(' ')[0];
			}
			if (count == 1)
			{
				worksheet.Columns["A"].ColumnWidth = 25;
				worksheet.Columns["B"].ColumnWidth = 25;
				worksheet.Columns["C"].ColumnWidth = 25;
				worksheet.Cells[2, "A"] = "ID Поставщика";
				worksheet.Cells[2, "B"] = "Название фирмы";
				worksheet.Cells[2, "C"] = "Название товара";

				rowExcel = 3;
				for (int i = 0; i < Excel_Save.Rows.Count; i++)
				{
					worksheet.Cells[rowExcel, "A"] = Excel_Save.Rows[i].Cells["Id_Поставщика"].Value;
					worksheet.Cells[rowExcel, "B"] = Excel_Save.Rows[i].Cells["Название фирмы"].Value;
					worksheet.Cells[rowExcel, "C"] = Excel_Save.Rows[i].Cells["Название"].Value;
					++rowExcel;
				}
				Excel.Range tRange = worksheet.UsedRange;
				tRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
				tRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
				worksheet.Cells[1, "A"] = "Отчет 'Поставщики'";
				worksheet.Cells[rowExcel, "A"] = "Дата формирования" + " " + DateTime.Today.ToString().Split(' ')[0];
			}
			if (count == 2 || count == 3)
			{
				Excel.Range _excelCells1 = (Excel.Range)worksheet.get_Range("A1", "B1").Cells;
				Excel.Range _excelCells2 = (Excel.Range)worksheet.get_Range("A" + rowExcel, "B" + rowExcel).Cells;
				_excelCells1.Merge(Type.Missing);
				_excelCells2.Merge(Type.Missing);
				_excelCells1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				_excelCells2.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
			}
			if (count == 1)
			{
				Excel.Range _excelCells1 = (Excel.Range)worksheet.get_Range("A1","C1").Cells;
				Excel.Range _excelCells2 = (Excel.Range)worksheet.get_Range("A" + rowExcel, "C"+ rowExcel).Cells;
				_excelCells1.Merge(Type.Missing);
				_excelCells2.Merge(Type.Missing);
				_excelCells1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				_excelCells2.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
			}
			excelapp.AlertBeforeOverwriting = false;
			workbook.SaveAs(path);
			excelapp.Quit();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			
		}
	}
}
