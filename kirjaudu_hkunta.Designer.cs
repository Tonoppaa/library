namespace kirjasto_käyttöliittymä_versio2
{
    partial class kirjaudu_hkunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kirjaudu_hkunta));
            OtaYhteytta = new Button();
            KirjauduSisaan = new Button();
            salasanatextbox = new TextBox();
            kayttajatextbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuljeOhjelmaNappi = new Button();
            SuspendLayout();
            // 
            // OtaYhteytta
            // 
            OtaYhteytta.Location = new Point(695, 35);
            OtaYhteytta.Name = "OtaYhteytta";
            OtaYhteytta.Size = new Size(135, 29);
            OtaYhteytta.TabIndex = 17;
            OtaYhteytta.Text = "Ota yhteyttä";
            OtaYhteytta.UseVisualStyleBackColor = true;
            OtaYhteytta.Click += OtaYhteytta_Click;
            // 
            // KirjauduSisaan
            // 
            KirjauduSisaan.Font = new Font("Segoe UI", 13F);
            KirjauduSisaan.Location = new Point(383, 275);
            KirjauduSisaan.Name = "KirjauduSisaan";
            KirjauduSisaan.Size = new Size(140, 60);
            KirjauduSisaan.TabIndex = 16;
            KirjauduSisaan.Text = "Kirjaudu";
            KirjauduSisaan.UseVisualStyleBackColor = true;
            KirjauduSisaan.Click += KirjauduSisaan_Click;
            // 
            // salasanatextbox
            // 
            salasanatextbox.Location = new Point(244, 217);
            salasanatextbox.Name = "salasanatextbox";
            salasanatextbox.PasswordChar = '*';
            salasanatextbox.Size = new Size(447, 27);
            salasanatextbox.TabIndex = 15;
            salasanatextbox.Text = "1234";
            // 
            // kayttajatextbox
            // 
            kayttajatextbox.Location = new Point(244, 147);
            kayttajatextbox.Name = "kayttajatextbox";
            kayttajatextbox.Size = new Size(447, 27);
            kayttajatextbox.TabIndex = 14;
            kayttajatextbox.Text = "TT00124";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(24, 208);
            label4.Name = "label4";
            label4.Size = new Size(111, 35);
            label4.TabIndex = 13;
            label4.Text = "Salasana";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(24, 139);
            label3.Name = "label3";
            label3.Size = new Size(178, 35);
            label3.TabIndex = 12;
            label3.Text = "Käyttäjätunnus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(285, 97);
            label2.Name = "label2";
            label2.Size = new Size(346, 35);
            label2.TabIndex = 11;
            label2.Text = "Kirjaudu sisään (henkilökunta)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(372, 35);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 10;
            label1.Text = "Kirjasto X";
            // 
            // SuljeOhjelmaNappi
            // 
            SuljeOhjelmaNappi.Location = new Point(695, 70);
            SuljeOhjelmaNappi.Name = "SuljeOhjelmaNappi";
            SuljeOhjelmaNappi.Size = new Size(135, 29);
            SuljeOhjelmaNappi.TabIndex = 18;
            SuljeOhjelmaNappi.Text = "Sulje ohjelma";
            SuljeOhjelmaNappi.UseVisualStyleBackColor = true;
            SuljeOhjelmaNappi.Click += SuljeOhjelmaNappi_Click;
            // 
            // kirjaudu_hkunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(862, 460);
            Controls.Add(SuljeOhjelmaNappi);
            Controls.Add(OtaYhteytta);
            Controls.Add(KirjauduSisaan);
            Controls.Add(salasanatextbox);
            Controls.Add(kayttajatextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "kirjaudu_hkunta";
            Text = "kirjaudu_hkunta";
            Load += kirjaudu_hkunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OtaYhteytta;
        private Button KirjauduSisaan;
        private TextBox salasanatextbox;
        private TextBox kayttajatextbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button SuljeOhjelmaNappi;
    }
}