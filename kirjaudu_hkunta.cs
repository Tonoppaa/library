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
    public partial class kirjaudu_hkunta : Form
    {

        MySqlConnection yhteys;
        string userID;
        string yhteysMerkkijono = "SERVER=localhost;PORT=3306;DATABASE=kirjasto;UID=root;PASSWORD=7F6yxyi4!"; //Paikallisen MySQL-yhteyden muodostamiseen tarvittava lauseke

        // string yhteysMerkkijono = "SERVER=34.88.80.103;PORT=3306;DATABASE=Kirjasto_tietokanta;UID=testityyppi;PASSWORD=testi"; Google Cloud Service-tietokanta yhteyden muodostamiseen tarvittava lauseke

        public kirjaudu_hkunta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //Asetetaan Form keskelle näyttöä
            yhteys = new MySqlConnection(yhteysMerkkijono); //Määritellään muuttujalle "yhteys"`MySQL-yhteyteen vaadittava yhteydenmuodostus lauseke
        }

        private void kirjaudu_hkunta_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch; //Kuva venyy täyttämään koko formin koon tai pienentyy tarvittaessa
        }

        private void KirjauduSisaan_Click(object sender, EventArgs e)
        {
            MySqlDataReader tunnus = null; //Tämä muuttuja käytetään tietokannan lukemiseen, ja se on aluksi tyhjillään

            try
            {
                yhteys.Open(); // Avataan yhteys
                string hkunta_kirjautuminen = $"SELECT ttnum, salasana FROM tyontekija WHERE ttnum = '{kayttajatextbox.Text}' AND salasana = '{salasanatextbox.Text}'";
                MySqlCommand command = new MySqlCommand(hkunta_kirjautuminen, yhteys);

                tunnus = command.ExecuteReader(); // Luetaan tiedot

                if (tunnus.Read()) // Tarkastetaan, onko tietoja tietokannassa
                {
                    string kayttajatunnus = tunnus.GetString("ttnum");
                    string salasana = tunnus.GetString("salasana");

                    if (kayttajatextbox.Text == kayttajatunnus && salasana == salasanatextbox.Text)
                    {
                        MessageBox.Show("Onnistunut sisäänkirjautuminen.");
                        userID = kayttajatextbox.Text;

                        // Suljetaan DataReader ennen uuden ikkunan avaamista
                        tunnus.Close();

                        // Päivitetään last_login sarake
                        string updateQuery = "UPDATE tyontekija SET last_login = NOW() WHERE ttnum = @userID";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, yhteys);
                        updateCommand.Parameters.AddWithValue("@userID", kayttajatextbox.Text);
                        updateCommand.ExecuteNonQuery(); // Toteutetaan komento

                        // Näytetään uusi ikkuna
                        etusivu_hkunta hkunta_etusivu = new etusivu_hkunta(yhteys, userID);
                        hkunta_etusivu.Show();
                        this.Hide(); // Piilotetaan Kirjaudu-ikkuna
                    }
                    else
                    {
                        MessageBox.Show("Virheellinen salasana.");
                    }
                }
                else
                {
                    MessageBox.Show("Virheellinen käyttäjätunnus tai salasana.");
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


        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta_hkunta otayhteyttahkunta = new otayhteytta_hkunta();
            otayhteyttahkunta.Show();
        }

        private void SuljeOhjelmaNappi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
