namespace Metrics_COCOMO
{
    partial class Basic
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
            KLOC_Effort = new NumericUpDown();
            CalcEffortBtn = new Button();
            CalcTDEVBtn = new Button();
            label2 = new Label();
            ModeBox = new ComboBox();
            EffortBox = new TextBox();
            TDEVBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)KLOC_Effort).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 84);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "KLOC";
            // 
            // KLOC_Effort
            // 
            KLOC_Effort.Location = new Point(162, 84);
            KLOC_Effort.Name = "KLOC_Effort";
            KLOC_Effort.Size = new Size(120, 23);
            KLOC_Effort.TabIndex = 2;
            // 
            // CalcEffortBtn
            // 
            CalcEffortBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalcEffortBtn.Location = new Point(87, 192);
            CalcEffortBtn.Name = "CalcEffortBtn";
            CalcEffortBtn.Size = new Size(278, 46);
            CalcEffortBtn.TabIndex = 5;
            CalcEffortBtn.Text = "Calculate Effort";
            CalcEffortBtn.UseVisualStyleBackColor = true;
            // 
            // CalcTDEVBtn
            // 
            CalcTDEVBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalcTDEVBtn.Location = new Point(87, 319);
            CalcTDEVBtn.Name = "CalcTDEVBtn";
            CalcTDEVBtn.Size = new Size(278, 46);
            CalcTDEVBtn.TabIndex = 7;
            CalcTDEVBtn.Text = "Calculate TDEV";
            CalcTDEVBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(411, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Mode";
            // 
            // ModeBox
            // 
            ModeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ModeBox.FormattingEnabled = true;
            ModeBox.Items.AddRange(new object[] { "Automatic", "Oragnic", "Semi-detached", "Embedded" });
            ModeBox.Location = new Point(506, 83);
            ModeBox.Name = "ModeBox";
            ModeBox.Size = new Size(177, 23);
            ModeBox.TabIndex = 4;
            // 
            // EffortBox
            // 
            EffortBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            EffortBox.Location = new Point(459, 197);
            EffortBox.Multiline = true;
            EffortBox.Name = "EffortBox";
            EffortBox.ReadOnly = true;
            EffortBox.Size = new Size(224, 35);
            EffortBox.TabIndex = 6;
            // 
            // TDEVBox
            // 
            TDEVBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            TDEVBox.Location = new Point(459, 325);
            TDEVBox.Multiline = true;
            TDEVBox.Name = "TDEVBox";
            TDEVBox.ReadOnly = true;
            TDEVBox.Size = new Size(224, 35);
            TDEVBox.TabIndex = 8;
            // 
            // Basic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TDEVBox);
            Controls.Add(EffortBox);
            Controls.Add(ModeBox);
            Controls.Add(label2);
            Controls.Add(CalcTDEVBtn);
            Controls.Add(CalcEffortBtn);
            Controls.Add(KLOC_Effort);
            Controls.Add(label1);
            Name = "Basic";
            Text = "Basic";
            Load += Basic_Load;
            ((System.ComponentModel.ISupportInitialize)KLOC_Effort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown KLOC_Effort;
        private Button CalcEffortBtn;
        private Button CalcTDEVBtn;
        private Label label2;
        private ComboBox ModeBox;
        private TextBox EffortBox;
        private TextBox TDEVBox;
    }
}