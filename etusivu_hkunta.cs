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
    public partial class etusivu_hkunta : Form
    {
        string userID;
        MySqlConnection yhteys;

        public etusivu_hkunta(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"UserID: {userID}");
        }

        private void etusivu_hkunta_Load(object sender, EventArgs e)
        {
            Tyontekijan_Tiedot();
            Viimeisin_kirjautuminen();
        }

        private void EnsureConnectionOpen() //Metodi, jossa varmistetaan, että yhteys on aina auki eli tekstikentät päivittyvät
        {
            if (yhteys.State == ConnectionState.Closed || yhteys.State == ConnectionState.Broken)
            {
                yhteys.Open();
            }
        }

        private void Tyontekijan_Tiedot()
        {
            try
            {
                EnsureConnectionOpen();
                {
                    string nimikysely = $"SELECT enimi, snimi FROM tyontekija WHERE ttnum = '{userID}'";
                    MySqlCommand nimihaku = new MySqlCommand(nimikysely, yhteys);
                    object nimihaku_vastaus = nimihaku.ExecuteScalar();
                    string kirjautunut_nimi = nimihaku_vastaus.ToString();
                    Hkunta_nimi.Text = kirjautunut_nimi;
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

        private void Viimeisin_kirjautuminen()
        {
            try
            {
                EnsureConnectionOpen();
                {
                    string kirjautumiskysely = $"SELECT last_login FROM tyontekija WHERE ttnum = '{userID}'";
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
                yhteys.Close();
            }
        }

        private void Hkunta_aineistot_Click(object sender, EventArgs e)
        {
            aineistot_hkunta hkunta_aineistot = new aineistot_hkunta(yhteys, userID);
            hkunta_aineistot.Show();
            this.Close();
        }

        private void Hkunta_tarkkahaku_Click(object sender, EventArgs e)
        {
            tarkka_haku_hkunta tarkkahaku = new tarkka_haku_hkunta(yhteys, userID);
            tarkkahaku.Show();
            this.Close();
        }

        private void Hkunta_omasivu_Click(object sender, EventArgs e)
        {
            oma_sivu_hkunta hkunta_omasivu = new oma_sivu_hkunta(yhteys, userID);
            hkunta_omasivu.Show();
            this.Close();
        }

        private void Hkunta_LisaaJarj_Click(object sender, EventArgs e)
        {
            uusiasiakas_tai_uusikirja lisaauusiastaikir = new uusiasiakas_tai_uusikirja(yhteys, userID);
            lisaauusiastaikir.Show();
        }

        private void Hkunta_Otayhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta_hkunta hkunta_otayhteytta = new otayhteytta_hkunta();
            hkunta_otayhteytta.Show();
        }

        private void Hkunta_KirjauduUlos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            yhteys.Close();
            kirjaudu kirjaudu_ulos = new kirjaudu();
            kirjaudu_ulos.Show();
            this.Close();
        }

        private void Hkunta_hakunappi_Click(object sender, EventArgs e)
        {
            //haku_hkunta
        }

        private void ViimeisinKirjautuminen_TextChanged(object sender, EventArgs e)
        {
            //Tähän tulostuu viimeisin kirjautuminen
        }
    }
}
