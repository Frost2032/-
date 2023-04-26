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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП_ИСРПО
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text != "" && txtPassword.Text != ""&& cmbRole.Text !="")
            {
                if (txtPassword1.Text == txtPassword.Text)
                {
                    if (txtPassword.Text.Length >= 6 && txtPassword1.Text.Length >= 6)
                    {
                        string login = txtlogin.Text.Trim();
                        string password = txtPassword.Text.Trim();
                        string Role =cmbRole.Text.Trim();



                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LO375IE\MSSQLSERVER01;Integrated Security=True;Initial Catalog=Stadionmihaylov");
                        string query = "SELECT* FROM asd WHERE Login = '" + login + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже существует");
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            string inserquery = "INSERT INTO asd (Login,Password,Role) VALUES ('" + login + "','" + password + "','"+Role+"')";
                            SqlCommand cmd2 = new SqlCommand(inserquery, con);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы");
                            Авторизация.ActiveForm.Close();
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен иметь длину больше или равно 5 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Авторизация frm1 = new Авторизация();
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtlogin.Text = "";
            txtPassword.Text = "";
            txtPassword1.Text = "";
            cmbRole.Text = "";
        }
    }
}
