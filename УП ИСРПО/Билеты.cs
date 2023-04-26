using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_ИСРПО
{
    public partial class Билеты : Form
    {
        public Билеты()
        {
            InitializeComponent();
        }

        private void Билеты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stadionmihaylovDataSet1.Prodazha_biletov". При необходимости она может быть перемещена или удалена.
            this.prodazha_biletovTableAdapter.Fill(this.stadionmihaylovDataSet1.Prodazha_biletov);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Расписание frm1 = new Расписание();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Наличие_билетов frm1 = new Наличие_билетов();
            frm1.Show();
            this.Hide();
        }
    }
}
