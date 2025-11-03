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
using MySql.Data.MySqlClient;

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
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=heaven_hotel");
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            Foglaláskezelő frm = new Foglaláskezelő();
            frm.Show();
            this.Hide();
        }

        
        private void btnFuttat_Click(object sender, EventArgs e)
        {
            string query = "";

            switch (cbLekerdezesek.SelectedItem.ToString())
            {
                case "Összes szoba száma":
                    query = "SELECT COUNT(*) AS 'Összes szoba' FROM szobak;";
                    break;
                case "Foglalt szobák száma":
                    query = "SELECT COUNT(DISTINCT szobaid) AS 'Jelenleg foglalt szobák száma'\r\nFROM foglalasok f\r\nJOIN vendegek v ON f.vendegid = v.vendegsorszam\r\nWHERE v.allapot = 'foglalt';";
                    break;
                case "Szabad szobák listája":
                    query = "SELECT s.szobanev\r\nFROM szobak s\r\nLEFT JOIN foglalasok f ON s.szobaazonosito = f.szobaid\r\nLEFT JOIN vendegek v ON f.vendegid = v.vendegsorszam\r\nWHERE v.allapot = 'szabad' OR v.allapot = 'lemondva'\r\nGROUP BY s.szobanev;\r\n";
                    break;
                case "Átlagos vendégszám foglalásonként":
                    query = "SELECT ROUND(AVG(szallofo), 2) AS 'Átlagos vendégszám' FROM foglalasok;";
                    break;
                case "Vendégek nemzetiségi megoszlása":
                    query = "SELECT nemzetiseg AS 'Nemzetiség', COUNT(*) AS 'Vendégek száma'\r\nFROM vendegek\r\nGROUP BY nemzetiseg\r\nORDER BY COUNT(*) DESC;\r\n";
                    break;
                case "Aktuálisan tartózkodó vendégek (mai dátum alapján)":
                    query = "SELECT v.vendegnev AS 'Vendég neve', s.szobanev AS 'Szoba', f.erkezes AS 'Érkezés', f.tavozas AS 'Távozás'\r\nFROM foglalasok f\r\nJOIN vendegek v ON f.vendegid = v.vendegsorszam\r\nJOIN szobak s ON f.szobaid = s.szobaazonosito\r\nWHERE CURDATE() BETWEEN f.erkezes AND f.tavozas;\r\n";
                    break;
                case "Lemondott foglalások száma":
                    query = "SELECT COUNT(*) AS 'Lemondott foglalások száma'\r\nFROM vendegek\r\nWHERE allapot = 'lemondva';";
                    break;
                case "Leggyakrabban foglalt szoba":
                    query = "SELECT s.szobanev AS 'Szoba neve', COUNT(f.foglalasid) AS 'Foglalások száma'\r\nFROM foglalasok f\r\nJOIN szobak s ON f.szobaid = s.szobaazonosito\r\nGROUP BY s.szobanev\r\nORDER BY COUNT(f.foglalasid) DESC\r\nLIMIT 1;\r\n";
                    break;
                case "Közelgő foglalások (a következő 7 napban)":
                    query = "SELECT v.vendegnev AS 'Vendég neve', s.szobanev AS 'Szoba', f.erkezes AS 'Érkezés', f.tavozas AS 'Távozás'\r\nFROM foglalasok f\r\nJOIN vendegek v ON f.vendegid = v.vendegsorszam\r\nJOIN szobak s ON f.szobaid = s.szobaazonosito\r\nWHERE f.erkezes BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 7 DAY)\r\nORDER BY f.erkezes ASC;";
                    break;
            }

            if (query != "")
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;database=heaven_hotel;username=root;password=mysql");
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvEredmeny.DataSource = dataTable;
                    dgvEredmeny.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a lekérdezés végrehajtása során: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void dgvEredmeny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
