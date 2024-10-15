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
    public partial class otayhteytta_hkunta : Form
    {
        public otayhteytta_hkunta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SuljeIkkunaNappi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
