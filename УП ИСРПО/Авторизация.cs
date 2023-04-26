using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace УП_ИСРПО
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-LO375IE\MSSQLSERVER01;Initial Catalog=Stadionmihaylov;Integrated Security=True");
            string query = "SELECT * FROM asd WHERE Login = '" + cmbLogin.Text + "' and Password = '" + txtPassword.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    object Login = rdr.GetValue(0);
                    object Password = rdr.GetValue(1);
                    object Role = rdr.GetValue(2);

                    string User_Login = Login.ToString();
                    string Password_Login = Password.ToString();
                    string Role_Login = Role.ToString();
                    if (Role_Login == "True")
                    {
                        Расписание fra = new Расписание();
                        fra.NewRasp.Visible = true;
                        fra.Back.Visible = true;
                        fra.NewRasp.Visible = true;
                        fra.Poisk.Visible = true;
                        fra.btnUpdate.Visible = true;
                        fra.btnFiltr.Visible = true;
                        fra.btnSort.Visible = true;
                        fra.btnDelete.Visible = true;
                        fra.bntSave.Visible = true;
                        fra.bilety.Visible = false;
                        fra.bilety1.Visible = false;
                        fra.Show();
                        this.Hide();
                    }
                    else if (Role_Login == "False")
                    {
                        Расписание frm3 = new Расписание();
                        frm3.NewRasp.Visible = true;
                        frm3.Back.Visible = true;
                        frm3.NewRasp.Visible = false;
                        frm3.Poisk.Visible = true;
                        frm3.btnUpdate.Visible = true;
                        frm3.btnFiltr.Visible = true;
                        frm3.btnSort.Visible = true;
                        frm3.btnDelete.Visible = false;
                        frm3.bntSave.Visible = true;
                        frm3.bilety.Visible = true;
                        frm3.bilety1.Visible = true;
                        frm3.Show();
                        this.Hide();
                    }

                }

            }
            else
            {
                MessageBox.Show("Не правильный пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация frm1 = new Регистрация();
            frm1.Show();
            this.Hide();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stadionmihaylovDataSet2.asd". При необходимости она может быть перемещена или удалена.
            this.asdTableAdapter.Fill(this.stadionmihaylovDataSet2.asd);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
