namespace kirjasto_käyttöliittymä_versio2
{
    partial class asiakas_etusivu2
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
            label10 = new Label();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            KirjauduUlos = new Button();
            OtaYhteytta = new Button();
            HaeNappi = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            OmatTiedot = new Button();
            OmatLainat = new Button();
            Aineistot = new Button();
            Etusivu = new Button();
            kayttajanNimi = new TextBox();
            ViimeisinKirjautuminen = new TextBox();
            LainatutKirjatKpl = new TextBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(397, 308);
            label10.Name = "label10";
            label10.Size = new Size(127, 35);
            label10.TabIndex = 40;
            label10.Text = "kpl kirjoja.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(40, 309);
            label8.Name = "label8";
            label8.Size = new Size(217, 35);
            label8.TabIndex = 38;
            label8.Text = "Sinulla on lainassa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(260, 245);
            label5.Name = "label5";
            label5.Size = new Size(288, 35);
            label5.TabIndex = 35;
            label5.Text = "kirjauduit viimeksi sisään";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(40, 245);
            label3.Name = "label3";
            label3.Size = new Size(57, 35);
            label3.TabIndex = 33;
            label3.Text = "Hei,";
            // 
            // KirjauduUlos
            // 
            KirjauduUlos.Font = new Font("Segoe UI", 9F);
            KirjauduUlos.Location = new Point(748, 129);
            KirjauduUlos.Name = "KirjauduUlos";
            KirjauduUlos.Size = new Size(152, 29);
            KirjauduUlos.TabIndex = 32;
            KirjauduUlos.Text = "Kirjaudu ulos";
            KirjauduUlos.UseVisualStyleBackColor = true;
            KirjauduUlos.Click += KirjauduUlos_Click;
            // 
            // OtaYhteytta
            // 
            OtaYhteytta.Font = new Font("Segoe UI", 9F);
            OtaYhteytta.Location = new Point(748, 94);
            OtaYhteytta.Name = "OtaYhteytta";
            OtaYhteytta.Size = new Size(152, 29);
            OtaYhteytta.TabIndex = 31;
            OtaYhteytta.Text = "Ota yhteyttä";
            OtaYhteytta.UseVisualStyleBackColor = true;
            OtaYhteytta.Click += OtaYhteytta_Click;
            // 
            // HaeNappi
            // 
            HaeNappi.BackColor = Color.Lime;
            HaeNappi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HaeNappi.Location = new Point(623, 94);
            HaeNappi.Name = "HaeNappi";
            HaeNappi.Size = new Size(39, 29);
            HaeNappi.TabIndex = 30;
            HaeNappi.Text = "->";
            HaeNappi.UseVisualStyleBackColor = false;
            HaeNappi.Click += HaeNappi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(266, 73);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 29;
            label2.Text = "Hakukenttä";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(40, 79);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 27;
            label1.Text = "Kirjasto X";
            // 
            // OmatTiedot
            // 
            OmatTiedot.Font = new Font("Segoe UI", 12F);
            OmatTiedot.Location = new Point(415, 163);
            OmatTiedot.Name = "OmatTiedot";
            OmatTiedot.Size = new Size(146, 42);
            OmatTiedot.TabIndex = 26;
            OmatTiedot.Text = "Omat tiedot";
            OmatTiedot.UseVisualStyleBackColor = true;
            OmatTiedot.Click += OmatTiedot_Click;
            // 
            // OmatLainat
            // 
            OmatLainat.Font = new Font("Segoe UI", 12F);
            OmatLainat.Location = new Point(266, 163);
            OmatLainat.Name = "OmatLainat";
            OmatLainat.Size = new Size(143, 42);
            OmatLainat.TabIndex = 25;
            OmatLainat.Text = "Omat lainat";
            OmatLainat.UseVisualStyleBackColor = true;
            OmatLainat.Click += OmatLainat_Click;
            // 
            // Aineistot
            // 
            Aineistot.Font = new Font("Segoe UI", 12F);
            Aineistot.Location = new Point(147, 163);
            Aineistot.Name = "Aineistot";
            Aineistot.Size = new Size(112, 42);
            Aineistot.TabIndex = 23;
            Aineistot.Text = "Aineistot";
            Aineistot.UseVisualStyleBackColor = true;
            Aineistot.Click += Aineistot_Click;
            // 
            // Etusivu
            // 
            Etusivu.BackColor = SystemColors.ActiveCaption;
            Etusivu.Font = new Font("Segoe UI", 12F);
            Etusivu.Location = new Point(40, 163);
            Etusivu.Name = "Etusivu";
            Etusivu.Size = new Size(106, 42);
            Etusivu.TabIndex = 22;
            Etusivu.Text = "Etusivu";
            Etusivu.UseVisualStyleBackColor = false;
            // 
            // kayttajanNimi
            // 
            kayttajanNimi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kayttajanNimi.Location = new Point(103, 244);
            kayttajanNimi.Name = "kayttajanNimi";
            kayttajanNimi.ReadOnly = true;
            kayttajanNimi.Size = new Size(140, 34);
            kayttajanNimi.TabIndex = 41;
            kayttajanNimi.TextAlign = HorizontalAlignment.Center;
            kayttajanNimi.TextChanged += kayttajanNimi_TextChanged;
            // 
            // ViimeisinKirjautuminen
            // 
            ViimeisinKirjautuminen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ViimeisinKirjautuminen.Location = new Point(554, 244);
            ViimeisinKirjautuminen.Name = "ViimeisinKirjautuminen";
            ViimeisinKirjautuminen.ReadOnly = true;
            ViimeisinKirjautuminen.Size = new Size(258, 34);
            ViimeisinKirjautuminen.TabIndex = 48;
            ViimeisinKirjautuminen.TextAlign = HorizontalAlignment.Center;
            // 
            // LainatutKirjatKpl
            // 
            LainatutKirjatKpl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LainatutKirjatKpl.Location = new Point(263, 311);
            LainatutKirjatKpl.Name = "LainatutKirjatKpl";
            LainatutKirjatKpl.ReadOnly = true;
            LainatutKirjatKpl.Size = new Size(125, 34);
            LainatutKirjatKpl.TabIndex = 49;
            LainatutKirjatKpl.TextAlign = HorizontalAlignment.Center;
            // 
            // asiakas_etusivu2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 504);
            Controls.Add(LainatutKirjatKpl);
            Controls.Add(ViimeisinKirjautuminen);
            Controls.Add(kayttajanNimi);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(KirjauduUlos);
            Controls.Add(OtaYhteytta);
            Controls.Add(HaeNappi);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(OmatTiedot);
            Controls.Add(OmatLainat);
            Controls.Add(Aineistot);
            Controls.Add(Etusivu);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "asiakas_etusivu2";
            Text = "asiakas_etusivu2";
            Load += Asiakkaan_Tiedot_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label8;
        private Label label5;
        private Label label3;
        private Button KirjauduUlos;
        private Button OtaYhteytta;
        private Button HaeNappi;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button OmatTiedot;
        private Button OmatLainat;
        private Button Aineistot;
        private Button Etusivu;
        private TextBox kayttajanNimi;
        private TextBox ViimeisinKirjautuminen;
        private TextBox LainatutKirjatKpl;
    }
}