namespace week8_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_p1_archer = new System.Windows.Forms.RadioButton();
            this.rbtn_p1_warrior = new System.Windows.Forms.RadioButton();
            this.rbtn_p1_witcher = new System.Windows.Forms.RadioButton();
            this.lbl_p1_role = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_p2_archer = new System.Windows.Forms.RadioButton();
            this.rbtn_p2_warrior = new System.Windows.Forms.RadioButton();
            this.rbtn_p2_witcher = new System.Windows.Forms.RadioButton();
            this.lbl_p2_role = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn_p1_chessD = new System.Windows.Forms.RadioButton();
            this.rbtn_p1_chessC = new System.Windows.Forms.RadioButton();
            this.rbtn_p1_chessA = new System.Windows.Forms.RadioButton();
            this.rbtn_p1_chessB = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_p2_chessD = new System.Windows.Forms.RadioButton();
            this.rbtn_p2_chessA = new System.Windows.Forms.RadioButton();
            this.rbtn_p2_chessC = new System.Windows.Forms.RadioButton();
            this.rbtn_p2_chessB = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_p1_archer);
            this.panel1.Controls.Add(this.rbtn_p1_warrior);
            this.panel1.Controls.Add(this.rbtn_p1_witcher);
            this.panel1.Location = new System.Drawing.Point(27, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 153);
            this.panel1.TabIndex = 0;
            // 
            // rbtn_p1_archer
            // 
            this.rbtn_p1_archer.AutoSize = true;
            this.rbtn_p1_archer.Location = new System.Drawing.Point(29, 69);
            this.rbtn_p1_archer.Name = "rbtn_p1_archer";
            this.rbtn_p1_archer.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_archer.TabIndex = 2;
            this.rbtn_p1_archer.TabStop = true;
            this.rbtn_p1_archer.Text = "radioButton3";
            this.rbtn_p1_archer.UseVisualStyleBackColor = true;
            this.rbtn_p1_archer.CheckedChanged += new System.EventHandler(this.rbtn_p1_archer_CheckedChanged);
            // 
            // rbtn_p1_warrior
            // 
            this.rbtn_p1_warrior.AutoSize = true;
            this.rbtn_p1_warrior.Location = new System.Drawing.Point(29, 19);
            this.rbtn_p1_warrior.Name = "rbtn_p1_warrior";
            this.rbtn_p1_warrior.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_warrior.TabIndex = 0;
            this.rbtn_p1_warrior.TabStop = true;
            this.rbtn_p1_warrior.Text = "radioButton1";
            this.rbtn_p1_warrior.UseVisualStyleBackColor = true;
            this.rbtn_p1_warrior.CheckedChanged += new System.EventHandler(this.rbtn_p1_warrior_CheckedChanged);
            // 
            // rbtn_p1_witcher
            // 
            this.rbtn_p1_witcher.AutoSize = true;
            this.rbtn_p1_witcher.Location = new System.Drawing.Point(29, 44);
            this.rbtn_p1_witcher.Name = "rbtn_p1_witcher";
            this.rbtn_p1_witcher.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_witcher.TabIndex = 1;
            this.rbtn_p1_witcher.TabStop = true;
            this.rbtn_p1_witcher.Text = "radioButton2";
            this.rbtn_p1_witcher.UseVisualStyleBackColor = true;
            this.rbtn_p1_witcher.CheckedChanged += new System.EventHandler(this.rbtn_p1_witcher_CheckedChanged);
            // 
            // lbl_p1_role
            // 
            this.lbl_p1_role.Location = new System.Drawing.Point(49, 113);
            this.lbl_p1_role.Name = "lbl_p1_role";
            this.lbl_p1_role.Size = new System.Drawing.Size(133, 58);
            this.lbl_p1_role.TabIndex = 3;
            this.lbl_p1_role.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_p2_archer);
            this.panel2.Controls.Add(this.rbtn_p2_warrior);
            this.panel2.Controls.Add(this.rbtn_p2_witcher);
            this.panel2.Location = new System.Drawing.Point(801, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 153);
            this.panel2.TabIndex = 1;
            // 
            // rbtn_p2_archer
            // 
            this.rbtn_p2_archer.AutoSize = true;
            this.rbtn_p2_archer.Location = new System.Drawing.Point(29, 69);
            this.rbtn_p2_archer.Name = "rbtn_p2_archer";
            this.rbtn_p2_archer.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_archer.TabIndex = 5;
            this.rbtn_p2_archer.Text = "radioButton4";
            this.rbtn_p2_archer.UseVisualStyleBackColor = true;
            this.rbtn_p2_archer.CheckedChanged += new System.EventHandler(this.rbtn_p2_archer_CheckedChanged);
            // 
            // rbtn_p2_warrior
            // 
            this.rbtn_p2_warrior.AutoSize = true;
            this.rbtn_p2_warrior.Location = new System.Drawing.Point(29, 19);
            this.rbtn_p2_warrior.Name = "rbtn_p2_warrior";
            this.rbtn_p2_warrior.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_warrior.TabIndex = 3;
            this.rbtn_p2_warrior.Text = "radioButton6";
            this.rbtn_p2_warrior.UseVisualStyleBackColor = true;
            this.rbtn_p2_warrior.CheckedChanged += new System.EventHandler(this.rbtn_p2_warrior_CheckedChanged);
            // 
            // rbtn_p2_witcher
            // 
            this.rbtn_p2_witcher.AutoSize = true;
            this.rbtn_p2_witcher.Location = new System.Drawing.Point(29, 44);
            this.rbtn_p2_witcher.Name = "rbtn_p2_witcher";
            this.rbtn_p2_witcher.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_witcher.TabIndex = 4;
            this.rbtn_p2_witcher.Text = "radioButton5";
            this.rbtn_p2_witcher.UseVisualStyleBackColor = true;
            this.rbtn_p2_witcher.CheckedChanged += new System.EventHandler(this.rbtn_p2_witcher_CheckedChanged);
            // 
            // lbl_p2_role
            // 
            this.lbl_p2_role.Location = new System.Drawing.Point(809, 113);
            this.lbl_p2_role.Name = "lbl_p2_role";
            this.lbl_p2_role.Size = new System.Drawing.Size(133, 58);
            this.lbl_p2_role.TabIndex = 6;
            this.lbl_p2_role.Text = "label2";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(339, 189);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(99, 40);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "button1";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtn_p1_chessD);
            this.panel3.Controls.Add(this.rbtn_p1_chessC);
            this.panel3.Controls.Add(this.rbtn_p1_chessA);
            this.panel3.Controls.Add(this.rbtn_p1_chessB);
            this.panel3.Location = new System.Drawing.Point(32, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 153);
            this.panel3.TabIndex = 7;
            // 
            // rbtn_p1_chessD
            // 
            this.rbtn_p1_chessD.AutoSize = true;
            this.rbtn_p1_chessD.Location = new System.Drawing.Point(20, 94);
            this.rbtn_p1_chessD.Name = "rbtn_p1_chessD";
            this.rbtn_p1_chessD.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_chessD.TabIndex = 6;
            this.rbtn_p1_chessD.TabStop = true;
            this.rbtn_p1_chessD.Text = "radioButton3";
            this.rbtn_p1_chessD.UseVisualStyleBackColor = true;
            this.rbtn_p1_chessD.CheckedChanged += new System.EventHandler(this.rbtn_p1_chessD_CheckedChanged);
            // 
            // rbtn_p1_chessC
            // 
            this.rbtn_p1_chessC.AutoSize = true;
            this.rbtn_p1_chessC.Location = new System.Drawing.Point(20, 69);
            this.rbtn_p1_chessC.Name = "rbtn_p1_chessC";
            this.rbtn_p1_chessC.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_chessC.TabIndex = 5;
            this.rbtn_p1_chessC.TabStop = true;
            this.rbtn_p1_chessC.Text = "radioButton3";
            this.rbtn_p1_chessC.UseVisualStyleBackColor = true;
            this.rbtn_p1_chessC.CheckedChanged += new System.EventHandler(this.rbtn_p1_chessC_CheckedChanged);
            // 
            // rbtn_p1_chessA
            // 
            this.rbtn_p1_chessA.AutoSize = true;
            this.rbtn_p1_chessA.Location = new System.Drawing.Point(20, 19);
            this.rbtn_p1_chessA.Name = "rbtn_p1_chessA";
            this.rbtn_p1_chessA.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_chessA.TabIndex = 3;
            this.rbtn_p1_chessA.TabStop = true;
            this.rbtn_p1_chessA.Text = "radioButton1";
            this.rbtn_p1_chessA.UseVisualStyleBackColor = true;
            this.rbtn_p1_chessA.CheckedChanged += new System.EventHandler(this.rbtn_p1_chessA_CheckedChanged);
            // 
            // rbtn_p1_chessB
            // 
            this.rbtn_p1_chessB.AutoSize = true;
            this.rbtn_p1_chessB.Location = new System.Drawing.Point(20, 44);
            this.rbtn_p1_chessB.Name = "rbtn_p1_chessB";
            this.rbtn_p1_chessB.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p1_chessB.TabIndex = 4;
            this.rbtn_p1_chessB.TabStop = true;
            this.rbtn_p1_chessB.Text = "radioButton2";
            this.rbtn_p1_chessB.UseVisualStyleBackColor = true;
            this.rbtn_p1_chessB.CheckedChanged += new System.EventHandler(this.rbtn_p1_chessB_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtn_p2_chessD);
            this.panel4.Controls.Add(this.rbtn_p2_chessA);
            this.panel4.Controls.Add(this.rbtn_p2_chessC);
            this.panel4.Controls.Add(this.rbtn_p2_chessB);
            this.panel4.Location = new System.Drawing.Point(806, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 153);
            this.panel4.TabIndex = 8;
            // 
            // rbtn_p2_chessD
            // 
            this.rbtn_p2_chessD.AutoSize = true;
            this.rbtn_p2_chessD.Location = new System.Drawing.Point(23, 94);
            this.rbtn_p2_chessD.Name = "rbtn_p2_chessD";
            this.rbtn_p2_chessD.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_chessD.TabIndex = 10;
            this.rbtn_p2_chessD.TabStop = true;
            this.rbtn_p2_chessD.Text = "radioButton3";
            this.rbtn_p2_chessD.UseVisualStyleBackColor = true;
            this.rbtn_p2_chessD.CheckedChanged += new System.EventHandler(this.rbtn_p2_chessD_CheckedChanged);
            // 
            // rbtn_p2_chessA
            // 
            this.rbtn_p2_chessA.AutoSize = true;
            this.rbtn_p2_chessA.Location = new System.Drawing.Point(23, 19);
            this.rbtn_p2_chessA.Name = "rbtn_p2_chessA";
            this.rbtn_p2_chessA.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_chessA.TabIndex = 7;
            this.rbtn_p2_chessA.TabStop = true;
            this.rbtn_p2_chessA.Text = "radioButton1";
            this.rbtn_p2_chessA.UseVisualStyleBackColor = true;
            this.rbtn_p2_chessA.CheckedChanged += new System.EventHandler(this.rbtn_p2_chessA_CheckedChanged);
            // 
            // rbtn_p2_chessC
            // 
            this.rbtn_p2_chessC.AutoSize = true;
            this.rbtn_p2_chessC.Location = new System.Drawing.Point(23, 69);
            this.rbtn_p2_chessC.Name = "rbtn_p2_chessC";
            this.rbtn_p2_chessC.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_chessC.TabIndex = 9;
            this.rbtn_p2_chessC.TabStop = true;
            this.rbtn_p2_chessC.Text = "radioButton3";
            this.rbtn_p2_chessC.UseVisualStyleBackColor = true;
            this.rbtn_p2_chessC.CheckedChanged += new System.EventHandler(this.rbtn_p2_chessC_CheckedChanged);
            // 
            // rbtn_p2_chessB
            // 
            this.rbtn_p2_chessB.AutoSize = true;
            this.rbtn_p2_chessB.Location = new System.Drawing.Point(23, 44);
            this.rbtn_p2_chessB.Name = "rbtn_p2_chessB";
            this.rbtn_p2_chessB.Size = new System.Drawing.Size(102, 19);
            this.rbtn_p2_chessB.TabIndex = 8;
            this.rbtn_p2_chessB.TabStop = true;
            this.rbtn_p2_chessB.Text = "radioButton2";
            this.rbtn_p2_chessB.UseVisualStyleBackColor = true;
            this.rbtn_p2_chessB.CheckedChanged += new System.EventHandler(this.rbtn_p2_chessB_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(227, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 399);
            this.panel5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 551);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_p2_role);
            this.Controls.Add(this.lbl_p1_role);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_p1_archer;
        private System.Windows.Forms.RadioButton rbtn_p1_witcher;
        private System.Windows.Forms.RadioButton rbtn_p1_warrior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn_p2_archer;
        private System.Windows.Forms.RadioButton rbtn_p2_witcher;
        private System.Windows.Forms.RadioButton rbtn_p2_warrior;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_p1_role;
        private System.Windows.Forms.Label lbl_p2_role;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtn_p1_chessD;
        private System.Windows.Forms.RadioButton rbtn_p1_chessC;
        private System.Windows.Forms.RadioButton rbtn_p1_chessA;
        private System.Windows.Forms.RadioButton rbtn_p1_chessB;
        private System.Windows.Forms.RadioButton rbtn_p2_chessD;
        private System.Windows.Forms.RadioButton rbtn_p2_chessA;
        private System.Windows.Forms.RadioButton rbtn_p2_chessC;
        private System.Windows.Forms.RadioButton rbtn_p2_chessB;
        private System.Windows.Forms.Panel panel5;
    }
}

