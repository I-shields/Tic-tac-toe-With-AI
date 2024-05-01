namespace TicTacToeMiniMax
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
            btn_2_0 = new Button();
            btn_2_1 = new Button();
            btn_2_2 = new Button();
            btn_1_2 = new Button();
            btn_1_1 = new Button();
            btn_1_0 = new Button();
            btn_0_2 = new Button();
            btn_0_1 = new Button();
            btn_0_0 = new Button();
            Reset_Btn = new Button();
            End_Btn = new Button();
            WinBox = new Label();
            SuspendLayout();
            // 
            // btn_2_0
            // 
            btn_2_0.Location = new Point(119, 48);
            btn_2_0.Name = "btn_2_0";
            btn_2_0.Size = new Size(80, 80);
            btn_2_0.TabIndex = 0;
            btn_2_0.UseVisualStyleBackColor = true;
            // 
            // btn_2_1
            // 
            btn_2_1.Location = new Point(205, 48);
            btn_2_1.Name = "btn_2_1";
            btn_2_1.Size = new Size(80, 80);
            btn_2_1.TabIndex = 1;
            btn_2_1.UseVisualStyleBackColor = true;
            // 
            // btn_2_2
            // 
            btn_2_2.Location = new Point(291, 48);
            btn_2_2.Name = "btn_2_2";
            btn_2_2.Size = new Size(80, 80);
            btn_2_2.TabIndex = 2;
            btn_2_2.UseVisualStyleBackColor = true;
            // 
            // btn_1_2
            // 
            btn_1_2.Location = new Point(291, 134);
            btn_1_2.Name = "btn_1_2";
            btn_1_2.Size = new Size(80, 80);
            btn_1_2.TabIndex = 5;
            btn_1_2.UseVisualStyleBackColor = true;
            btn_1_2.Click += button3_Click;
            // 
            // btn_1_1
            // 
            btn_1_1.Location = new Point(205, 134);
            btn_1_1.Name = "btn_1_1";
            btn_1_1.Size = new Size(80, 80);
            btn_1_1.TabIndex = 4;
            btn_1_1.UseVisualStyleBackColor = true;
            // 
            // btn_1_0
            // 
            btn_1_0.Location = new Point(119, 134);
            btn_1_0.Name = "btn_1_0";
            btn_1_0.Size = new Size(80, 80);
            btn_1_0.TabIndex = 3;
            btn_1_0.UseVisualStyleBackColor = true;
            // 
            // btn_0_2
            // 
            btn_0_2.Location = new Point(291, 220);
            btn_0_2.Name = "btn_0_2";
            btn_0_2.Size = new Size(80, 80);
            btn_0_2.TabIndex = 8;
            btn_0_2.UseVisualStyleBackColor = true;
            // 
            // btn_0_1
            // 
            btn_0_1.Location = new Point(205, 220);
            btn_0_1.Name = "btn_0_1";
            btn_0_1.Size = new Size(80, 80);
            btn_0_1.TabIndex = 7;
            btn_0_1.UseVisualStyleBackColor = true;
            // 
            // btn_0_0
            // 
            btn_0_0.Location = new Point(119, 220);
            btn_0_0.Name = "btn_0_0";
            btn_0_0.Size = new Size(80, 80);
            btn_0_0.TabIndex = 6;
            btn_0_0.UseVisualStyleBackColor = true;
            // 
            // Reset_Btn
            // 
            Reset_Btn.Location = new Point(388, 277);
            Reset_Btn.Name = "Reset_Btn";
            Reset_Btn.Size = new Size(138, 23);
            Reset_Btn.TabIndex = 9;
            Reset_Btn.Text = "Reset Board";
            Reset_Btn.UseVisualStyleBackColor = true;
            // 
            // End_Btn
            // 
            End_Btn.Location = new Point(388, 248);
            End_Btn.Name = "End_Btn";
            End_Btn.Size = new Size(138, 23);
            End_Btn.TabIndex = 10;
            End_Btn.Text = "End turn";
            End_Btn.UseVisualStyleBackColor = true;
            // 
            // WinBox
            // 
            WinBox.AutoSize = true;
            WinBox.Font = new Font("Segoe UI", 20F);
            WinBox.ForeColor = SystemColors.ControlText;
            WinBox.Location = new Point(388, 149);
            WinBox.Name = "WinBox";
            WinBox.Size = new Size(0, 37);
            WinBox.TabIndex = 11;
            WinBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WinBox);
            Controls.Add(End_Btn);
            Controls.Add(Reset_Btn);
            Controls.Add(btn_0_2);
            Controls.Add(btn_0_1);
            Controls.Add(btn_0_0);
            Controls.Add(btn_1_2);
            Controls.Add(btn_1_1);
            Controls.Add(btn_1_0);
            Controls.Add(btn_2_2);
            Controls.Add(btn_2_1);
            Controls.Add(btn_2_0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_2_0;
        private Button btn_2_1;
        private Button btn_2_2;
        private Button btn_1_2;
        private Button btn_1_1;
        private Button btn_1_0;
        private Button btn_0_2;
        private Button btn_0_1;
        private Button btn_0_0;
        private Button Reset_Btn;
        private Button End_Btn;
        private Label WinBox;
    }
}
