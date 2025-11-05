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
using MySql.Data.MySqlClient;

namespace heavenHotel
{
    public partial class Foglaláskezelő : Form
    {
        private Button btn;   

        public Foglaláskezelő()
        {
            InitializeComponent();
        }
        private void SzobakSzinezese()
        {
            // Get selected dates
            DateTime erkezes = dtpErkezes.Value.Date;
            DateTime tavozas = dtpTavozas.Value.Date;

            // Get all room names
            List<string> szobak = new List<string>();
            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=heaven_hotel;username=root;password=mysql"))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT szobanev FROM szobak ORDER BY szobaazonosito", connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        szobak.Add(reader.GetString("szobanev"));
                    }
                }
            }

            // Get booked rooms for the selected period
            HashSet<string> foglaltSzobak = new HashSet<string>();
            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=heaven_hotel;username=root;password=mysql"))
            {
                connection.Open();
                string query = @"
                SELECT s1.szobanev
                FROM szobak s1
                INNER JOIN foglalasok f ON s1.szobaazonosito = f.szobaid
                WHERE
                    (f.erkezes < @tavozas) AND
                    (f.tavozas > @erkezes)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@erkezes", erkezes);
                    cmd.Parameters.AddWithValue("@tavozas", tavozas);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foglaltSzobak.Add(reader.GetString("szobanev"));
                        }
                    }
                }
            }

            // Color the buttons
            for (int r = 0; r < dgvTalalatok.Rows.Count; r++)
            {
                for (int c = 0; c < dgvTalalatok.Columns.Count; c++)
                {
                    var cell = dgvTalalatok.Rows[r].Cells[c];
                    string szobaNev = cell.Value?.ToString();
                    if (string.IsNullOrWhiteSpace(szobaNev)) continue;

                    if (foglaltSzobak.Contains(szobaNev))
                    {
                        cell.Style.BackColor = Color.LightCoral; // Light red
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightGreen; // Light green
                    }
                }
            }
        }
        private void Foglaláskezelő_Load(object sender, EventArgs e)
        {
            dgvTalalatok.Columns.Clear();
            dgvTalalatok.Rows.Clear();

            for (int i = 1; i <= 5; i++)
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    UseColumnTextForButtonValue = false
                };
                dgvTalalatok.Columns.Add(btnCol);
            }
            dgvTalalatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<string> szobak = new List<string>();
            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=heaven_hotel;username=root;password=mysql"))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT szobanev FROM szobak ORDER BY szobaazonosito", connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        szobak.Add(reader.GetString("szobanev"));
                    }
                }
            }

            for (int row = 0; row < szobak.Count; row += 5)
            {
                var rowRooms = szobak.Skip(row).Take(5).ToArray();
                int colCount = dgvTalalatok.Columns.Count;
                object[] cells = new object[colCount];
                for (int i = 0; i < colCount; i++)
                {
                    cells[i] = i < rowRooms.Length ? rowRooms[i] : "";
                }
                dgvTalalatok.Rows.Add(cells);
            }

            SzobakSzinezese();
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
            label1.Visible = true;
            DateTime erkezes = dtpErkezes.Value.Date;
            DateTime tavozas = dtpTavozas.Value.Date;

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=heaven_hotel;username=root;password=mysql"))
            {
                connection.Open();

                // 1️⃣ Megnézzük, van-e szabad szoba a megadott időszakban
                string checkQuery = @"
            SELECT COUNT(*) 
            FROM szobak 
            WHERE szobaazonosito NOT IN (
                SELECT szobaid FROM foglalasok
                WHERE @erkezes < tavozas AND @tavozas > erkezes
            );";

                using (MySqlCommand cmd = new MySqlCommand(checkQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@erkezes", erkezes);
                    cmd.Parameters.AddWithValue("@tavozas", tavozas);

                    int szabadSzobak = Convert.ToInt32(cmd.ExecuteScalar());

                    if (szabadSzobak > 0)
                    {
                        label1.Text = "✅ Van szabad szoba!";
                        label1.ForeColor = Color.Green;
                        return;
                    }
                }

                // 2️⃣ Ha nincs szabad szoba, nézzük meg, mikortól lesz a legközelebbi
                string nextFreeQuery = @"
            SELECT MIN(tavozas)
            FROM foglalasok
            WHERE tavozas > @tavozas;";

                using (MySqlCommand cmdNext = new MySqlCommand(nextFreeQuery, connection))
                {
                    cmdNext.Parameters.AddWithValue("@tavozas", tavozas);

                    object result = cmdNext.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        DateTime nextAvailable = Convert.ToDateTime(result);
                        label1.Text = $"❌ Nincs szabad szoba.\nLegközelebbi szabad időpont: {nextAvailable:yyyy-MM-dd}";
                        label1.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        label1.Text = "❌ Jelenleg minden szoba foglalt, és nincs további adat a foglalásokról.";
                        label1.ForeColor = Color.Red;
                    }
                }
                
            }
        }


        private void dtpErkezes_ValueChanged(object sender, EventArgs e)
        {
            SzobakSzinezese();
        }

        private void dtpTavozas_ValueChanged(object sender, EventArgs e)
        {
            SzobakSzinezese();
        }
       

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            FoglalasiAdatok frm = new FoglalasiAdatok();
            frm.Show();
            this.Hide();
        }
    }
}
