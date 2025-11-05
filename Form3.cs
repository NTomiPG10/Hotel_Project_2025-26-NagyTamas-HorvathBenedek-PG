using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        // Add the following constructor to the FoglalasiAdatok class to fix the CS1729 error.  

        // Existing members of the class...  

        // Add this constructor to accept a string parameter.  
        public FoglalasiAdatok(string szobaNev)
        {
            InitializeComponent();
            // You can use the szobaNev parameter here if needed.  
            // For example, you might want to display it in a TextBox or Label.  
            textBox1.Text = szobaNev;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 1️⃣ Adatok beolvasása az űrlapról
            string vendegNev = textBox2.Text.Trim();
            string nemzet = textBox5.Text.Trim();
            string allapot = "";
            if (comboBox1.Text.Trim() == "Fizet")
            {
                allapot = "fizetett";
            }
            else if (comboBox1.Text.Trim() == "Foglal")
            {
                allapot = "foglalt";
            }
            string szallofo = textBox8.Text.Trim();


            string telfon = textBox2.Text.Trim();

            DateTime erkezes = dateTimePicker1.Value.Date;
            DateTime tavozas = dateTimePicker2.Value.Date;

            if (textBox2.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Kérem, töltse ki az összes mezőt!", "Hiányzó adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (erkezes >= tavozas)
            {
                MessageBox.Show("A távozás dátumának későbbinek kell lennie, mint az érkezésnek!", "Dátum hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool vanSzabadSzoba = false;
            int szabadSzobaId = -1;

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=heaven_hotel;username=root;password=mysql"))
            {
                connection.Open();

                // 2️⃣ Ellenőrizzük, hogy van-e szabad szoba az adott időpontban
                string checkQuery = @"
            SELECT szobaazonosito 
            FROM szobak 
            WHERE szobaazonosito NOT IN (
                SELECT szobaid 
                FROM foglalasok
                WHERE @erkezes < tavozas 
                AND @tavozas > erkezes
            )
            LIMIT 1;";

                using (MySqlCommand cmd = new MySqlCommand(checkQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@erkezes", erkezes);
                    cmd.Parameters.AddWithValue("@tavozas", tavozas);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        vanSzabadSzoba = true;
                        szabadSzobaId = Convert.ToInt32(result);
                    }
                }

                if (!vanSzabadSzoba)
                {
                    MessageBox.Show("Nincs szabad szoba ebben az időszakban!", "Foglalási hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3️⃣ Vendég beszúrása
                int vendegid;
                string insertVendeg = @"INSERT INTO vendegek (vendegnev, telefonszam, allapot, nemzetiseg)
                                VALUES (@vendegnev, @telefonszam, @allapot, @nemzetiseg);
                                SELECT LAST_INSERT_ID();";

                using (MySqlCommand vendegCmd = new MySqlCommand(insertVendeg, connection))
                {
                    vendegCmd.Parameters.AddWithValue("@vendegnev", vendegNev);
                    vendegCmd.Parameters.AddWithValue("@telefonszam", telfon);
                    vendegCmd.Parameters.AddWithValue("@allapot", allapot);
                    vendegCmd.Parameters.AddWithValue("@nemzetiseg", nemzet);

                    vendegid = Convert.ToInt32(vendegCmd.ExecuteScalar());
                }

                // 4️⃣ Foglalás beszúrása
                string insertFoglalas = @"INSERT INTO foglalasok (vendegid, szobaid, erkezes, tavozas, szallofo)
                                  VALUES (@vendegid, @szobaid, @erkezes, @tavozas, @szallofo)";
                using (MySqlCommand foglalasCmd = new MySqlCommand(insertFoglalas, connection))
                {
                    foglalasCmd.Parameters.AddWithValue("@vendegid", vendegid);
                    foglalasCmd.Parameters.AddWithValue("@szobaid", szabadSzobaId);
                    foglalasCmd.Parameters.AddWithValue("@erkezes", erkezes);
                    foglalasCmd.Parameters.AddWithValue("@tavozas", tavozas);
                    foglalasCmd.Parameters.AddWithValue("@szallofo", szallofo);
                    foglalasCmd.ExecuteNonQuery();
                }
            }

            // 5️⃣ Visszajelzés
            MessageBox.Show("Foglalás sikeresen mentve! Szabad szoba találva és lefoglalva.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            new Foglaláskezelő().Show();
            this.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
