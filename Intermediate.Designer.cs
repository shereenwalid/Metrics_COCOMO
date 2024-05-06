namespace Metrics_COCOMO
{
    partial class Intermediate
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            mode_comboBox = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(185, 196);
            button1.Name = "button1";
            button1.Size = new Size(172, 41);
            button1.TabIndex = 0;
            button1.Text = "Cost Drivers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 47);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 1;
            label1.Text = "Intermediate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.Location = new Point(69, 126);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 2;
            label2.Text = "KLOC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 124);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 32);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F);
            label3.Location = new Point(417, 126);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 4;
            label3.Text = "Mode";
            // 
            // mode_comboBox
            // 
            mode_comboBox.FormattingEnabled = true;
            mode_comboBox.Items.AddRange(new object[] { "Organic", "Semidetached", "Embedded" });
            mode_comboBox.Location = new Point(543, 124);
            mode_comboBox.Name = "mode_comboBox";
            mode_comboBox.Size = new Size(121, 23);
            mode_comboBox.TabIndex = 5;
            mode_comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(98, 300);
            button2.Name = "button2";
            button2.Size = new Size(163, 40);
            button2.TabIndex = 6;
            button2.Text = "Effort";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(98, 375);
            button3.Name = "button3";
            button3.Size = new Size(163, 40);
            button3.TabIndex = 7;
            button3.Text = "TDEV";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(417, 308);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 32);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(417, 375);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 32);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(397, 205);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 32);
            textBox4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(585, 318);
            label4.Name = "label4";
            label4.Size = new Size(134, 19);
            label4.TabIndex = 11;
            label4.Text = "PM (person months)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(585, 386);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 12;
            label5.Text = "Months";
            // 
            // Intermediate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(mode_comboBox);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Intermediate";
            Text = "Intermediate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox mode_comboBox;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
    }
}