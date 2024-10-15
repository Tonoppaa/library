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
    public partial class uusi_kirja : Form
    {
        string userID; //Kirjautunut käyttäjä siirretty kirjaudu-sivun oliolta
        MySqlConnection yhteys; //Tietokantayhteys, joka luodaan ensimmäiseksi kirjaudu-sivulla

        public uusi_kirja(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"UserID: {userID}");
        }

        private void uusi_kirja_Load(object sender, EventArgs e) //Kun uusi_kirja.cs-form avautuu, niin seuraavat metodit aktivoituvat
        {
            MaakoodiTiedot(); //Maakoodi-tiedot haetaan tietokannasta tämän metodin avulla
            KategoriaTiedot(); //Kategoria-tiedot haetaan tietokannasta tämän metodin avulla
        }
        private void EnsureConnectionOpen() //Tämän metodin avulla tarkistetaan, onko yhteys auki vai ei
        {
            if (yhteys.State == ConnectionState.Closed || yhteys.State == ConnectionState.Broken) //Jos yhteys ei auki, se avataan
            {
                yhteys.Open();
            }
        }

        private void KategoriaTiedot() //Tässä metodissa haetaan tietokannasta kirjan kategoriatiedot
        {
            try
            {
                EnsureConnectionOpen(); //Varmistetaan tietokantayhteys, onko auki
                {
                    MySqlCommand kategoriahaku = new MySqlCommand($"SELECT DISTINCT kategoria FROM kirja", yhteys); //Distinct-avainsana auttaa poistamaan duplikaatit
                                                                                                                    //Haetaan kyselyllä tietokannasta kategorian arvot
                    MySqlDataReader luku = kategoriahaku.ExecuteReader(); //olio, joka lukee SQL-kyselyn tulosjoukkoa rivi kerrallaan
                    while (luku.Read())
                    //Tämä silmukka käy läpi jokaisen rivin, jonka MySqlDataReader on hakenut tietokannasta.
                    //Read()-metodi siirtää lukijan seuraavalle tulosjoukon riville, ja se palauttaa true, jos luettavissa on lisää rivejä.
                    {
                        Kategoriat.Items.Add(luku["kategoria"].ToString());
                        //lisätään jokaisen rivin "kategoria"-sarakkeen arvo Kategoriat-nimisen UI-komponentin Items-kokoelmaan.
                        //luku["kategoria"] hakee kyseisen sarakkeen arvon nykyiseltä riviltä, ja ToString() muuntaa sen merkkijonoksi.
                    }
                    luku.Close(); //Suljetaan MySqlDataReader
                }
            }
            catch (Exception ex) //Jos tapahtuu virhe, virheilmoitus kerrotaan tässä
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }

            finally

            {
                
            }
        }

        private void MaakoodiTiedot() //Tässä metodissa haetaan tietokannasta maakooditiedot
        {
            try
            {
                EnsureConnectionOpen();
                {
                    MySqlCommand command = new MySqlCommand($"SELECT lyhenne, maanimi FROM maakoodi", yhteys); //Kysely maakoodista, jotta saadaan haettua
                                                                                           //maakoodin lyhenne ja maan nimi tietokannasta
                    MySqlDataReader luku = command.ExecuteReader(); //Tulostaa rivi kerrallaan tulosjoukon
                    while (luku.Read())
                    {
                        string lyhenne = luku["lyhenne"].ToString(); //Yhdistetään muuttujaan lyhenne Read-metodin avulla tietokannasta "lyhenne"
                        string maanimi = luku["maanimi"].ToString(); //Yhdistetään muuttujaan maanimi Read-metodin avulla tietokannasta "maanimi"
                        string yhdistetty = $"{lyhenne} - {maanimi}"; //Yhdistetään muuttujaan yhdistetty lyhenne ja maanimi

                        // Lisää yhdistetty merkkijono ComboBoxiin
                        Maakoodit.Items.Add(yhdistetty);
                    }
                    luku.Close(); //Suljetaan MySqlDataReader
                }
            }
            catch (Exception ex) //Jos tapahtuu virhe, virheilmoitus kerrotaan tässä
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }

            finally

            {
                
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SuljeNappi_Click(object sender, EventArgs e) //Nappi, jolla uusi_kirja.cs-form sulkeutuu
        {
            this.Close();
        }

        private void LisaaKirja_Click(object sender, EventArgs e) //Nappi, jolla lisätään kirja tietokantaan
        {
            try
            {
                EnsureConnectionOpen();

                //Kirtu on kirjailijatunnus (esim. KTFIAN01, KT=Kirjailijatunnus (aina sama), FI=maakoodi joka poimitaan listalta,
                //A=vuosituhat, N=sukunimen alkukirjain, 01=järj.nro vuosituhannen sisällä)
                //Luodaan uusi kirja parametrisoidulla lausekkeella

                string kirtunnus_alku = "KT"; //Kirjailijatunnuksen alku
                string maatunnus = Maakoodit.SelectedItem.ToString().Substring(0, 2); //Kirjailijatunnuksen maakoodi
                //MessageBox.Show($"Maatunnus: {maatunnus}");
                string vuosituhat; //Kirjailijatunnuksen vuosituhat, alla ehdot, miten kirjain määriytyy
                int julkaisuvuosi = int.Parse(Julkaisuvuosi.Text); //Julkaisuvuosi otetaan tekstikentästä "Julkaisuvuosi.Text"

                if (julkaisuvuosi > 1799 && julkaisuvuosi < 1900)
                {
                    vuosituhat = "A";
                }
                else if (julkaisuvuosi >= 1900 && julkaisuvuosi < 2000)
                {
                    vuosituhat = "B";
                }
                else if (julkaisuvuosi >= 2000 && julkaisuvuosi < 2100)
                {
                    vuosituhat = "C";
                }
                else
                {
                    vuosituhat = "X";
                }
                string kirj_snimi_ekakirjain = KirjoittajaSnimi.Text[0].ToString(); //Kirjailijan sukunimen ensimmäinen kirjain, joka poimitaan
                                                                                    //"KirjoittajaSnimi.Text"-kentästä ja muutetaan merkkijonoksi
                string jarj_nro = "01"; //Kirjailijatunnuksen järjestysnumero
                string yhdistetty_kirjtunnus = kirtunnus_alku + maatunnus + vuosituhat + kirj_snimi_ekakirjain + jarj_nro;
                //Yhdistetään kirjailijatunnuksen osat yhdeksi merkkijonoksi
                //MessageBox.Show($"Yhdistetty kirjailijatunnus: {yhdistetty_kirjtunnus}");

                //Lisätään kirjailijatunnus kirjailija-tauluun

                string uusi_kirjailijatunnus = "INSERT INTO kirjailija (kirtunnus,enimi, snimi) VALUES (@kirtunnus, @enimi, @snimi)";
                //Luodaan muuttuja, jossa lisätään tietokantaan Kirjailija-tauluun parametrisoiduilla arvoilla
                MySqlCommand kirjailijalisays = new MySqlCommand(uusi_kirjailijatunnus, yhteys);
                //Sql-komento, jossa parametrina on uusi_kirjailijatunnus ja yhteys (tietokantayhteys)
                kirjailijalisays.Parameters.AddWithValue("@kirtunnus", yhdistetty_kirjtunnus);
                //Tällä komennolla määritetään parametrille @kirtunnus arvo yhdistetty_kirjtunnus
                kirjailijalisays.Parameters.AddWithValue("@enimi", Kirjoittaja.Text);
                //Kirjoittaja.Text-kenttä on parametrin @enimi arvo
                kirjailijalisays.Parameters.AddWithValue("@snimi", KirjoittajaSnimi.Text);
                //KirjoittajaSnimi.Text-kenttä on parametrin @snimi arvo
                kirjailijalisays.ExecuteNonQuery(); //Suoritetaan arvojen sijoittaminen tietokantaan
                //MessageBox.Show($"Kirjailija {Kirjoittaja.Text} {KirjoittajaSnimi.Text} sai tunnukseksi: {yhdistetty_kirjtunnus}. Kirjailija lisätty onnistuneesti järjestelmään.");

                string kategoria = Kategoriat.SelectedItem.ToString(); // Haetaan valittu kategoria

                string uusi_asiakas = "INSERT INTO kirja (isbn, kirtu, nimi, julkaistu, sivut, kategoria, kuva, kpl) VALUES (@isbn, @kirtu, @nimi, @julkaistu, @sivut, @kategoria, @kuva, @kpl)";
                //Uuden asiakkaan lisääminen Kirja-tauluun yllä olevilla attribuuteilla (parametrit)
                MySqlCommand AsiakkaanLisays = new MySqlCommand(uusi_asiakas, yhteys);
                //Poimitaan arvoiksi teksikentistä ja muuttujista tarvittavat tiedot tietokannan syöttöä varten
                AsiakkaanLisays.Parameters.AddWithValue("@isbn", ISBNkentta.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@kirtu", yhdistetty_kirjtunnus);
                AsiakkaanLisays.Parameters.AddWithValue("@nimi", KirjanNimi.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@julkaistu", Julkaisuvuosi.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@sivut", Sivumaara.Text);
                AsiakkaanLisays.Parameters.AddWithValue("@kategoria", kategoria);
                AsiakkaanLisays.Parameters.AddWithValue("@kuva", "");
                AsiakkaanLisays.Parameters.AddWithValue("@kpl", KirjaLkm.Text);
                AsiakkaanLisays.ExecuteNonQuery(); //Toteutetaan komento, jolla syötetään tiedot tietokantaan
                MessageBox.Show($"Kirja {KirjanNimi.Text} lisätty onnistuneesti järjestelmään.");
                
            }

            catch (Exception ex)

            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }

            finally

            {
                yhteys.Close(); //Suljetaan tietokantayhteys
            }
        }
    }
}
