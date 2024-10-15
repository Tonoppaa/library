using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class tarkka_haku_hkunta : Form
    {
        string userID;
        MySqlConnection yhteys;

        public tarkka_haku_hkunta(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            this.HaeISBN.Click += new System.EventHandler(this.HaeISBN_Click); //Ulkoasu design-sivulle kopioitiin Asiakas-hausta, jolloin nappien klikkaustapahtumat
            this.HaeKirjailija.Click += new System.EventHandler(this.HaeKirjailija_Click); //eivät kopioituneet suoraan. Näiden rivien avulla napit toimivat
            this.HaeKirjanNimi.Click += new System.EventHandler(this.HaeKirjanNimi_Click);
            this.HaeJulkaisuvuosi.Click += new System.EventHandler(this.HaeJulkaisuvuosi_Click);
            this.HaeKategoria.Click += new System.EventHandler(this.HaeKategoria_Click);
            this.TyhjennaKentat.Click += new System.EventHandler(this.TyhjennaKentat_Click);
            this.HakuTulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HakuTulos_CellDoubleClick);
        }

        private void tarkka_haku_hkunta_Load(object sender, EventArgs e)
        {

        }

        public bool HaeTiedot(string hakusana) //Täällä käsitellään hakukenttään kirjoitettu numero/sana
        {
            try
            {
                //Syöte on numero, joten haku tehdään numerolla
                if (int.TryParse(hakusana, out _)) //int.TryParse(hakusana, out _) on C#:n tapa tarkistaa, onko annettu merkkijono kelvollinen kokonaisluvuksi ja tallentaa se tarvittaessa muuttujaan. Tässä _ on vain nimi muuttujalle
                {
                    string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND (isbn LIKE '%{hakusana}%' OR enimi LIKE '%{hakusana}%' OR snimi like '%{hakusana}%' OR julkaistu LIKE '%{hakusana}%' OR sivut LIKE '%{hakusana}%')";
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
                    string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND (nimi LIKE '%{hakusana}%' OR enimi LIKE '%{hakusana}%' OR snimi like '%{hakusana}%' OR julkaistu LIKE '%{hakusana}%' OR sivut LIKE '%{hakusana}%')";

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

            string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND isbn LIKE '%{isbn}%'";
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

            string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND (enimi LIKE '%{kirjailija}%' OR snimi LIKE '%{kirjailija}%')";
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

            string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND nimi LIKE '%{kirjan_nimi}%'";
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

            string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND julkaistu LIKE '%{julkaisuvuosi}%'";
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

            string kysely = $"SELECT isbn AS ISBN, kirtu AS Kirjailijatunnus, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria LIKE '%{kategoria}%'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kategoriataulu = new DataTable();
            adapter.Fill(Kategoriataulu);
            HakuTulos.DataSource = Kategoriataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = Kategoriataulu.Rows.Count.ToString();
            return Kategoriataulu.Rows.Count > 0;
        }

        private bool HaeTiedotAsnum(string asiakasnumero)
        {
            if (string.IsNullOrWhiteSpace(asiakasnumero)) // Tarkista, onko asiakasnumero-kenttä tyhjä
            {
                MessageBox.Show("Jätit Asiakasnumero-kentän tyhjäksi.");
                return false;
            }

                string kysely = $"SELECT asnum AS Asiakasnumero, enimi AS Etunimi, snimi AS Sukunimi, loso AS Lahiosoite, pno AS Postinumero, ptp AS Postitoimipaikka, puh AS Puhelinnumero, salasana AS Salasana FROM asiakas WHERE asnum LIKE '%{asiakasnumero}%'";
                MySqlCommand command = new MySqlCommand(kysely, yhteys);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable Asiakastaulu = new DataTable();
                adapter.Fill(Asiakastaulu);
                HakuTulos.DataSource = Asiakastaulu;

                // Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
                HakuTulosYht.Text = Asiakastaulu.Rows.Count.ToString();
                return Asiakastaulu.Rows.Count > 0;
        }

        private bool HaeTiedotAsEnimiSnimi(string asiakkaan_etunimi, string asiakkaan_sukunimi)
        {
            if (string.IsNullOrWhiteSpace(asiakkaan_etunimi) || string.IsNullOrWhiteSpace(asiakkaan_sukunimi)) // Tarkista, onko asiakkaan nimikenttä/kentät tyhjiä
            {
                MessageBox.Show("Jätit Asiakkaan nimikentän (molemmat tai toisen) tyhjäksi.");
                return false;
            }

            string kysely = $"SELECT asnum AS Asiakasnumero, enimi AS Etunimi, snimi AS Sukunimi, loso AS Lahiosoite, pno AS Postinumero, ptp AS Postitoimipaikka, puh AS Puhelinnumero, salasana AS Salasana FROM asiakas WHERE enimi LIKE '%{asiakkaan_etunimi}%' OR snimi LIKE '%{asiakkaan_sukunimi}%'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Asiakas_nimitaulu = new DataTable();
            adapter.Fill(Asiakas_nimitaulu);
            HakuTulos.DataSource = Asiakas_nimitaulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            HakuTulosYht.Text = Asiakas_nimitaulu.Rows.Count.ToString();
            return Asiakas_nimitaulu.Rows.Count > 0;
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
                //MessageBox.Show("Näytetään tulokset:");
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
                //MessageBox.Show("Näytetään tulokset:");
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
                //MessageBox.Show("Näytetään tulokset:");
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
                //MessageBox.Show("Näytetään tulokset:");
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
                //MessageBox.Show("Näytetään tulokset:");
            }
            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void EtusivuNappi_Click(object sender, EventArgs e)
        {
            etusivu_hkunta etusivuhkunta = new etusivu_hkunta(yhteys, userID);
            etusivuhkunta.Show();
            this.Close();
        }

        private void AineistotHkunta_Click(object sender, EventArgs e)
        {
            aineistot_hkunta hkunta_aineistot = new aineistot_hkunta(yhteys, userID);
            hkunta_aineistot.Show();
            this.Close();
        }

        private void OmaSivuNappi_Click(object sender, EventArgs e)
        {
            oma_sivu_hkunta hkunta_omasivu = new oma_sivu_hkunta(yhteys, userID);
            hkunta_omasivu.Show();
            this.Close();
        }

        private void LisaaNappi_Click(object sender, EventArgs e)
        {
            uusiasiakas_tai_uusikirja lisaauusiastaikir = new uusiasiakas_tai_uusikirja(yhteys, userID);
            lisaauusiastaikir.Show();
        }

        private void OtaYhteyttaNappi_Click(object sender, EventArgs e)
        {
            otayhteytta_hkunta hkunta_otayhteytta = new otayhteytta_hkunta();
            hkunta_otayhteytta.Show();
        }

        private void KirjauduUlosNappi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            yhteys.Close();
            kirjaudu kirjaudu_ulos = new kirjaudu();
            kirjaudu_ulos.Show();
            this.Close();
        }

        private void HakuTulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewRow selectedRow = HakuTulos.Rows[e.RowIndex];

            //Alla olevat solut koskevat "Hae ISBN, kirjailija, kirjan nimi, kirjan julkaisuvuosi ja kategoria"-tekstikenttiä/nappeja
            string isbn = selectedRow.Cells["ISBN"].Value.ToString();
            string etunimi = selectedRow.Cells["Etunimi"].Value.ToString();
            string sukunimi = selectedRow.Cells["Sukunimi"].Value.ToString();
            string kirjanNimi = selectedRow.Cells["Kirjan_nimi"].Value.ToString();
            string julkaisuvuosi = selectedRow.Cells["Julkaisuvuosi"].Value.ToString();
            string kategoria = selectedRow.Cells["Kategoria"].Value.ToString();
            string kpl = selectedRow.Cells["Kpl"].Value.ToString();
            string sivut = selectedRow.Cells["Sivumäärä"].Value.ToString();

            //Alla olevat solut koskevat "Hae asiakasnumero ja nimi (etunimi + sukunimi)"
            string asnum = selectedRow.Cells["Asiakasnumero"].Value.ToString();
            string enimi = selectedRow.Cells["Etunimi"].Value.ToString();
            string snimi = selectedRow.Cells["Sukunimi"].Value.ToString();
            string loso = selectedRow.Cells["Lahiosoite"].Value.ToString();
            string pno = selectedRow.Cells["Postinumero"].Value.ToString();
            string ptp = selectedRow.Cells["Postitoimipaikka"].Value.ToString();
            string puh = selectedRow.Cells["Puhelinnumero"].Value.ToString();
            string salasana = selectedRow.Cells["Salasana"].Value.ToString();


            kirja2_hkunta kirjaIkkuna = new kirja2_hkunta(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, sivut, yhteys, userID);
            hakutulos_asiakastiedot_hkunta asiakashakutulos = new hakutulos_asiakastiedot_hkunta(asnum, enimi, snimi,  loso, pno, ptp, salasana, yhteys, userID);

            kirjaIkkuna.Show();
            asiakashakutulos.Show();*/

            if (e.RowIndex >= 0) // Varmistetaan, ettei klikata otsikkoriviä
            {
                string columnName = HakuTulos.Columns[e.ColumnIndex].Name;

                // Sarakkeet, jotka kuuluvat kirjaan
                string[] kirjaSarakkeet = { "ISBN", "Etunimi", "Sukunimi", "Kirjan_nimi", "Julkaisuvuosi", "Kategoria", "Kpl", "Sivumäärä" };

                // Sarakkeet, jotka kuuluvat asiakkaaseen
                string[] asiakasSarakkeet = { "Asiakasnumero", "Etunimi", "Sukunimi", "Lahiosoite", "Postinumero", "Postitoimipaikka", "Salasana" };

                if (kirjaSarakkeet.Contains(columnName))
                {
                    // Hae kirjan tiedot riviltä
                    string isbn = HakuTulos.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                    string etunimi = HakuTulos.Rows[e.RowIndex].Cells["Etunimi"].Value.ToString();
                    string sukunimi = HakuTulos.Rows[e.RowIndex].Cells["Sukunimi"].Value.ToString();
                    string kirjanNimi = HakuTulos.Rows[e.RowIndex].Cells["Kirjan_nimi"].Value.ToString();
                    string julkaisuvuosi = HakuTulos.Rows[e.RowIndex].Cells["Julkaisuvuosi"].Value.ToString();
                    string kategoria = HakuTulos.Rows[e.RowIndex].Cells["Kategoria"].Value.ToString();
                    string kpl = HakuTulos.Rows[e.RowIndex].Cells["Kpl"].Value.ToString();
                    string sivut = HakuTulos.Rows[e.RowIndex].Cells["Sivumäärä"].Value.ToString();

                    // Näytä kirjan tiedot
                    kirja2_hkunta kirjainfo = new kirja2_hkunta(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, sivut, yhteys, userID);
                    kirjainfo.ShowDialog();
                }
                else if (asiakasSarakkeet.Contains(columnName))
                {
                    // Hae asiakastiedot riviltä
                    string asiakasnumero = HakuTulos.Rows[e.RowIndex].Cells["Asiakasnumero"].Value.ToString();
                    string enimi = HakuTulos.Rows[e.RowIndex].Cells["Etunimi"].Value.ToString();
                    string snimi = HakuTulos.Rows[e.RowIndex].Cells["Sukunimi"].Value.ToString();
                    string loso = HakuTulos.Rows[e.RowIndex].Cells["Lahiosoite"].Value.ToString();
                    string pno = HakuTulos.Rows[e.RowIndex].Cells["Postinumero"].Value.ToString();
                    string ptp = HakuTulos.Rows[e.RowIndex].Cells["Postitoimipaikka"].Value.ToString();
                    string puh = HakuTulos.Rows[e.RowIndex].Cells["Puhelinnumero"].Value.ToString();
                    string ssana = HakuTulos.Rows[e.RowIndex].Cells["Salasana"].Value.ToString();

                    // Näytä asiakastiedot
                    hakutulos_asiakastiedot_hkunta asiakastiedot = new hakutulos_asiakastiedot_hkunta(asiakasnumero, enimi, snimi, loso, pno, ptp, puh, ssana, yhteys, userID);
                    asiakastiedot.ShowDialog();
                }
            }
        }

        private void HaeAsnumNappi_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string asiakasnumero = AsiakasnumeroTextBox.Text;

            // Kutsu HaeTiedotAsnum-metodia parametrina isbn
            if (HaeTiedotAsnum(asiakasnumero))
            {
                //MessageBox.Show("Näytetään tulokset:");
            }

            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }

        private void HaeAsEnimiSnimiNappi_Click(object sender, EventArgs e)
        {
            // Tarkista, onko syöte merkkijono ja muunna se tarvittaessa
            string asiakkaan_etunimi = AsEtunimiTextBox.Text;
            string asiakkaan_sukunimi = AsSukunimiTextBox.Text;

            // Kutsu HaeTiedotEnimiSnimi-metodia parametrina AsEtunimi ja AsSukunimi
            if (HaeTiedotAsEnimiSnimi(asiakkaan_etunimi, asiakkaan_sukunimi))
            {
                //MessageBox.Show("Näytetään tulokset:");
            }

            else
            {
                MessageBox.Show("Ei tuloksia");
            }
        }
    }
}
