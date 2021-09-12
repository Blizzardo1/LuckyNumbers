
namespace LuckyNumbers
{
    partial class LuckyWin
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
            this.luckyNumber = new System.Windows.Forms.Button();
            this.birthYear = new System.Windows.Forms.ComboBox();
            this.birthMonth = new System.Windows.Forms.ComboBox();
            this.birthDay = new System.Windows.Forms.ComboBox();
            this.favColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luckyNumber
            // 
            this.luckyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luckyNumber.Location = new System.Drawing.Point(48, 213);
            this.luckyNumber.Name = "luckyNumber";
            this.luckyNumber.Size = new System.Drawing.Size(315, 57);
            this.luckyNumber.TabIndex = 0;
            this.luckyNumber.Text = "Find out your lucky number";
            this.luckyNumber.UseVisualStyleBackColor = true;
            this.luckyNumber.Click += new System.EventHandler(this.luckyNumber_Click);
            // 
            // birthYear
            // 
            this.birthYear.FormattingEnabled = true;
            this.birthYear.Location = new System.Drawing.Point(173, 38);
            this.birthYear.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.birthYear.Name = "birthYear";
            this.birthYear.Size = new System.Drawing.Size(205, 23);
            this.birthYear.TabIndex = 1;
            this.birthYear.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // birthMonth
            // 
            this.birthMonth.FormattingEnabled = true;
            this.birthMonth.Location = new System.Drawing.Point(173, 73);
            this.birthMonth.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.birthMonth.Name = "birthMonth";
            this.birthMonth.Size = new System.Drawing.Size(205, 23);
            this.birthMonth.TabIndex = 1;
            this.birthMonth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // birthDay
            // 
            this.birthDay.FormattingEnabled = true;
            this.birthDay.Location = new System.Drawing.Point(173, 108);
            this.birthDay.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(205, 23);
            this.birthDay.TabIndex = 1;
            // 
            // favColor
            // 
            this.favColor.FormattingEnabled = true;
            this.favColor.Location = new System.Drawing.Point(173, 143);
            this.favColor.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.favColor.Name = "favColor";
            this.favColor.Size = new System.Drawing.Size(205, 23);
            this.favColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your birth year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your birth month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your birth day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter your favorite color";
            // 
            // LuckyWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.favColor);
            this.Controls.Add(this.birthDay);
            this.Controls.Add(this.birthMonth);
            this.Controls.Add(this.birthYear);
            this.Controls.Add(this.luckyNumber);
            this.Name = "LuckyWin";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luckyNumber;
        private System.Windows.Forms.ComboBox birthYear;
        private System.Windows.Forms.ComboBox birthMonth;
        private System.Windows.Forms.ComboBox birthDay;
        private System.Windows.Forms.ComboBox favColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

