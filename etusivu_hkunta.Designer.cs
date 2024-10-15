namespace kirjasto_käyttöliittymä_versio2
{
    partial class etusivu_hkunta
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
            label5 = new Label();
            label3 = new Label();
            Hkunta_KirjauduUlos = new Button();
            Hkunta_Otayhteytta = new Button();
            label1 = new Label();
            Hkunta_LisaaJarj = new Button();
            Hkunta_omasivu = new Button();
            Hkunta_tarkkahaku = new Button();
            Hkunta_aineistot = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            Hkunta_nimi = new TextBox();
            ViimeisinKirjautuminen = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(230, 257);
            label5.Name = "label5";
            label5.Size = new Size(288, 35);
            label5.TabIndex = 35;
            label5.Text = "kirjauduit viimeksi sisään";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(29, 253);
            label3.Name = "label3";
            label3.Size = new Size(57, 35);
            label3.TabIndex = 33;
            label3.Text = "Hei,";
            // 
            // Hkunta_KirjauduUlos
            // 
            Hkunta_KirjauduUlos.Location = new Point(658, 137);
            Hkunta_KirjauduUlos.Name = "Hkunta_KirjauduUlos";
            Hkunta_KirjauduUlos.Size = new Size(135, 29);
            Hkunta_KirjauduUlos.TabIndex = 32;
            Hkunta_KirjauduUlos.Text = "Kirjaudu ulos";
            Hkunta_KirjauduUlos.UseVisualStyleBackColor = true;
            Hkunta_KirjauduUlos.Click += Hkunta_KirjauduUlos_Click;
            // 
            // Hkunta_Otayhteytta
            // 
            Hkunta_Otayhteytta.Location = new Point(658, 102);
            Hkunta_Otayhteytta.Name = "Hkunta_Otayhteytta";
            Hkunta_Otayhteytta.Size = new Size(135, 29);
            Hkunta_Otayhteytta.TabIndex = 31;
            Hkunta_Otayhteytta.Text = "Ota yhteyttä";
            Hkunta_Otayhteytta.UseVisualStyleBackColor = true;
            Hkunta_Otayhteytta.Click += Hkunta_Otayhteytta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(29, 87);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 27;
            label1.Text = "Kirjasto X";
            // 
            // Hkunta_LisaaJarj
            // 
            Hkunta_LisaaJarj.BackColor = Color.Lime;
            Hkunta_LisaaJarj.Font = new Font("Segoe UI", 12F);
            Hkunta_LisaaJarj.Location = new Point(463, 190);
            Hkunta_LisaaJarj.Name = "Hkunta_LisaaJarj";
            Hkunta_LisaaJarj.Size = new Size(182, 42);
            Hkunta_LisaaJarj.TabIndex = 26;
            Hkunta_LisaaJarj.Text = "Lisää järjestelmään";
            Hkunta_LisaaJarj.UseVisualStyleBackColor = false;
            Hkunta_LisaaJarj.Click += Hkunta_LisaaJarj_Click;
            // 
            // Hkunta_omasivu
            // 
            Hkunta_omasivu.Font = new Font("Segoe UI", 12F);
            Hkunta_omasivu.Location = new Point(356, 190);
            Hkunta_omasivu.Name = "Hkunta_omasivu";
            Hkunta_omasivu.Size = new Size(101, 42);
            Hkunta_omasivu.TabIndex = 25;
            Hkunta_omasivu.Text = "Oma sivu";
            Hkunta_omasivu.UseVisualStyleBackColor = true;
            Hkunta_omasivu.Click += Hkunta_omasivu_Click;
            // 
            // Hkunta_tarkkahaku
            // 
            Hkunta_tarkkahaku.Font = new Font("Segoe UI", 12F);
            Hkunta_tarkkahaku.Location = new Point(224, 190);
            Hkunta_tarkkahaku.Name = "Hkunta_tarkkahaku";
            Hkunta_tarkkahaku.Size = new Size(132, 42);
            Hkunta_tarkkahaku.TabIndex = 24;
            Hkunta_tarkkahaku.Text = "Tarkka haku";
            Hkunta_tarkkahaku.UseVisualStyleBackColor = true;
            Hkunta_tarkkahaku.Click += Hkunta_tarkkahaku_Click;
            // 
            // Hkunta_aineistot
            // 
            Hkunta_aineistot.Font = new Font("Segoe UI", 12F);
            Hkunta_aineistot.Location = new Point(124, 190);
            Hkunta_aineistot.Name = "Hkunta_aineistot";
            Hkunta_aineistot.Size = new Size(100, 42);
            Hkunta_aineistot.TabIndex = 23;
            Hkunta_aineistot.Text = "Aineistot";
            Hkunta_aineistot.UseVisualStyleBackColor = true;
            Hkunta_aineistot.Click += Hkunta_aineistot_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(29, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 22;
            button1.Text = "Etusivu";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 372);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 27);
            dateTimePicker1.TabIndex = 45;
            // 
            // Hkunta_nimi
            // 
            Hkunta_nimi.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Hkunta_nimi.Location = new Point(92, 250);
            Hkunta_nimi.Name = "Hkunta_nimi";
            Hkunta_nimi.ReadOnly = true;
            Hkunta_nimi.Size = new Size(132, 41);
            Hkunta_nimi.TabIndex = 46;
            Hkunta_nimi.TextAlign = HorizontalAlignment.Center;
            // 
            // ViimeisinKirjautuminen
            // 
            ViimeisinKirjautuminen.Location = new Point(546, 261);
            ViimeisinKirjautuminen.Name = "ViimeisinKirjautuminen";
            ViimeisinKirjautuminen.ReadOnly = true;
            ViimeisinKirjautuminen.Size = new Size(172, 27);
            ViimeisinKirjautuminen.TabIndex = 47;
            ViimeisinKirjautuminen.TextAlign = HorizontalAlignment.Center;
            ViimeisinKirjautuminen.TextChanged += ViimeisinKirjautuminen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(29, 321);
            label2.Name = "label2";
            label2.Size = new Size(134, 35);
            label2.TabIndex = 48;
            label2.Text = "Tänään on:";
            // 
            // etusivu_hkunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 532);
            Controls.Add(label2);
            Controls.Add(ViimeisinKirjautuminen);
            Controls.Add(Hkunta_nimi);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(Hkunta_KirjauduUlos);
            Controls.Add(Hkunta_Otayhteytta);
            Controls.Add(label1);
            Controls.Add(Hkunta_LisaaJarj);
            Controls.Add(Hkunta_omasivu);
            Controls.Add(Hkunta_tarkkahaku);
            Controls.Add(Hkunta_aineistot);
            Controls.Add(button1);
            Name = "etusivu_hkunta";
            Text = "etusivu_hkunta";
            Load += etusivu_hkunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Button Hkunta_KirjauduUlos;
        private Button Hkunta_Otayhteytta;
        private Label label1;
        private Button Hkunta_LisaaJarj;
        private Button Hkunta_omasivu;
        private Button Hkunta_tarkkahaku;
        private Button Hkunta_aineistot;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox Hkunta_nimi;
        private TextBox ViimeisinKirjautuminen;
        private Label label2;
    }
}