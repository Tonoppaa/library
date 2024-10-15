using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kirjasto_käyttöliittymä_versio2
{

    public partial class kirjaudu : Form
    {

        MySqlConnection yhteys;
        string userID;
        string yhteysMerkkijono = "SERVER=localhost;PORT=3306;DATABASE=kirjasto;UID=root;PASSWORD=7F6yxyi4!"; //Paikallinen MySQL-yhteys

        /*string yhteysMerkkijono = "SERVER=34.88.80.103;PORT=3306;DATABASE=Kirjasto_tietokanta;UID=testityyppi;PASSWORD=testi"; Google Cloud Service-tietokanta
                                                                                                                               yhteyden muodostamiseen tarvittava
                                                                                                                               merkkijono*/
                                                                                                                               

        public kirjaudu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            yhteys = new MySqlConnection(yhteysMerkkijono);
        }

        private void kirjaudu_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch; // Kuva venyy täyttämään koko formin koon tai pienentyy tarvittaessa
        }

        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta form2 = new otayhteytta();
            form2.Show();
        }

        private void Unohtunut_Click(object sender, EventArgs e)
        {
            unohtunut form3 = new unohtunut();
            form3.Show();
        }

        private void KirjauduSisaan_Click(object sender, EventArgs e)
        {

            try
            {
                //using (MySqlConnection connection = DatabaseConnection.OpenConnection())
                yhteys.Open();
                {
                    string asiakas_kirjautuminen = $"SELECT asnum, salasana FROM asiakas WHERE asnum = '{textBox1.Text}' AND salasana = '{textBox2.Text}'";
                    MySqlCommand command = new MySqlCommand(asiakas_kirjautuminen, yhteys);
                    MySqlDataReader tunnus = command.ExecuteReader();
                    //object vastaus = command.ExecuteScalar(); //ExecuteScalar() -metodi palauttaa yhden tietokannasta haetun arvon
                    //yleinen C#-kielen tyyppi, joka on kaikkien muiden tyyppien perusluokka. Se on niin sanottu "kaiken kattava" tyyppi, joka voi
                    //viitata mihin tahansa muuhun tyyppiin.
                    //Tässä tapauksessa sitä käytetään tietokannasta haettavan yhden arvon tallentamiseen.

                    if (tunnus != null && tunnus.HasRows)
                    {
                        while (tunnus.Read())
                        {
                            string kayttajatunnus = tunnus.GetString("asnum");
                            //MessageBox.Show($"Arvo on: {kayttajatunnus}");
                            string salasana = tunnus.GetString("salasana");
                            //MessageBox.Show($"Toinen arvo on: {salasana}");

                            if (textBox1.Text == kayttajatunnus && salasana == textBox2.Text)
                            {
                                MessageBox.Show("Onnistunut sisäänkirjautuminen.");
                                userID = textBox1.Text;

                                // Suljetaan DataReader ennen uuden ikkunan avaamista
                                tunnus.Close();

                                // Päivitetään last_login sarake
                                string updateQuery = "UPDATE asiakas SET last_login_asiakas = NOW() WHERE asnum = @userID";
                                MySqlCommand updateCommand = new MySqlCommand(updateQuery, yhteys);
                                updateCommand.Parameters.AddWithValue("@userID", textBox1.Text);
                                updateCommand.ExecuteNonQuery(); // Toteutetaan komento

                                //MessageBox.Show($"Tulostetaan KirjautunutKayttaja: {KirjautunutKayttaja}");
                                asiakas_etusivu2 form4 = new asiakas_etusivu2(yhteys, userID);
                                form4.Show(); // Näytetään Asiakas etusivu-ikkuna
                                this.Hide(); // Piilotetaan Kirjaudu-ikkuna
                                return; // Lopetetaan nykyisen menetelmän suoritus onnistuneen kirjautumisen jälkeen
                                //Kun ohjelma saavuttaa return-komennon, se palaa menetelmää kutsuneeseen koodiin, eikä mitään muuta kyseisessä menetelmässä olevaa koodia suoriteta.
                            }
                            else
                            {
                                MessageBox.Show("Virheellinen salasana.");
                            }
                        }
                    }
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

        private void Henkilökunta_Click(object sender, EventArgs e)
        {
            kirjaudu_hkunta hkuntakirjaudu = new kirjaudu_hkunta();
            hkuntakirjaudu.Show();
            this.Hide();
        }

        private void SuljeOhjelmaNappi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
