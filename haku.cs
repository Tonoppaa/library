using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class haku : Form
    {
        string userID;
        MySqlConnection yhteys;
        //MySqlConnection connection;

        public haku(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            this.HakuTulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HakuTulos_CellDoubleClick);
        }

        public bool HaeTiedot(string hakusana) //Täällä käsitellään hakukenttään kirjoitettu numero/sana
        {
            try
            {
                    //Syöte on numero, joten haku tehdään numerolla
                    if (int.TryParse(hakusana, out _)) //int.TryParse(hakusana, out _) on C#:n tapa tarkistaa, onko annettu merkkijono kelvollinen kokonaisluvuksi ja tallentaa se tarvittaessa muuttujaan. Tässä _ on vain nimi muuttujalle
                {
                    string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND (isbn LIKE '%{hakusana}%' OR enimi LIKE '%{hakusana}%' OR snimi like '%{hakusana}%' OR julkaistu LIKE '%{hakusana}%' OR sivut LIKE '%{hakusana}%')";
                    //Tee toinen kysely kuvalle tähän!
                    MySqlCommand command = new MySqlCommand(kysely, yhteys);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    // Uusi taulu attribuuteille
                    DataTable attrTaulu = new DataTable();
                    adapter.Fill(attrTaulu);
                    HakuTulos.DataSource = attrTaulu;

                    //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
                    HakuTulosYht.Text = attrTaulu.Rows.Count.ToString();
                    return attrTaulu.Rows.Count > 0;
                }

                else if (!int.TryParse(hakusana, out _))
                {
                    //Syöte ei ole numero, joten tehdään haku kirjan nimellä
                    string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND (nimi LIKE '%{hakusana}%' OR enimi LIKE '%{hakusana}%' OR snimi like '%{hakusana}%' OR julkaistu LIKE '%{hakusana}%' OR sivut LIKE '%{hakusana}%')";

                    MySqlCommand command = new MySqlCommand(kysely, yhteys);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    // Uusi taulu attribuuteille
                    DataTable attrTaulu = new DataTable();
                    adapter.Fill(attrTaulu);
                    HakuTulos.DataSource = attrTaulu;

                    //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
                    HakuTulosYht.Text = attrTaulu.Rows.Count.ToString();
                    return attrTaulu.Rows.Count > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hakutulos ei ollut kelvollinen: " + ex.Message);
                return false; //Ilmoitetaan käyttäjälle, jos tuli virhe
            }
            finally
            {
                yhteys.Close();
            }
            return false; //Ilmoitetaan käyttäjälle, jos ei hakutuloksia
            
        }

        private bool HaeTiedotISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) // Tarkista, onko ISBN-kenttä tyhjä
            {
                MessageBox.Show("Jätit ISBN-kentän tyhjäksi.");
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND isbn LIKE '%{isbn}%'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable ISBNtaulu = new DataTable();
            adapter.Fill(ISBNtaulu);
            HakuTulos.DataSource = ISBNtaulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = ISBNtaulu.Rows.Count.ToString();
            return ISBNtaulu.Rows.Count > 0;
        }

        private bool HaeTiedotKirjailija(string kirjailija)
        {
            if (string.IsNullOrWhiteSpace(kirjailija)) // Tarkista, onko kirjailija-kenttä tyhjä
            {
                MessageBox.Show("Jätit Kirjailija-kentän tyhjäksi.");
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND (enimi LIKE '%{kirjailija}%' OR snimi LIKE '%{kirjailija}%')";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjailijataulu = new DataTable();
            adapter.Fill(Kirjailijataulu);
            HakuTulos.DataSource = Kirjailijataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = Kirjailijataulu.Rows.Count.ToString();
            return Kirjailijataulu.Rows.Count > 0;
        }

        private bool HaeTiedotKirjanNimi(string kirjan_nimi)
        {
            if (string.IsNullOrWhiteSpace(kirjan_nimi)) // Tarkista, onko kirjan_nimi-kenttä tyhjä
            {
                MessageBox.Show("Jätit Kirjan nimi-kentän tyhjäksi.");
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND nimi LIKE '%{kirjan_nimi}%'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            HakuTulos.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = Kirjataulu.Rows.Count.ToString();
            return Kirjataulu.Rows.Count > 0;
        }

        private bool HaeTiedotJulkaisuvuosi(string julkaisuvuosi)
        {
            if (string.IsNullOrWhiteSpace(julkaisuvuosi)) // Tarkista, onko julkaisuvuosi-kenttä tyhjä
            {
                MessageBox.Show("Jätit julkaisuvuosi-kentän tyhjäksi.");
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND julkaistu LIKE '%{julkaisuvuosi}%'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Julkaisuvuositaulu = new DataTable();
            adapter.Fill(Julkaisuvuositaulu);
            HakuTulos.DataSource = Julkaisuvuositaulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = Julkaisuvuositaulu.Rows.Count.ToString();
            return Julkaisuvuositaulu.Rows.Count > 0;
        }

        private bool HaeTiedotKategoria(string kategoria)
        {
            if (string.IsNullOrWhiteSpace(kategoria)) // Tarkista, onko kategoria-kenttä tyhjä
            {
                MessageBox.Show("Jätit Kategoria-kentän tyhjäksi.");
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria LIKE '%{kategoria}%'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kategoriataulu = new DataTable();
            adapter.Fill(Kategoriataulu);
            HakuTulos.DataSource = Kategoriataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = Kategoriataulu.Rows.Count.ToString();
            return Kategoriataulu.Rows.Count > 0;
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

        private void HakuTulosYht_TextChanged(object sender, EventArgs e)
        {
            //Tässä tekstikentässä näkyy haun tuloksen määrä
        }

        private void SuljeIkkuna_Click(object sender, EventArgs e)
        {
            this.Close(); //Suljetaan hakuikkuna
        }

        private void HakuNappi_Click(object sender, EventArgs e)
        {
            string hakusana = HakuKentta_Haku.Text;
            //Hakuikkunan käsittely
            if (HaunTarkistus(hakusana))
            {
                // Avataan hakuikkuna vain, jos löytyy tuloksia
                if (HaeTiedot(hakusana)) //Jos hakutuloksia löytyy, ikkuna avataan ja tulokset näytetään. Jos ei tuloksia, siitä ilmoitetaan käyttäjälle
                {
                    //Näytetään hakuikkuna
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Haullasi ei löytynyt tuloksia.");
                }
            }
        }

        private void TyhjennaKentat_Click(object sender, EventArgs e)
        {
            HakuTulos.DataSource = null; //Poistetaan tietolähde Datagridview:sta
            HakuTulosYht.Text = null; //Poistetaan hakutuloksien määrä
            HakuTulos.Rows.Clear(); //Tyhjennetään Datagridview esim. Uutta hakua varten
        }

        private void HaeISBN_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string isbn = ISBNTekstikentta.Text;

            // Kutsu HaeTiedotISBN-metodia parametrina isbn
            if (HaeTiedotISBN(isbn))
            {
                MessageBox.Show("Näytetään tulokset:");
            }

            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void HaeKirjailija_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string kirjailija = KirjailijaTekstikentta.Text;

            // Kutsu HaeTiedotISBN-metodia parametrina isbn
            if (HaeTiedotKirjailija(kirjailija))
            {
                MessageBox.Show("Näytetään tulokset:");
            }
            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void HaeKirjanNimi_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string kirja = KirjaTekstikentta.Text;

            // Kutsu HaeTiedotISBN-metodia parametrina isbn
            if (HaeTiedotKirjanNimi(kirja))
            {
                MessageBox.Show("Näytetään tulokset:");
            }
            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void HaeJulkaisuvuosi_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string julkaisuvuosi = JulkaisuvuosiTekstikentta.Text;

            // Kutsu HaeTiedotISBN-metodia parametrina isbn
            if (HaeTiedotJulkaisuvuosi(julkaisuvuosi))
            {
                MessageBox.Show("Näytetään tulokset:");
            }
            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void HaeKategoria_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string kategoria = KategoriaTekstikentta.Text;

            // Kutsu HaeTiedotISBN-metodia parametrina isbn
            if (HaeTiedotKategoria(kategoria))
            {
                MessageBox.Show("Näytetään tulokset:");
            }
            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void HakuTulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = HakuTulos.Rows[e.RowIndex];

            string isbn = selectedRow.Cells["ISBN"].Value.ToString();
            string etunimi = selectedRow.Cells["Etunimi"].Value.ToString();
            string sukunimi = selectedRow.Cells["Sukunimi"].Value.ToString();
            string kirjanNimi = selectedRow.Cells["Kirjan_nimi"].Value.ToString();
            string julkaisuvuosi = selectedRow.Cells["Julkaisuvuosi"].Value.ToString();
            string kategoria = selectedRow.Cells["Kategoria"].Value.ToString();
            string kpl = selectedRow.Cells["Kpl"].Value.ToString();
            //Tänne kuvalle muuttuja

            kirja kirjaIkkuna = new kirja(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, yhteys, userID);
            kirjaIkkuna.Show();
            this.Close();
        }
    }
}
