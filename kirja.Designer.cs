namespace kirjasto_käyttöliittymä_versio2
{
    partial class kirja
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
            KirjanKuva = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            LainaNappi = new Button();
            KirjanNimiTextBox = new TextBox();
            KirjoittajaTextBox = new TextBox();
            ISBNTextBox = new TextBox();
            KirjaLkmTextBox = new TextBox();
            JulkaisuVuosiTextBox = new TextBox();
            KategoriaTextBox = new TextBox();
            KirjoittajaSnimiTextBox = new TextBox();
            EiNappi = new Button();
            SuljeNappi = new Button();
            ((System.ComponentModel.ISupportInitialize)KirjanKuva).BeginInit();
            SuspendLayout();
            // 
            // KirjanKuva
            // 
            KirjanKuva.Location = new Point(43, 24);
            KirjanKuva.Name = "KirjanKuva";
            KirjanKuva.Size = new Size(289, 461);
            KirjanKuva.TabIndex = 0;
            KirjanKuva.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(338, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 1;
            label1.Text = "Kirjan nimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(338, 63);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Kirjoittaja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(338, 101);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 3;
            label3.Text = "Kirjan kuvaus:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(338, 132);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(417, 120);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(338, 307);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 5;
            label4.Text = "Teoksia kirjastossa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(338, 425);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 7;
            label6.Text = "Lainattavissa?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(338, 269);
            label9.Name = "label9";
            label9.Size = new Size(58, 28);
            label9.TabIndex = 10;
            label9.Text = "ISBN:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(338, 341);
            label11.Name = "label11";
            label11.Size = new Size(129, 28);
            label11.TabIndex = 12;
            label11.Text = "Julkaisuvuosi:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(338, 378);
            label13.Name = "label13";
            label13.Size = new Size(101, 28);
            label13.TabIndex = 14;
            label13.Text = "Kategoria:";
            // 
            // LainaNappi
            // 
            LainaNappi.BackColor = Color.Lime;
            LainaNappi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LainaNappi.Location = new Point(539, 427);
            LainaNappi.Name = "LainaNappi";
            LainaNappi.Size = new Size(129, 29);
            LainaNappi.TabIndex = 16;
            LainaNappi.Text = "Kyllä (varaa)";
            LainaNappi.UseVisualStyleBackColor = false;
            LainaNappi.Click += LainaNappi_Click;
            // 
            // KirjanNimiTextBox
            // 
            KirjanNimiTextBox.Location = new Point(475, 24);
            KirjanNimiTextBox.Name = "KirjanNimiTextBox";
            KirjanNimiTextBox.ReadOnly = true;
            KirjanNimiTextBox.Size = new Size(280, 27);
            KirjanNimiTextBox.TabIndex = 18;
            KirjanNimiTextBox.TextChanged += KirjanNimiTextBox_TextChanged;
            // 
            // KirjoittajaTextBox
            // 
            KirjoittajaTextBox.Location = new Point(475, 63);
            KirjoittajaTextBox.Name = "KirjoittajaTextBox";
            KirjoittajaTextBox.ReadOnly = true;
            KirjoittajaTextBox.Size = new Size(119, 27);
            KirjoittajaTextBox.TabIndex = 19;
            KirjoittajaTextBox.TextChanged += KirjoittajaTextBox_TextChanged;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(475, 270);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.ReadOnly = true;
            ISBNTextBox.Size = new Size(280, 27);
            ISBNTextBox.TabIndex = 20;
            ISBNTextBox.TextChanged += ISBNTextBox_TextChanged;
            // 
            // KirjaLkmTextBox
            // 
            KirjaLkmTextBox.Location = new Point(539, 307);
            KirjaLkmTextBox.Name = "KirjaLkmTextBox";
            KirjaLkmTextBox.ReadOnly = true;
            KirjaLkmTextBox.Size = new Size(216, 27);
            KirjaLkmTextBox.TabIndex = 21;
            KirjaLkmTextBox.TextChanged += KirjaLkmTextBox_TextChanged;
            // 
            // JulkaisuVuosiTextBox
            // 
            JulkaisuVuosiTextBox.Location = new Point(539, 345);
            JulkaisuVuosiTextBox.Name = "JulkaisuVuosiTextBox";
            JulkaisuVuosiTextBox.ReadOnly = true;
            JulkaisuVuosiTextBox.Size = new Size(216, 27);
            JulkaisuVuosiTextBox.TabIndex = 22;
            JulkaisuVuosiTextBox.TextChanged += JulkaisuVuosiTextBox_TextChanged;
            // 
            // KategoriaTextBox
            // 
            KategoriaTextBox.Location = new Point(539, 382);
            KategoriaTextBox.Name = "KategoriaTextBox";
            KategoriaTextBox.ReadOnly = true;
            KategoriaTextBox.Size = new Size(216, 27);
            KategoriaTextBox.TabIndex = 23;
            KategoriaTextBox.TextChanged += KategoriaTextBox_TextChanged;
            // 
            // KirjoittajaSnimiTextBox
            // 
            KirjoittajaSnimiTextBox.Location = new Point(594, 63);
            KirjoittajaSnimiTextBox.Name = "KirjoittajaSnimiTextBox";
            KirjoittajaSnimiTextBox.ReadOnly = true;
            KirjoittajaSnimiTextBox.Size = new Size(161, 27);
            KirjoittajaSnimiTextBox.TabIndex = 24;
            KirjoittajaSnimiTextBox.TextChanged += KirjoittajaSnimiTextBox_TextChanged;
            // 
            // EiNappi
            // 
            EiNappi.BackColor = Color.Red;
            EiNappi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EiNappi.Location = new Point(539, 462);
            EiNappi.Name = "EiNappi";
            EiNappi.Size = new Size(129, 29);
            EiNappi.TabIndex = 25;
            EiNappi.Text = "Ei";
            EiNappi.UseVisualStyleBackColor = false;
            // 
            // SuljeNappi
            // 
            SuljeNappi.Location = new Point(685, 428);
            SuljeNappi.Name = "SuljeNappi";
            SuljeNappi.Size = new Size(94, 29);
            SuljeNappi.TabIndex = 26;
            SuljeNappi.Text = "Sulje";
            SuljeNappi.UseVisualStyleBackColor = true;
            SuljeNappi.Click += SuljeNappi_Click;
            // 
            // kirja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 525);
            Controls.Add(SuljeNappi);
            Controls.Add(EiNappi);
            Controls.Add(KirjoittajaSnimiTextBox);
            Controls.Add(KategoriaTextBox);
            Controls.Add(JulkaisuVuosiTextBox);
            Controls.Add(KirjaLkmTextBox);
            Controls.Add(ISBNTextBox);
            Controls.Add(KirjoittajaTextBox);
            Controls.Add(KirjanNimiTextBox);
            Controls.Add(LainaNappi);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KirjanKuva);
            Name = "kirja";
            Text = "kirja";
            ((System.ComponentModel.ISupportInitialize)KirjanKuva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox KirjanKuva;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label6;
        private Label label9;
        private Label label11;
        private Label label13;
        private Button LainaNappi;
        private TextBox KirjanNimiTextBox;
        private TextBox KirjoittajaTextBox;
        private TextBox ISBNTextBox;
        private TextBox KirjaLkmTextBox;
        private TextBox JulkaisuVuosiTextBox;
        private TextBox KategoriaTextBox;
        private TextBox KirjoittajaSnimiTextBox;
        private Button EiNappi;
        private Button SuljeNappi;
    }
}