namespace kirjasto_käyttöliittymä_versio2
{
    partial class oma_sivu_hkunta_ssanavaihto
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
            label3 = new Label();
            label4 = new Label();
            UusiSalasanatextBox = new TextBox();
            UudelleenUusiSalasanatextBox = new TextBox();
            PaivitaNappi = new Button();
            PeruutaNappi = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(231, 52);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 0;
            label1.Text = "Muuta salasana";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 169);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 2;
            label3.Text = "Uusi salasana";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 226);
            label4.Name = "label4";
            label4.Size = new Size(217, 28);
            label4.TabIndex = 3;
            label4.Text = "Uusi salasana uudelleen";
            // 
            // UusiSalasanatextBox
            // 
            UusiSalasanatextBox.Location = new Point(346, 170);
            UusiSalasanatextBox.MaxLength = 4;
            UusiSalasanatextBox.Name = "UusiSalasanatextBox";
            UusiSalasanatextBox.PasswordChar = '*';
            UusiSalasanatextBox.Size = new Size(271, 27);
            UusiSalasanatextBox.TabIndex = 5;
            // 
            // UudelleenUusiSalasanatextBox
            // 
            UudelleenUusiSalasanatextBox.Location = new Point(346, 227);
            UudelleenUusiSalasanatextBox.MaxLength = 4;
            UudelleenUusiSalasanatextBox.Name = "UudelleenUusiSalasanatextBox";
            UudelleenUusiSalasanatextBox.PasswordChar = '*';
            UudelleenUusiSalasanatextBox.Size = new Size(271, 27);
            UudelleenUusiSalasanatextBox.TabIndex = 6;
            // 
            // PaivitaNappi
            // 
            PaivitaNappi.BackColor = Color.FromArgb(128, 255, 128);
            PaivitaNappi.Location = new Point(173, 315);
            PaivitaNappi.Name = "PaivitaNappi";
            PaivitaNappi.Size = new Size(94, 29);
            PaivitaNappi.TabIndex = 7;
            PaivitaNappi.Text = "Päivitä";
            PaivitaNappi.UseVisualStyleBackColor = false;
            PaivitaNappi.Click += PaivitaNappi_Click;
            // 
            // PeruutaNappi
            // 
            PeruutaNappi.BackColor = Color.Red;
            PeruutaNappi.Location = new Point(346, 315);
            PeruutaNappi.Name = "PeruutaNappi";
            PeruutaNappi.Size = new Size(94, 29);
            PeruutaNappi.TabIndex = 8;
            PeruutaNappi.Text = "Peruuta";
            PeruutaNappi.UseVisualStyleBackColor = false;
            PeruutaNappi.Click += PeruutaNappi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 110);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 9;
            label2.Text = "Salasanan täytyy olla neljä merkkiä.";
            // 
            // oma_sivu_hkunta_ssanavaihto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(label2);
            Controls.Add(PeruutaNappi);
            Controls.Add(PaivitaNappi);
            Controls.Add(UudelleenUusiSalasanatextBox);
            Controls.Add(UusiSalasanatextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "oma_sivu_hkunta_ssanavaihto";
            Text = "oma_sivu_hkunta_ssanavaihto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox UusiSalasanatextBox;
        private TextBox UudelleenUusiSalasanatextBox;
        private Button PaivitaNappi;
        private Button PeruutaNappi;
        private Label label2;
    }
}