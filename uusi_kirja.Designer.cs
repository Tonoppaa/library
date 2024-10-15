namespace kirjasto_käyttöliittymä_versio2
{
    partial class uusi_kirja
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
            label1 = new Label();
            KirjanKuva = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            KirjanNimi = new TextBox();
            Kirjoittaja = new TextBox();
            label5 = new Label();
            Julkaisuvuosi = new TextBox();
            label6 = new Label();
            KirjaLkm = new TextBox();
            label7 = new Label();
            LisaaKirja = new Button();
            SuljeNappi = new Button();
            Sivumaara = new TextBox();
            label8 = new Label();
            KirjanKuvaus = new RichTextBox();
            label10 = new Label();
            ISBNkentta = new TextBox();
            label11 = new Label();
            Maakoodit = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            KirjoittajaSnimi = new TextBox();
            Kategoriat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)KirjanKuva).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(73, 30);
            label1.Name = "label1";
            label1.Size = new Size(163, 46);
            label1.TabIndex = 0;
            label1.Text = "Lisää kirja";
            // 
            // KirjanKuva
            // 
            KirjanKuva.Location = new Point(73, 108);
            KirjanKuva.Name = "KirjanKuva";
            KirjanKuva.Size = new Size(230, 295);
            KirjanKuva.TabIndex = 1;
            KirjanKuva.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Kirjan nimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 143);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 3;
            label3.Text = "Kirjoittaja etunimi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 265);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 4;
            label4.Text = "Kirjan kuvaus:";
            // 
            // KirjanNimi
            // 
            KirjanNimi.Location = new Point(433, 101);
            KirjanNimi.Name = "KirjanNimi";
            KirjanNimi.Size = new Size(353, 27);
            KirjanNimi.TabIndex = 6;
            // 
            // Kirjoittaja
            // 
            Kirjoittaja.Location = new Point(472, 134);
            Kirjoittaja.Name = "Kirjoittaja";
            Kirjoittaja.Size = new Size(312, 27);
            Kirjoittaja.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 408);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 8;
            label5.Text = "Julkaisuvuosi:";
            // 
            // Julkaisuvuosi
            // 
            Julkaisuvuosi.Location = new Point(431, 405);
            Julkaisuvuosi.MaxLength = 4;
            Julkaisuvuosi.Name = "Julkaisuvuosi";
            Julkaisuvuosi.Size = new Size(353, 27);
            Julkaisuvuosi.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 451);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 10;
            label6.Text = "Kirjojen lukumäärä:";
            // 
            // KirjaLkm
            // 
            KirjaLkm.Location = new Point(481, 448);
            KirjaLkm.MaxLength = 10;
            KirjaLkm.Name = "KirjaLkm";
            KirjaLkm.Size = new Size(303, 27);
            KirjaLkm.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 493);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 12;
            label7.Text = "Kategoria:";
            // 
            // LisaaKirja
            // 
            LisaaKirja.BackColor = Color.Lime;
            LisaaKirja.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LisaaKirja.Location = new Point(73, 478);
            LisaaKirja.Name = "LisaaKirja";
            LisaaKirja.Size = new Size(128, 36);
            LisaaKirja.TabIndex = 16;
            LisaaKirja.Text = "Lisää kirja";
            LisaaKirja.UseVisualStyleBackColor = false;
            LisaaKirja.Click += LisaaKirja_Click;
            // 
            // SuljeNappi
            // 
            SuljeNappi.BackColor = Color.White;
            SuljeNappi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SuljeNappi.Location = new Point(209, 478);
            SuljeNappi.Name = "SuljeNappi";
            SuljeNappi.Size = new Size(94, 36);
            SuljeNappi.TabIndex = 17;
            SuljeNappi.Text = "Peruuta";
            SuljeNappi.UseVisualStyleBackColor = false;
            SuljeNappi.Click += SuljeNappi_Click;
            // 
            // Sivumaara
            // 
            Sivumaara.Location = new Point(431, 528);
            Sivumaara.MaxLength = 4;
            Sivumaara.Name = "Sivumaara";
            Sivumaara.Size = new Size(353, 27);
            Sivumaara.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 535);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 20;
            label8.Text = "Sivumäärä:";
            // 
            // KirjanKuvaus
            // 
            KirjanKuvaus.Location = new Point(333, 284);
            KirjanKuvaus.Name = "KirjanKuvaus";
            KirjanKuvaus.Size = new Size(451, 101);
            KirjanKuvaus.TabIndex = 5;
            KirjanKuvaus.Text = "";
            KirjanKuvaus.TextChanged += richTextBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(333, 71);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 21;
            label10.Text = "ISBN:";
            // 
            // ISBNkentta
            // 
            ISBNkentta.Location = new Point(433, 64);
            ISBNkentta.MaxLength = 13;
            ISBNkentta.Name = "ISBNkentta";
            ISBNkentta.Size = new Size(353, 27);
            ISBNkentta.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(333, 225);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 23;
            label11.Text = "Maakoodi:";
            // 
            // Maakoodit
            // 
            Maakoodit.FormattingEnabled = true;
            Maakoodit.Location = new Point(431, 218);
            Maakoodit.Name = "Maakoodit";
            Maakoodit.Size = new Size(353, 28);
            Maakoodit.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(483, 30);
            label12.Name = "label12";
            label12.Size = new Size(236, 20);
            label12.TabIndex = 25;
            label12.Text = "ISBN-numero on 13 merkkiä pitkä ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(333, 182);
            label14.Name = "label14";
            label14.Size = new Size(139, 20);
            label14.TabIndex = 28;
            label14.Text = "Kirjoittaja sukunimi:";
            // 
            // KirjoittajaSnimi
            // 
            KirjoittajaSnimi.Location = new Point(472, 178);
            KirjoittajaSnimi.Name = "KirjoittajaSnimi";
            KirjoittajaSnimi.Size = new Size(312, 27);
            KirjoittajaSnimi.TabIndex = 29;
            // 
            // Kategoriat
            // 
            Kategoriat.FormattingEnabled = true;
            Kategoriat.Location = new Point(431, 490);
            Kategoriat.Name = "Kategoriat";
            Kategoriat.Size = new Size(353, 28);
            Kategoriat.TabIndex = 30;
            // 
            // uusi_kirja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 620);
            Controls.Add(Kategoriat);
            Controls.Add(KirjoittajaSnimi);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(Maakoodit);
            Controls.Add(label11);
            Controls.Add(ISBNkentta);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(Sivumaara);
            Controls.Add(SuljeNappi);
            Controls.Add(LisaaKirja);
            Controls.Add(label7);
            Controls.Add(KirjaLkm);
            Controls.Add(label6);
            Controls.Add(Julkaisuvuosi);
            Controls.Add(label5);
            Controls.Add(Kirjoittaja);
            Controls.Add(KirjanNimi);
            Controls.Add(KirjanKuvaus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(KirjanKuva);
            Controls.Add(label1);
            Name = "uusi_kirja";
            Text = "uusi_kirja";
            Load += uusi_kirja_Load;
            ((System.ComponentModel.ISupportInitialize)KirjanKuva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox KirjanKuva;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox KirjanNimi;
        private TextBox Kirjoittaja;
        private Label label5;
        private TextBox Julkaisuvuosi;
        private Label label6;
        private TextBox KirjaLkm;
        private Label label7;
        private Button LisaaKirja;
        private Button SuljeNappi;
        private TextBox Sivumaara;
        private Label label8;
        private RichTextBox KirjanKuvaus;
        private Label label10;
        private TextBox ISBNkentta;
        private Label label11;
        private ComboBox Maakoodit;
        private Label label12;
        private Label label14;
        private TextBox KirjoittajaSnimi;
        private ComboBox Kategoriat;
    }
}