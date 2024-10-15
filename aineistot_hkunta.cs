using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class aineistot_hkunta : Form
    {
        string userID; //Kirjautunut käyttäjä siirretty kirjaudu-sivun oliolta
        MySqlConnection yhteys; //Tietokantayhteys, joka luodaan ensimmäiseksi kirjaudu-sivulla

        public aineistot_hkunta(MySqlConnection yhteysOlio, string uID) //Konstruktori, jolla parametrit yhteysOlio ja uID. Nämä otetaan kirjaudu-sivulta
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //Formi asetetaan keskelle sivua
            userID = uID; //Konstruktori tallentaa parametrina annetun käyttäjän tunnuksen (uID) luokan jäsenmuuttujaan userID, jotta sitä voidaan käyttää myöhemmin
            yhteys = yhteysOlio; //Konstruktori tallentaa parametrina annetun tietokantayhteyden (yhteysOlio) luokan jäsenmuuttujaan yhteys, jotta yhteyttä voidaan käyttää tietokantaoperaatioissa tässä lomakkeessa
            this.Fantasia.Click += new System.EventHandler(this.Fantasia_Click); //Ulkoasu design-sivulle kopioitiin Asiakas-aineistosta, jolloin nappien klikkaustapahtumat
            this.Jannitys.Click += new System.EventHandler(this.Jannitys_Click); //eivät kopioituneet suoraan. Näiden rivien avulla napit toimivat
            this.Kauhu.Click += new System.EventHandler(this.Kauhu_Click);
            this.Draama.Click += new System.EventHandler(this.Draama_Click);
            this.Romanssi.Click += new System.EventHandler(this.Romanssi_Click);
            this.Huumori.Click += new System.EventHandler(this.Huumori_Click);
            this.Historia.Click += new System.EventHandler(this.Historia_Click);
            this.EKirjat.Click += new System.EventHandler(this.EKirjat_Click);
            this.Sarjakuvat.Click += new System.EventHandler(this.Sarjakuvat_Click);
            this.Esikoululaiset.Click += new System.EventHandler(this.Esikoululaiset_Click);
            this.Koululaiset.Click += new System.EventHandler(this.Koululaiset_Click);
            this.Aikuiset.Click += new System.EventHandler(this.Aikuiset_Click);
            this.Nuoret.Click += new System.EventHandler(this.Nuoret_Click);
            this.KirjaTaulu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KirjaTaulu_CellDoubleClick); //Kun DataTablen solua tuplaklikataan, avautuu kirja.cs
            //MessageBox.Show($"UserID: {userID}");
        }

        private bool FantasiaKirjat_hkunta(string fantasia)
        {
            if (string.IsNullOrWhiteSpace(fantasia)) //Tarkista, onko julkaisuvuosi-kenttä tyhjä.
            { //Tämä rivi tarkistaa, onko fantasia-merkkijono tyhjä, koostuuko se vain välilyönneistä, vai onko se muuten olematon (null).
                //string.IsNullOrWhiteSpace on C# tarjoama metodi, joka tekee tämän tarkistuksen yhdellä kertaa.
                return false; //Jos edellä mainittu ehto täyttyy (eli fantasia on tyhjä tai vain valkoinen tila), metodi palauttaa arvon false
            }

            string kysely = $"SELECT isbn AS ISBN, enimi AS Etunimi, snimi AS Sukunimi, nimi AS Kirjan_nimi, julkaistu AS Julkaisuvuosi, sivut AS Sivumäärä, kategoria AS Kategoria, kpl AS Kpl FROM kirja, kirjailija WHERE kirtunnus = kirtu AND kategoria = 'Fantasia'";
            //Tietokantakysely, jossa haetaan kirjan tiedot (isbn, enimi, snimi, nimi, julkaistu, sivut, kategoria, kpl. Tiedot otetaan kategorian mukaan "Fantasia"
            MySqlCommand command = new MySqlCommand(kysely, yhteys); //MySQL-komento, jossa määritelty muuttujan nimeksi "command", jossa parametriksi on "kysely"-muuttuja ja käytetään tietokantayhteyttä "yhteys" 
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //MySqlDataAdapter on luokka, joka toimii siltana tietokannan ja DataSet- tai DataTable-objektien välillä. Se mahdollistaa tiedon hakemisen tietokannasta ja sen siirtämisen ohjelman muistiin, sekä tiedon päivittämisen takaisin tietokantaan.
            DataTable Kirjataulu = new DataTable();
            //Luo uuden taulukon ohjelman muistiin käytettäväksi tiedon säilömiseen ja käsittelyyn
            adapter.Fill(Kirjataulu); //Täytetään taulukko eli DataTable tietokannasta haettavalla datalla
            KirjaTaulu.DataSource = Kirjataulu; //DataSource-ominaisuus määrittää, mistä tiedot tulevat. Kun asetetaan KirjaTaulu.DataSource = Kirjataulu, liitetään DataGridView näyttämään Kirjataulu-olion sisältämät tiedot

            //Palautetaan true, jos tuloksia. Eli Datagridviewissä täytyy olla/löytyä vähintään yksi rivi
            return Kirjataulu.Rows.Count > 0;
        }
        //Vastaavat kyselyt ja tarkistukset muille kategorioille
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

        //Tähän e-kirjat
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

        private void Fantasia_Click(object sender, EventArgs e) //Kun klikataan Fantasia-nappia, niinalla oleva if-lauseet tarkistavat, löytyykö
        {                                                       //Fantasia-kategoriasta kirjoja. Jos löytyy, niin näytetään tulokset. Jos ei, niin
                                                                //ilmoitetaan asiakkaalle, että kirjoja ei löydy
            if (FantasiaKirjat_hkunta("Fantasia"))

            {

            }
            else
            {
                MessageBox.Show("Fantasia-kirjoja ei löytynyt.");
            }

        }

        private void Jannitys_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (JannitysKirjat("Jannitys"))

            {

            }
            else
            {
                MessageBox.Show("Jännitys-kirjoja ei löytynyt.");
            }
        }

        private void Kauhu_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (KauhuKirjat("Kauhu"))

            {

            }
            else
            {
                MessageBox.Show("Kauhukirjoja ei löytynyt.");
            }
        }

        private void Draama_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (DraamaKirjat("Draama"))

            {

            }
            else
            {
                MessageBox.Show("Draamakirjoja ei löytynyt.");
            }
        }

        private void Romanssi_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (RomanssiKirjat("Romanssi"))

            {

            }
            else
            {
                MessageBox.Show("Romanssikirjoja ei löytynyt.");
            }
        }

        private void Huumori_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (HuumoriKirjat("Huumori"))

            {

            }
            else
            {
                MessageBox.Show("Huumorikirjoja ei löytynyt.");
            }
        }

        private void Historia_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (HistoriaKirjat("Historia"))

            {

            }
            else
            {
                MessageBox.Show("Historiakirjoja ei löytynyt.");
            }
        }

        private void EKirjat_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (EeKirjat("E-kirjat"))

            {

            }
            else
            {
                MessageBox.Show("E-kirjoja ei löytynyt.");
            }
        }

        private void Sarjakuvat_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (Sarjakuvatt("Sarjakuvat"))

            {

            }
            else
            {
                MessageBox.Show("Sarjakuvia ei löytynyt.");
            }
        }

        private void Esikoululaiset_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (Esikoululaisett("Esikoululaiset"))

            {

            }
            else
            {
                MessageBox.Show("Esikoululaisten teoksia ei löytynyt.");
            }
        }

        private void Koululaiset_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (Koululaisett("Koululaiset"))

            {

            }
            else
            {
                MessageBox.Show("Koululaisille tarkoitettuja teoksia ei löytynyt.");
            }
        }

        private void Nuoret_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (Nuorett("Nuoret"))

            {

            }
            else
            {
                MessageBox.Show("Nuorille tarkoitettuja teoksia ei löytynyt.");
            }
        }

        private void Aikuiset_Click(object sender, EventArgs e) //Vastaavat if-lauseet eli tarkistukset, kuten Fantasia-nappia klikatessa
        {
            if (Aikuisett("Aikuiset"))

            {

            }
            else
            {
                MessageBox.Show("Aikuisille tarkoitettuja teoksia ei löytynyt.");
            }
        }

        private void LisaaKirjaNappi_Click(object sender, EventArgs e) //Lisää kirja-nappia painamalla avataan sivu, jossa voidaan lisätä tietokantaan
        {                                                               // uusi kirja. Muodostetaan olio, jossa käytetään argumentteina yhteys-oliota ja
                                                                        //userID-oliota
            uusi_kirja lisaauusikirja = new uusi_kirja(yhteys, userID);
            lisaauusikirja.Show();
        }

        private void OtaYhteyttaNappi_Click(object sender, EventArgs e)
        {                                                               //Napin nimestä voidaan päätellä, mikä sivu avautuu. Vastaavasti käytetään, kuten
                                                                        //aiemmin, oliota, jolla on argumentteina yhteys- ja userID-oliot
            otayhteytta_hkunta otayhteytta = new otayhteytta_hkunta();
            otayhteytta.Show();
        }

        private void KirjauduUlosNappi_Click(object sender, EventArgs e)
        {                                                               //Napin nimestä voidaan päätellä, mikä sivu avautuu. Napin avulla kirjaudutaan ulos,
                                                                        //ja suljetaan tietokantayhteys
            MessageBox.Show("Olet kirjautunut ulos.");
            yhteys.Close();
            kirjaudu kirjaudu_ulos = new kirjaudu();
            kirjaudu_ulos.Show();
            this.Close();
        }

        private void TarkkaHakuNappi_Click(object sender, EventArgs e) //Napin nimestä voidaan päätellä, mikä sivu avautuu. Vastaavasti käytetään, kuten
                                                                       //aiemmin, oliota, jolla on argumentteina yhteys- ja userID-oliot
        {
            tarkka_haku_hkunta tarkkahaku = new tarkka_haku_hkunta(yhteys, userID);
            tarkkahaku.Show();
            this.Close();
        }

        private void OmaSivuNappi_Click(object sender, EventArgs e) //Napin nimestä voidaan päätellä, mikä sivu avautuu. Vastaavasti käytetään, kuten
                                                                    //aiemmin, oliota, jolla on argumentteina yhteys- ja userID-oliot
        {
            oma_sivu_hkunta hkunta_omasivu = new oma_sivu_hkunta(yhteys, userID);
            hkunta_omasivu.Show();
            this.Close();
        }

        private void LisaaJarjNappi_Click(object sender, EventArgs e) //Napin nimestä voidaan päätellä, mikä sivu avautuu. Vastaavasti käytetään, kuten
                                                                      //aiemmin, oliota, jolla on argumentteina yhteys- ja userID-oliot
        {
            uusiasiakas_tai_uusikirja lisaauusiastaikir = new uusiasiakas_tai_uusikirja(yhteys, userID);
            lisaauusiastaikir.Show();
        }

        private void KirjaTaulu_CellDoubleClick(object sender, DataGridViewCellEventArgs e) /*Kun tuplaklikataan Kirjataulun solua, niin siirretään seuraavat
                                                                                            muuttujien arvot kirja2_hkunta.cs-formille.
                                                                                            */
        {
            DataGridViewRow selectedRow = KirjaTaulu.Rows[e.RowIndex]; //Datagridin valittua riviä tuplaklikataan, niin seuraavat muuttujat siirretään
                                                                       //kirja_hkunta.cs-formille
                                                                       //Nämä rivit lukevat valitun rivin eri solujen arvot ja tallentavat ne merkkijonomuuttujiin:
            string isbn = selectedRow.Cells["ISBN"].Value.ToString();
            string etunimi = selectedRow.Cells["Etunimi"].Value.ToString();
            string sukunimi = selectedRow.Cells["Sukunimi"].Value.ToString();
            string kirjanNimi = selectedRow.Cells["Kirjan_nimi"].Value.ToString();
            string julkaisuvuosi = selectedRow.Cells["Julkaisuvuosi"].Value.ToString();
            string kategoria = selectedRow.Cells["Kategoria"].Value.ToString();
            string kpl = selectedRow.Cells["Kpl"].Value.ToString();
            string sivut = selectedRow.Cells["Sivumäärä"].Value.ToString();
            kirja2_hkunta kirjaIkkuna = new kirja2_hkunta(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, sivut, yhteys, userID);
            //Tässä luodaan uusi olio kirja2_hkunta-luokasta. Konstruktorille välitetään kaikki edellä määritellyt muuttujat sekä tietokantayhteys (yhteys) ja käyttäjän tunniste (userID)
            kirjaIkkuna.ShowDialog();
            //Tämä rivi avaa uuden ikkunan (kirja2_hkunta) modaalisena, mikä tarkoittaa, että tämä ikkuna on käytössä ja käyttäjän on suljettava se ennen kuin hän voi palata käsittelemään muita ikkunoita
        }

        private void EtusivuNappi_Click(object sender, EventArgs e) //Napin nimestä voidaan päätellä, mikä sivu avautuu. Vastaavasti käytetään, kuten
                                                                    //aiemmin, oliota, jolla on argumentteina yhteys- ja userID-oliot
        {
            etusivu_hkunta etusivuhkunta = new etusivu_hkunta(yhteys, userID);
            etusivuhkunta.Show();
            this.Close();
        }
    }
}
