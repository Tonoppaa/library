using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kirjasto_käyttöliittymä_versio2
{
    public partial class kirja : Form
    {
        string userID;
        MySqlConnection yhteys;
        private string kpl;

        public kirja(string isbn, string etunimi, string sukunimi, string kirjanNimi, string julkaisuvuosi, string kategoria, string kpl, MySqlConnection yhteysOlio, string uID)
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

            LainaNappi.Visible = (int.TryParse(kpl, out int kirjaLkm) && kirjaLkm > 0);
            EiNappi.Visible = (int.TryParse(kpl, out int kirja_Lkm) && kirja_Lkm == 0);

            userID = uID;
            yhteys = yhteysOlio;
        }

        //Tässä on koodia pohjustettuna kirjaston kirjojen kuville, joka on kesken
        /*

                    byte[] kuvaData = (byte[])srd["kuva"];

                    using (MemoryStream ms = new MemoryStream(kuvaData))
                    {
                        Image kuva = Image.FromStream(ms);
                        KirjanKuva.SizeMode = PictureBoxSizeMode.Zoom; // Aseta PictureBox koon mukaan
                        KirjanKuva.Image = kuva;
                        Console.WriteLine("Kuva ladattu onnistuneesti.");
                    }
                }
                srd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }*/

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Kirjan kuvaus
        }

        private void KirjanNimiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KirjoittajaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KirjaLkmTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JulkaisuVuosiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KategoriaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KirjoittajaSnimiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LainaNappi_Click(object sender, EventArgs e)
        {
            //Tämä nappi näkyy, jos kirjoja on tietokannassa enemmän kuin 1kpl. Jos kpl-määrä on 0, tämä nappi ei näy.
            //Tästä napista asiakas voi lainata kirjan
            try
            {
                yhteys.Open();

                //Kysely suurimmasta lainanumerosta:

                string Lainanumkysely = "SELECT MAX(lainanum) FROM lainaus"; //Haetaan suurin lainanumero tietokannasta
                MySqlCommand LainaNumHaku = new MySqlCommand(Lainanumkysely, yhteys); //MySQL-komento, jossa tehdään kysely MySQL:n
                object vastaus = LainaNumHaku.ExecuteScalar(); //Palauttaa ensimmäisen rivin ensimmäisen arvon tuloksista; hyvä käyttää aggrekaattifunktion kanssa
                string lainanumero = vastaus.ToString(); //Muutetaan object-arvo merkkijonoksi
                //MessageBox.Show($"Suurin lainanumero on: {lainanumero}");

                //Viimeisimmän lainanumeron pilkkominen osiin

                string vuosiOsa = lainanumero.Substring(0, 2); //Erotetaan ensimmäiset kaksi merkkiä lainanumerosta
                string kkOsa = lainanumero.Substring(2, 2); //Erotetaan kolmas ja neljäs merkki lainanumerosta
                string nroOsa = lainanumero.Substring(4, 3); //Erotetaan viimeiset merkit lainanumerosta

                int vuosi = int.Parse(vuosiOsa); //Muutetaan vuosiosa luvuksi
                int nykyinenvuosi = DateTime.Now.Year % 100; //Saadaan vuoden kaksi viimeistä numeroa DateTime % 100:n avulla
                //MessageBox.Show($"Vuosiosa pilkottuna: {nykyinenvuosi}");

                int kuukausi = int.Parse(kkOsa); //Muutetaan kuukausiosa luvuksi
                int nykyinenKK = DateTime.Now.Month; //Tallennetaan muuttujaan nykyinenKK tämän hetkinen kuukausi
                string nykyinenKKString = nykyinenKK.ToString("D2"); //Kuukausi muutettuna merkkijonoksi, jonka formaattityyppi on kaksi lukua esim. 02
                //MessageBox.Show($"Kuukausiosa pilkottuna: {nykyinenKKString}");

                int numero_osa = int.Parse(nroOsa); //
                string nykyinenNroOsa = numero_osa.ToString("D3"); //Monesko lainaus on menossa kyseisenä vuotena/kk, formaattityyppi kolme lukua esim. 001
                //MessageBox.Show($"Numero-osa pilkottuna: {nykyinenNroOsa}");

                //Tarkistetaan, monesko lainaus on kyseessä tässä vuodessa/kuussa
                if (numero_osa == 000) //Jos ensimmäinen lainaustapahtuma, numero-osa on 001
                {
                    numero_osa = 001;
                }
                else
                {
                    numero_osa++; //Jos lainaustapahtuma on toinen tai isompi, numero-osaa korotetaan yhdellä
                }
                string uusiNroOsa = numero_osa.ToString("D3"); //Muutetaan numero-osa luvusta merkkijonoksi
                //MessageBox.Show($"Nyt on tarvittaessa lisätty / muutettu numero-osaa joko 001 tai lisätty yksi numero lisää. Uusi numero-osa: {uusiNroOsa}");
                //Yhdistetään merkkijonot yhdeksi pötköksi
                string uusi_lainanumero = $"{nykyinenvuosi}{nykyinenKKString}{uusiNroOsa}"; //Osat voidaan yhdistää yhdeksi merkkijonoksi, kun kaikki merkkijonoa
                //MessageBox.Show($"Uusi lainanumeron arvo on: {uusi_lainanumero} jonka pituus on {uusi_lainanumero.Length}");

                //Lainauksen lisäys tietokantaan:
                string uusi_laina = "INSERT INTO lainaus (lainanum, astun, pvm) VALUES (@lainanum, @astun, NOW())"; //Lainauksen lisäys-rivi tietokantaan
                MySqlCommand LainauksenLisays = new MySqlCommand(uusi_laina, yhteys); //Suoritetaan MySQL-komento
                LainauksenLisays.Parameters.AddWithValue("@lainanum", uusi_lainanumero); //Asetetaan parametriksi uusi lainanumero
                LainauksenLisays.Parameters.AddWithValue("@astun", userID); //Asetetaan parametriksi kirjautunut käyttäjä
                LainauksenLisays.ExecuteNonQuery(); //Suoritetaan MySQL-komento tietokantaan
                MessageBox.Show("Laina lisätty. Tarkista MySQL");

                //Lainarivin määrittämiseen vaadittavat koodirimpsut
                string Lainarivikysely = "SELECT MAX(rivinum) FROM lainarivi"; //Kysely suurimmasta rivinumerosta
                MySqlCommand LainariviHaku = new MySqlCommand(Lainarivikysely, yhteys); //Suoritetaan MySQL-komento
                object lrivi_vastaus = LainariviHaku.ExecuteScalar(); //Tämä on muuttuja, joka tallentaa ExecuteScalar()-metodin palauttaman arvon.
                                                                      //Koska metodi palauttaa object-tyyppisen arvon, myös muuttujan lrivi_vastaus täytyy olla object-tyyppiä.
                                                                      //Tämä tarkoittaa, että arvo voi olla minkä tahansa tyyppinen olio, kuten kokonaisluku, merkkijono tai muu tietotyyppi.
                                                                      //Se riippuu SQL - kyselyn palauttamasta tiedosta.
                                                                      //ExecuteScalar()-metodia käytetään, kun halutaan suorittaa SQL-kysely, joka palauttaa vain yhden arvon. 
                string lainarivinumero = lrivi_vastaus.ToString(); //Muutetaan lainarivi merkkijonoksi
                int viimeisin_lainarivi = int.Parse(lainarivinumero); //Muutetaan viimeisin lainarivi luvuksi
                //MessageBox.Show($"Suurin lainarivi on: {viimeisin_lainarivi}");
                viimeisin_lainarivi++; //Korotetaan yhdellä viimeisintä lainariviä
                //MessageBox.Show($"Katsotaan, kasvoiko lainarivi: {viimeisin_lainarivi}");
                string uusi_lainarivi = viimeisin_lainarivi.ToString(); //Tässä nyt uusi lainarivin rivinumero

                //Kirjan lisäys ISBN:n mukaan:
                string KirjanISBN = ISBNTextBox.Text; //Tekstikentässä valitun kirjan ISBN
                string Kirjarivikysely = "SELECT kohdetun FROM lainarivi, lainakohde, kirja, lainaus WHERE isbn = @KirjanISBN AND isbn = ktun AND tunnus = kohdetun AND ltunnus = lainanum";
                                         //Kysely tietokannasta, jotta saadaan kohdetunnus eli "kohdetun". Kyselyssä on jokin virhe, koska kirjan lainaus
                                         //onnistuu joillakin kirjoilla ja joillakin ei.
                MySqlCommand KirjariviHaku = new MySqlCommand(Kirjarivikysely, yhteys); //MySQL-komento, jolla saadaan komento tehtyä MySQL:n
                // Lisää parametri kyselyyn
                KirjariviHaku.Parameters.AddWithValue("@KirjanISBN", KirjanISBN); //Käytetään parametrinä kirjan ISBN-numeroa
                object krivi_vastaus = KirjariviHaku.ExecuteScalar(); //Halutaan tietokannasta yksi arvo, joten voidaan käyttää object-tyyppiä
                string kirjarivinumero = krivi_vastaus.ToString(); //Muutetaan kirjarivinumero merkkijonoksi

                MessageBox.Show($"Kyseinen kirja, jota ollaan lisäämässä, on: {kirjarivinumero}");

                //Tässä lainarivin lisäys järjestelmään:
                string lainarivi_lisays = "INSERT INTO lainarivi (rivinum, ltunnus, kohdetun) VALUES (@rivinum, @ltunnus, @kohdetun)"; //Lisätään lainarivi tietokantaan parametrisoiduilla arvoilla
                MySqlCommand LainarivinLisays = new MySqlCommand(lainarivi_lisays, yhteys); //MySQL-komento, jolla saadaan komento tehtyä MySQL:n
                LainarivinLisays.Parameters.AddWithValue("@rivinum", uusi_lainarivi); //Käytetään parametrinä uutta lainariviä rivinumeroon
                LainarivinLisays.Parameters.AddWithValue("@ltunnus", uusi_lainanumero); //Käytetään parametrinä uutta lainanumeroa lainatunnukseen
                LainarivinLisays.Parameters.AddWithValue("@kohdetun", kirjarivinumero); //Käytetään parametrinä uutta rivinumeroa rivitunnukseen
                
                LainarivinLisays.ExecuteNonQuery(); //Suoritetaan komento tietokantaan ExecuteNonQuerylla()
                MessageBox.Show("Kirja lainattu onnistuneesti!");

                //Kirjan saldon vähentäminen kirjaston tietokannasta, kun kirja lainataan:
                string kirjasaldon_pienentaminen = "UPDATE kirja SET kpl = kpl - 1 WHERE isbn = @KirjanISBN"; //Päivitetään kirjan saldo tietokannasta lainauksen jälkeen
                MySqlCommand KplVahennys = new MySqlCommand(kirjasaldon_pienentaminen, yhteys); //MySQL-komento kirjasaldon vähentämiseen
                KplVahennys.Parameters.AddWithValue("@KirjanISBN", KirjanISBN); //Parametrinä kirjan ISBN
                KplVahennys.ExecuteNonQuery(); //Suoritetaan komento tietokantaan ExecuteNonQuerylla

               // MessageBox.Show("Kirjan saldo tietokannassa päivitetty (kpl-määrä vähennetty)");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message); //Jos ilmenee virhe, ohjelma kertoo
            }
            finally
            {
                yhteys.Close(); //Suljetaan tietokantayhteys
            }
        }

        private void SuljeNappi_Click(object sender, EventArgs e)
        {
            this.Close(); //Sulje kirja.cs-ikkuna
        }
    }
}
