using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class vahvista_asiakkaanpoisto : Form
    {
        string userID;
        MySqlConnection yhteys;
        hakutulos_asiakastiedot_hkunta parentForm;

        public vahvista_asiakkaanpoisto(string asnum, string enimi, string snimi, string loso, string pno, string ptp, string ssana, MySqlConnection yhteysOlio, string uID, hakutulos_asiakastiedot_hkunta parent)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AsNrotextBox.Text = asnum;
            EnimitextBox.Text = enimi;
            SnimitextBox.Text = snimi;
            LosotextBox.Text = loso;
            PnotextBox.Text = pno;
            PtptextBox.Text = ptp;
            SsanatextBox.Text = ssana;
            userID = uID;
            yhteys = yhteysOlio;
            parentForm = parent;
        }

        private void PeruutaNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KyllaNappi_Click(object sender, EventArgs e)
        {
            try
            {
                yhteys.Open();
                {
                    string asnum = AsNrotextBox.Text;
                    string poista_asiakas = "DELETE FROM asiakas WHERE asnum = @asnum";
                    MySqlCommand asiakkaanpoisto = new MySqlCommand(poista_asiakas, yhteys);
                    asiakkaanpoisto.Parameters.AddWithValue("@asnum", asnum);
                    asiakkaanpoisto.ExecuteNonQuery();
                    MessageBox.Show($"Asiakas {AsNrotextBox.Text} eli {EnimitextBox.Text} {SnimitextBox.Text} on onnistuneesti poistettu järjestelmästä.");
                    // Sulje parentForm
                    parentForm.Close();
                    this.Close();
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
