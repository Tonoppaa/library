namespace kirjasto_käyttöliittymä_versio2
{
    partial class uusiasiakas_tai_uusikirja
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
            AsiakasLisays = new Button();
            KirjaLisays = new Button();
            SuljeNappi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(89, 96);
            label1.Name = "label1";
            label1.Size = new Size(419, 35);
            label1.TabIndex = 0;
            label1.Text = "Kumman haluat lisätä järjestelmään?";
            // 
            // AsiakasLisays
            // 
            AsiakasLisays.Location = new Point(156, 175);
            AsiakasLisays.Name = "AsiakasLisays";
            AsiakasLisays.Size = new Size(94, 29);
            AsiakasLisays.TabIndex = 1;
            AsiakasLisays.Text = "Asiakas";
            AsiakasLisays.UseVisualStyleBackColor = true;
            AsiakasLisays.Click += AsiakasLisays_Click;
            // 
            // KirjaLisays
            // 
            KirjaLisays.Location = new Point(343, 175);
            KirjaLisays.Name = "KirjaLisays";
            KirjaLisays.Size = new Size(94, 29);
            KirjaLisays.TabIndex = 2;
            KirjaLisays.Text = "Kirja";
            KirjaLisays.UseVisualStyleBackColor = true;
            KirjaLisays.Click += KirjaLisays_Click;
            // 
            // SuljeNappi
            // 
            SuljeNappi.Location = new Point(487, 29);
            SuljeNappi.Name = "SuljeNappi";
            SuljeNappi.Size = new Size(94, 29);
            SuljeNappi.TabIndex = 3;
            SuljeNappi.Text = "Peruuta";
            SuljeNappi.UseVisualStyleBackColor = true;
            SuljeNappi.Click += SuljeNappi_Click;
            // 
            // uusiasiakas_tai_uusikirja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 303);
            Controls.Add(SuljeNappi);
            Controls.Add(KirjaLisays);
            Controls.Add(AsiakasLisays);
            Controls.Add(label1);
            Name = "uusiasiakas_tai_uusikirja";
            Text = "uusiasiakas_tai_uusikirja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AsiakasLisays;
        private Button KirjaLisays;
        private Button SuljeNappi;
    }
}