namespace Zoo_market
{
	partial class Buy
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.продавцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.клиентыTableAdapter = new Zoo_market.DBDataSetTableAdapters.КлиентыTableAdapter();
			this.продавцыTableAdapter = new Zoo_market.DBDataSetTableAdapters.ПродавцыTableAdapter();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.покупкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.покупкиTableAdapter = new Zoo_market.DBDataSetTableAdapters.ПокупкиTableAdapter();
			this.чекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.чекиTableAdapter = new Zoo_market.DBDataSetTableAdapters.ЧекиTableAdapter();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.товарTableAdapter = new Zoo_market.DBDataSetTableAdapters.ТоварTableAdapter();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.продавцыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.покупкиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.чекиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Клиента";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID Продавца";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Дата";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(19, 471);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 57);
			this.button1.TabIndex = 3;
			this.button1.Text = "Далее";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(212, 471);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(177, 57);
			this.button2.TabIndex = 4;
			this.button2.Text = "Отменить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.клиентыBindingSource;
			this.comboBox1.DisplayMember = "Id_Клиента";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(221, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(177, 46);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.ValueMember = "Id_Клиента";
			// 
			// клиентыBindingSource
			// 
			this.клиентыBindingSource.DataMember = "Клиенты";
			this.клиентыBindingSource.DataSource = this.dBDataSet;
			// 
			// dBDataSet
			// 
			this.dBDataSet.DataSetName = "DBDataSet";
			this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.продавцыBindingSource;
			this.comboBox2.DisplayMember = "Id_Продавца";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(221, 105);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(177, 46);
			this.comboBox2.TabIndex = 6;
			this.comboBox2.ValueMember = "Id_Продавца";
			// 
			// продавцыBindingSource
			// 
			this.продавцыBindingSource.DataMember = "Продавцы";
			this.продавцыBindingSource.DataSource = this.dBDataSet;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox1.Location = new System.Drawing.Point(444, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 539);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(221, 197);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(177, 46);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// клиентыTableAdapter
			// 
			this.клиентыTableAdapter.ClearBeforeFill = true;
			// 
			// продавцыTableAdapter
			// 
			this.продавцыTableAdapter.ClearBeforeFill = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 29);
			this.label4.TabIndex = 9;
			this.label4.Text = "ФИО";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 29);
			this.label5.TabIndex = 10;
			this.label5.Text = "ФИО";
			// 
			// покупкиBindingSource
			// 
			this.покупкиBindingSource.DataMember = "Покупки";
			this.покупкиBindingSource.DataSource = this.dBDataSet;
			// 
			// покупкиTableAdapter
			// 
			this.покупкиTableAdapter.ClearBeforeFill = true;
			// 
			// чекиBindingSource
			// 
			this.чекиBindingSource.DataMember = "Чеки";
			this.чекиBindingSource.DataSource = this.dBDataSet;
			// 
			// чекиTableAdapter
			// 
			this.чекиTableAdapter.ClearBeforeFill = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// товарBindingSource
			// 
			this.товарBindingSource.DataMember = "Товар";
			this.товарBindingSource.DataSource = this.dBDataSet;
			// 
			// товарTableAdapter
			// 
			this.товарTableAdapter.ClearBeforeFill = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(471, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 38);
			this.label6.TabIndex = 11;
			this.label6.Text = "ID Чека";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(471, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 38);
			this.label7.TabIndex = 12;
			this.label7.Text = "ID Товара";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(660, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(220, 46);
			this.textBox1.TabIndex = 13;
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.товарBindingSource;
			this.comboBox3.DisplayMember = "Id_Товара";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Enabled = false;
			this.comboBox3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(660, 70);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(220, 46);
			this.comboBox3.TabIndex = 14;
			this.comboBox3.ValueMember = "Id_Товара";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(653, 129);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(138, 38);
			this.label8.TabIndex = 15;
			this.label8.Text = "Название";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(460, 182);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(170, 38);
			this.label9.TabIndex = 16;
			this.label9.Text = "Количество";
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(595, 471);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(177, 57);
			this.button3.TabIndex = 18;
			this.button3.Text = "Оплатить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(460, 254);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(143, 38);
			this.label10.TabIndex = 19;
			this.label10.Text = "На складе";
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(660, 246);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(220, 46);
			this.textBox3.TabIndex = 20;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(460, 319);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(191, 38);
			this.label11.TabIndex = 21;
			this.label11.Text = "Цена еденицы";
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(660, 316);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(220, 46);
			this.textBox4.TabIndex = 22;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(460, 388);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 38);
			this.label12.TabIndex = 23;
			this.label12.Text = "К оплате:";
			// 
			// textBox5
			// 
			this.textBox5.Enabled = false;
			this.textBox5.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(660, 380);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(220, 46);
			this.textBox5.TabIndex = 24;
			// 
			// listBox1
			// 
			this.listBox1.Enabled = false;
			this.listBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 38;
			this.listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
			this.listBox1.Location = new System.Drawing.Point(660, 178);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(220, 42);
			this.listBox1.TabIndex = 101;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(12, 281);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(107, 38);
			this.label13.TabIndex = 102;
			this.label13.Text = "Скидка";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(218, 278);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(180, 46);
			this.textBox2.TabIndex = 103;
			this.textBox2.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(12, 359);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(183, 38);
			this.label14.TabIndex = 104;
			this.label14.Text = "Кол-во чеков";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(218, 356);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(180, 46);
			this.textBox6.TabIndex = 105;
			this.textBox6.Text = "0";
			// 
			// Buy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 540);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Buy";
			this.Text = "Buy";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buy_FormClosing);
			this.Load += new System.EventHandler(this.Buy_Load);
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.продавцыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.покупкиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.чекиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.BindingSource клиентыBindingSource;
		private DBDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
		private System.Windows.Forms.BindingSource продавцыBindingSource;
		private DBDataSetTableAdapters.ПродавцыTableAdapter продавцыTableAdapter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.BindingSource покупкиBindingSource;
		private DBDataSetTableAdapters.ПокупкиTableAdapter покупкиTableAdapter;
		private System.Windows.Forms.BindingSource чекиBindingSource;
		private DBDataSetTableAdapters.ЧекиTableAdapter чекиTableAdapter;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.BindingSource товарBindingSource;
		private DBDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox6;
	}
}