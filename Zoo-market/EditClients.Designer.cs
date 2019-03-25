namespace Zoo_market
{
	partial class EditClients
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыTableAdapter = new Zoo_market.DBDataSetTableAdapters.КлиентыTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(27, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "ФИО:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(168, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(223, 46);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(27, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 38);
			this.label2.TabIndex = 2;
			this.label2.Text = "Почта:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(168, 107);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(223, 46);
			this.textBox2.TabIndex = 3;
			this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(29, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 38);
			this.label3.TabIndex = 4;
			this.label3.Text = "Чеки:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(168, 191);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(223, 46);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(29, 278);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 38);
			this.label4.TabIndex = 6;
			this.label4.Text = "Скидка:";
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(168, 270);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(223, 46);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "0";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(59, 364);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 46);
			this.button1.TabIndex = 8;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(253, 364);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 46);
			this.button2.TabIndex = 9;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dBDataSet
			// 
			this.dBDataSet.DataSetName = "DBDataSet";
			this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// клиентыBindingSource
			// 
			this.клиентыBindingSource.DataMember = "Клиенты";
			this.клиентыBindingSource.DataSource = this.dBDataSet;
			// 
			// клиентыTableAdapter
			// 
			this.клиентыTableAdapter.ClearBeforeFill = true;
			// 
			// EditClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(478, 489);
			this.MinimumSize = new System.Drawing.Size(478, 489);
			this.Name = "EditClients";
			this.Text = "EditClients";
			this.Load += new System.EventHandler(this.EditClients_Load);
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.BindingSource клиентыBindingSource;
		private DBDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
	}
}