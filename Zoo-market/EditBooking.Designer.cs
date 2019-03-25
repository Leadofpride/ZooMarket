namespace Zoo_market
{
	partial class EditBooking
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
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыTableAdapter = new Zoo_market.DBDataSetTableAdapters.ЗаказыTableAdapter();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.товарTableAdapter = new Zoo_market.DBDataSetTableAdapters.ТоварTableAdapter();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.поставщикиTableAdapter = new Zoo_market.DBDataSetTableAdapters.ПоставщикиTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Товара";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID Поставщика";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Количество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 308);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Дата";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(19, 379);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 43);
			this.button1.TabIndex = 4;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(283, 379);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(174, 43);
			this.button2.TabIndex = 5;
			this.button2.Text = "Отменить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(251, 215);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(222, 46);
			this.textBox3.TabIndex = 8;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(251, 300);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(222, 46);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(276, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 38);
			this.label5.TabIndex = 10;
			this.label5.Text = "Название";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(276, 169);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(167, 38);
			this.label6.TabIndex = 11;
			this.label6.Text = "Поставщик";
			// 
			// dBDataSet
			// 
			this.dBDataSet.DataSetName = "DBDataSet";
			this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// заказыBindingSource
			// 
			this.заказыBindingSource.DataMember = "Заказы";
			this.заказыBindingSource.DataSource = this.dBDataSet;
			// 
			// заказыTableAdapter
			// 
			this.заказыTableAdapter.ClearBeforeFill = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.товарBindingSource;
			this.comboBox1.DisplayMember = "Id_Товара";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(251, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(222, 46);
			this.comboBox1.TabIndex = 12;
			this.comboBox1.ValueMember = "Id_Товара";
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
			// comboBox2
			// 
			this.comboBox2.DataSource = this.поставщикиBindingSource;
			this.comboBox2.DisplayMember = "Id_Поставщика";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(251, 120);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(222, 46);
			this.comboBox2.TabIndex = 13;
			this.comboBox2.ValueMember = "Id_Поставщика";
			// 
			// поставщикиBindingSource
			// 
			this.поставщикиBindingSource.DataMember = "Поставщики";
			this.поставщикиBindingSource.DataSource = this.dBDataSet;
			// 
			// поставщикиTableAdapter
			// 
			this.поставщикиTableAdapter.ClearBeforeFill = true;
			// 
			// EditBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 450);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(542, 489);
			this.MinimumSize = new System.Drawing.Size(542, 489);
			this.Name = "EditBooking";
			this.Text = "EditBooking";
			this.Load += new System.EventHandler(this.EditBooking_Load);
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.BindingSource заказыBindingSource;
		private DBDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource товарBindingSource;
		private DBDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource поставщикиBindingSource;
		private DBDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
	}
}