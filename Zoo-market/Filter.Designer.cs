namespace Zoo_market
{
	partial class Filter
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
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dBDataSet = new Zoo_market.DBDataSet();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.товарTableAdapter = new Zoo_market.DBDataSetTableAdapters.ТоварTableAdapter();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.dBDataSet;
			this.bindingSource1.Position = 0;
			// 
			// dBDataSet
			// 
			this.dBDataSet.DataSetName = "DBDataSet";
			this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idТовараDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.товарBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(33, 159);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(671, 317);
			this.dataGridView1.TabIndex = 0;
			// 
			// idТовараDataGridViewTextBoxColumn
			// 
			this.idТовараDataGridViewTextBoxColumn.DataPropertyName = "Id_Товара";
			this.idТовараDataGridViewTextBoxColumn.HeaderText = "Id_Товара";
			this.idТовараDataGridViewTextBoxColumn.Name = "idТовараDataGridViewTextBoxColumn";
			this.idТовараDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// названиеDataGridViewTextBoxColumn
			// 
			this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
			this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
			this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
			// 
			// количествоDataGridViewTextBoxColumn
			// 
			this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
			this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
			this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
			// 
			// ценаDataGridViewTextBoxColumn
			// 
			this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
			this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
			// 
			// категорияDataGridViewTextBoxColumn
			// 
			this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
			this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
			this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
			// 
			// описаниеDataGridViewTextBoxColumn
			// 
			this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
			this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
			this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
			// 
			// товарBindingSource
			// 
			this.товарBindingSource.DataMember = "Товар";
			this.товарBindingSource.DataSource = this.bindingSource1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magnolia Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(179, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(357, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Фильтрация по категории";
			// 
			// товарTableAdapter
			// 
			this.товарTableAdapter.ClearBeforeFill = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton1.Location = new System.Drawing.Point(136, 70);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(139, 33);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Животные";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton2.Location = new System.Drawing.Point(312, 70);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 33);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Корм";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Magnolia Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton3.Location = new System.Drawing.Point(472, 70);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(99, 33);
			this.radioButton3.TabIndex = 4;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Другое";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox1.Location = new System.Drawing.Point(104, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 117);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox2.Location = new System.Drawing.Point(104, 109);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(478, 10);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox3.Location = new System.Drawing.Point(572, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 119);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox4.Location = new System.Drawing.Point(14, 143);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(708, 10);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox5.Location = new System.Drawing.Point(12, 143);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(10, 349);
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox6.Location = new System.Drawing.Point(14, 482);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(708, 10);
			this.pictureBox6.TabIndex = 10;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBox7.Location = new System.Drawing.Point(712, 143);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(10, 349);
			this.pictureBox7.TabIndex = 11;
			this.pictureBox7.TabStop = false;
			// 
			// Filter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 504);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.MaximumSize = new System.Drawing.Size(750, 543);
			this.MinimumSize = new System.Drawing.Size(750, 543);
			this.Name = "Filter";
			this.Text = "Фильтрация";
			this.Load += new System.EventHandler(this.Filter_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private DBDataSet dBDataSet;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource товарBindingSource;
		private DBDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idТовараDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
	}
}