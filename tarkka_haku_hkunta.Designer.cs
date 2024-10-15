namespace kirjasto_käyttöliittymä_versio2
{
    partial class tarkka_haku_hkunta
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
            LisaaNappi = new Button();
            OmaSivuNappi = new Button();
            button3 = new Button();
            AineistotHkunta = new Button();
            EtusivuNappi = new Button();
            KirjauduUlosNappi = new Button();
            OtaYhteyttaNappi = new Button();
            label1 = new Label();
            label9 = new Label();
            HaeKategoria = new Button();
            HaeJulkaisuvuosi = new Button();
            HaeKirjanNimi = new Button();
            HaeKirjailija = new Button();
            HaeISBN = new Button();
            KategoriaTekstikentta = new TextBox();
            JulkaisuvuosiTekstikentta = new TextBox();
            KirjaTekstikentta = new TextBox();
            KirjailijaTekstikentta = new TextBox();
            label8 = new Label();
            ISBNTekstikentta = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            TyhjennaKentat = new Button();
            HakuTulosYht = new TextBox();
            HakuTulos = new DataGridView();
            label5 = new Label();
            label13 = new Label();
            label2 = new Label();
            AsiakasnumeroTextBox = new TextBox();
            HaeAsnumNappi = new Button();
            label10 = new Label();
            AsEtunimiTextBox = new TextBox();
            AsSukunimiTextBox = new TextBox();
            HaeAsEnimiSnimiNappi = new Button();
            ((System.ComponentModel.ISupportInitialize)HakuTulos).BeginInit();
            SuspendLayout();
            // 
            // LisaaNappi
            // 
            LisaaNappi.BackColor = Color.Lime;
            LisaaNappi.Font = new Font("Segoe UI", 12F);
            LisaaNappi.Location = new Point(472, 136);
            LisaaNappi.Name = "LisaaNappi";
            LisaaNappi.Size = new Size(182, 42);
            LisaaNappi.TabIndex = 106;
            LisaaNappi.Text = "Lisää järjestelmään";
            LisaaNappi.UseVisualStyleBackColor = false;
            LisaaNappi.Click += LisaaNappi_Click;
            // 
            // OmaSivuNappi
            // 
            OmaSivuNappi.Font = new Font("Segoe UI", 12F);
            OmaSivuNappi.Location = new Point(365, 136);
            OmaSivuNappi.Name = "OmaSivuNappi";
            OmaSivuNappi.Size = new Size(101, 42);
            OmaSivuNappi.TabIndex = 105;
            OmaSivuNappi.Text = "Oma sivu";
            OmaSivuNappi.UseVisualStyleBackColor = true;
            OmaSivuNappi.Click += OmaSivuNappi_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(233, 136);
            button3.Name = "button3";
            button3.Size = new Size(132, 42);
            button3.TabIndex = 104;
            button3.Text = "Tarkka haku";
            button3.UseVisualStyleBackColor = false;
            // 
            // AineistotHkunta
            // 
            AineistotHkunta.BackColor = Color.White;
            AineistotHkunta.Font = new Font("Segoe UI", 12F);
            AineistotHkunta.Location = new Point(133, 136);
            AineistotHkunta.Name = "AineistotHkunta";
            AineistotHkunta.Size = new Size(100, 42);
            AineistotHkunta.TabIndex = 103;
            AineistotHkunta.Text = "Aineistot";
            AineistotHkunta.UseVisualStyleBackColor = false;
            AineistotHkunta.Click += AineistotHkunta_Click;
            // 
            // EtusivuNappi
            // 
            EtusivuNappi.BackColor = Color.White;
            EtusivuNappi.Font = new Font("Segoe UI", 12F);
            EtusivuNappi.Location = new Point(38, 136);
            EtusivuNappi.Name = "EtusivuNappi";
            EtusivuNappi.Size = new Size(94, 42);
            EtusivuNappi.TabIndex = 102;
            EtusivuNappi.Text = "Etusivu";
            EtusivuNappi.UseVisualStyleBackColor = false;
            EtusivuNappi.Click += EtusivuNappi_Click;
            // 
            // KirjauduUlosNappi
            // 
            KirjauduUlosNappi.Location = new Point(942, 94);
            KirjauduUlosNappi.Name = "KirjauduUlosNappi";
            KirjauduUlosNappi.Size = new Size(135, 29);
            KirjauduUlosNappi.TabIndex = 101;
            KirjauduUlosNappi.Text = "Kirjaudu ulos";
            KirjauduUlosNappi.UseVisualStyleBackColor = true;
            KirjauduUlosNappi.Click += KirjauduUlosNappi_Click;
            // 
            // OtaYhteyttaNappi
            // 
            OtaYhteyttaNappi.Location = new Point(942, 59);
            OtaYhteyttaNappi.Name = "OtaYhteyttaNappi";
            OtaYhteyttaNappi.Size = new Size(135, 29);
            OtaYhteyttaNappi.TabIndex = 100;
            OtaYhteyttaNappi.Text = "Ota yhteyttä";
            OtaYhteyttaNappi.UseVisualStyleBackColor = true;
            OtaYhteyttaNappi.Click += OtaYhteyttaNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 96;
            label1.Text = "Kirjasto X";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label9.Location = new Point(38, 255);
            label9.Name = "label9";
            label9.Size = new Size(318, 46);
            label9.TabIndex = 126;
            label9.Text = "Tarkka haku (kirja)";
            // 
            // HaeKategoria
            // 
            HaeKategoria.BackColor = Color.Lime;
            HaeKategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeKategoria.Location = new Point(1042, 357);
            HaeKategoria.Name = "HaeKategoria";
            HaeKategoria.Size = new Size(35, 29);
            HaeKategoria.TabIndex = 125;
            HaeKategoria.Text = "->";
            HaeKategoria.UseVisualStyleBackColor = false;
            // 
            // HaeJulkaisuvuosi
            // 
            HaeJulkaisuvuosi.BackColor = Color.Lime;
            HaeJulkaisuvuosi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeJulkaisuvuosi.Location = new Point(832, 357);
            HaeJulkaisuvuosi.Name = "HaeJulkaisuvuosi";
            HaeJulkaisuvuosi.Size = new Size(35, 29);
            HaeJulkaisuvuosi.TabIndex = 124;
            HaeJulkaisuvuosi.Text = "->";
            HaeJulkaisuvuosi.UseVisualStyleBackColor = false;
            // 
            // HaeKirjanNimi
            // 
            HaeKirjanNimi.BackColor = Color.Lime;
            HaeKirjanNimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeKirjanNimi.Location = new Point(604, 357);
            HaeKirjanNimi.Name = "HaeKirjanNimi";
            HaeKirjanNimi.Size = new Size(35, 29);
            HaeKirjanNimi.TabIndex = 123;
            HaeKirjanNimi.Text = "->";
            HaeKirjanNimi.UseVisualStyleBackColor = false;
            // 
            // HaeKirjailija
            // 
            HaeKirjailija.BackColor = Color.Lime;
            HaeKirjailija.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeKirjailija.Location = new Point(399, 359);
            HaeKirjailija.Name = "HaeKirjailija";
            HaeKirjailija.Size = new Size(35, 29);
            HaeKirjailija.TabIndex = 122;
            HaeKirjailija.Text = "->";
            HaeKirjailija.UseVisualStyleBackColor = false;
            // 
            // HaeISBN
            // 
            HaeISBN.BackColor = Color.Lime;
            HaeISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeISBN.Location = new Point(197, 357);
            HaeISBN.Name = "HaeISBN";
            HaeISBN.Size = new Size(35, 29);
            HaeISBN.TabIndex = 121;
            HaeISBN.Text = "->";
            HaeISBN.UseVisualStyleBackColor = false;
            // 
            // KategoriaTekstikentta
            // 
            KategoriaTekstikentta.Location = new Point(877, 359);
            KategoriaTekstikentta.Name = "KategoriaTekstikentta";
            KategoriaTekstikentta.Size = new Size(168, 27);
            KategoriaTekstikentta.TabIndex = 120;
            // 
            // JulkaisuvuosiTekstikentta
            // 
            JulkaisuvuosiTekstikentta.Location = new Point(658, 359);
            JulkaisuvuosiTekstikentta.Name = "JulkaisuvuosiTekstikentta";
            JulkaisuvuosiTekstikentta.Size = new Size(179, 27);
            JulkaisuvuosiTekstikentta.TabIndex = 119;
            // 
            // KirjaTekstikentta
            // 
            KirjaTekstikentta.Location = new Point(440, 359);
            KirjaTekstikentta.Name = "KirjaTekstikentta";
            KirjaTekstikentta.Size = new Size(168, 27);
            KirjaTekstikentta.TabIndex = 118;
            // 
            // KirjailijaTekstikentta
            // 
            KirjailijaTekstikentta.Location = new Point(238, 359);
            KirjailijaTekstikentta.Name = "KirjailijaTekstikentta";
            KirjailijaTekstikentta.Size = new Size(168, 27);
            KirjailijaTekstikentta.TabIndex = 117;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(877, 324);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 116;
            label8.Text = "Hae kategoria";
            // 
            // ISBNTekstikentta
            // 
            ISBNTekstikentta.Location = new Point(38, 359);
            ISBNTekstikentta.Name = "ISBNTekstikentta";
            ISBNTekstikentta.Size = new Size(168, 27);
            ISBNTekstikentta.TabIndex = 115;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(658, 324);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 114;
            label7.Text = "Hae kirjan julkaisuvuosi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 324);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 113;
            label6.Text = "Hae kirjan nimi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 324);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 112;
            label4.Text = "Hae kirjailija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 324);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 111;
            label3.Text = "Hae ISBN";
            // 
            // TyhjennaKentat
            // 
            TyhjennaKentat.Location = new Point(533, 206);
            TyhjennaKentat.Name = "TyhjennaKentat";
            TyhjennaKentat.Size = new Size(121, 29);
            TyhjennaKentat.TabIndex = 110;
            TyhjennaKentat.Text = "Tyhjennä kentät";
            TyhjennaKentat.UseVisualStyleBackColor = true;
            // 
            // HakuTulosYht
            // 
            HakuTulosYht.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HakuTulosYht.Location = new Point(238, 201);
            HakuTulosYht.Name = "HakuTulosYht";
            HakuTulosYht.ReadOnly = true;
            HakuTulosYht.Size = new Size(62, 51);
            HakuTulosYht.TabIndex = 109;
            HakuTulosYht.TextAlign = HorizontalAlignment.Center;
            // 
            // HakuTulos
            // 
            HakuTulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HakuTulos.Location = new Point(40, 491);
            HakuTulos.Name = "HakuTulos";
            HakuTulos.ReadOnly = true;
            HakuTulos.RowHeadersWidth = 51;
            HakuTulos.Size = new Size(1039, 244);
            HakuTulos.TabIndex = 108;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(38, 205);
            label5.Name = "label5";
            label5.Size = new Size(137, 30);
            label5.TabIndex = 107;
            label5.Text = "Hakuosumia:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 389);
            label13.Name = "label13";
            label13.Size = new Size(1041, 20);
            label13.TabIndex = 127;
            label13.Text = "____________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 421);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 128;
            label2.Text = "Hae asiakasnumero";
            // 
            // AsiakasnumeroTextBox
            // 
            AsiakasnumeroTextBox.Location = new Point(38, 444);
            AsiakasnumeroTextBox.Name = "AsiakasnumeroTextBox";
            AsiakasnumeroTextBox.Size = new Size(153, 27);
            AsiakasnumeroTextBox.TabIndex = 129;
            // 
            // HaeAsnumNappi
            // 
            HaeAsnumNappi.BackColor = Color.Lime;
            HaeAsnumNappi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeAsnumNappi.Location = new Point(197, 442);
            HaeAsnumNappi.Name = "HaeAsnumNappi";
            HaeAsnumNappi.Size = new Size(35, 29);
            HaeAsnumNappi.TabIndex = 130;
            HaeAsnumNappi.Text = "->";
            HaeAsnumNappi.UseVisualStyleBackColor = false;
            HaeAsnumNappi.Click += HaeAsnumNappi_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(238, 421);
            label10.Name = "label10";
            label10.Size = new Size(277, 20);
            label10.TabIndex = 131;
            label10.Text = "Hae asiakkaan nimi (etunimi + sukunimi)";
            // 
            // AsEtunimiTextBox
            // 
            AsEtunimiTextBox.Location = new Point(238, 442);
            AsEtunimiTextBox.Name = "AsEtunimiTextBox";
            AsEtunimiTextBox.Size = new Size(118, 27);
            AsEtunimiTextBox.TabIndex = 132;
            // 
            // AsSukunimiTextBox
            // 
            AsSukunimiTextBox.Location = new Point(362, 442);
            AsSukunimiTextBox.Name = "AsSukunimiTextBox";
            AsSukunimiTextBox.Size = new Size(171, 27);
            AsSukunimiTextBox.TabIndex = 133;
            // 
            // HaeAsEnimiSnimiNappi
            // 
            HaeAsEnimiSnimiNappi.BackColor = Color.Lime;
            HaeAsEnimiSnimiNappi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeAsEnimiSnimiNappi.Location = new Point(539, 440);
            HaeAsEnimiSnimiNappi.Name = "HaeAsEnimiSnimiNappi";
            HaeAsEnimiSnimiNappi.Size = new Size(35, 29);
            HaeAsEnimiSnimiNappi.TabIndex = 134;
            HaeAsEnimiSnimiNappi.Text = "->";
            HaeAsEnimiSnimiNappi.UseVisualStyleBackColor = false;
            HaeAsEnimiSnimiNappi.Click += HaeAsEnimiSnimiNappi_Click;
            // 
            // tarkka_haku_hkunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 763);
            Controls.Add(HaeAsEnimiSnimiNappi);
            Controls.Add(AsSukunimiTextBox);
            Controls.Add(AsEtunimiTextBox);
            Controls.Add(label10);
            Controls.Add(HaeAsnumNappi);
            Controls.Add(AsiakasnumeroTextBox);
            Controls.Add(label2);
            Controls.Add(label13);
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
            Controls.Add(HakuTulosYht);
            Controls.Add(HakuTulos);
            Controls.Add(label5);
            Controls.Add(LisaaNappi);
            Controls.Add(OmaSivuNappi);
            Controls.Add(button3);
            Controls.Add(AineistotHkunta);
            Controls.Add(EtusivuNappi);
            Controls.Add(KirjauduUlosNappi);
            Controls.Add(OtaYhteyttaNappi);
            Controls.Add(label1);
            Name = "tarkka_haku_hkunta";
            Text = "tarkka_haku_hkunta";
            ((System.ComponentModel.ISupportInitialize)HakuTulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LisaaNappi;
        private Button OmaSivuNappi;
        private Button button3;
        private Button AineistotHkunta;
        private Button EtusivuNappi;
        private Button KirjauduUlosNappi;
        private Button OtaYhteyttaNappi;
        private Label label1;
        private Label label9;
        private Button HaeKategoria;
        private Button HaeJulkaisuvuosi;
        private Button HaeKirjanNimi;
        private Button HaeKirjailija;
        private Button HaeISBN;
        private TextBox KategoriaTekstikentta;
        private TextBox JulkaisuvuosiTekstikentta;
        private TextBox KirjaTekstikentta;
        private TextBox KirjailijaTekstikentta;
        private Label label8;
        private TextBox ISBNTekstikentta;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button TyhjennaKentat;
        private TextBox HakuTulosYht;
        private DataGridView HakuTulos;
        private Label label5;
        private Label label13;
        private Label label2;
        private TextBox AsiakasnumeroTextBox;
        private Button HaeAsnumNappi;
        private Label label10;
        private TextBox AsEtunimiTextBox;
        private TextBox AsSukunimiTextBox;
        private Button HaeAsEnimiSnimiNappi;
    }
}