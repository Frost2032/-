﻿namespace УП_ИСРПО
{
    partial class Авторизация
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
            this.ВХОД = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.asdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadionmihaylovDataSet2 = new УП_ИСРПО.StadionmihaylovDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.Регистрация = new System.Windows.Forms.Button();
            this.asdTableAdapter = new УП_ИСРПО.StadionmihaylovDataSet2TableAdapters.asdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.asdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ВХОД
            // 
            this.ВХОД.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ВХОД.Location = new System.Drawing.Point(116, 180);
            this.ВХОД.Name = "ВХОД";
            this.ВХОД.Size = new System.Drawing.Size(94, 24);
            this.ВХОД.TabIndex = 0;
            this.ВХОД.Text = "Вход";
            this.ВХОД.UseVisualStyleBackColor = true;
            this.ВХОД.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(140, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbLogin
            // 
            this.cmbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLogin.DataSource = this.asdBindingSource;
            this.cmbLogin.DisplayMember = "Login";
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(140, 85);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(125, 21);
            this.cmbLogin.TabIndex = 5;
            this.cmbLogin.ValueMember = "Login";
            this.cmbLogin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // asdBindingSource
            // 
            this.asdBindingSource.DataMember = "asd";
            this.asdBindingSource.DataSource = this.stadionmihaylovDataSet2;
            // 
            // stadionmihaylovDataSet2
            // 
            this.stadionmihaylovDataSet2.DataSetName = "StadionmihaylovDataSet2";
            this.stadionmihaylovDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Регистрация
            // 
            this.Регистрация.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Регистрация.Location = new System.Drawing.Point(116, 219);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(94, 24);
            this.Регистрация.TabIndex = 7;
            this.Регистрация.Text = "Регистрация";
            this.Регистрация.UseVisualStyleBackColor = true;
            this.Регистрация.Click += new System.EventHandler(this.button2_Click);
            // 
            // asdTableAdapter
            // 
            this.asdTableAdapter.ClearBeforeFill = true;
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 272);
            this.Controls.Add(this.Регистрация);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ВХОД);
            this.Name = "Авторизация";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Авторизация_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadionmihaylovDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ВХОД;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Регистрация;
        private StadionmihaylovDataSet2 stadionmihaylovDataSet2;
        private System.Windows.Forms.BindingSource asdBindingSource;
        private StadionmihaylovDataSet2TableAdapters.asdTableAdapter asdTableAdapter;
    }
}