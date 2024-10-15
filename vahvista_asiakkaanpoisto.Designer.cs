namespace kirjasto_käyttöliittymä_versio2
{
    partial class vahvista_asiakkaanpoisto
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
            SsanatextBox = new TextBox();
            PuhtextBox = new TextBox();
            PtptextBox = new TextBox();
            PnotextBox = new TextBox();
            LosotextBox = new TextBox();
            SnimitextBox = new TextBox();
            EnimitextBox = new TextBox();
            AsNrotextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(55, 48);
            label1.Name = "label1";
            label1.Size = new Size(506, 35);
            label1.TabIndex = 1;
            label1.Text = "Oletko varma, että haluat poistaa asiakkaan?";
            // 
            // KyllaNappi
            // 
            KyllaNappi.Location = new Point(166, 105);
            KyllaNappi.Name = "KyllaNappi";
            KyllaNappi.Size = new Size(94, 29);
            KyllaNappi.TabIndex = 2;
            KyllaNappi.Text = "Kyllä";
            KyllaNappi.UseVisualStyleBackColor = true;
            KyllaNappi.Click += KyllaNappi_Click;
            // 
            // PeruutaNappi
            // 
            PeruutaNappi.Location = new Point(332, 105);
            PeruutaNappi.Name = "PeruutaNappi";
            PeruutaNappi.Size = new Size(94, 29);
            PeruutaNappi.TabIndex = 3;
            PeruutaNappi.Text = "Peruuta";
            PeruutaNappi.UseVisualStyleBackColor = true;
            PeruutaNappi.Click += PeruutaNappi_Click;
            // 
            // SsanatextBox
            // 
            SsanatextBox.Location = new Point(165, 513);
            SsanatextBox.Name = "SsanatextBox";
            SsanatextBox.ReadOnly = true;
            SsanatextBox.Size = new Size(261, 27);
            SsanatextBox.TabIndex = 103;
            // 
            // PuhtextBox
            // 
            PuhtextBox.Location = new Point(165, 467);
            PuhtextBox.Name = "PuhtextBox";
            PuhtextBox.ReadOnly = true;
            PuhtextBox.Size = new Size(261, 27);
            PuhtextBox.TabIndex = 102;
            // 
            // PtptextBox
            // 
            PtptextBox.Location = new Point(165, 419);
            PtptextBox.Name = "PtptextBox";
            PtptextBox.ReadOnly = true;
            PtptextBox.Size = new Size(261, 27);
            PtptextBox.TabIndex = 101;
            // 
            // PnotextBox
            // 
            PnotextBox.Location = new Point(165, 367);
            PnotextBox.Name = "PnotextBox";
            PnotextBox.ReadOnly = true;
            PnotextBox.Size = new Size(261, 27);
            PnotextBox.TabIndex = 100;
            // 
            // LosotextBox
            // 
            LosotextBox.Location = new Point(165, 313);
            LosotextBox.Name = "LosotextBox";
            LosotextBox.ReadOnly = true;
            LosotextBox.Size = new Size(261, 27);
            LosotextBox.TabIndex = 99;
            // 
            // SnimitextBox
            // 
            SnimitextBox.Location = new Point(165, 269);
            SnimitextBox.Name = "SnimitextBox";
            SnimitextBox.ReadOnly = true;
            SnimitextBox.Size = new Size(261, 27);
            SnimitextBox.TabIndex = 98;
            // 
            // EnimitextBox
            // 
            EnimitextBox.Location = new Point(165, 220);
            EnimitextBox.Name = "EnimitextBox";
            EnimitextBox.ReadOnly = true;
            EnimitextBox.Size = new Size(261, 27);
            EnimitextBox.TabIndex = 97;
            // 
            // AsNrotextBox
            // 
            AsNrotextBox.Location = new Point(165, 178);
            AsNrotextBox.Name = "AsNrotextBox";
            AsNrotextBox.ReadOnly = true;
            AsNrotextBox.Size = new Size(261, 27);
            AsNrotextBox.TabIndex = 96;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 520);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 95;
            label9.Text = "Salasana";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 470);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 94;
            label8.Text = "Puhelinnumero";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 422);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 93;
            label7.Text = "Postitoimipaikka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 367);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 92;
            label6.Text = "Postinumero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 313);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 91;
            label5.Text = "Lähiosoite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 272);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 90;
            label4.Text = "Sukunimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 223);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 89;
            label3.Text = "Etunimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 181);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 88;
            label2.Text = "Asiakasnumero";
            // 
            // vahvista_asiakkaanpoisto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 159);
            Controls.Add(SsanatextBox);
            Controls.Add(PuhtextBox);
            Controls.Add(PtptextBox);
            Controls.Add(PnotextBox);
            Controls.Add(LosotextBox);
            Controls.Add(SnimitextBox);
            Controls.Add(EnimitextBox);
            Controls.Add(AsNrotextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PeruutaNappi);
            Controls.Add(KyllaNappi);
            Controls.Add(label1);
            Name = "vahvista_asiakkaanpoisto";
            Text = "vahvista_asiakkaanpoisto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button KyllaNappi;
        private Button PeruutaNappi;
        private TextBox SsanatextBox;
        private TextBox PuhtextBox;
        private TextBox PtptextBox;
        private TextBox PnotextBox;
        private TextBox LosotextBox;
        private TextBox SnimitextBox;
        private TextBox EnimitextBox;
        private TextBox AsNrotextBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}