namespace kirjasto_käyttöliittymä_versio2
{
    partial class haku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HakuNappi = new Button();
            label2 = new Label();
            HakuKentta_Haku = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label12 = new Label();
            label13 = new Label();
            HakuTulos = new DataGridView();
            HakuTulosYht = new TextBox();
            SuljeIkkuna = new Button();
            TyhjennaKentat = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            ISBNTekstikentta = new TextBox();
            label8 = new Label();
            KirjailijaTekstikentta = new TextBox();
            KirjaTekstikentta = new TextBox();
            JulkaisuvuosiTekstikentta = new TextBox();
            KategoriaTekstikentta = new TextBox();
            HaeISBN = new Button();
            HaeKirjailija = new Button();
            HaeKirjanNimi = new Button();
            HaeJulkaisuvuosi = new Button();
            HaeKategoria = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)HakuTulos).BeginInit();
            SuspendLayout();
            // 
            // HakuNappi
            // 
            HakuNappi.BackColor = Color.Lime;
            HakuNappi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HakuNappi.Location = new Point(559, 60);
            HakuNappi.Name = "HakuNappi";
            HakuNappi.Size = new Size(35, 29);
            HakuNappi.TabIndex = 41;
            HakuNappi.Text = "->";
            HakuNappi.UseVisualStyleBackColor = false;
            HakuNappi.Click += HakuNappi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 39);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 40;
            label2.Text = "Hakukenttä";
            // 
            // HakuKentta_Haku
            // 
            HakuKentta_Haku.Location = new Point(241, 62);
            HakuKentta_Haku.Name = "HakuKentta_Haku";
            HakuKentta_Haku.Size = new Size(321, 27);
            HakuKentta_Haku.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 38;
            label1.Text = "Kirjasto X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(41, 126);
            label5.Name = "label5";
            label5.Size = new Size(137, 30);
            label5.TabIndex = 46;
            label5.Text = "Hakuosumia:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 614);
            label12.Name = "label12";
            label12.Size = new Size(353, 20);
            label12.TabIndex = 54;
            label12.Text = "Klikkaa riviä tarkastellaksesi kirjan tarkempia tietoja!";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 634);
            label13.Name = "label13";
            label13.Size = new Size(1041, 20);
            label13.TabIndex = 55;
            label13.Text = "____________________________________________________________________________________________________________________________________________________________________________";
            // 
            // HakuTulos
            // 
            HakuTulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HakuTulos.Location = new Point(41, 317);
            HakuTulos.Name = "HakuTulos";
            HakuTulos.ReadOnly = true;
            HakuTulos.RowHeadersWidth = 51;
            HakuTulos.Size = new Size(1039, 276);
            HakuTulos.TabIndex = 56;
            HakuTulos.CellContentDoubleClick += HakuTulos_CellDoubleClick;
            // 
            // HakuTulosYht
            // 
            HakuTulosYht.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HakuTulosYht.Location = new Point(241, 105);
            HakuTulosYht.Name = "HakuTulosYht";
            HakuTulosYht.ReadOnly = true;
            HakuTulosYht.Size = new Size(62, 51);
            HakuTulosYht.TabIndex = 57;
            HakuTulosYht.TextAlign = HorizontalAlignment.Center;
            HakuTulosYht.TextChanged += HakuTulosYht_TextChanged;
            // 
            // SuljeIkkuna
            // 
            SuljeIkkuna.Location = new Point(986, 62);
            SuljeIkkuna.Name = "SuljeIkkuna";
            SuljeIkkuna.Size = new Size(94, 29);
            SuljeIkkuna.TabIndex = 58;
            SuljeIkkuna.Text = "Sulje";
            SuljeIkkuna.UseVisualStyleBackColor = true;
            SuljeIkkuna.Click += SuljeIkkuna_Click;
            // 
            // TyhjennaKentat
            // 
            TyhjennaKentat.Location = new Point(473, 124);
            TyhjennaKentat.Name = "TyhjennaKentat";
            TyhjennaKentat.Size = new Size(121, 29);
            TyhjennaKentat.TabIndex = 59;
            TyhjennaKentat.Text = "Tyhjennä kentät";
            TyhjennaKentat.UseVisualStyleBackColor = true;
            TyhjennaKentat.Click += TyhjennaKentat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 245);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 60;
            label3.Text = "Hae ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 245);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 61;
            label4.Text = "Hae kirjailija";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 245);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 62;
            label6.Text = "Hae kirjan nimi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(661, 245);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 63;
            label7.Text = "Hae kirjan julkaisuvuosi";
            // 
            // ISBNTekstikentta
            // 
            ISBNTekstikentta.Location = new Point(41, 280);
            ISBNTekstikentta.Name = "ISBNTekstikentta";
            ISBNTekstikentta.Size = new Size(168, 27);
            ISBNTekstikentta.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(880, 245);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 65;
            label8.Text = "Hae kategoria";
            // 
            // KirjailijaTekstikentta
            // 
            KirjailijaTekstikentta.Location = new Point(241, 280);
            KirjailijaTekstikentta.Name = "KirjailijaTekstikentta";
            KirjailijaTekstikentta.Size = new Size(168, 27);
            KirjailijaTekstikentta.TabIndex = 66;
            // 
            // KirjaTekstikentta
            // 
            KirjaTekstikentta.Location = new Point(443, 280);
            KirjaTekstikentta.Name = "KirjaTekstikentta";
            KirjaTekstikentta.Size = new Size(168, 27);
            KirjaTekstikentta.TabIndex = 67;
            // 
            // JulkaisuvuosiTekstikentta
            // 
            JulkaisuvuosiTekstikentta.Location = new Point(661, 280);
            JulkaisuvuosiTekstikentta.Name = "JulkaisuvuosiTekstikentta";
            JulkaisuvuosiTekstikentta.Size = new Size(179, 27);
            JulkaisuvuosiTekstikentta.TabIndex = 68;
            // 
            // KategoriaTekstikentta
            // 
            KategoriaTekstikentta.Location = new Point(880, 280);
            KategoriaTekstikentta.Name = "KategoriaTekstikentta";
            KategoriaTekstikentta.Size = new Size(168, 27);
            KategoriaTekstikentta.TabIndex = 69;
            // 
            // HaeISBN
            // 
            HaeISBN.BackColor = Color.Lime;
            HaeISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeISBN.Location = new Point(200, 278);
            HaeISBN.Name = "HaeISBN";
            HaeISBN.Size = new Size(35, 29);
            HaeISBN.TabIndex = 70;
            HaeISBN.Text = "->";
            HaeISBN.UseVisualStyleBackColor = false;
            HaeISBN.Click += HaeISBN_Click;
            // 
            // HaeKirjailija
            // 
            HaeKirjailija.BackColor = Color.Lime;
            HaeKirjailija.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeKirjailija.Location = new Point(402, 280);
            HaeKirjailija.Name = "HaeKirjailija";
            HaeKirjailija.Size = new Size(35, 29);
            HaeKirjailija.TabIndex = 71;
            HaeKirjailija.Text = "->";
            HaeKirjailija.UseVisualStyleBackColor = false;
            HaeKirjailija.Click += HaeKirjailija_Click;
            // 
            // HaeKirjanNimi
            // 
            HaeKirjanNimi.BackColor = Color.Lime;
            HaeKirjanNimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeKirjanNimi.Location = new Point(607, 278);
            HaeKirjanNimi.Name = "HaeKirjanNimi";
            HaeKirjanNimi.Size = new Size(35, 29);
            HaeKirjanNimi.TabIndex = 72;
            HaeKirjanNimi.Text = "->";
            HaeKirjanNimi.UseVisualStyleBackColor = false;
            HaeKirjanNimi.Click += HaeKirjanNimi_Click;
            // 
            // HaeJulkaisuvuosi
            // 
            HaeJulkaisuvuosi.BackColor = Color.Lime;
            HaeJulkaisuvuosi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeJulkaisuvuosi.Location = new Point(835, 278);
            HaeJulkaisuvuosi.Name = "HaeJulkaisuvuosi";
            HaeJulkaisuvuosi.Size = new Size(35, 29);
            HaeJulkaisuvuosi.TabIndex = 73;
            HaeJulkaisuvuosi.Text = "->";
            HaeJulkaisuvuosi.UseVisualStyleBackColor = false;
            HaeJulkaisuvuosi.Click += HaeJulkaisuvuosi_Click;
            // 
            // HaeKategoria
            // 
            HaeKategoria.BackColor = Color.Lime;
            HaeKategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeKategoria.Location = new Point(1045, 278);
            HaeKategoria.Name = "HaeKategoria";
            HaeKategoria.Size = new Size(35, 29);
            HaeKategoria.TabIndex = 74;
            HaeKategoria.Text = "->";
            HaeKategoria.UseVisualStyleBackColor = false;
            HaeKategoria.Click += HaeKategoria_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label9.Location = new Point(41, 176);
            label9.Name = "label9";
            label9.Size = new Size(212, 46);
            label9.TabIndex = 75;
            label9.Text = "Tarkka haku";
            // 
            // haku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 671);
            Controls.Add(label9);
            Controls.Add(HaeKategoria);
            Controls.Add(HaeJulkaisuvuosi);
            Controls.Add(HaeKirjanNimi);
            Controls.Add(HaeKirjailija);
            Controls.Add(HaeISBN);
            Controls.Add(KategoriaTekstikentta);
            Controls.Add(JulkaisuvuosiTekstikentta);
            Controls.Add(KirjaTekstikentta);
            Controls.Add(KirjailijaTekstikentta);
            Controls.Add(label8);
            Controls.Add(ISBNTekstikentta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TyhjennaKentat);
            Controls.Add(SuljeIkkuna);
            Controls.Add(HakuTulosYht);
            Controls.Add(HakuTulos);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(HakuNappi);
            Controls.Add(label2);
            Controls.Add(HakuKentta_Haku);
            Controls.Add(label1);
            Name = "haku";
            Text = "haku";
            ((System.ComponentModel.ISupportInitialize)HakuTulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button HakuNappi;
        private Label label2;
        private TextBox HakuKentta_Haku;
        private Label label1;
        private Label label5;
        private Label label12;
        private Label label13;
        private DataGridView HakuTulos;
        private TextBox HakuTulosYht;
        private Button SuljeIkkuna;
        private Button TyhjennaKentat;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox ISBNTekstikentta;
        private Label label8;
        private TextBox KirjailijaTekstikentta;
        private TextBox KirjaTekstikentta;
        private TextBox JulkaisuvuosiTekstikentta;
        private TextBox KategoriaTekstikentta;
        private Button HaeISBN;
        private Button HaeKirjailija;
        private Button HaeKirjanNimi;
        private Button HaeJulkaisuvuosi;
        private Button HaeKategoria;
        private Label label9;
    }
}