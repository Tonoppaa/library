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
    public partial class vahvista_kirjapoisto : Form
    {
        string userID;
        MySqlConnection yhteys;

        public vahvista_kirjapoisto(string isbn, string etunimi, string sukunimi, string kirjanNimi, string julkaisuvuosi, string kategoria, string kpl, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ISBNTextBox.Text = isbn;
            KirjoittajaTextBox.Text = etunimi;
            KirjoittajaSnimiTextBox.Text = sukunimi;
            KirjanNimiTextBox.Text = kirjanNimi;
            JulkaisuVuosiTextBox.Text = julkaisuvuosi;
            KategoriaTextBox.Text = kategoria;
            KirjaLkmTextBox.Text = kpl;
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void KyllaNappi_Click(object sender, EventArgs e)
        {
            try
            {
                yhteys.Open();
                string kirjan_poisto = "DELETE FROM kirja WHERE isbn = @isbn"; //Parametrisoidulla kyselyllä voidaan ennaltaehkäistä helpommin
                MySqlCommand kirjanpoisto = new MySqlCommand(kirjan_poisto, yhteys); //SQL-injektiohyökkäykset
                kirjanpoisto.Parameters.AddWithValue("@isbn", ISBNTextBox.Text);
                int rowsAffected = kirjanpoisto.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kirja poistettu onnistuneesti!");
                }
                else
                {
                    MessageBox.Show("Kirjaa ei poistettu onnistuneesti.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
                this.Close();
            }
        }

        private void PeruutaNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
