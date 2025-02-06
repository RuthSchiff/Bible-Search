namespace Search
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox2 = new ListBox();
            textBox2 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            listBox3 = new ListBox();
            label9 = new Label();
            label2 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label7 = new Label();
            label8 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1287, 336);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(245, 35);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(1130, 336);
            button1.Name = "button1";
            button1.Size = new Size(144, 37);
            button1.TabIndex = 1;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(1356, 311);
            label1.Name = "label1";
            label1.Size = new Size(176, 22);
            label1.TabIndex = 2;
            label1.Text = "הכנס מילה לחיפוש בתנ\"ך";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(378, 419);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(1157, 123);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 351);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "מספר תוצאות";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 383);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "מספר פסוקים";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(1342, 545);
            label5.Name = "label5";
            label5.Size = new Size(189, 22);
            label5.TabIndex = 7;
            label5.Text = "הכנס מילה לחיפוש גימטריה";
            label5.Click += label5_Click_1;
            // 
            // listBox2
            // 
            listBox2.DataSource = listBox2.CustomTabOffsets;
            listBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(378, 654);
            listBox2.Name = "listBox2";
            listBox2.RightToLeft = RightToLeft.Yes;
            listBox2.Size = new Size(1157, 89);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1288, 578);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(245, 35);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(1418, 629);
            label6.Name = "label6";
            label6.Size = new Size(113, 22);
            label6.TabIndex = 10;
            label6.Text = "תוצאות החיפוש";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(1053, 570);
            button2.Name = "button2";
            button2.Size = new Size(144, 37);
            button2.TabIndex = 11;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1294, 794);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(245, 35);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(1133, 794);
            button3.Name = "button3";
            button3.Size = new Size(144, 37);
            button3.TabIndex = 15;
            button3.Text = "search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 17;
            listBox3.Location = new Point(378, 861);
            listBox3.Name = "listBox3";
            listBox3.RightToLeft = RightToLeft.Yes;
            listBox3.Size = new Size(1157, 89);
            listBox3.TabIndex = 16;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(912, 760);
            label9.Name = "label9";
            label9.Size = new Size(625, 22);
            label9.TabIndex = 17;
            label9.Text = "הכנס מילה לחיפוש פסוק המתחיל באות הראשונה של המילה ומסתיים באות האחרונה של המילה";
            label9.Click += label9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(1419, 383);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 3;
            label2.Text = "תוצאות החיפוש";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(1424, 836);
            label10.Name = "label10";
            label10.Size = new Size(113, 22);
            label10.TabIndex = 18;
            label10.Text = "תוצאות החיפוש";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Location = new Point(378, 836);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(99, 20);
            label11.TabIndex = 19;
            label11.Text = "מספר תוצאות";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Guttman Stam", 13.7999992F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(696, 217);
            label12.Name = "label12";
            label12.Size = new Size(154, 34);
            label12.TabIndex = 20;
            label12.Text = "חיפוש בתנ\"ך";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(929, 581);
            label13.Name = "label13";
            label13.Size = new Size(105, 20);
            label13.TabIndex = 22;
            label13.Text = "ערך הגימטריה ";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(893, 581);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 23;
            label14.Text = "0";
            label14.Click += label14_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 640);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 24;
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(195, 640);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(403, 620);
            label15.Name = "label15";
            label15.Size = new Size(99, 20);
            label15.TabIndex = 26;
            label15.Text = "מספר תוצאות";
            label15.Click += label15_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Gui.Properties.Resources.bdd676a27c72cf5cb6a376c398407f57;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1724, 1055);
            Controls.Add(label15);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(listBox3);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(listBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox2;
        private TextBox textBox2;
        private Label label6;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private ListBox listBox3;
        private Label label9;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label7;
        private Label label8;
        private Label label15;
    }
}