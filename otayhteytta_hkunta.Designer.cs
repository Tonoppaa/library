namespace kirjasto_käyttöliittymä_versio2
{
    partial class otayhteytta_hkunta
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
            SuljeIkkunaNappi = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // SuljeIkkunaNappi
            // 
            SuljeIkkunaNappi.Location = new Point(707, 36);
            SuljeIkkunaNappi.Name = "SuljeIkkunaNappi";
            SuljeIkkunaNappi.Size = new Size(127, 29);
            SuljeIkkunaNappi.TabIndex = 15;
            SuljeIkkunaNappi.Text = "Sulje ikkuna";
            SuljeIkkunaNappi.UseVisualStyleBackColor = true;
            SuljeIkkunaNappi.Click += SuljeIkkunaNappi_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(484, 370);
            label7.Name = "label7";
            label7.Size = new Size(270, 35);
            label7.TabIndex = 14;
            label7.Text = "ma-su klo 08.00 - 16.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(38, 365);
            label6.Name = "label6";
            label6.Size = new Size(417, 41);
            label6.TabIndex = 13;
            label6.Text = "IT-asiakaspalvelun aukioloajat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Underline);
            label5.Location = new Point(303, 65);
            label5.Name = "label5";
            label5.Size = new Size(242, 54);
            label5.TabIndex = 12;
            label5.Text = "Ota yhteyttä";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(484, 176);
            label4.Name = "label4";
            label4.Size = new Size(259, 35);
            label4.TabIndex = 11;
            label4.Text = "IT-Mikko 040-1111111";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(484, 269);
            label3.Name = "label3";
            label3.Size = new Size(309, 35);
            label3.TabIndex = 10;
            label3.Text = "asiakaspalvelu@itpalvelu.fi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(38, 264);
            label2.Name = "label2";
            label2.Size = new Size(400, 41);
            label2.TabIndex = 9;
            label2.Text = "IT-asiakaspalvelu sähköposti:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(38, 170);
            label1.Name = "label1";
            label1.Size = new Size(368, 41);
            label1.TabIndex = 8;
            label1.Text = "IT-asiakaspalvelu puh. nro:";
            // 
            // otayhteytta_hkunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 521);
            Controls.Add(SuljeIkkunaNappi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "otayhteytta_hkunta";
            Text = "otayhteytta_hkunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SuljeIkkunaNappi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}