namespace WindowsFormsApp1
{
    partial class Tovar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Добавить = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.testDataSet1 = new WindowsFormsApp1.testDataSet1();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new WindowsFormsApp1.testDataSet1TableAdapters.tovarTableAdapter();
            this.nametovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdelenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nametovarDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.postavshikDataGridViewTextBoxColumn,
            this.otdelenDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя товара";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(648, 44);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 32);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 32);
            this.textBox1.TabIndex = 7;
            // 
            // Добавить
            // 
            this.Добавить.Location = new System.Drawing.Point(648, 185);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(115, 33);
            this.Добавить.TabIndex = 6;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 115);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(551, 32);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Отделение";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(247, 185);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 32);
            this.textBox4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Цена";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(528, 185);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 32);
            this.textBox5.TabIndex = 15;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.testDataSet1;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // nametovarDataGridViewTextBoxColumn
            // 
            this.nametovarDataGridViewTextBoxColumn.DataPropertyName = "name_tovar";
            this.nametovarDataGridViewTextBoxColumn.HeaderText = "имя товара";
            this.nametovarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nametovarDataGridViewTextBoxColumn.Name = "nametovarDataGridViewTextBoxColumn";
            this.nametovarDataGridViewTextBoxColumn.ReadOnly = true;
            this.nametovarDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "количество товара";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // postavshikDataGridViewTextBoxColumn
            // 
            this.postavshikDataGridViewTextBoxColumn.DataPropertyName = "postavshik";
            this.postavshikDataGridViewTextBoxColumn.HeaderText = "поставщик";
            this.postavshikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postavshikDataGridViewTextBoxColumn.Name = "postavshikDataGridViewTextBoxColumn";
            this.postavshikDataGridViewTextBoxColumn.ReadOnly = true;
            this.postavshikDataGridViewTextBoxColumn.Width = 125;
            // 
            // otdelenDataGridViewTextBoxColumn
            // 
            this.otdelenDataGridViewTextBoxColumn.DataPropertyName = "otdelen";
            this.otdelenDataGridViewTextBoxColumn.HeaderText = "отделение";
            this.otdelenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otdelenDataGridViewTextBoxColumn.Name = "otdelenDataGridViewTextBoxColumn";
            this.otdelenDataGridViewTextBoxColumn.ReadOnly = true;
            this.otdelenDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(247, 300);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(326, 32);
            this.textBox6.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Имя товара для удаления ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Удалить товар ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tovar";
            this.Text = "Tovar";
            this.Load += new System.EventHandler(this.Tovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private testDataSet1TableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdelenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}