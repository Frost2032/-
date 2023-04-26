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
    public partial class Расписание : Form
    {
        public Расписание()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            НовоеРасп frm1 = new НовоеРасп();
            frm1.Show();
            this.Hide();
        }

        private void Расписание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stadionmihaylovDataSet1.Raspisanie_matchey". При необходимости она может быть перемещена или удалена.
            this.raspisanie_matcheyTableAdapter.Fill(this.stadionmihaylovDataSet1.Raspisanie_matchey);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Авторизация frm1 = new Авторизация();
            frm1.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Poisk_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.raspisanie_matcheyTableAdapter.Fill(this.stadionmihaylovDataSet1.Raspisanie_matchey);
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name_stadion LIKE '%{textBox1.Text}%'";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }
        private void UpdateDB()
        {

            string sql = @"Data source= DESKTOP-LO375IE\MSSQLSERVER01; Initial Catalog=Stadionmihaylov;Integrated Security=True ";
            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter raspisanie_matcheyTableAdapter = new SqlDataAdapter();
            SqlCommandBuilder Conbuild = new SqlCommandBuilder(raspisanie_matcheyTableAdapter);
            StadionmihaylovDataSet1 StadionmihaylovDataSet1 = new StadionmihaylovDataSet1();
            raspisanie_matcheyTableAdapter.Update(StadionmihaylovDataSet1.Raspisanie_matchey);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-LO375IE\MSSQLSERVER01;Initial Catalog =Stadionmihaylov; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Raspisanie_matchey Order By Name_stadion desc", con);
            con.Open();
            da.Fill(ds, "Raspisanie_matchey");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con.Dispose();
            ds.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)

            {
                dataGridView1.Rows.Remove(row);
            }
            MessageBox.Show(
                "Вы точно хотите удалить?", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection(@"Data source= DESKTOP-LO375IE\MSSQLSERVER01; Initial Catalog=Stadionmihaylov;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Raspisanie_matchey", con2);

                DataTable dt = new DataTable();
                adapter.Fill(dt);


                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataGridView1.EndEdit();
                adapter.Update(dt);
                MessageBox.Show("Изменения сохранены успешно!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void bilety_Click(object sender, EventArgs e)
        {
            Билеты frm1 = new Билеты();
            frm1.Show();
            this.Hide();
        }

        private void bilety1_Click(object sender, EventArgs e)
        {
            Возврат_билетов f = new Возврат_билетов();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}