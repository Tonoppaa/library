/*using System;
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
    public partial class uutuudet : Form
    {
        public uutuudet()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}*/
        /*private void Etusivu_Click(object sender, EventArgs e)
        {
            asiakas_etusivu2 form17 = new asiakas_etusivu2();
            form17.Show();
            this.Close();
        }

        private void Uutuudet_Click(object sender, EventArgs e)
        {
            asiakas_aineistot2 form18 = new asiakas_aineistot2();
            form18.Show();
            this.Close();
        }

        private void OmatLainat_Click(object sender, EventArgs e)
        {
            omat_lainat form19 = new omat_lainat();
            form19.Show();
            this.Close();
        }

        private void OmatTiedot_Click(object sender, EventArgs e)
        {
            omat_tiedot form20 = new omat_tiedot();
            form20.Show();
            this.Close();
        }

        private void OtaYhteytta_Click(object sender, EventArgs e)
        {
            otayhteytta form21 = new otayhteytta();
            form21.Show();
        }

        private void KirjauduUlos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olet kirjautunut ulos.");
            kirjaudu form22 = new kirjaudu();
            form22.Show();
            this.Close();
        }

        private bool HaunTarkistus(string hakusana) //Luodaan metodi, jonka avulla tarkistetaan, onko käyttäjän antama hakusyöte tyhjä
        {
            if (string.IsNullOrWhiteSpace(hakusana)) //string.IsNullOrWhiteSpace on C#-kielen funktio, joka tarkistaa, onko annettu merkkijono null, tyhjä ("") tai koostuu pelkistä välilyönneistä tai muista tila-merkeistä
            {
                MessageBox.Show("Haullasi ei löytynyt tuloksia.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void HakuNappiUutuudet_Click(object sender, EventArgs e)
        {
            string hakusana = HakuKenttaUutuudet.Text;
            //Hakuikkunan käsittely
            if (HaunTarkistus(hakusana))
            {
                // Avataan hakuikkuna vain, jos löytyy tuloksia
                haku hakuIkkuna = new haku();
                if (hakuIkkuna.HaeTiedot(hakusana)) //Jos hakutuloksia löytyy, ikkuna avataan ja tulokset näytetään. Jos ei tuloksia, siitä ilmoitetaan käyttäjälle
                {
                    //Näytetään hakuikkuna
                    hakuIkkuna.Show();
                }
                else
                {
                    MessageBox.Show("Haullasi ei löytynyt tuloksia.");
                }
            }
        }
    }
}
        */