namespace kirjasto_käyttöliittymä_versio2
{
    partial class vahvista_kirjapoisto
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
            KyllaNappi = new Button();
            PeruutaNappi = new Button();
            KirjoittajaSnimiTextBox = new TextBox();
            KirjoittajaTextBox = new TextBox();
            KirjanNimiTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ISBNTextBox = new TextBox();
            label9 = new Label();
            KategoriaTextBox = new TextBox();
            label7 = new Label();
            KirjaLkmTextBox = new TextBox();
            label6 = new Label();
            JulkaisuVuosiTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(459, 35);
            label1.TabIndex = 0;
            label1.Text = "Oletko varma, että haluat poistaa kirjan?";
            // 
            // KyllaNappi
            // 
            KyllaNappi.Location = new Point(113, 112);
            KyllaNappi.Name = "KyllaNappi";
            KyllaNappi.Size = new Size(94, 29);
            KyllaNappi.TabIndex = 1;
            KyllaNappi.Text = "Kyllä";
            KyllaNappi.UseVisualStyleBackColor = true;
            KyllaNappi.Click += KyllaNappi_Click;
            // 
            // PeruutaNappi
            // 
            PeruutaNappi.Location = new Point(306, 112);
            PeruutaNappi.Name = "PeruutaNappi";
            PeruutaNappi.Size = new Size(94, 29);
            PeruutaNappi.TabIndex = 2;
            PeruutaNappi.Text = "Peruuta";
            PeruutaNappi.UseVisualStyleBackColor = true;
            PeruutaNappi.Click += PeruutaNappi_Click;
            // 
            // KirjoittajaSnimiTextBox
            // 
            KirjoittajaSnimiTextBox.Location = new Point(275, 201);
            KirjoittajaSnimiTextBox.Name = "KirjoittajaSnimiTextBox";
            KirjoittajaSnimiTextBox.Size = new Size(207, 27);
            KirjoittajaSnimiTextBox.TabIndex = 45;
            KirjoittajaSnimiTextBox.Visible = false;
            // 
            // KirjoittajaTextBox
            // 
            KirjoittajaTextBox.Location = new Point(129, 201);
            KirjoittajaTextBox.Name = "KirjoittajaTextBox";
            KirjoittajaTextBox.Size = new Size(140, 27);
            KirjoittajaTextBox.TabIndex = 44;
            KirjoittajaTextBox.Visible = false;
            // 
            // KirjanNimiTextBox
            // 
            KirjanNimiTextBox.Location = new Point(129, 166);
            KirjanNimiTextBox.Name = "KirjanNimiTextBox";
            KirjanNimiTextBox.Size = new Size(353, 27);
            KirjanNimiTextBox.TabIndex = 43;
            KirjanNimiTextBox.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 204);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 42;
            label3.Text = "Kirjoittaja:";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 173);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 41;
            label2.Text = "Kirjan nimi:";
            label2.Visible = false;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(128, 361);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(353, 27);
            ISBNTextBox.TabIndex = 53;
            ISBNTextBox.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 368);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 52;
            label9.Text = "ISBN:";
            label9.Visible = false;
            // 
            // KategoriaTextBox
            // 
            KategoriaTextBox.Location = new Point(129, 324);
            KategoriaTextBox.Name = "KategoriaTextBox";
            KategoriaTextBox.Size = new Size(353, 27);
            KategoriaTextBox.TabIndex = 51;
            KategoriaTextBox.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 331);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 50;
            label7.Text = "Kategoria:";
            label7.Visible = false;
            // 
            // KirjaLkmTextBox
            // 
            KirjaLkmTextBox.Location = new Point(179, 286);
            KirjaLkmTextBox.Name = "KirjaLkmTextBox";
            KirjaLkmTextBox.Size = new Size(303, 27);
            KirjaLkmTextBox.TabIndex = 49;
            KirjaLkmTextBox.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 289);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 48;
            label6.Text = "Teoksien lukumäärä:";
            label6.Visible = false;
            // 
            // JulkaisuVuosiTextBox
            // 
            JulkaisuVuosiTextBox.Location = new Point(129, 243);
            JulkaisuVuosiTextBox.Name = "JulkaisuVuosiTextBox";
            JulkaisuVuosiTextBox.Size = new Size(353, 27);
            JulkaisuVuosiTextBox.TabIndex = 47;
            JulkaisuVuosiTextBox.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 246);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 46;
            label5.Text = "Julkaisuvuosi:";
            label5.Visible = false;
            // 
            // vahvista_kirjapoisto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 163);
            Controls.Add(ISBNTextBox);
            Controls.Add(label9);
            Controls.Add(KategoriaTextBox);
            Controls.Add(label7);
            Controls.Add(KirjaLkmTextBox);
            Controls.Add(label6);
            Controls.Add(JulkaisuVuosiTextBox);
            Controls.Add(label5);
            Controls.Add(KirjoittajaSnimiTextBox);
            Controls.Add(KirjoittajaTextBox);
            Controls.Add(KirjanNimiTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PeruutaNappi);
            Controls.Add(KyllaNappi);
            Controls.Add(label1);
            Name = "vahvista_kirjapoisto";
            Text = "vahvista_kirjapoisto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button KyllaNappi;
        private Button PeruutaNappi;
        private TextBox KirjoittajaSnimiTextBox;
        private TextBox KirjoittajaTextBox;
        private TextBox KirjanNimiTextBox;
        private Label label3;
        private Label label2;
        private TextBox ISBNTextBox;
        private Label label9;
        private TextBox KategoriaTextBox;
        private Label label7;
        private TextBox KirjaLkmTextBox;
        private Label label6;
        private TextBox JulkaisuVuosiTextBox;
        private Label label5;
    }
}