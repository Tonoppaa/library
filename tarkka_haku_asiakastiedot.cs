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
    public partial class tarkka_haku_asiakastiedot : Form
    {
        string userID;
        MySqlConnection yhteys;
        public tarkka_haku_asiakastiedot(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userID = uID;
            yhteys = yhteysOlio;
        }
    }
}
