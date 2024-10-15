namespace kirjasto_käyttöliittymä_versio2
{
    partial class unohtunut
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
            textBox1 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(57, 86);
            label1.Name = "label1";
            label1.Size = new Size(690, 35);
            label1.TabIndex = 0;
            label1.Text = "Saat unohtuneen käyttäjätunnuksen / salasanan sähköpostiisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(57, 137);
            label2.Name = "label2";
            label2.Size = new Size(629, 35);
            label2.TabIndex = 1;
            label2.Text = " kirjoittamalla tekstikenttään oman sähköpostiosoitteesi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(314, 321);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 3;
            button1.Text = "Lähetä";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(639, 22);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 8;
            button3.Text = "Sulje ikkuna";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(57, 184);
            label3.Name = "label3";
            label3.Size = new Size(280, 35);
            label3.TabIndex = 9;
            label3.Text = "ja klikkaamalla \"Lähetä\".";
            // 
            // unohtunut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "unohtunut";
            Text = "unohtunut";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Label label3;
    }
}