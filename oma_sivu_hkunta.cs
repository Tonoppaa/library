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
    public partial class oma_sivu_hkunta : Form
    {
        string userID;
        MySqlConnection yhteys;
        public oma_sivu_hkunta(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
            //MessageBox.Show($"UserID: {userID}");
        }

        private void oma_sivu_hkunta_Load(object sender, EventArgs e)
        {
            HenkilokuntaTiedot();
        }

        private void HenkilokuntaTiedot()
        {
            try
            {
                yhteys.Open();
                {
                    //MessageBox.Show(userID);
                    MySqlCommand command = new MySqlCommand($"SELECT ttnum, enimi, snimi, loso, pno, ptp, puh FROM tyontekija WHERE ttnum = '{userID}'", yhteys);
                    MySqlDataReader luku = command.ExecuteReader();
                    while (luku.Read())
                    {
                        HkuntaKayttajaTunnus.Text = luku.GetString("ttnum");
                        //MessageBox.Show($"Asiakasnumero tiedot: {AsiakasnumerotextBox.Text}");
                        HkuntaEtunimi.Text = luku.GetString("enimi");
                        HkuntaSukunimi.Text = luku.GetString("snimi");
                        HkuntaOsoite.Text = luku.GetString("loso");
                        HkuntaPostinumero.Text = luku.GetString("pno");
                        HkuntaKaupunki.Text = luku.GetString("ptp");
                        HkuntaPuhelin.Text = luku.GetString("puh");
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
                yhteys.Close();
            }
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

        private void EtusivuNappi_Click(object sender, EventArgs e)
        {
            etusivu_hkunta etusivuhkunta = new etusivu_hkunta(yhteys, userID);
            etusivuhkunta.Show();
            this.Close();
        }

        private void AineistotNappi_Click(object sender, EventArgs e)
        {
            aineistot_hkunta aineistothkunta = new aineistot_hkunta(yhteys, userID);
            aineistothkunta.Show();
            this.Close();
        }

        private void TarkkaHakuNappi_Click(object sender, EventArgs e)
        {
            tarkka_haku_hkunta tarkkahakuhkunta = new tarkka_haku_hkunta(yhteys, userID);
            tarkkahakuhkunta.Show();
            this.Close();
        }

        private void LisaaJarjNappi_Click(object sender, EventArgs e)
        {
            uusiasiakas_tai_uusikirja uusikirjataiasiakas = new uusiasiakas_tai_uusikirja(yhteys, userID);
            uusikirjataiasiakas.Show();
        }

        private void MuutaSalasanaNappi_Click(object sender, EventArgs e)
        {
            oma_sivu_hkunta_ssanavaihto salasananvaihto = new oma_sivu_hkunta_ssanavaihto(yhteys, userID);
            salasananvaihto.ShowDialog();
        }
    }
}
