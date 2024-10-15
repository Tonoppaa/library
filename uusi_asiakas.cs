using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class uusi_asiakas : Form
    {
        string userID;
        MySqlConnection yhteys;
        public uusi_asiakas(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"UserID: {userID}");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Kts. kohta "LisaaAsiakas_Click"
        }

        private void uusi_asiakas_Load(object sender, EventArgs e)
        {

        }
        private void EnsureConnectionOpen()
        {
            if (yhteys.State == ConnectionState.Closed || yhteys.State == ConnectionState.Broken)
            {
                yhteys.Open();
            }
        }
        private void LisaaAsiakas_Click(object sender, EventArgs e)
        {
            //Haetaan viimeisin asiakasnumero ja sen jälkeen luodaan uusi asiakas. lisäätään esim as00135->as00136

            try
            {
                EnsureConnectionOpen();

                string Asnumkysely = "SELECT MAX(asnum) FROM asiakas"; //Haetaan suurin asiakasnumero tietokannasta
                MySqlCommand AsNumHaku = new MySqlCommand(Asnumkysely, yhteys);
                object vastaus = AsNumHaku.ExecuteScalar();
                string asiakasnumero = vastaus.ToString();
                //MessageBox.Show($"Suurin asiakasnumero on: {asiakasnumero}");

                //Pilkotaan merkkijono ja numero-osat erilleen
                string mjonoOsa = asiakasnumero.Substring(0, 2); //Pilkotaan asiakastunnuksen alku "AS"
                //MessageBox.Show($"Mjono-Osa: {mjonoOsa}");
                string nroOsa = asiakasnumero.Substring(2, 5); //Pilkotaan asiakastunnuksen kolmannesta merkistä viisi merkkiä eteenpäin
                //MessageBox.Show($"Nro-Osa: {nroOsa}");

                int muunnos = int.Parse(nroOsa); //Muutetaan nroOsa luvuksi
                muunnos++; //Kasvatetaan nroOsaa yhdellä
                string uusi_asiakasnumero = mjonoOsa + muunnos.ToString("D" + nroOsa.Length); //Asiakasnumeron alkuosa ja loppuosan yhdistäminen
                                                                                              //nroOsa.Lenght määrittää, kuinka monta numero "muunnos"-muuttujan tulee olla

                //MessageBox.Show($"Uusi asiakasnumero on: {uusi_asiakasnumero}");

                //Luodaan uusi asiakas parametrisoidulla lausekkeella
                string uusi_asiakas = "INSERT INTO asiakas (asnum, enimi, snimi, loso, pno, ptp, puh, salasana) VALUES (@asnum, @enimi, @snimi, @loso, @pno, @ptp, @puh, @salasana)";
                MySqlCommand AsiakkaanLisays = new MySqlCommand(uusi_asiakas, yhteys);
                AsiakkaanLisays.Parameters.AddWithValue("@asnum", uusi_asiakasnumero);
                AsiakkaanLisays.Parameters.AddWithValue("@enimi", asEtunimi.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@snimi", asSukunimi.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@loso", asOsoite.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@pno", asPostinumero.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@ptp", asKaupunki.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@puh", asPuhelin.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@salasana", "1234");
                AsiakkaanLisays.ExecuteNonQuery();
                MessageBox.Show("Asiakas lisätty onnistuneesti.");

            }

            catch (Exception ex)

            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }

            finally

            {
                yhteys.Close();
            }
        }

        private void SuljeIkkuna_Click(object sender, EventArgs e)
        {
            this.Close(); //Suljetaan ikkuna
        }
    }
}
