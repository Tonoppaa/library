﻿using System;
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
    public partial class unohtunut : Form
    {
        public unohtunut()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kenttä ei voi olla tyhjä!");
            } else {
                MessageBox.Show("Käyttäjätunnuksesi / salasanasi on lähetetty sähköpostiisi.");
            }
        }
    }
}
