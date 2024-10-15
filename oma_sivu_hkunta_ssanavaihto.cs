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
    public partial class oma_sivu_hkunta_ssanavaihto : Form
    {
        string userID;
        MySqlConnection yhteys;

        public oma_sivu_hkunta_ssanavaihto(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void PeruutaNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaivitaNappi_Click(object sender, EventArgs e)
        {
            try
            {
                yhteys.Open();
                {
                    if (UusiSalasanatextBox.Text != UudelleenUusiSalasanatextBox.Text)
                    {
                        MessageBox.Show("Salasanat eivät ole samat salasanakentissä!");
                        return; //Lopeta suoritus, jos salasanat eivät ole samat
                    }                
                    string salasana_paivitys = $"UPDATE tyontekija SET salasana = '{UusiSalasanatextBox.Text}' WHERE ttnum = '{userID}'";
                    MySqlCommand salasana_paivitys_komento = new MySqlCommand(salasana_paivitys, yhteys);
                    salasana_paivitys_komento.ExecuteNonQuery();
                    MessageBox.Show("Salasana on päivitetty onnistuneesti.");
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
