namespace УП_ИСРПО
{
    partial class Возврат_билетов
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
            this.idvozvrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shtrafDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datavozvrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozvratbiletovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadionmihaylovDataSet1 = new УП_ИСРПО.StadionmihaylovDataSet1();
            this.vozvrat_biletovTableAdapter = new УП_ИСРПО.StadionmihaylovDataSet1TableAdapters.Vozvrat_biletovTableAdapter();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvratbiletovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvozvrataDataGridViewTextBoxColumn,
            this.shtrafDataGridViewCheckBoxColumn,
            this.datavozvrataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vozvratbiletovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // idvozvrataDataGridViewTextBoxColumn
            // 
            this.idvozvrataDataGridViewTextBoxColumn.DataPropertyName = "Id_vozvrata";
            this.idvozvrataDataGridViewTextBoxColumn.HeaderText = "Id_vozvrata";
            this.idvozvrataDataGridViewTextBoxColumn.Name = "idvozvrataDataGridViewTextBoxColumn";
            // 
            // shtrafDataGridViewCheckBoxColumn
            // 
            this.shtrafDataGridViewCheckBoxColumn.DataPropertyName = "Shtraf";
            this.shtrafDataGridViewCheckBoxColumn.HeaderText = "Shtraf";
            this.shtrafDataGridViewCheckBoxColumn.Name = "shtrafDataGridViewCheckBoxColumn";
            // 
            // datavozvrataDataGridViewTextBoxColumn
            // 
            this.datavozvrataDataGridViewTextBoxColumn.DataPropertyName = "Data_vozvrata";
            this.datavozvrataDataGridViewTextBoxColumn.HeaderText = "Data_vozvrata";
            this.datavozvrataDataGridViewTextBoxColumn.Name = "datavozvrataDataGridViewTextBoxColumn";
            // 
            // vozvratbiletovBindingSource
            // 
            this.vozvratbiletovBindingSource.DataMember = "Vozvrat_biletov";
            this.vozvratbiletovBindingSource.DataSource = this.stadionmihaylovDataSet1;
            // 
            // stadionmihaylovDataSet1
            // 
            this.stadionmihaylovDataSet1.DataSetName = "StadionmihaylovDataSet1";
            this.stadionmihaylovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozvrat_biletovTableAdapter
            // 
            this.vozvrat_biletovTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(11, 244);
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
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Билеты подлежащие возврату";
            // 
            // Возврат_билетов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Возврат_билетов";
            this.Text = "Возврат_билетов";
            this.Load += new System.EventHandler(this.Возврат_билетов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvratbiletovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StadionmihaylovDataSet1 stadionmihaylovDataSet1;
        private System.Windows.Forms.BindingSource vozvratbiletovBindingSource;
        private StadionmihaylovDataSet1TableAdapters.Vozvrat_biletovTableAdapter vozvrat_biletovTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozvrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn shtrafDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavozvrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
    }
}