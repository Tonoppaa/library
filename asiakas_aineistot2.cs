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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class asiakas_aineistot2 : Form
    {
        string userID;
        MySqlConnection yhteys;
        public asiakas_aineistot2(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            this.KirjaTaulu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KirjaTaulu_CellDoubleClick);
        }

        private bool FantasiaKirjat(string fantasia)
        {
            if (string.IsNullOrWhiteSpace(fantasia)) // Tarkista, onko julkaisuvuosi-kenttä tyhjä
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Fantasia'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool JannitysKirjat(string jannitys)
        {
            if (string.IsNullOrWhiteSpace(jannitys))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Jannitys'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool KauhuKirjat(string kauhu)
        {
            if (string.IsNullOrWhiteSpace(kauhu))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Kauhu'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool DraamaKirjat(string draama)
        {
            if (string.IsNullOrWhiteSpace(draama))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Draama'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool RomanssiKirjat(string romanssi)
        {
            if (string.IsNullOrWhiteSpace(romanssi))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Romanssi'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool HuumoriKirjat(string huumori)
        {
            if (string.IsNullOrWhiteSpace(huumori))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Huumori'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool HistoriaKirjat(string historia)
        {
            if (string.IsNullOrWhiteSpace(historia))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Historia'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool EeKirjat(string ekirja)
        {
            if (string.IsNullOrWhiteSpace(ekirja))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'E-kirjat'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool Sarjakuvatt(string sarjakuva)
        {
            if (string.IsNullOrWhiteSpace(sarjakuva))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Sarjakuvat'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool Esikoululaisett(string esikoulu)
        {
            if (string.IsNullOrWhiteSpace(esikoulu))
            {
                return false;
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Esikoululaiset'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool Koululaisett(string koulu)
        {
            if (string.IsNullOrWhiteSpace(koulu))
            {
                return false;
            }
            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Koululaiset'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool Nuorett(string nuoret)
        {
            if (string.IsNullOrWhiteSpace(nuoret))
            {
                return false;
            }
            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Nuoret'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private bool Aikuisett(string aikuiset)
        {
            if (string.IsNullOrWhiteSpace(aikuiset))
            {
                return false;
            }
            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Aikuiset'";
            MySqlCommand command = new MySqlCommand(kysely, yhteys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable Kirjataulu = new DataTable();
            adapter.Fill(Kirjataulu);
            KirjaTaulu.DataSource = Kirjataulu;

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }

        private void Aineistot_Click(object sender, EventArgs e)
        {
            //Tämä nappi
        }

        private void Etusivu_Click(object sender, EventArgs e)
        {
            asiakas_etusivu2 form11 = new asiakas_etusivu2(yhteys, userID);
            form11.Show();
            this.Close();
        }

        private void OmatLainat_Click(object sender, EventArgs e)
        {
            omat_lainat form13 = new omat_lainat(yhteys, userID);
            form13.Show();
            this.Close();
        }

        private void OmatTiedot_Click(object sender, EventArgs e)
        {
            omat_tiedot form14 = new omat_tiedot(yhteys, userID);
            form14.Show();
            this.Close();
        }

        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta form15 = new otayhteytta();
            form15.Show();
        }

        private void KirjauduUlos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            kirjaudu form16 = new kirjaudu();
            form16.Show();
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

        private void HaeNappiAineistot_Click(object sender, EventArgs e)
        {
            string hakusana = HakuKenttaAineistot.Text;
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

        private void Fantasia_Click(object sender, EventArgs e)
        {
            if (FantasiaKirjat("Fantasia"))

            {

            }
            else
            {
                MessageBox.Show("Fantasia-kirjoja ei löytynyt.");
            }

        }

        private void Jannitys_Click(object sender, EventArgs e)
        {
            if (JannitysKirjat("Jannitys"))

            {

            }
            else
            {
                MessageBox.Show("Jännitys-kirjoja ei löytynyt.");
            }
        }

        private void Kauhu_Click(object sender, EventArgs e)
        {
            if (KauhuKirjat("Kauhu"))

            {

            }
            else
            {
                MessageBox.Show("Kauhukirjoja ei löytynyt.");
            }
        }

        private void Draama_Click(object sender, EventArgs e)
        {
            if (DraamaKirjat("Draama"))

            {

            }
            else
            {
                MessageBox.Show("Draamakirjoja ei löytynyt.");
            }
        }

        private void Romanssi_Click(object sender, EventArgs e)
        {
            if (RomanssiKirjat("Romanssi"))

            {

            }
            else
            {
                MessageBox.Show("Romanssikirjoja ei löytynyt.");
            }
        }

        private void Huumori_Click(object sender, EventArgs e)
        {
            if (HuumoriKirjat("Huumori"))

            {

            }
            else
            {
                MessageBox.Show("Huumorikirjoja ei löytynyt.");
            }
        }

        private void Historia_Click(object sender, EventArgs e)
        {
            if (HistoriaKirjat("Historia"))

            {

            }
            else
            {
                MessageBox.Show("Historiakirjoja ei löytynyt.");
            }
        }

        private void EKirjat_Click(object sender, EventArgs e)
        {
            if (EeKirjat("E-kirjat"))

            {

            }
            else
            {
                MessageBox.Show("E-kirjoja ei löytynyt.");
            }
        }

        private void Sarjakuvat_Click(object sender, EventArgs e)
        {
            if (Sarjakuvatt("Sarjakuvat"))

            {

            }
            else
            {
                MessageBox.Show("Sarjakuvia ei löytynyt.");
            }
        }

        private void Esikoululaiset_Click(object sender, EventArgs e)
        {
            if (Esikoululaisett("Esikoululaiset"))

            {

            }
            else
            {
                MessageBox.Show("Esikoululaisten teoksia ei löytynyt.");
            }
        }

        private void Koululaiset_Click(object sender, EventArgs e)
        {
            if (Koululaisett("Koululaiset"))

            {

            }
            else
            {
                MessageBox.Show("Koululaisille tarkoitettuja teoksia ei löytynyt.");
            }
        }

        private void Nuoret_Click(object sender, EventArgs e)
        {
            if (Nuorett("Nuoret"))

            {

            }
            else
            {
                MessageBox.Show("Nuorille tarkoitettuja teoksia ei löytynyt.");
            }
        }

        private void Aikuiset_Click(object sender, EventArgs e)
        {
            if (Aikuisett("Aikuiset"))

            {

            }
            else
            {
                MessageBox.Show("Aikuisille tarkoitettuja teoksia ei löytynyt.");
            }
        }

        private void KirjaTaulu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = KirjaTaulu.Rows[e.RowIndex];

            string isbn = selectedRow.Cells["ISBN"].Value.ToString();
            string etunimi = selectedRow.Cells["Etunimi"].Value.ToString();
            string sukunimi = selectedRow.Cells["Sukunimi"].Value.ToString();
            string kirjanNimi = selectedRow.Cells["Kirjan_nimi"].Value.ToString();
            string julkaisuvuosi = selectedRow.Cells["Julkaisuvuosi"].Value.ToString();
            string kategoria = selectedRow.Cells["Kategoria"].Value.ToString();
            string kpl = selectedRow.Cells["Kpl"].Value.ToString();
            string uID;
            MySqlConnection yhteysOlio;
            kirja kirjaIkkuna = new kirja(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, yhteys, userID);
            kirjaIkkuna.Show();
            //this.Close();
        }
    }
}
