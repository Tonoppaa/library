using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Net.WebRequestMethods;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class hakutulos_asiakastiedot_hkunta : Form
    {
        string userID;
        MySqlConnection yhteys;
        public hakutulos_asiakastiedot_hkunta(string asnum, string enimi, string snimi, string loso, string pno, string ptp, string puh, string salasana, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AsNrotextBox.Text = asnum;
            EnimitextBox.Text = enimi;
            SnimitextBox.Text = snimi;
            LosotextBox.Text = loso;
            PnotextBox.Text = pno;
            PtptextBox.Text = ptp;
            PuhtextBox.Text = puh;
            SsanatextBox.Text = salasana;
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MuokkaaAsiakasNappi_Click(object sender, EventArgs e)
        {
            PaivitaTiedotNappi.Visible = true;
            PoistaAsiakasNappi.Visible = true;
            AsNrotextBox.ReadOnly = false;
            EnimitextBox.ReadOnly = false;
            SnimitextBox.ReadOnly = false;
            LosotextBox.ReadOnly = false;
            PnotextBox.ReadOnly = false;
            PtptextBox.ReadOnly = false;
            PuhtextBox.ReadOnly = false;
            SsanatextBox.ReadOnly = false;
        }

        private void PalaaNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoistaAsiakasNappi_Click(object sender, EventArgs e)
        {
            string asnum = AsNrotextBox.Text;
            string enimi = EnimitextBox.Text;
            string snimi =SnimitextBox.Text;
            string loso = LosotextBox.Text;
            string pno = PnotextBox.Text;
            string ptp = PtptextBox.Text;
            string ssana = SsanatextBox.Text;

            vahvista_asiakkaanpoisto vahvista_asiakkaanpoistaminen = new vahvista_asiakkaanpoisto(asnum, enimi, snimi, loso, pno, ptp, ssana, yhteys, userID, this);
            vahvista_asiakkaanpoistaminen.ShowDialog();
        }

        private void PaivitaTiedotNappi_Click(object sender, EventArgs e)
        {
            try
            {
                yhteys.Open();
                {
                    string asiakkaantiedot_paivitys = $"UPDATE asiakas SET enimi = '{EnimitextBox.Text}', snimi = '{SnimitextBox.Text}', loso = '{LosotextBox.Text}', pno = '{PnotextBox.Text}', ptp = '{PtptextBox.Text}', puh = '{PuhtextBox.Text}', salasana = '{SsanatextBox.Text}' WHERE asnum = '{AsNrotextBox.Text}'";
                    MySqlCommand astiedot_paivitys = new MySqlCommand(asiakkaantiedot_paivitys, yhteys);
                    astiedot_paivitys.ExecuteNonQuery();
                    MessageBox.Show($"Asiakkaan {AsNrotextBox.Text} eli {EnimitextBox.Text} {SnimitextBox.Text} tiedot ovat onnistuneesti päivitetty järjestelmään.");
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
