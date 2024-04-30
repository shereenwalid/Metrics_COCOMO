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
            KLOC_TDEV = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)KLOC_Effort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KLOC_TDEV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 75);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "KLOC";
            // 
            // KLOC_Effort
            // 
            KLOC_Effort.Location = new Point(162, 75);
            KLOC_Effort.Name = "KLOC_Effort";
            KLOC_Effort.Size = new Size(120, 23);
            KLOC_Effort.TabIndex = 2;
            // 
            // CalcEffortBtn
            // 
            CalcEffortBtn.Location = new Point(56, 125);
            CalcEffortBtn.Name = "CalcEffortBtn";
            CalcEffortBtn.Size = new Size(698, 46);
            CalcEffortBtn.TabIndex = 3;
            CalcEffortBtn.Text = "Calculate Effort";
            CalcEffortBtn.UseVisualStyleBackColor = true;
            // 
            // CalcTDEVBtn
            // 
            CalcTDEVBtn.Location = new Point(56, 317);
            CalcTDEVBtn.Name = "CalcTDEVBtn";
            CalcTDEVBtn.Size = new Size(698, 46);
            CalcTDEVBtn.TabIndex = 6;
            CalcTDEVBtn.Text = "Calculate TDEV";
            CalcTDEVBtn.UseVisualStyleBackColor = true;
            // 
            // KLOC_TDEV
            // 
            KLOC_TDEV.Location = new Point(162, 267);
            KLOC_TDEV.Name = "KLOC_TDEV";
            KLOC_TDEV.Size = new Size(120, 23);
            KLOC_TDEV.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 267);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 4;
            label2.Text = "KLOC";
            // 
            // Basic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalcTDEVBtn);
            Controls.Add(KLOC_TDEV);
            Controls.Add(label2);
            Controls.Add(CalcEffortBtn);
            Controls.Add(KLOC_Effort);
            Controls.Add(label1);
            Name = "Basic";
            Text = "Basic";
            ((System.ComponentModel.ISupportInitialize)KLOC_Effort).EndInit();
            ((System.ComponentModel.ISupportInitialize)KLOC_TDEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown KLOC_Effort;
        private Button CalcEffortBtn;
        private Button CalcTDEVBtn;
        private NumericUpDown KLOC_TDEV;
        private Label label2;
    }
}