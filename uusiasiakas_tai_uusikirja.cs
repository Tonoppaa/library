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
    public partial class uusiasiakas_tai_uusikirja : Form
    {
        string userID;
        MySqlConnection yhteys;
        public uusiasiakas_tai_uusikirja(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"UserID: {userID}");
        }

        private void SuljeNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsiakasLisays_Click(object sender, EventArgs e)
        {
            uusi_asiakas uusiasiakas = new uusi_asiakas(yhteys, userID);
            uusiasiakas.Show();
            this.Close();
        }

        private void KirjaLisays_Click(object sender, EventArgs e)
        {
            uusi_kirja uusikirja = new uusi_kirja(yhteys, userID);
            uusikirja.Show();
            this.Close();
        }
    }
}
