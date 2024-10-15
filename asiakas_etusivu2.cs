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

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class asiakas_etusivu2 : Form
    {
        string userID;
        MySqlConnection yhteys;

        public asiakas_etusivu2(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"UserID: {userID}");
        }

        private void Asiakkaan_Tiedot_Load(object sender, EventArgs e)
        {
            Asiakkaan_Tiedot();
            Viimeisin_kirjautuminen();
            Lainatut_Kirjat_Maara();
        }

        private void EnsureConnectionOpen() //Metodi, jossa varmistetaan, että yhteys on aina auki eli tekstikentät päivittyvät
        {
            if (yhteys.State == ConnectionState.Closed || yhteys.State == ConnectionState.Broken)
            {
                yhteys.Open();
            }
        }

        private void Asiakkaan_Tiedot()
        {
            try
            {
                EnsureConnectionOpen();
                {
                    string nimikysely = $"SELECT enimi FROM asiakas WHERE asnum = '{userID}'";
                    MySqlCommand nimihaku = new MySqlCommand(nimikysely, yhteys);
                    object nimihaku_vastaus = nimihaku.ExecuteScalar();
                    string kirjautunut_nimi = nimihaku_vastaus.ToString();
                    kayttajanNimi.Text = kirjautunut_nimi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
        }

        private void Viimeisin_kirjautuminen()
        {
            try
            {
                EnsureConnectionOpen();
                {
                    string kirjautumiskysely = $"SELECT last_login_asiakas FROM asiakas WHERE asnum = '{userID}'";
                    MySqlCommand kirjautumistiedot = new MySqlCommand(kirjautumiskysely, yhteys);
                    object kirjautumishaku_vastaus = kirjautumistiedot.ExecuteScalar();
                    /*ExecuteScalar() -metodi palauttaa yhden tietokannasta haetun arvon
                    yleinen C#-kielen tyyppi, joka on kaikkien muiden tyyppien perusluokka. Se on niin sanottu "kaiken kattava" tyyppi, joka voi
                    viitata mihin tahansa muuhun tyyppiin.
                    Tässä tapauksessa sitä käytetään tietokannasta haettavan yhden arvon tallentamiseen.*/
                    if (kirjautumishaku_vastaus != null && kirjautumishaku_vastaus != DBNull.Value)
                    {
                        DateTime viimeisinKirjautuminen = Convert.ToDateTime(kirjautumishaku_vastaus);
                        ViimeisinKirjautuminen.Text = viimeisinKirjautuminen.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
            finally
            {
                //yhteys.Close();
            }
        }

        private void Lainatut_Kirjat_Maara()
        {
            try
            {
                EnsureConnectionOpen();
                {
                    string kirjakysely = $"SELECT COUNT(lainanum) FROM lainaus WHERE astun = '{userID}'";
                    MySqlCommand kirjatiedot = new MySqlCommand(kirjakysely, yhteys);
                    object kirjalainat_vastaus = kirjatiedot.ExecuteScalar();
                    LainatutKirjatKpl.Text = kirjalainat_vastaus.ToString();
                    /*ExecuteScalar() -metodi palauttaa yhden tietokannasta haetun arvon
                    yleinen C#-kielen tyyppi, joka on kaikkien muiden tyyppien perusluokka. Se on niin sanottu "kaiken kattava" tyyppi, joka voi
                    viitata mihin tahansa muuhun tyyppiin.
                    Tässä tapauksessa sitä käytetään tietokannasta haettavan yhden arvon tallentamiseen.*/
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

        private void Aineistot_Click(object sender, EventArgs e)
        {
            asiakas_aineistot2 form5 = new asiakas_aineistot2(yhteys, userID);
            form5.Show();
            this.Close();
        }

        private void OmatLainat_Click(object sender, EventArgs e)
        {
            omat_lainat form7 = new omat_lainat(yhteys, userID);
            form7.Show();
            this.Close();
        }

        private void OmatTiedot_Click(object sender, EventArgs e)
        {
            omat_tiedot form8 = new omat_tiedot(yhteys, userID);
            form8.Show();
            this.Close();
        }

        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta form9 = new otayhteytta();
            form9.Show();
        }

        private void KirjauduUlos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            kirjaudu form10 = new kirjaudu();
            form10.Show();
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

        private void HaeNappi_Click(object sender, EventArgs e)
        {
            string hakusana = textBox1.Text;
            //Hakuikkunan käsittely
            if (HaunTarkistus(hakusana))
            {
                // Avataan hakuikkuna vain, jos löytyy tuloksia
                haku hakuIkkuna = new haku(yhteys, userID);
                if (hakuIkkuna.HaeTiedot(hakusana)) //Jos hakutuloksia löytyy, ikkuna avataan ja tulokset näytetään. Jos ei tuloksia, siitä ilmoitetaan käyttäjälle
                {
                    //Näytetään hakuikkuna
                    hakuIkkuna.Show();
                    MessageBox.Show("Jos haku ei mielestäsi tuottanut oikeita tuloksia, voit kokeilla tarkkaa hakua.");
                }
                else
                {
                    MessageBox.Show("Haullasi ei löytynyt tuloksia.");
                    hakuIkkuna.Show();
                    MessageBox.Show("Jos haku ei mielestäsi tuottanut oikeita tuloksia, voit kokeilla tarkkaa hakua.");
                }
            }

        }

        private void kayttajanNimi_TextChanged(object sender, EventArgs e)
        {
            //Tähän tulostuu kirjautuneen käyttäjän etunimi
        }
    }
}
