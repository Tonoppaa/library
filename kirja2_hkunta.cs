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
using static System.Net.Mime.MediaTypeNames;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class kirja2_hkunta : Form
    {
        string userID;
        MySqlConnection yhteys;

        public kirja2_hkunta(string isbn, string etunimi, string sukunimi, string kirjanNimi, string julkaisuvuosi, string kategoria, string kpl, string sivut, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ISBN.Text = isbn;
            kirjoittajaEtunimi.Text = etunimi;
            kirjoittajaSukunimi.Text = sukunimi;
            KirjanNimi.Text = kirjanNimi;
            Julkaisuvuosi.Text = julkaisuvuosi;
            Kategoria.Text = kategoria;
            KirjaLkm.Text = kpl;
            Sivumaara.Text = sivut;
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void SuljeNappi_Click(object sender, EventArgs e)
        {
            tarkka_haku_hkunta tarkkahakuhkunta = new tarkka_haku_hkunta(yhteys, userID);
            tarkkahakuhkunta.Show();
            this.Close();
        }

        private void MuokkaaNappi_Click(object sender, EventArgs e)
        {
            string kirjanNimi = KirjanNimi.Text;
            string etunimi = kirjoittajaEtunimi.Text;
            string sukunimi = kirjoittajaSukunimi.Text;
            string julkaisuvuosi = Julkaisuvuosi.Text;
            string kategoria = Kategoria.Text;
            string kpl = KirjaLkm.Text;
            string isbn = ISBN.Text;

            muokkaa_kirja muokkaakirjaa = new muokkaa_kirja(isbn, etunimi, sukunimi, kirjanNimi, julkaisuvuosi, kategoria, kpl, yhteys, userID);
            muokkaakirjaa.Show();
            this.Close();
        }
    }
}
