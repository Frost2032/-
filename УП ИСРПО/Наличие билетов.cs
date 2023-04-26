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
    public partial class Наличие_билетов : Form
    {
        public Наличие_билетов()
        {
            InitializeComponent();
        }

        private void Наличие_билетов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stadionmihaylovDataSet1.Bilety". При необходимости она может быть перемещена или удалена.
            this.biletyTableAdapter.Fill(this.stadionmihaylovDataSet1.Bilety);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Билеты frm1 = new Билеты();
            frm1.Show();
            this.Hide();
        }
    }
}
