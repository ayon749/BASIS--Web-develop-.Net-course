namespace WindowsFormsApp1
{
	partial class Calculator
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
			this.equationSelectComboBox = new System.Windows.Forms.ComboBox();
			this.selectedItemShowLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.principalTextBox = new System.Windows.Forms.TextBox();
			this.principalLabel = new System.Windows.Forms.Label();
			this.rateLabel = new System.Windows.Forms.Label();
			this.rateTeextBox = new System.Windows.Forms.TextBox();
			this.yearLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.timeComboBox = new System.Windows.Forms.ComboBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.calculateButton = new System.Windows.Forms.Button();
			this.answerTextBox = new System.Windows.Forms.TextBox();
			this.yearlable2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(238, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Simple Ineterest Calculator";
			// 
			// equationSelectComboBox
			// 
			this.equationSelectComboBox.FormattingEnabled = true;
			this.equationSelectComboBox.Location = new System.Drawing.Point(287, 74);
			this.equationSelectComboBox.Name = "equationSelectComboBox";
			this.equationSelectComboBox.Size = new System.Drawing.Size(164, 21);
			this.equationSelectComboBox.TabIndex = 1;
			this.equationSelectComboBox.Text = "--Select--";
			this.equationSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.equationSelectComboBox_SelectedIndexChanged);
			// 
			// selectedItemShowLabel
			// 
			this.selectedItemShowLabel.AutoSize = true;
			this.selectedItemShowLabel.Location = new System.Drawing.Point(284, 98);
			this.selectedItemShowLabel.Name = "selectedItemShowLabel";
			this.selectedItemShowLabel.Size = new System.Drawing.Size(94, 13);
			this.selectedItemShowLabel.TabIndex = 2;
			this.selectedItemShowLabel.Text = "where : select one";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(210, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Solver For :";
			// 
			// principalTextBox
			// 
			this.principalTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.principalTextBox.Location = new System.Drawing.Point(323, 138);
			this.principalTextBox.Name = "principalTextBox";
			this.principalTextBox.Size = new System.Drawing.Size(138, 22);
			this.principalTextBox.TabIndex = 4;
			this.principalTextBox.Tag = "";
			this.principalTextBox.Text = "amount";
			// 
			// principalLabel
			// 
			this.principalLabel.AutoSize = true;
			this.principalLabel.Location = new System.Drawing.Point(213, 144);
			this.principalLabel.Name = "principalLabel";
			this.principalLabel.Size = new System.Drawing.Size(83, 13);
			this.principalLabel.TabIndex = 5;
			this.principalLabel.Text = "Principal (P): TK";
			// 
			// rateLabel
			// 
			this.rateLabel.AutoSize = true;
			this.rateLabel.Location = new System.Drawing.Point(213, 180);
			this.rateLabel.Name = "rateLabel";
			this.rateLabel.Size = new System.Drawing.Size(64, 13);
			this.rateLabel.TabIndex = 6;
			this.rateLabel.Text = "Rate (R): % ";
			// 
			// rateTeextBox
			// 
			this.rateTeextBox.Location = new System.Drawing.Point(323, 173);
			this.rateTeextBox.Name = "rateTeextBox";
			this.rateTeextBox.Size = new System.Drawing.Size(138, 20);
			this.rateTeextBox.TabIndex = 7;
			this.rateTeextBox.Text = "rate";
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yearLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.yearLabel.Location = new System.Drawing.Point(263, 193);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(51, 15);
			this.yearLabel.TabIndex = 8;
			this.yearLabel.Text = "per year";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(213, 218);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(48, 13);
			this.timeLabel.TabIndex = 9;
			this.timeLabel.Text = "Time (t) :";
			// 
			// timeTextBox
			// 
			this.timeTextBox.Location = new System.Drawing.Point(323, 211);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(138, 20);
			this.timeTextBox.TabIndex = 10;
			this.timeTextBox.Text = "#";
			// 
			// timeComboBox
			// 
			this.timeComboBox.FormattingEnabled = true;
			this.timeComboBox.Items.AddRange(new object[] {
            "days(365/Yr)",
            "days(360/Yr)",
            "weeks",
            "months",
            "quarters",
            "year"});
			this.timeComboBox.Location = new System.Drawing.Point(340, 228);
			this.timeComboBox.Name = "timeComboBox";
			this.timeComboBox.Size = new System.Drawing.Size(121, 21);
			this.timeComboBox.TabIndex = 11;
			this.timeComboBox.Text = "Years";
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(121, 263);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 12;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(549, 263);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(75, 23);
			this.calculateButton.TabIndex = 13;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// answerTextBox
			// 
			this.answerTextBox.Location = new System.Drawing.Point(166, 288);
			this.answerTextBox.Multiline = true;
			this.answerTextBox.Name = "answerTextBox";
			this.answerTextBox.Size = new System.Drawing.Size(423, 150);
			this.answerTextBox.TabIndex = 14;
			this.answerTextBox.Text = "Answer:";
			// 
			// yearlable2
			// 
			this.yearlable2.AutoSize = true;
			this.yearlable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yearlable2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.yearlable2.Location = new System.Drawing.Point(266, 246);
			this.yearlable2.Name = "yearlable2";
			this.yearlable2.Size = new System.Drawing.Size(45, 13);
			this.yearlable2.TabIndex = 15;
			this.yearlable2.Text = "per year";
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.yearlable2);
			this.Controls.Add(this.answerTextBox);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.timeComboBox);
			this.Controls.Add(this.timeTextBox);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.yearLabel);
			this.Controls.Add(this.rateTeextBox);
			this.Controls.Add(this.rateLabel);
			this.Controls.Add(this.principalLabel);
			this.Controls.Add(this.principalTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.selectedItemShowLabel);
			this.Controls.Add(this.equationSelectComboBox);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Calculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Interest Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox equationSelectComboBox;
		private System.Windows.Forms.Label selectedItemShowLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox principalTextBox;
		private System.Windows.Forms.Label principalLabel;
		private System.Windows.Forms.Label rateLabel;
		private System.Windows.Forms.TextBox rateTeextBox;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.ComboBox timeComboBox;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.TextBox answerTextBox;
		private System.Windows.Forms.Label yearlable2;
	}
}

