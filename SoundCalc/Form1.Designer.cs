namespace SoundCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products1DataSet = new SoundCalc.Products1DataSet();
            this.productsDBTableAdapter = new SoundCalc.Products1DataSetTableAdapters.ProductsDBTableAdapter();
            this.products1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.products1DataSet1 = new SoundCalc.Products1DataSet1();
            this.productsDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsDBTableAdapter1 = new SoundCalc.Products1DataSet1TableAdapters.ProductsDBTableAdapter();
            this.products1DataSet2 = new SoundCalc.Products1DataSet2();
            this.productsDBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsDBTableAdapter2 = new SoundCalc.Products1DataSet2TableAdapters.ProductsDBTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкачасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDBBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество часов";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 28);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ставка";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(16, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 28);
            this.textBox2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(16, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Расчёт";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_calculate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Стоимость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.услугиDataGridViewTextBoxColumn,
            this.ставкачасDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsDBBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(179, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(478, 394);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btn_cell_click);
            // 
            // productsDBBindingSource
            // 
            this.productsDBBindingSource.DataMember = "ProductsDB";
            this.productsDBBindingSource.DataSource = this.products1DataSetBindingSource;
            // 
            // products1DataSetBindingSource
            // 
            this.products1DataSetBindingSource.DataSource = this.products1DataSet;
            this.products1DataSetBindingSource.Position = 0;
            // 
            // products1DataSet
            // 
            this.products1DataSet.DataSetName = "Products1DataSet";
            this.products1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsDBTableAdapter
            // 
            this.productsDBTableAdapter.ClearBeforeFill = true;
            // 
            // products1DataSetBindingSource1
            // 
            this.products1DataSetBindingSource1.DataSource = this.products1DataSet;
            this.products1DataSetBindingSource1.Position = 0;
            // 
            // products1DataSet1
            // 
            this.products1DataSet1.DataSetName = "Products1DataSet1";
            this.products1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsDBBindingSource1
            // 
            this.productsDBBindingSource1.DataMember = "ProductsDB";
            this.productsDBBindingSource1.DataSource = this.products1DataSet1;
            // 
            // productsDBTableAdapter1
            // 
            this.productsDBTableAdapter1.ClearBeforeFill = true;
            // 
            // products1DataSet2
            // 
            this.products1DataSet2.DataSetName = "Products1DataSet2";
            this.products1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsDBBindingSource2
            // 
            this.productsDBBindingSource2.DataMember = "ProductsDB";
            this.productsDBBindingSource2.DataSource = this.products1DataSet2;
            // 
            // productsDBTableAdapter2
            // 
            this.productsDBTableAdapter2.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // услугиDataGridViewTextBoxColumn
            // 
            this.услугиDataGridViewTextBoxColumn.DataPropertyName = "Услуги";
            this.услугиDataGridViewTextBoxColumn.HeaderText = "Услуги";
            this.услугиDataGridViewTextBoxColumn.Name = "услугиDataGridViewTextBoxColumn";
            this.услугиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ставкачасDataGridViewTextBoxColumn
            // 
            this.ставкачасDataGridViewTextBoxColumn.DataPropertyName = "Ставка/час";
            this.ставкачасDataGridViewTextBoxColumn.HeaderText = "Ставка/час";
            this.ставкачасDataGridViewTextBoxColumn.Name = "ставкачасDataGridViewTextBoxColumn";
            this.ставкачасDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(656, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDBBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Products1DataSet products1DataSet;
        private System.Windows.Forms.BindingSource products1DataSetBindingSource;
        private System.Windows.Forms.BindingSource productsDBBindingSource;
        private Products1DataSetTableAdapters.ProductsDBTableAdapter productsDBTableAdapter;
        private System.Windows.Forms.BindingSource products1DataSetBindingSource1;
        private Products1DataSet1 products1DataSet1;
        private System.Windows.Forms.BindingSource productsDBBindingSource1;
        private Products1DataSet1TableAdapters.ProductsDBTableAdapter productsDBTableAdapter1;
        private Products1DataSet2 products1DataSet2;
        private System.Windows.Forms.BindingSource productsDBBindingSource2;
        private Products1DataSet2TableAdapters.ProductsDBTableAdapter productsDBTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкачасDataGridViewTextBoxColumn;
    }
}

