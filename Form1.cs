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

            dgvTalalatok.Columns.Clear();
            dgvTalalatok.Rows.Clear();

            // Add 5 columns for rooms
            for (int i = 1; i <= 5; i++)
            {
                dgvTalalatok.Columns.Add($"Szoba{i}", $"Szoba {i}");
            }
            dgvTalalatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Prepare room names
            List<string> szobak = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                szobak.Add($"Szoba {i + 1}");
            }

            // Add rooms to rows, 5 per row
            for (int row = 0; row < szobak.Count; row += 5)
            {
                var rowRooms = szobak.Skip(row).Take(5).ToArray();
                dgvTalalatok.Rows.Add(rowRooms);
            }


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
           
        }

    }
}
