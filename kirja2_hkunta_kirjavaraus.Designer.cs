namespace kirjasto_käyttöliittymä_versio2
{
    partial class kirja2_hkunta_kirjavaraus
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
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(201, 52);
            label1.Name = "label1";
            label1.Size = new Size(227, 46);
            label1.TabIndex = 0;
            label1.Text = "Kirjan varaus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(25, 116);
            label2.Name = "label2";
            label2.Size = new Size(601, 23);
            label2.TabIndex = 1;
            label2.Text = "Varataksesi kirjan asiakkaalle, lisää joko asiakkaan koko nimi tai lainaajatunnus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 193);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Asiakkaan koko nimi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 27);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 235);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 4;
            label4.Text = "Lainaajatunnus";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(201, 313);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Varaa";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(334, 313);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Peruuta";
            button2.UseVisualStyleBackColor = false;
            // 
            // kirja2_hkunta_kirjavaraus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 394);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "kirja2_hkunta_kirjavaraus";
            Text = "kirja2_hkunta_kirjavaraus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}