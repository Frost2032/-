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
    public partial class Возврат_билетов : Form
    {
        public Возврат_билетов()
        {
            InitializeComponent();
        }

        private void Возврат_билетов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stadionmihaylovDataSet1.Vozvrat_biletov". При необходимости она может быть перемещена или удалена.
            this.vozvrat_biletovTableAdapter.Fill(this.stadionmihaylovDataSet1.Vozvrat_biletov);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Расписание frm1 = new Расписание();
            frm1.Show();
            this.Hide();
        }
    }
}
