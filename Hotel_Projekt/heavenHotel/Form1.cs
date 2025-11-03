using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heavenHotel
{
    public partial class Foglaláskezelő : Form
    {
        private Button btn;   

        public Foglaláskezelő()
        {
            InitializeComponent();
        }

        private void Foglaláskezelő_Load(object sender, EventArgs e)
        {

        }

        private void btnAPEH_Click_1(object sender, EventArgs e)
        {
            APEH frm = new APEH();
            frm.Show();
            this.Hide();
        }

        private void dgvTalalatok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            btn = new Button();
            DataTable dt = new DataTable();
            dt.
        }
    }
}
