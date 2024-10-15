namespace kirjasto_käyttöliittymä_versio2
{
    partial class kirja2_hkunta
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
            button1 = new Button();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            ISBN = new TextBox();
            label9 = new Label();
            SuljeNappi = new Button();
            Kategoria = new TextBox();
            label7 = new Label();
            KirjaLkm = new TextBox();
            label6 = new Label();
            Julkaisuvuosi = new TextBox();
            label5 = new Label();
            kirjoittajaEtunimi = new TextBox();
            KirjanNimi = new TextBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            kirjoittajaSukunimi = new TextBox();
            MuokkaaNappi = new Button();
            Sivumaara = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(131, 622);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 97;
            button1.Text = "Varaa kirja";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(412, 619);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(357, 27);
            textBox9.TabIndex = 96;
            textBox9.Visible = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(466, 586);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(303, 27);
            textBox8.TabIndex = 95;
            textBox8.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(315, 626);
            label15.Name = "label15";
            label15.Size = new Size(61, 20);
            label15.TabIndex = 94;
            label15.Text = "Asiakas:";
            label15.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(314, 586);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 93;
            label14.Text = "Eräpäivämäärä:";
            label14.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Red;
            label13.Location = new Point(261, 586);
            label13.Name = "label13";
            label13.Size = new Size(21, 20);
            label13.TabIndex = 92;
            label13.Text = "Ei";
            label13.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Lime;
            label12.Location = new Point(185, 586);
            label12.Name = "label12";
            label12.Size = new Size(40, 20);
            label12.TabIndex = 91;
            label12.Text = "Kyllä";
            label12.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 586);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 90;
            label11.Text = "Lainattavissa?";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 545);
            label10.Name = "label10";
            label10.Size = new Size(717, 20);
            label10.TabIndex = 89;
            label10.Text = "______________________________________________________________________________________________________________________";
            // 
            // ISBN
            // 
            ISBN.Location = new Point(412, 465);
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            ISBN.Size = new Size(353, 27);
            ISBN.TabIndex = 88;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(314, 472);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 87;
            label9.Text = "ISBN:";
            // 
            // SuljeNappi
            // 
            SuljeNappi.BackColor = Color.White;
            SuljeNappi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SuljeNappi.Location = new Point(620, 15);
            SuljeNappi.Name = "SuljeNappi";
            SuljeNappi.Size = new Size(145, 36);
            SuljeNappi.TabIndex = 86;
            SuljeNappi.Text = "Palaa";
            SuljeNappi.UseVisualStyleBackColor = false;
            SuljeNappi.Click += SuljeNappi_Click;
            // 
            // Kategoria
            // 
            Kategoria.Location = new Point(412, 421);
            Kategoria.Name = "Kategoria";
            Kategoria.ReadOnly = true;
            Kategoria.Size = new Size(353, 27);
            Kategoria.TabIndex = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(314, 428);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 82;
            label7.Text = "Kategoria:";
            // 
            // KirjaLkm
            // 
            KirjaLkm.Location = new Point(462, 383);
            KirjaLkm.Name = "KirjaLkm";
            KirjaLkm.ReadOnly = true;
            KirjaLkm.Size = new Size(303, 27);
            KirjaLkm.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 386);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 80;
            label6.Text = "Kirjojen lukumäärä:";
            // 
            // Julkaisuvuosi
            // 
            Julkaisuvuosi.Location = new Point(412, 340);
            Julkaisuvuosi.Name = "Julkaisuvuosi";
            Julkaisuvuosi.ReadOnly = true;
            Julkaisuvuosi.Size = new Size(353, 27);
            Julkaisuvuosi.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 343);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 78;
            label5.Text = "Julkaisuvuosi:";
            // 
            // kirjoittajaEtunimi
            // 
            kirjoittajaEtunimi.Location = new Point(412, 112);
            kirjoittajaEtunimi.Name = "kirjoittajaEtunimi";
            kirjoittajaEtunimi.ReadOnly = true;
            kirjoittajaEtunimi.Size = new Size(159, 27);
            kirjoittajaEtunimi.TabIndex = 77;
            // 
            // KirjanNimi
            // 
            KirjanNimi.Location = new Point(412, 77);
            KirjanNimi.Name = "KirjanNimi";
            KirjanNimi.ReadOnly = true;
            KirjanNimi.Size = new Size(353, 27);
            KirjanNimi.TabIndex = 76;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(314, 180);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(451, 151);
            richTextBox1.TabIndex = 75;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 144);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 74;
            label4.Text = "Kirjan kuvaus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 115);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 73;
            label3.Text = "Kirjoittaja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 84);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 72;
            label2.Text = "Kirjan nimi:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 295);
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(52, 6);
            label1.Name = "label1";
            label1.Size = new Size(203, 46);
            label1.TabIndex = 70;
            label1.Text = "Kirjan tiedot";
            // 
            // kirjoittajaSukunimi
            // 
            kirjoittajaSukunimi.Location = new Point(577, 112);
            kirjoittajaSukunimi.Name = "kirjoittajaSukunimi";
            kirjoittajaSukunimi.ReadOnly = true;
            kirjoittajaSukunimi.Size = new Size(188, 27);
            kirjoittajaSukunimi.TabIndex = 98;
            // 
            // MuokkaaNappi
            // 
            MuokkaaNappi.Location = new Point(97, 424);
            MuokkaaNappi.Name = "MuokkaaNappi";
            MuokkaaNappi.Size = new Size(128, 29);
            MuokkaaNappi.TabIndex = 99;
            MuokkaaNappi.Text = "Muokkaa kirjaa";
            MuokkaaNappi.UseVisualStyleBackColor = true;
            MuokkaaNappi.Click += MuokkaaNappi_Click;
            // 
            // Sivumaara
            // 
            Sivumaara.Location = new Point(412, 515);
            Sivumaara.Name = "Sivumaara";
            Sivumaara.ReadOnly = true;
            Sivumaara.Size = new Size(353, 27);
            Sivumaara.TabIndex = 100;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(315, 522);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 101;
            label8.Text = "Sivumäärä:";
            // 
            // kirja2_hkunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 671);
            Controls.Add(label8);
            Controls.Add(Sivumaara);
            Controls.Add(MuokkaaNappi);
            Controls.Add(kirjoittajaSukunimi);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(ISBN);
            Controls.Add(label9);
            Controls.Add(SuljeNappi);
            Controls.Add(Kategoria);
            Controls.Add(label7);
            Controls.Add(KirjaLkm);
            Controls.Add(label6);
            Controls.Add(Julkaisuvuosi);
            Controls.Add(label5);
            Controls.Add(kirjoittajaEtunimi);
            Controls.Add(KirjanNimi);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "kirja2_hkunta";
            Text = "kirja2_hkunta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox ISBN;
        private Label label9;
        private Button SuljeNappi;
        private TextBox Kategoria;
        private Label label7;
        private TextBox KirjaLkm;
        private Label label6;
        private TextBox Julkaisuvuosi;
        private Label label5;
        private TextBox kirjoittajaEtunimi;
        private TextBox KirjanNimi;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox kirjoittajaSukunimi;
        private Button MuokkaaNappi;
        private TextBox Sivumaara;
        private Label label8;
    }
}