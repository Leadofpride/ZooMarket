namespace Zoo_market
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idПродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.продавцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.продавцыTableAdapter = new Zoo_market.DBDataSetTableAdapters.ПродавцыTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.продавцыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(36, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Логин:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(36, 223);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(151, 158);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(158, 46);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(151, 220);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(158, 46);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(113, 316);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 51);
			this.button1.TabIndex = 4;
			this.button1.Text = "Вход";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(420, 316);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(156, 51);
			this.button2.TabIndex = 5;
			this.button2.Text = "For Admin";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(804, 284);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name";
			this.label3.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idПродавцаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.продавцыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(782, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(153, 150);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// idПродавцаDataGridViewTextBoxColumn
			// 
			this.idПродавцаDataGridViewTextBoxColumn.DataPropertyName = "Id_Продавца";
			this.idПродавцаDataGridViewTextBoxColumn.HeaderText = "Id_Продавца";
			this.idПродавцаDataGridViewTextBoxColumn.Name = "idПродавцаDataGridViewTextBoxColumn";
			this.idПродавцаDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// фИОDataGridViewTextBoxColumn
			// 
			this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
			this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
			this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
			// 
			// логинDataGridViewTextBoxColumn
			// 
			this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
			this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
			this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
			// 
			// парольDataGridViewTextBoxColumn
			// 
			this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
			this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
			this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
			// 
			// продавцыBindingSource
			// 
			this.продавцыBindingSource.DataMember = "Продавцы";
			this.продавцыBindingSource.DataSource = this.dBDataSet;
			// 
			// dBDataSet
			// 
			this.dBDataSet.DataSetName = "DBDataSet";
			this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// продавцыTableAdapter
			// 
			this.продавцыTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Zoo_market.Properties.Resources.фон;
			this.ClientSize = new System.Drawing.Size(759, 470);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(775, 509);
			this.MinimumSize = new System.Drawing.Size(775, 509);
			this.Name = "Form1";
			this.Text = "Вход";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.продавцыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.BindingSource продавцыBindingSource;
		private DBDataSetTableAdapters.ПродавцыTableAdapter продавцыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idПродавцаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
	}
}

