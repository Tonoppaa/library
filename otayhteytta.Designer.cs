namespace kirjasto_käyttöliittymä_versio2
{
    partial class otayhteytta
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(75, 163);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 0;
            label1.Text = "Asiakaspalvelu puh. nro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(75, 257);
            label2.Name = "label2";
            label2.Size = new Size(368, 41);
            label2.TabIndex = 1;
            label2.Text = "Asiakaspalvelu sähköposti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(496, 262);
            label3.Name = "label3";
            label3.Size = new Size(307, 35);
            label3.TabIndex = 2;
            label3.Text = "asiakaspalvelu@kirjastox.fi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(496, 169);
            label4.Name = "label4";
            label4.Size = new Size(155, 35);
            label4.TabIndex = 3;
            label4.Text = "040-1234567";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Underline);
            label5.Location = new Point(340, 58);
            label5.Name = "label5";
            label5.Size = new Size(242, 54);
            label5.TabIndex = 4;
            label5.Text = "Ota yhteyttä";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(75, 358);
            label6.Name = "label6";
            label6.Size = new Size(291, 41);
            label6.TabIndex = 5;
            label6.Text = "Kirjaston aukioloajat:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(496, 363);
            label7.Name = "label7";
            label7.Size = new Size(270, 35);
            label7.TabIndex = 6;
            label7.Text = "ma-su klo 08.00 - 16.00";
            // 
            // button1
            // 
            button1.Location = new Point(744, 29);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 7;
            button1.Text = "Sulje ikkuna";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // otayhteytta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 482);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "otayhteytta";
            Text = "otayhteytta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}