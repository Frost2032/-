namespace УП_ИСРПО
{
    partial class Расписание
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
            this.idraspisaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestadionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataotkruniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazakruniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidmatchaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raspisaniematcheyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stadionmihaylovDataSet1 = new УП_ИСРПО.StadionmihaylovDataSet1();
            this.raspisaniematcheyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadionmihaylovDataSet = new УП_ИСРПО.StadionmihaylovDataSet();
            this.NewRasp = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.userTableAdapter = new УП_ИСРПО.StadionmihaylovDataSetTableAdapters.UserTableAdapter();
            this.dataSet11 = new УП_ИСРПО.DataSet11();
            this.asdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asdTableAdapter = new УП_ИСРПО.DataSet11TableAdapters.asdTableAdapter();
            this.raspisanie_matcheyTableAdapter = new УП_ИСРПО.StadionmihaylovDataSet1TableAdapters.Raspisanie_matcheyTableAdapter();
            this.Poisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.bilety = new System.Windows.Forms.Button();
            this.bilety1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisaniematcheyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisaniematcheyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idraspisaniaDataGridViewTextBoxColumn,
            this.namestadionDataGridViewTextBoxColumn,
            this.dataotkruniaDataGridViewTextBoxColumn,
            this.datazakruniaDataGridViewTextBoxColumn,
            this.vidmatchaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raspisaniematcheyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // idraspisaniaDataGridViewTextBoxColumn
            // 
            this.idraspisaniaDataGridViewTextBoxColumn.DataPropertyName = "Id_raspisania";
            this.idraspisaniaDataGridViewTextBoxColumn.HeaderText = "Id_raspisania";
            this.idraspisaniaDataGridViewTextBoxColumn.Name = "idraspisaniaDataGridViewTextBoxColumn";
            // 
            // namestadionDataGridViewTextBoxColumn
            // 
            this.namestadionDataGridViewTextBoxColumn.DataPropertyName = "Name_stadion";
            this.namestadionDataGridViewTextBoxColumn.HeaderText = "Name_stadion";
            this.namestadionDataGridViewTextBoxColumn.Name = "namestadionDataGridViewTextBoxColumn";
            // 
            // dataotkruniaDataGridViewTextBoxColumn
            // 
            this.dataotkruniaDataGridViewTextBoxColumn.DataPropertyName = "Data_otkrunia";
            this.dataotkruniaDataGridViewTextBoxColumn.HeaderText = "Data_otkrunia";
            this.dataotkruniaDataGridViewTextBoxColumn.Name = "dataotkruniaDataGridViewTextBoxColumn";
            // 
            // datazakruniaDataGridViewTextBoxColumn
            // 
            this.datazakruniaDataGridViewTextBoxColumn.DataPropertyName = "Data_zakrunia";
            this.datazakruniaDataGridViewTextBoxColumn.HeaderText = "Data_zakrunia";
            this.datazakruniaDataGridViewTextBoxColumn.Name = "datazakruniaDataGridViewTextBoxColumn";
            // 
            // vidmatchaDataGridViewTextBoxColumn
            // 
            this.vidmatchaDataGridViewTextBoxColumn.DataPropertyName = "Vid_matcha";
            this.vidmatchaDataGridViewTextBoxColumn.HeaderText = "Vid_matcha";
            this.vidmatchaDataGridViewTextBoxColumn.Name = "vidmatchaDataGridViewTextBoxColumn";
            // 
            // raspisaniematcheyBindingSource1
            // 
            this.raspisaniematcheyBindingSource1.DataMember = "Raspisanie_matchey";
            this.raspisaniematcheyBindingSource1.DataSource = this.stadionmihaylovDataSet1;
            // 
            // stadionmihaylovDataSet1
            // 
            this.stadionmihaylovDataSet1.DataSetName = "StadionmihaylovDataSet1";
            this.stadionmihaylovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raspisaniematcheyBindingSource
            // 
            this.raspisaniematcheyBindingSource.DataMember = "Raspisanie_matchey";
            this.raspisaniematcheyBindingSource.DataSource = this.stadionmihaylovDataSet1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.stadionmihaylovDataSet;
            // 
            // stadionmihaylovDataSet
            // 
            this.stadionmihaylovDataSet.DataSetName = "StadionmihaylovDataSet";
            this.stadionmihaylovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewRasp
            // 
            this.NewRasp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewRasp.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NewRasp.Location = new System.Drawing.Point(444, 354);
            this.NewRasp.Name = "NewRasp";
            this.NewRasp.Size = new System.Drawing.Size(124, 24);
            this.NewRasp.TabIndex = 1;
            this.NewRasp.Text = "Новое расписание";
            this.NewRasp.UseVisualStyleBackColor = true;
            this.NewRasp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Back.Location = new System.Drawing.Point(21, 410);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 24);
            this.Back.TabIndex = 2;
            this.Back.Text = "К началу";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet11";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asdBindingSource
            // 
            this.asdBindingSource.DataMember = "asd";
            this.asdBindingSource.DataSource = this.dataSet11;
            // 
            // asdTableAdapter
            // 
            this.asdTableAdapter.ClearBeforeFill = true;
            // 
            // raspisanie_matcheyTableAdapter
            // 
            this.raspisanie_matcheyTableAdapter.ClearBeforeFill = true;
            // 
            // Poisk
            // 
            this.Poisk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Poisk.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Poisk.Location = new System.Drawing.Point(162, 353);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(81, 24);
            this.Poisk.TabIndex = 7;
            this.Poisk.Text = "Поиск";
            this.Poisk.UseVisualStyleBackColor = true;
            this.Poisk.Click += new System.EventHandler(this.Poisk_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnFiltr
            // 
            this.btnFiltr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFiltr.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFiltr.Location = new System.Drawing.Point(21, 380);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(81, 24);
            this.btnFiltr.TabIndex = 8;
            this.btnFiltr.Text = "Фильтр";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUpdate.Location = new System.Drawing.Point(580, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 24);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Обновление";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnSort
            // 
            this.btnSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSort.Location = new System.Drawing.Point(249, 353);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(81, 24);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Сортировка";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.Location = new System.Drawing.Point(582, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 24);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удаление";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // bntSave
            // 
            this.bntSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bntSave.Location = new System.Drawing.Point(582, 12);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(81, 24);
            this.bntSave.TabIndex = 13;
            this.bntSave.Text = "Сохранить";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.button5_Click);
            // 
            // bilety
            // 
            this.bilety.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bilety.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bilety.Location = new System.Drawing.Point(336, 383);
            this.bilety.Name = "bilety";
            this.bilety.Size = new System.Drawing.Size(81, 24);
            this.bilety.TabIndex = 14;
            this.bilety.Text = "Билеты";
            this.bilety.UseVisualStyleBackColor = true;
            this.bilety.Click += new System.EventHandler(this.bilety_Click);
            // 
            // bilety1
            // 
            this.bilety1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bilety1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bilety1.Location = new System.Drawing.Point(336, 353);
            this.bilety1.Name = "bilety1";
            this.bilety1.Size = new System.Drawing.Size(102, 24);
            this.bilety1.TabIndex = 15;
            this.bilety1.Text = "Возврат билетов";
            this.bilety1.UseVisualStyleBackColor = true;
            this.bilety1.Click += new System.EventHandler(this.bilety1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-9, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Расписание
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bilety1);
            this.Controls.Add(this.bilety);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NewRasp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Расписание";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Расписание_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisaniematcheyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisaniematcheyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button NewRasp;
        public System.Windows.Forms.Button Back;
        private StadionmihaylovDataSet stadionmihaylovDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private StadionmihaylovDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private DataSet11 dataSet11;
        private System.Windows.Forms.BindingSource asdBindingSource;
        private DataSet11TableAdapters.asdTableAdapter asdTableAdapter;
        private StadionmihaylovDataSet1 stadionmihaylovDataSet1;
        private System.Windows.Forms.BindingSource raspisaniematcheyBindingSource;
        private StadionmihaylovDataSet1TableAdapters.Raspisanie_matcheyTableAdapter raspisanie_matcheyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idraspisaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestadionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataotkruniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazakruniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidmatchaDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button Poisk;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource raspisaniematcheyBindingSource1;
        public System.Windows.Forms.Button btnSort;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button bntSave;
        public System.Windows.Forms.Button bilety;
        public System.Windows.Forms.Button bilety1;
        private System.Windows.Forms.Label label1;
    }
}