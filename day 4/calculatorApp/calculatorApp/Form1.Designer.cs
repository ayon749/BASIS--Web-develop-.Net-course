namespace calculatorApp
{
    partial class Form1
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
            this.firstNumberBox = new System.Windows.Forms.TextBox();
            this.secondNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNumber = new System.Windows.Forms.Button();
            this.subNumber = new System.Windows.Forms.Button();
            this.mulNumber = new System.Windows.Forms.Button();
            this.divNumber = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumberBox
            // 
            this.firstNumberBox.Location = new System.Drawing.Point(389, 99);
            this.firstNumberBox.Name = "firstNumberBox";
            this.firstNumberBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumberBox.TabIndex = 0;
            // 
            // secondNumberBox
            // 
            this.secondNumberBox.Location = new System.Drawing.Point(389, 140);
            this.secondNumberBox.Name = "secondNumberBox";
            this.secondNumberBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumberBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter second Number";
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(267, 198);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(75, 23);
            this.addNumber.TabIndex = 4;
            this.addNumber.Text = "Add";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // subNumber
            // 
            this.subNumber.Location = new System.Drawing.Point(348, 198);
            this.subNumber.Name = "subNumber";
            this.subNumber.Size = new System.Drawing.Size(75, 23);
            this.subNumber.TabIndex = 5;
            this.subNumber.Text = "Sub";
            this.subNumber.UseVisualStyleBackColor = true;
            this.subNumber.Click += new System.EventHandler(this.subNumber_Click);
            // 
            // mulNumber
            // 
            this.mulNumber.Location = new System.Drawing.Point(429, 198);
            this.mulNumber.Name = "mulNumber";
            this.mulNumber.Size = new System.Drawing.Size(75, 23);
            this.mulNumber.TabIndex = 6;
            this.mulNumber.Text = "Mul";
            this.mulNumber.UseVisualStyleBackColor = true;
            this.mulNumber.Click += new System.EventHandler(this.mulNumber_Click);
            // 
            // divNumber
            // 
            this.divNumber.Location = new System.Drawing.Point(510, 198);
            this.divNumber.Name = "divNumber";
            this.divNumber.Size = new System.Drawing.Size(75, 23);
            this.divNumber.TabIndex = 7;
            this.divNumber.Text = "Div";
            this.divNumber.UseVisualStyleBackColor = true;
            this.divNumber.Click += new System.EventHandler(this.divNumber_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(389, 263);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.divNumber);
            this.Controls.Add(this.mulNumber);
            this.Controls.Add(this.subNumber);
            this.Controls.Add(this.addNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNumberBox);
            this.Controls.Add(this.firstNumberBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberBox;
        private System.Windows.Forms.TextBox secondNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Button subNumber;
        private System.Windows.Forms.Button mulNumber;
        private System.Windows.Forms.Button divNumber;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label3;
    }
}

