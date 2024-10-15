using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class omat_lainat : Form
    {
        string userID;
        MySqlConnection yhteys;

        public omat_lainat(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"Userid: {userID}");
        }

        private void Asiakkaanlainat_Load(object sender, EventArgs e)
        {
            AsiakkaanLainat();
        }

        private void AsiakkaanLainat()
        {
            try
            {
                yhteys.Open();
                {
                   
                    string kysely = $"SELECT nimi AS Kirjan_nimi, enimi AS Etunimi, snimi AS Sukunimi, julkaistu AS Julkaisuvuosi, pvm AS Lainauspäivä FROM kirja, lainarivi, lainaus, lainakohde, kirjailija WHERE astun = '{userID}' AND isbn = ktun AND tunnus = kohdetun AND lainanum = ltunnus AND kirtunnus = kirtu";
                    MySqlCommand command = new MySqlCommand(kysely, yhteys);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable LainatutKirjat = new DataTable();
                    adapter.Fill(LainatutKirjat);
                    dataGridView1.DataSource = LainatutKirjat;
                    }
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


        private void Etusivu_Click(object sender, EventArgs e)
        {
            asiakas_etusivu2 form23 = new asiakas_etusivu2(yhteys, userID);
            form23.Show();
            this.Close();
        }

        private void Aineistot_Click(object sender, EventArgs e)
        {
            asiakas_aineistot2 form24 = new asiakas_aineistot2(yhteys, userID);
            form24.Show();
            this.Close();
        }

        private void OmatTiedot_Click(object sender, EventArgs e)
        {
            omat_tiedot form26 = new omat_tiedot(yhteys, userID);
            form26.Show();
            this.Close();
        }

        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta form27 = new otayhteytta();
            form27.Show();
        }

        private void KirjauduUlos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            kirjaudu form28 = new kirjaudu();
            form28.Show();
            yhteys.Close();
            this.Close();
        }

        private bool HaunTarkistus(string hakusana) //Luodaan metodi, jonka avulla tarkistetaan, onko käyttäjän antama hakusyöte tyhjä
        {
            if (string.IsNullOrWhiteSpace(hakusana)) //string.IsNullOrWhiteSpace on C#-kielen funktio, joka tarkistaa, onko annettu merkkijono null, tyhjä ("") tai koostuu pelkistä välilyönneistä tai muista tila-merkeistä
            {
                MessageBox.Show("Haullasi ei löytynyt tuloksia.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void HakuNappiOmatLainat_Click(object sender, EventArgs e)
        {
            string hakusana = HakuKenttaOmatLainat.Text;
            //Hakuikkunan käsittely
            if (HaunTarkistus(hakusana))
            {
                // Avataan hakuikkuna vain, jos löytyy tuloksia
                haku hakuIkkuna = new haku(yhteys, userID);
                if (hakuIkkuna.HaeTiedot(hakusana)) //Jos hakutuloksia löytyy, ikkuna avataan ja tulokset näytetään. Jos ei tuloksia, siitä ilmoitetaan käyttäjälle
                {
                    //Näytetään hakuikkuna
                    hakuIkkuna.Show();
                }
                else
                {
                    MessageBox.Show("Haullasi ei löytynyt tuloksia.");
                }
            }
        }
    }
}
