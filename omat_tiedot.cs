using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class omat_tiedot : Form
    {
        string userID;
        MySqlConnection yhteys;

        public omat_tiedot(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"Userid: {userID}");
        }

        private void omat_tiedot_Load(object sender, EventArgs e)
        {
            AsiakkaanTiedot();
        }

        private void AsiakkaanTiedot()
        {
            try
            {
                yhteys.Open();
                {
                    //MessageBox.Show(userID);
                    MySqlCommand command = new MySqlCommand($"SELECT asnum, enimi, snimi, loso, pno, ptp, puh, salasana FROM asiakas WHERE asnum = '{userID}'", yhteys);
                    MySqlDataReader luku = command.ExecuteReader();
                    while (luku.Read())
                    {
                        AsiakasnumerotextBox.Text = luku.GetString("asnum");
                        //MessageBox.Show($"Asiakasnumero tiedot: {AsiakasnumerotextBox.Text}");
                        EtunimitextBox.Text = luku.GetString("enimi");
                        SukunimitextBox.Text = luku.GetString("snimi");
                        OsoitetextBox.Text = luku.GetString("loso");
                        PostinumerotextBox.Text = luku.GetString("pno");
                        KaupunkitextBox.Text = luku.GetString("ptp");
                        PuhelintextBox.Text = luku.GetString("puh");
                        SalasanatextBox.Text = luku.GetString("salasana");
                    }
                    luku.Close();
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
            asiakas_etusivu2 form29 = new asiakas_etusivu2(yhteys, userID);
            form29.Show();
            this.Close();
        }

        private void Aineistot_Click(object sender, EventArgs e)
        {
            asiakas_aineistot2 form30 = new asiakas_aineistot2(yhteys, userID);
            form30.Show();
            this.Close();
        }

        private void OmatLainat_Click(object sender, EventArgs e)
        {
            omat_lainat form32 = new omat_lainat(yhteys, userID);
            form32.Show();
            this.Close();
        }

        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta form33 = new otayhteytta();
            form33.Show();
        }

        private void KirjauduUlos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            kirjaudu form34 = new kirjaudu();
            form34.Show();
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

        private void HakuNappiOmatTiedot_Click(object sender, EventArgs e)
        {
            string hakusana = HakuKenttaOmatTiedot.Text;
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

        private void SalasananVaihtoNappi_Click(object sender, EventArgs e)
        {
            vaihda_salasana_asiakas vaihdasalasana = new vaihda_salasana_asiakas(yhteys, userID);
            vaihdasalasana.ShowDialog();
        }

        private void MuokkaaOmatTiedotNappi_Click(object sender, EventArgs e)
        {
            EtunimitextBox.ReadOnly = false;
            SukunimitextBox.ReadOnly = false;
            OsoitetextBox.ReadOnly = false;
            PostinumerotextBox.ReadOnly = false;
            KaupunkitextBox.ReadOnly = false;
            PuhelintextBox.ReadOnly = false;
        }

        private void TallennaMuutoksetNappi_Click(object sender, EventArgs e)
        {
            try
            {
                yhteys.Open();
                {
                    string omat_tiedot_paivitys = $"UPDATE asiakas SET enimi = '{EtunimitextBox.Text}', snimi = '{SukunimitextBox.Text}', loso = '{OsoitetextBox.Text}', pno = '{PostinumerotextBox.Text}', ptp = '{KaupunkitextBox.Text}', puh = '{PuhelintextBox.Text}' WHERE asnum = '{userID}'";
                    MySqlCommand omat_tiedot_paivitys_komento = new MySqlCommand(omat_tiedot_paivitys, yhteys);
                    omat_tiedot_paivitys_komento.ExecuteNonQuery();
                    MessageBox.Show("Omat tiedot ovat päivitetty onnistuneesti!");
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
    }
}
