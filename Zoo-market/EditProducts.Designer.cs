namespace Zoo_market
{
	partial class EditProducts
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.подвидыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.label8 = new System.Windows.Forms.Label();
			this.подвидыTableAdapter = new Zoo_market.DBDataSetTableAdapters.ПодвидыTableAdapter();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.животныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.животныеTableAdapter = new Zoo_market.DBDataSetTableAdapters.ЖивотныеTableAdapter();
			this.кормBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.кормTableAdapter = new Zoo_market.DBDataSetTableAdapters.КормTableAdapter();
			this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.товарTableAdapter = new Zoo_market.DBDataSetTableAdapters.ТоварTableAdapter();
			this.label13 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.подвидыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.животныеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.кормBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton1.Location = new System.Drawing.Point(12, 28);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(151, 37);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Животное";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton2.Location = new System.Drawing.Point(169, 28);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(95, 37);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Корм";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton3.Location = new System.Drawing.Point(293, 28);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(110, 37);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Другое";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 33);
			this.label1.TabIndex = 3;
			this.label1.Text = "Название:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 33);
			this.label2.TabIndex = 4;
			this.label2.Text = "Количество:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "Цена(грн):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 284);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 33);
			this.label4.TabIndex = 6;
			this.label4.Text = "Категория:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 343);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 33);
			this.label5.TabIndex = 7;
			this.label5.Text = "Описание:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(233, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(157, 41);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(233, 164);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(157, 41);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "0";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(233, 225);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(157, 41);
			this.textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(233, 281);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(157, 41);
			this.textBox4.TabIndex = 11;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(233, 340);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(157, 41);
			this.textBox5.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(31, 430);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 46);
			this.button1.TabIndex = 13;
			this.button1.Text = "Далее";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(192, 430);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 46);
			this.button2.TabIndex = 14;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(430, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 33);
			this.label6.TabIndex = 15;
			this.label6.Text = "ID Товара:";
			this.label6.Visible = false;
			// 
			// textBox6
			// 
			this.textBox6.Enabled = false;
			this.textBox6.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(599, 92);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(193, 46);
			this.textBox6.TabIndex = 16;
			this.textBox6.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(430, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 33);
			this.label7.TabIndex = 17;
			this.label7.Text = "ДР:";
			this.label7.Visible = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(599, 159);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(193, 46);
			this.dateTimePicker1.TabIndex = 18;
			this.dateTimePicker1.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.подвидыBindingSource;
			this.comboBox1.DisplayMember = "Id_Подвида";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(599, 226);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 46);
			this.comboBox1.TabIndex = 19;
			this.comboBox1.ValueMember = "Id_Подвида";
			this.comboBox1.Visible = false;
			// 
			// подвидыBindingSource
			// 
			this.подвидыBindingSource.DataMember = "Подвиды";
			this.подвидыBindingSource.DataSource = this.dBDataSet;
			// 
			// dBDataSet
			// 
			this.dBDataSet.DataSetName = "DBDataSet";
			this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(430, 233);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(154, 33);
			this.label8.TabIndex = 20;
			this.label8.Text = "ID Подвида:";
			this.label8.Visible = false;
			// 
			// подвидыTableAdapter
			// 
			this.подвидыTableAdapter.ClearBeforeFill = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(430, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 33);
			this.label9.TabIndex = 21;
			this.label9.Text = "ID Товара:";
			this.label9.Visible = false;
			// 
			// textBox7
			// 
			this.textBox7.Enabled = false;
			this.textBox7.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox7.Location = new System.Drawing.Point(599, 98);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(193, 46);
			this.textBox7.TabIndex = 22;
			this.textBox7.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(430, 169);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 33);
			this.label10.TabIndex = 23;
			this.label10.Text = "Тип:";
			this.label10.Visible = false;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Enabled = false;
			this.comboBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Сухой",
            "Мокрый"});
			this.comboBox2.Location = new System.Drawing.Point(599, 162);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(193, 46);
			this.comboBox2.TabIndex = 24;
			this.comboBox2.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(430, 223);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 33);
			this.label11.TabIndex = 25;
			this.label11.Text = "Вес(г):";
			this.label11.Visible = false;
			// 
			// textBox8
			// 
			this.textBox8.Enabled = false;
			this.textBox8.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.Location = new System.Drawing.Point(599, 221);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(193, 46);
			this.textBox8.TabIndex = 26;
			this.textBox8.Visible = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(430, 280);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(154, 33);
			this.label12.TabIndex = 27;
			this.label12.Text = "ID Подвида:";
			this.label12.Visible = false;
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.подвидыBindingSource;
			this.comboBox3.DisplayMember = "Id_Подвида";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Enabled = false;
			this.comboBox3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(599, 278);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(193, 46);
			this.comboBox3.TabIndex = 28;
			this.comboBox3.ValueMember = "Id_Подвида";
			this.comboBox3.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox1.Location = new System.Drawing.Point(407, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 519);
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(542, 430);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(183, 46);
			this.button3.TabIndex = 30;
			this.button3.Text = "Завершить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// животныеBindingSource
			// 
			this.животныеBindingSource.DataMember = "Животные";
			this.животныеBindingSource.DataSource = this.dBDataSet;
			// 
			// животныеTableAdapter
			// 
			this.животныеTableAdapter.ClearBeforeFill = true;
			// 
			// кормBindingSource
			// 
			this.кормBindingSource.DataMember = "Корм";
			this.кормBindingSource.DataSource = this.dBDataSet;
			// 
			// кормTableAdapter
			// 
			this.кормTableAdapter.ClearBeforeFill = true;
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
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Magnolia Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(603, 340);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(99, 33);
			this.label13.TabIndex = 32;
			this.label13.Text = "Подвид";
			this.label13.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// EditProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 532);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.MaximumSize = new System.Drawing.Size(840, 571);
			this.MinimumSize = new System.Drawing.Size(840, 571);
			this.Name = "EditProducts";
			this.Text = "EditProducts";
			this.Load += new System.EventHandler(this.EditProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.подвидыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.животныеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.кормBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label8;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.BindingSource подвидыBindingSource;
		private DBDataSetTableAdapters.ПодвидыTableAdapter подвидыTableAdapter;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.BindingSource животныеBindingSource;
		private DBDataSetTableAdapters.ЖивотныеTableAdapter животныеTableAdapter;
		private System.Windows.Forms.BindingSource кормBindingSource;
		private DBDataSetTableAdapters.КормTableAdapter кормTableAdapter;
		private System.Windows.Forms.BindingSource товарBindingSource;
		private DBDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Timer timer1;
	}
}