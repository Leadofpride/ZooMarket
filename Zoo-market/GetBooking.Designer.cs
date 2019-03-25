namespace Zoo_market
{
	partial class GetBooking
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыTableAdapter = new Zoo_market.DBDataSetTableAdapters.ЗаказыTableAdapter();
			this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.товарTableAdapter = new Zoo_market.DBDataSetTableAdapters.ТоварTableAdapter();
			this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.поставщикиTableAdapter = new Zoo_market.DBDataSetTableAdapters.ПоставщикиTableAdapter();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
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
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Товара";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID Поставщика";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 243);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Количество";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(266, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(230, 46);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(266, 146);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(230, 46);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(266, 240);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(230, 46);
			this.textBox3.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(19, 343);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(173, 63);
			this.button1.TabIndex = 6;
			this.button1.Text = "Принять";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(291, 343);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(173, 63);
			this.button2.TabIndex = 7;
			this.button2.Text = "Отменить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(268, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 38);
			this.label4.TabIndex = 8;
			this.label4.Text = "Название";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(268, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 38);
			this.label5.TabIndex = 9;
			this.label5.Text = "Поставщик";
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
			// товарBindingSource
			// 
			this.товарBindingSource.DataMember = "Товар";
			this.товарBindingSource.DataSource = this.dBDataSet;
			// 
			// товарTableAdapter
			// 
			this.товарTableAdapter.ClearBeforeFill = true;
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(553, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 38);
			this.label6.TabIndex = 10;
			this.label6.Text = "Тип";
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(622, 42);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(230, 46);
			this.textBox4.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(553, 117);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 38);
			this.label7.TabIndex = 12;
			this.label7.Text = "Склад";
			// 
			// textBox5
			// 
			this.textBox5.Enabled = false;
			this.textBox5.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(653, 114);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(230, 46);
			this.textBox5.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(553, 195);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 38);
			this.label8.TabIndex = 14;
			this.label8.Text = "Id Подвида";
			// 
			// textBox6
			// 
			this.textBox6.Enabled = false;
			this.textBox6.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(719, 195);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(230, 46);
			this.textBox6.TabIndex = 15;
			// 
			// GetBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 450);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(532, 489);
			this.MinimumSize = new System.Drawing.Size(532, 489);
			this.Name = "GetBooking";
			this.Text = "GetBooking";
			this.Load += new System.EventHandler(this.GetBooking_Load);
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.BindingSource заказыBindingSource;
		private DBDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
		private System.Windows.Forms.BindingSource товарBindingSource;
		private DBDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
		private System.Windows.Forms.BindingSource поставщикиBindingSource;
		private DBDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
	}
}