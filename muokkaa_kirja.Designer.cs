namespace kirjasto_käyttöliittymä_versio2
{
    partial class muokkaa_kirja
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
            SuljeNappi = new Button();
            TallennaNappi = new Button();
            KategoriaTextBox = new TextBox();
            label7 = new Label();
            KirjaLkmTextBox = new TextBox();
            label6 = new Label();
            JulkaisuVuosiTextBox = new TextBox();
            label5 = new Label();
            KirjoittajaTextBox = new TextBox();
            KirjanNimiTextBox = new TextBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            ISBNTextBox = new TextBox();
            PoistaKirjaNappi = new Button();
            KirjoittajaSnimiTextBox = new TextBox();
            label8 = new Label();
            Kategoriat = new ComboBox();
            SivumaaraTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SuljeNappi
            // 
            SuljeNappi.BackColor = Color.White;
            SuljeNappi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SuljeNappi.Location = new Point(69, 455);
            SuljeNappi.Name = "SuljeNappi";
            SuljeNappi.Size = new Size(94, 36);
            SuljeNappi.TabIndex = 36;
            SuljeNappi.Text = "Peruuta";
            SuljeNappi.UseVisualStyleBackColor = false;
            SuljeNappi.Click += SuljeNappi_Click;
            // 
            // TallennaNappi
            // 
            TallennaNappi.BackColor = Color.Lime;
            TallennaNappi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TallennaNappi.Location = new Point(69, 413);
            TallennaNappi.Name = "TallennaNappi";
            TallennaNappi.Size = new Size(229, 36);
            TallennaNappi.TabIndex = 35;
            TallennaNappi.Text = "Tallenna muutokset";
            TallennaNappi.UseVisualStyleBackColor = false;
            TallennaNappi.Click += TallennaNappi_Click;
            // 
            // KategoriaTextBox
            // 
            KategoriaTextBox.Location = new Point(69, 598);
            KategoriaTextBox.Name = "KategoriaTextBox";
            KategoriaTextBox.Size = new Size(353, 27);
            KategoriaTextBox.TabIndex = 32;
            KategoriaTextBox.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 434);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 31;
            label7.Text = "Kategoria:";
            // 
            // KirjaLkmTextBox
            // 
            KirjaLkmTextBox.Location = new Point(479, 389);
            KirjaLkmTextBox.Name = "KirjaLkmTextBox";
            KirjaLkmTextBox.Size = new Size(303, 27);
            KirjaLkmTextBox.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 392);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 29;
            label6.Text = "Kirjojen lukumäärä:";
            // 
            // JulkaisuVuosiTextBox
            // 
            JulkaisuVuosiTextBox.Location = new Point(429, 346);
            JulkaisuVuosiTextBox.Name = "JulkaisuVuosiTextBox";
            JulkaisuVuosiTextBox.Size = new Size(353, 27);
            JulkaisuVuosiTextBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 349);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 27;
            label5.Text = "Julkaisuvuosi:";
            // 
            // KirjoittajaTextBox
            // 
            KirjoittajaTextBox.Location = new Point(429, 118);
            KirjoittajaTextBox.Name = "KirjoittajaTextBox";
            KirjoittajaTextBox.ReadOnly = true;
            KirjoittajaTextBox.Size = new Size(140, 27);
            KirjoittajaTextBox.TabIndex = 26;
            // 
            // KirjanNimiTextBox
            // 
            KirjanNimiTextBox.Location = new Point(429, 83);
            KirjanNimiTextBox.Name = "KirjanNimiTextBox";
            KirjanNimiTextBox.Size = new Size(353, 27);
            KirjanNimiTextBox.TabIndex = 25;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(331, 186);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 151);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 150);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 23;
            label4.Text = "Kirjan kuvaus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 121);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 22;
            label3.Text = "Kirjoittaja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 90);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 21;
            label2.Text = "Kirjan nimi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(69, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 295);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(69, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 46);
            label1.TabIndex = 19;
            label1.Text = "Muokkaa kirjaa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(331, 471);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 37;
            label9.Text = "ISBN:";
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(428, 464);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.ReadOnly = true;
            ISBNTextBox.Size = new Size(353, 27);
            ISBNTextBox.TabIndex = 38;
            // 
            // PoistaKirjaNappi
            // 
            PoistaKirjaNappi.BackColor = Color.Red;
            PoistaKirjaNappi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PoistaKirjaNappi.Location = new Point(69, 497);
            PoistaKirjaNappi.Name = "PoistaKirjaNappi";
            PoistaKirjaNappi.Size = new Size(135, 36);
            PoistaKirjaNappi.TabIndex = 39;
            PoistaKirjaNappi.Text = "Poista kirja";
            PoistaKirjaNappi.UseVisualStyleBackColor = false;
            PoistaKirjaNappi.Click += PoistaKirjaNappi_Click;
            // 
            // KirjoittajaSnimiTextBox
            // 
            KirjoittajaSnimiTextBox.Location = new Point(575, 118);
            KirjoittajaSnimiTextBox.Name = "KirjoittajaSnimiTextBox";
            KirjoittajaSnimiTextBox.ReadOnly = true;
            KirjoittajaSnimiTextBox.Size = new Size(207, 27);
            KirjoittajaSnimiTextBox.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 508);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 41;
            label8.Text = "Sivumäärä:";
            // 
            // Kategoriat
            // 
            Kategoriat.FormattingEnabled = true;
            Kategoriat.Location = new Point(429, 426);
            Kategoriat.Name = "Kategoriat";
            Kategoriat.Size = new Size(353, 28);
            Kategoriat.TabIndex = 42;
            // 
            // SivumaaraTextBox
            // 
            SivumaaraTextBox.Location = new Point(428, 505);
            SivumaaraTextBox.Name = "SivumaaraTextBox";
            SivumaaraTextBox.Size = new Size(353, 27);
            SivumaaraTextBox.TabIndex = 43;
            // 
            // muokkaa_kirja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 637);
            Controls.Add(SivumaaraTextBox);
            Controls.Add(Kategoriat);
            Controls.Add(label8);
            Controls.Add(KirjoittajaSnimiTextBox);
            Controls.Add(PoistaKirjaNappi);
            Controls.Add(ISBNTextBox);
            Controls.Add(label9);
            Controls.Add(SuljeNappi);
            Controls.Add(TallennaNappi);
            Controls.Add(KategoriaTextBox);
            Controls.Add(label7);
            Controls.Add(KirjaLkmTextBox);
            Controls.Add(label6);
            Controls.Add(JulkaisuVuosiTextBox);
            Controls.Add(label5);
            Controls.Add(KirjoittajaTextBox);
            Controls.Add(KirjanNimiTextBox);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "muokkaa_kirja";
            Text = "muokkaa_kirja";
            Load += muokkaa_kirja_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SuljeNappi;
        private Button TallennaNappi;
        private TextBox KategoriaTextBox;
        private Label label7;
        private TextBox KirjaLkmTextBox;
        private Label label6;
        private TextBox JulkaisuVuosiTextBox;
        private Label label5;
        private TextBox KirjoittajaTextBox;
        private TextBox KirjanNimiTextBox;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private TextBox ISBNTextBox;
        private Button PoistaKirjaNappi;
        private TextBox KirjoittajaSnimiTextBox;
        private Label label8;
        private ComboBox Kategoriat;
        private TextBox SivumaaraTextBox;
    }
}