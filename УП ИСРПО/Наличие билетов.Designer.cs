namespace УП_ИСРПО
{
    partial class Наличие_билетов
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
            this.idbiletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalichiebiletaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.biletyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadionmihaylovDataSet1 = new УП_ИСРПО.StadionmihaylovDataSet1();
            this.biletyTableAdapter = new УП_ИСРПО.StadionmihaylovDataSet1TableAdapters.BiletyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbiletaDataGridViewTextBoxColumn,
            this.nalichiebiletaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.biletyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 132);
            this.dataGridView1.TabIndex = 0;
            // 
            // idbiletaDataGridViewTextBoxColumn
            // 
            this.idbiletaDataGridViewTextBoxColumn.DataPropertyName = "Id_bileta";
            this.idbiletaDataGridViewTextBoxColumn.HeaderText = "Id_bileta";
            this.idbiletaDataGridViewTextBoxColumn.Name = "idbiletaDataGridViewTextBoxColumn";
            // 
            // nalichiebiletaDataGridViewCheckBoxColumn
            // 
            this.nalichiebiletaDataGridViewCheckBoxColumn.DataPropertyName = "Nalichie_bileta";
            this.nalichiebiletaDataGridViewCheckBoxColumn.HeaderText = "Nalichie_bileta";
            this.nalichiebiletaDataGridViewCheckBoxColumn.Name = "nalichiebiletaDataGridViewCheckBoxColumn";
            // 
            // biletyBindingSource
            // 
            this.biletyBindingSource.DataMember = "Bilety";
            this.biletyBindingSource.DataSource = this.stadionmihaylovDataSet1;
            // 
            // stadionmihaylovDataSet1
            // 
            this.stadionmihaylovDataSet1.DataSetName = "StadionmihaylovDataSet1";
            this.stadionmihaylovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletyTableAdapter
            // 
            this.biletyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о наличии билетов";
            // 
            // Наличие_билетов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(269, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Наличие_билетов";
            this.Text = "Наличие_билетов";
            this.Load += new System.EventHandler(this.Наличие_билетов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StadionmihaylovDataSet1 stadionmihaylovDataSet1;
        private System.Windows.Forms.BindingSource biletyBindingSource;
        private StadionmihaylovDataSet1TableAdapters.BiletyTableAdapter biletyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbiletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nalichiebiletaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}