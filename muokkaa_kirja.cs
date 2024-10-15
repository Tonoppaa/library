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
using System.Xml.Linq;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class muokkaa_kirja : Form
    {
        string userID;
        MySqlConnection yhteys;
        public muokkaa_kirja(string isbn, string etunimi, string sukunimi, string kirjanNimi, string julkaisuvuosi, string kategoria, string kpl, MySqlConnection yhteysOlio, string uID)
        { //Konstruktori, joka luo uuden instanssin. Ottaa parametreja valitusta kirjasta
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //Asettaa tekstikenttiin arvot, jotka ovat konstruktorista
            ISBNTextBox.Text = isbn;
            KirjoittajaTextBox.Text = etunimi;
            KirjoittajaSnimiTextBox.Text = sukunimi;
            KirjanNimiTextBox.Text = kirjanNimi;
            JulkaisuVuosiTextBox.Text = julkaisuvuosi;
            KategoriaTextBox.Text = kategoria;
            KirjaLkmTextBox.Text = kpl;
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void muokkaa_kirja_Load(object sender, EventArgs e)
        {
            KategoriaTiedot(); //Lataa KategoriaTiedot-metodin
            SivuTiedot(); //Lataa SivuTiedot-metodin
        }
        private void EnsureConnectionOpen()
        {
            if (yhteys.State == ConnectionState.Closed || yhteys.State == ConnectionState.Broken)
            {
                yhteys.Open();
            }
        }
        private void KategoriaTiedot() //Metodi, jossa käsitellään kategoriatiedot
        {
            try
            {
                EnsureConnectionOpen();
                {
                    MySqlCommand kategoriahaku = new MySqlCommand($"SELECT DISTINCT kategoria FROM kirja", yhteys); //Distinct-avainsana auttaa poistamaan duplikaatit tuloksesta
                    MySqlDataReader luku = kategoriahaku.ExecuteReader();
                    while (luku.Read())
                    {
                        Kategoriat.Items.Add(luku["kategoria"].ToString());
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
                
            }
        }

        private void SivuTiedot() //Metodi, jossa käsitellään kirjan sivutiedot
        {
            try
            {
                //yhteys.Open();
                {
                    string sivumaaran_haku = "SELECT sivut FROM kirja WHERE isbn = @isbn";
                    MySqlCommand sivumaarahaku = new MySqlCommand(sivumaaran_haku, yhteys);
                    sivumaarahaku.Parameters.AddWithValue("@isbn", ISBNTextBox.Text);
                    MySqlDataReader luku = sivumaarahaku.ExecuteReader();
                    while (luku.Read())
                    {
                        SivumaaraTextBox.Text = luku.GetInt32("sivut").ToString();
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
                
            }
        }

        private void SuljeNappi_Click(object sender, EventArgs e) //Sulje-nappi
        {
            tarkka_haku_hkunta tarkkahakuhkunta = new tarkka_haku_hkunta(yhteys, userID);
            tarkkahakuhkunta.Show();
            this.Close();
        }

        private void PoistaKirjaNappi_Click(object sender, EventArgs e) //Nappi, jonka avulla poistetaan kirja tietokannasta
        {
            //Alustetaan muuttujat, joiden tiedot poimitaan tekstikentistä.
            string kirjanNimi = KirjanNimiTextBox.Text;
            string etunimi = KirjoittajaTextBox.Text;
            string sukunimi = KirjoittajaSnimiTextBox.Text;
            string julkaisuvuosi = JulkaisuVuosiTextBox.Text;
            string kategoria = KategoriaTextBox.Text;
            string kpl = KirjaLkmTextBox.Text;
            string isbn = ISBNTextBox.Text;

            //Siirretään tiedot instanssiin, josta konstruktori ottaa vastaan parametreja
            vahvista_kirjapoisto vahvistakirjapoisto = new vahvista_kirjapoisto(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, yhteys, userID);
            vahvistakirjapoisto.Show();
        }

        private void TallennaNappi_Click(object sender, EventArgs e) //Tallenna-napin avulla päivitetään tietokantaan kirjan tiedot
        {
            try
            {
                EnsureConnectionOpen();
                {

                    string paivita_kirja = "UPDATE kirja SET nimi = @nimi, julkaistu = @julkaistu, sivut = @sivut, kategoria = @kategoria, kuva = @kuva, kpl = @kpl WHERE isbn = @isbn";
                    MySqlCommand KirjanPaivitys = new MySqlCommand(paivita_kirja, yhteys);
                    KirjanPaivitys.Parameters.AddWithValue("@isbn", ISBNTextBox.Text);
                    KirjanPaivitys.Parameters.AddWithValue("@nimi", KirjanNimiTextBox.Text);
                    KirjanPaivitys.Parameters.AddWithValue("@julkaistu", JulkaisuVuosiTextBox.Text);
                    KirjanPaivitys.Parameters.AddWithValue("@sivut", SivumaaraTextBox.Text);
                    KirjanPaivitys.Parameters.AddWithValue("@kategoria", Kategoriat.SelectedItem.ToString());
                    KirjanPaivitys.Parameters.AddWithValue("@kuva", "");
                    KirjanPaivitys.Parameters.AddWithValue("@kpl", KirjaLkmTextBox.Text);
                    KirjanPaivitys.ExecuteNonQuery();
                    MessageBox.Show($"Kirja {KirjanNimiTextBox.Text} päivitetty onnistuneesti järjestelmään.");
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
