namespace kirjasto_käyttöliittymä_versio2
{
    partial class vaihda_salasana_asiakas
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
            label2 = new Label();
            UudelleenUusiSalasanatextBox = new TextBox();
            UusiSalasanatextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            PaivitaNappi = new Button();
            PeruutaNappi = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 137);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 17;
            label2.Text = "Salasanan täytyy olla neljä merkkiä.";
            // 
            // UudelleenUusiSalasanatextBox
            // 
            UudelleenUusiSalasanatextBox.Location = new Point(413, 254);
            UudelleenUusiSalasanatextBox.MaxLength = 4;
            UudelleenUusiSalasanatextBox.Name = "UudelleenUusiSalasanatextBox";
            UudelleenUusiSalasanatextBox.PasswordChar = '*';
            UudelleenUusiSalasanatextBox.Size = new Size(271, 27);
            UudelleenUusiSalasanatextBox.TabIndex = 14;
            // 
            // UusiSalasanatextBox
            // 
            UusiSalasanatextBox.Location = new Point(413, 197);
            UusiSalasanatextBox.MaxLength = 4;
            UusiSalasanatextBox.Name = "UusiSalasanatextBox";
            UusiSalasanatextBox.PasswordChar = '*';
            UusiSalasanatextBox.Size = new Size(271, 27);
            UusiSalasanatextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(117, 253);
            label4.Name = "label4";
            label4.Size = new Size(217, 28);
            label4.TabIndex = 12;
            label4.Text = "Uusi salasana uudelleen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(117, 196);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 11;
            label3.Text = "Uusi salasana";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(298, 79);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 10;
            label1.Text = "Muuta salasana";
            // 
            // PaivitaNappi
            // 
            PaivitaNappi.Location = new Point(221, 331);
            PaivitaNappi.Name = "PaivitaNappi";
            PaivitaNappi.Size = new Size(94, 29);
            PaivitaNappi.TabIndex = 18;
            PaivitaNappi.Text = "Päivitä";
            PaivitaNappi.UseVisualStyleBackColor = true;
            PaivitaNappi.Click += PaivitaNappi_Click;
            // 
            // PeruutaNappi
            // 
            PeruutaNappi.Location = new Point(442, 331);
            PeruutaNappi.Name = "PeruutaNappi";
            PeruutaNappi.Size = new Size(94, 29);
            PeruutaNappi.TabIndex = 19;
            PeruutaNappi.Text = "Peruuta";
            PeruutaNappi.UseVisualStyleBackColor = true;
            PeruutaNappi.Click += PeruutaNappi_Click;
            // 
            // vaihda_salasana_asiakas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PeruutaNappi);
            Controls.Add(PaivitaNappi);
            Controls.Add(label2);
            Controls.Add(UudelleenUusiSalasanatextBox);
            Controls.Add(UusiSalasanatextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "vaihda_salasana_asiakas";
            Text = "vaihda_salasana_asiakas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox UudelleenUusiSalasanatextBox;
        private TextBox UusiSalasanatextBox;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button PaivitaNappi;
        private Button PeruutaNappi;
    }
}