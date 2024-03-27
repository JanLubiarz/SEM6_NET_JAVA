namespace Lab02_WeatherApi
{
    partial class WeatherApiForm
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
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button4 = new Button();
            button5 = new Button();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button6 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 164);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(27, 236);
            button1.Name = "button1";
            button1.Size = new Size(157, 42);
            button1.TabIndex = 2;
            button1.Text = "Wyslij wspolrzedne";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(200, 238);
            button2.Name = "button2";
            button2.Size = new Size(157, 39);
            button2.TabIndex = 5;
            button2.Text = "Wyswietl wyniki";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 6;
            label1.Text = "Wyniki wyszykiwania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(200, 293);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "latitude";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(200, 372);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "longitude";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.earth;
            pictureBox1.InitialImage = Properties.Resources.earth;
            pictureBox1.Location = new Point(27, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(379, 53);
            button3.Name = "button3";
            button3.Size = new Size(116, 37);
            button3.TabIndex = 10;
            button3.Text = "Sortuj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(379, 96);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(206, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Temperatura odczywalna";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox2.ForeColor = SystemColors.Control;
            checkBox2.Location = new Point(379, 126);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(110, 24);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Wilgotnosc";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox3.ForeColor = SystemColors.Control;
            checkBox3.Location = new Point(379, 156);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 24);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Temperatura";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(635, 390);
            button4.Name = "button4";
            button4.Size = new Size(113, 38);
            button4.TabIndex = 14;
            button4.Text = "Usun dane";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(617, 53);
            button5.Name = "button5";
            button5.Size = new Size(131, 35);
            button5.TabIndex = 15;
            button5.Text = "Stworz wykres";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox4.ForeColor = SystemColors.Control;
            checkBox4.Location = new Point(617, 96);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(70, 24);
            checkBox4.TabIndex = 16;
            checkBox4.Text = "Temp";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox5.ForeColor = SystemColors.Control;
            checkBox5.Location = new Point(617, 126);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(110, 24);
            checkBox5.TabIndex = 17;
            checkBox5.Text = "Wilgotnosc";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // button6
            // 
            button6.Location = new Point(379, 238);
            button6.Name = "button6";
            button6.Size = new Size(148, 39);
            button6.TabIndex = 18;
            button6.Text = "Wyniki dla miasta";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(379, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 27);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(379, 293);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 20;
            label4.Text = "Wpisz wybrane miasto";
            // 
            // WeatherApiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "WeatherApiForm";
            Text = "WeatherApi App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button6;
        private TextBox textBox3;
        private Label label4;
    }
}
