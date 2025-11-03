using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heavenHotel
{
    public partial class FoglalasiAdatok : Form
    {
        public FoglalasiAdatok()
        {
            InitializeComponent();
        }

        private void FoglalasiAdatok_Load(object sender, EventArgs e)
        {

        }

        private void btnVissza2_Click(object sender, EventArgs e)
        {
            Foglaláskezelő frm = new Foglaláskezelő();
            frm.Show();
            this.Hide();
        }
    }
}
