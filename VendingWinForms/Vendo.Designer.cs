namespace VendingWinForms
{
    partial class Vendo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sfNumericTextBox1 = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.sfNumericTextBox2 = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsertCoin = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertCoin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sfNumericTextBox2);
            this.groupBox1.Controls.Add(this.sfNumericTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Coin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diameter (mm)";
            // 
            // sfNumericTextBox1
            // 
            this.sfNumericTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sfNumericTextBox1.Location = new System.Drawing.Point(96, 31);
            this.sfNumericTextBox1.MaxValue = 1000D;
            this.sfNumericTextBox1.MinValue = 0D;
            this.sfNumericTextBox1.Name = "sfNumericTextBox1";
            this.sfNumericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sfNumericTextBox1.TabIndex = 2;
            this.sfNumericTextBox1.ThemeName = null;
            // 
            // sfNumericTextBox2
            // 
            this.sfNumericTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sfNumericTextBox2.Location = new System.Drawing.Point(96, 57);
            this.sfNumericTextBox2.MaxValue = 1000D;
            this.sfNumericTextBox2.MinValue = 0D;
            this.sfNumericTextBox2.Name = "sfNumericTextBox2";
            this.sfNumericTextBox2.Size = new System.Drawing.Size(100, 20);
            this.sfNumericTextBox2.TabIndex = 3;
            this.sfNumericTextBox2.ThemeName = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nickel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quarter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "4.99 - 5.02";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "2.25 - 2.28";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "5.66 - 5.68";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "21.1 - 21.3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "17.7 - 18";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "24.1 - 25.4";
            // 
            // btnInsertCoin
            // 
            this.btnInsertCoin.Location = new System.Drawing.Point(107, 83);
            this.btnInsertCoin.Name = "btnInsertCoin";
            this.btnInsertCoin.Size = new System.Drawing.Size(75, 23);
            this.btnInsertCoin.TabIndex = 13;
            this.btnInsertCoin.Text = "Insert Coin";
            this.btnInsertCoin.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Yellow;
            this.lblDisplay.Location = new System.Drawing.Point(7, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(341, 50);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "INSERT COIN";
            // 
            // Vendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vendo";
            this.Text = "Vend-a-Snack";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Input.SfNumericTextBox sfNumericTextBox1;
        private Syncfusion.WinForms.Input.SfNumericTextBox sfNumericTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertCoin;
        private System.Windows.Forms.Label lblDisplay;
    }
}

