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

namespace heavenHotel
{
    public partial class APEH : Form
    {
        public APEH()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbLekerdezesek.Items.Add("Összes szoba száma");
            cbLekerdezesek.Items.Add("Foglalt szobák száma");
            cbLekerdezesek.Items.Add("Szabad szobák listája");
            cbLekerdezesek.Items.Add("Átlagos vendégszám foglalásonként");
            cbLekerdezesek.Items.Add("Vendégek nemzetiségi megoszlása");
            cbLekerdezesek.Items.Add("Aktuálisan tartózkodó vendégek (mai dátum alapján)");
            cbLekerdezesek.Items.Add("Lemondott foglalások száma");
            cbLekerdezesek.Items.Add("Leggyakrabban foglalt szoba");
            cbLekerdezesek.Items.Add("Közelgő foglalások (a következő 7 napban)");
            cbLekerdezesek.SelectedIndex = 0;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            Foglaláskezelő frm = new Foglaláskezelő();
            frm.Show();
            this.Hide();
        }

        //Ez csak egy vázlat hogy ezt a részt hogyan kezd el! A szövegek nem megegyezők fenti lekérdezések elnevezésivel!
        private void btnFuttat_Click(object sender, EventArgs e)
        {
            string query = "";

            switch (cbLekerdezesek.SelectedItem.ToString())
            {
                case "Szobák száma":
                    query = "SELECT COUNT(*) AS 'Összes szoba' FROM szobak;";
                    break;
                case "Idegenforgalom (nemzetiségek szerint)":
                    query = "SELECT nemzetiseg AS 'Nemzetiség', COUNT(*) AS 'Vendégek száma' FROM vendegek GROUP BY nemzetiseg;";
                    break;
                case "Átlagos vendégszám":
                    query = "SELECT ROUND(AVG(szallofo), 2) AS 'Átlagos vendégszám' FROM foglalasok;";
                    break;
                case "Aktuálisan foglalt szobák":
                    query = "SELECT v.vendegnev, s.szobanev, f.erkezes, f.tavozas FROM foglalasok f JOIN vendegek v ON f.vendegid = v.vendegsorszam JOIN szobak s ON f.szobaid = s.szobaazonosito WHERE CURDATE() BETWEEN f.erkezes AND f.tavozas;";
                    break;
            }

            if (query != "")
            {
                /*MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEredmeny.DataSource = dt;*/
            }
        }
    }
}
