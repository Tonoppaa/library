namespace kirjasto_käyttöliittymä_versio2
{
    partial class uusi_asiakas
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
            asPuhelin = new TextBox();
            label9 = new Label();
            asKaupunki = new TextBox();
            label8 = new Label();
            asPostinumero = new TextBox();
            label7 = new Label();
            asOsoite = new TextBox();
            label6 = new Label();
            asSukunimi = new TextBox();
            label5 = new Label();
            asEtunimi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            LisaaAsiakas = new Button();
            SuljeIkkuna = new Button();
            SuspendLayout();
            // 
            // asPuhelin
            // 
            asPuhelin.Location = new Point(172, 372);
            asPuhelin.Name = "asPuhelin";
            asPuhelin.Size = new Size(308, 27);
            asPuhelin.TabIndex = 145;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 375);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 144;
            label9.Text = "Puhelin";
            // 
            // asKaupunki
            // 
            asKaupunki.Location = new Point(172, 318);
            asKaupunki.Name = "asKaupunki";
            asKaupunki.Size = new Size(308, 27);
            asKaupunki.TabIndex = 143;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 321);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 142;
            label8.Text = "Kaupunki";
            // 
            // asPostinumero
            // 
            asPostinumero.Location = new Point(172, 263);
            asPostinumero.Name = "asPostinumero";
            asPostinumero.Size = new Size(308, 27);
            asPostinumero.TabIndex = 141;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 266);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 140;
            label7.Text = "Postinumero";
            // 
            // asOsoite
            // 
            asOsoite.Location = new Point(172, 207);
            asOsoite.Name = "asOsoite";
            asOsoite.Size = new Size(308, 27);
            asOsoite.TabIndex = 139;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 210);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 138;
            label6.Text = "Osoite";
            // 
            // asSukunimi
            // 
            asSukunimi.Location = new Point(172, 152);
            asSukunimi.Name = "asSukunimi";
            asSukunimi.Size = new Size(308, 27);
            asSukunimi.TabIndex = 137;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 155);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 136;
            label5.Text = "Sukunimi";
            // 
            // asEtunimi
            // 
            asEtunimi.Location = new Point(172, 101);
            asEtunimi.Name = "asEtunimi";
            asEtunimi.Size = new Size(308, 27);
            asEtunimi.TabIndex = 135;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 104);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 134;
            label4.Text = "Etunimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(52, 40);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 133;
            label3.Text = "Lisää uusi asiakas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 428);
            label1.Name = "label1";
            label1.Size = new Size(533, 20);
            label1.TabIndex = 146;
            label1.Text = "Lainaajatunnus generoidaan automaattisesti, kun asiakas lisätään järjestelmään.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 463);
            label2.Name = "label2";
            label2.Size = new Size(240, 20);
            label2.TabIndex = 147;
            label2.Text = "Oletussalasana asiakkaalle on 1234";
            // 
            // LisaaAsiakas
            // 
            LisaaAsiakas.BackColor = Color.Lime;
            LisaaAsiakas.Location = new Point(52, 503);
            LisaaAsiakas.Name = "LisaaAsiakas";
            LisaaAsiakas.Size = new Size(94, 29);
            LisaaAsiakas.TabIndex = 148;
            LisaaAsiakas.Text = "Lisää";
            LisaaAsiakas.UseVisualStyleBackColor = false;
            LisaaAsiakas.Click += LisaaAsiakas_Click;
            // 
            // SuljeIkkuna
            // 
            SuljeIkkuna.BackColor = Color.White;
            SuljeIkkuna.Location = new Point(172, 503);
            SuljeIkkuna.Name = "SuljeIkkuna";
            SuljeIkkuna.Size = new Size(94, 29);
            SuljeIkkuna.TabIndex = 149;
            SuljeIkkuna.Text = "Peruuta";
            SuljeIkkuna.UseVisualStyleBackColor = false;
            SuljeIkkuna.Click += SuljeIkkuna_Click;
            // 
            // uusi_asiakas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 623);
            Controls.Add(SuljeIkkuna);
            Controls.Add(LisaaAsiakas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(asPuhelin);
            Controls.Add(label9);
            Controls.Add(asKaupunki);
            Controls.Add(label8);
            Controls.Add(asPostinumero);
            Controls.Add(label7);
            Controls.Add(asOsoite);
            Controls.Add(label6);
            Controls.Add(asSukunimi);
            Controls.Add(label5);
            Controls.Add(asEtunimi);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "uusi_asiakas";
            Text = "uusi_asiakas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox asPuhelin;
        private Label label9;
        private TextBox asKaupunki;
        private Label label8;
        private TextBox asPostinumero;
        private Label label7;
        private TextBox asOsoite;
        private Label label6;
        private TextBox asSukunimi;
        private Label label5;
        private TextBox asEtunimi;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button LisaaAsiakas;
        private Button SuljeIkkuna;
    }
}