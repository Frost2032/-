namespace УП_ИСРПО
{
    partial class Билеты
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
            this.stadionmihaylovDataSet1 = new УП_ИСРПО.StadionmihaylovDataSet1();
            this.prodazhabiletovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodazha_biletovTableAdapter = new УП_ИСРПО.StadionmihaylovDataSet1TableAdapters.Prodazha_biletovTableAdapter();
            this.idbiletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idraspisaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvozvrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senabiletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhabiletovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbiletaDataGridViewTextBoxColumn,
            this.idraspisaniaDataGridViewTextBoxColumn,
            this.idvozvrataDataGridViewTextBoxColumn,
            this.senabiletaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodazhabiletovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // stadionmihaylovDataSet1
            // 
            this.stadionmihaylovDataSet1.DataSetName = "StadionmihaylovDataSet1";
            this.stadionmihaylovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodazhabiletovBindingSource
            // 
            this.prodazhabiletovBindingSource.DataMember = "Prodazha_biletov";
            this.prodazhabiletovBindingSource.DataSource = this.stadionmihaylovDataSet1;
            // 
            // prodazha_biletovTableAdapter
            // 
            this.prodazha_biletovTableAdapter.ClearBeforeFill = true;
            // 
            // idbiletaDataGridViewTextBoxColumn
            // 
            this.idbiletaDataGridViewTextBoxColumn.DataPropertyName = "Id_bileta";
            this.idbiletaDataGridViewTextBoxColumn.HeaderText = "Id_bileta";
            this.idbiletaDataGridViewTextBoxColumn.Name = "idbiletaDataGridViewTextBoxColumn";
            // 
            // idraspisaniaDataGridViewTextBoxColumn
            // 
            this.idraspisaniaDataGridViewTextBoxColumn.DataPropertyName = "Id_raspisania";
            this.idraspisaniaDataGridViewTextBoxColumn.HeaderText = "Id_raspisania";
            this.idraspisaniaDataGridViewTextBoxColumn.Name = "idraspisaniaDataGridViewTextBoxColumn";
            // 
            // idvozvrataDataGridViewTextBoxColumn
            // 
            this.idvozvrataDataGridViewTextBoxColumn.DataPropertyName = "Id_vozvrata";
            this.idvozvrataDataGridViewTextBoxColumn.HeaderText = "Id_vozvrata";
            this.idvozvrataDataGridViewTextBoxColumn.Name = "idvozvrataDataGridViewTextBoxColumn";
            // 
            // senabiletaDataGridViewTextBoxColumn
            // 
            this.senabiletaDataGridViewTextBoxColumn.DataPropertyName = "Sena_bileta";
            this.senabiletaDataGridViewTextBoxColumn.HeaderText = "Sena_bileta";
            this.senabiletaDataGridViewTextBoxColumn.Name = "senabiletaDataGridViewTextBoxColumn";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 194);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Билеты на продажу";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Имеющиеся билеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Билеты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Билеты";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Билеты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhabiletovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StadionmihaylovDataSet1 stadionmihaylovDataSet1;
        private System.Windows.Forms.BindingSource prodazhabiletovBindingSource;
        private StadionmihaylovDataSet1TableAdapters.Prodazha_biletovTableAdapter prodazha_biletovTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbiletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idraspisaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozvrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senabiletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}