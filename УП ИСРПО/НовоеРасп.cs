using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП_ИСРПО
{
    public partial class НовоеРасп : Form
    {
        public НовоеРасп()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Расписание frm1 = new Расписание();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                string ID = textBox1.Text;
                string Name_stad = textBox2.Text;
                string Data_otkr = textBox3.Text;
                string Data_zakr = textBox4.Text;
                string Vid_matcha = textBox5.Text;

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LO375IE\MSSQLSERVER01;Initial Catalog=Stadionmihaylov;Integrated Security=True");
                con.Open();


                string query = "INSERT INTO Raspisanie_matchey (Id_raspisania,Name_stadion, Data_otkrunia, Data_zakrunia, Vid_matcha) VALUES ('" + ID + "','" + Name_stad + "','" + Data_otkr + "','" + Data_zakr + "','" + Vid_matcha + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Вы успешно добавили новое расписание");
                Расписание.ActiveForm.Close();
                con.Close();
            }
        }
    }
}
