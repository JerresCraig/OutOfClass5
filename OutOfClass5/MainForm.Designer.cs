namespace OutOfClass5
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.truthBtn = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.yesBtn = new System.Windows.Forms.RadioButton();
            this.noBtn = new System.Windows.Forms.RadioButton();
            this.adBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Birth Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Birth Year";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Has anyone looked at you in the past 5 days";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Have you ever recieved a targeted advertisement";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(18, 21);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(517, 29);
            this.questionLbl.TabIndex = 4;
            this.questionLbl.Text = "IS THE GOVERNMENT SPYING ON YOU ?";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // truthBtn
            // 
            this.truthBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.truthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truthBtn.Location = new System.Drawing.Point(23, 366);
            this.truthBtn.Name = "truthBtn";
            this.truthBtn.Size = new System.Drawing.Size(512, 72);
            this.truthBtn.TabIndex = 5;
            this.truthBtn.Text = "FIND THE TRUTH";
            this.truthBtn.UseVisualStyleBackColor = false;
            this.truthBtn.Click += new System.EventHandler(this.truthBtn_Click);
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(282, 97);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(174, 24);
            this.monthBox.TabIndex = 6;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(282, 157);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(174, 24);
            this.yearBox.TabIndex = 7;
            // 
            // yesBtn
            // 
            this.yesBtn.AutoSize = true;
            this.yesBtn.Location = new System.Drawing.Point(282, 209);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(53, 21);
            this.yesBtn.TabIndex = 10;
            this.yesBtn.TabStop = true;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            // 
            // noBtn
            // 
            this.noBtn.AutoSize = true;
            this.noBtn.Location = new System.Drawing.Point(282, 236);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(47, 21);
            this.noBtn.TabIndex = 11;
            this.noBtn.TabStop = true;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            // 
            // adBox
            // 
            this.adBox.FormattingEnabled = true;
            this.adBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.adBox.Location = new System.Drawing.Point(282, 285);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(174, 24);
            this.adBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.truthBtn);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label questionLbl;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button truthBtn;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.RadioButton yesBtn;
        private System.Windows.Forms.RadioButton noBtn;
        private System.Windows.Forms.ComboBox adBox;
    }
}

