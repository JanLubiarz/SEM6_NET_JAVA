namespace Lab03_ObliczeniaWielowatkowe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox9 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(382, 51);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Oblicz LL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 20);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 2;
            label2.Text = "Podaj wymiar macierzy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 20);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Podaj ilosc watkow";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(382, 16);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Oblicz HL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 105);
            button3.Name = "button3";
            button3.Size = new Size(190, 27);
            button3.TabIndex = 8;
            button3.Text = "Pokaz macierze startowe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 175);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 230);
            textBox3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 82);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 10;
            label1.Text = "Podaj ziarno 1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(229, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 16);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 12;
            label4.Text = "czas";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(621, 39);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(274, 175);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(245, 230);
            textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(528, 175);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(229, 230);
            textBox8.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 142);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 18;
            label6.Text = "macierz 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 142);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 19;
            label7.Text = "macierz 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(528, 142);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 20;
            label8.Text = "macierz wynikowa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 83);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 21;
            label9.Text = "Podaj ziarno 2";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(370, 106);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 22;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(482, 16);
            button4.Name = "button4";
            button4.Size = new Size(92, 29);
            button4.TabIndex = 23;
            button4.Text = "Oblicz Sek";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Thread Matrix Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox9;
        private Button button4;
    }
}
