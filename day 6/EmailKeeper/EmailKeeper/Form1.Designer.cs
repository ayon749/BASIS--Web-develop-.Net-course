namespace EmailKeeper
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailAddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailSearchTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addEmailListBox = new System.Windows.Forms.ListBox();
            this.searchEmailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email to add";
            // 
            // emailAddTextBox
            // 
            this.emailAddTextBox.Location = new System.Drawing.Point(84, 19);
            this.emailAddTextBox.Name = "emailAddTextBox";
            this.emailAddTextBox.Size = new System.Drawing.Size(165, 20);
            this.emailAddTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email to search";
            // 
            // emailSearchTextBox
            // 
            this.emailSearchTextBox.Location = new System.Drawing.Point(451, 22);
            this.emailSearchTextBox.Name = "emailSearchTextBox";
            this.emailSearchTextBox.Size = new System.Drawing.Size(165, 20);
            this.emailSearchTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(174, 48);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(541, 48);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Tag = "Search";
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addEmailListBox
            // 
            this.addEmailListBox.FormattingEnabled = true;
            this.addEmailListBox.Location = new System.Drawing.Point(84, 144);
            this.addEmailListBox.Name = "addEmailListBox";
            this.addEmailListBox.Size = new System.Drawing.Size(165, 160);
            this.addEmailListBox.TabIndex = 3;
            // 
            // searchEmailListBox
            // 
            this.searchEmailListBox.FormattingEnabled = true;
            this.searchEmailListBox.Location = new System.Drawing.Point(451, 144);
            this.searchEmailListBox.Name = "searchEmailListBox";
            this.searchEmailListBox.Size = new System.Drawing.Size(165, 160);
            this.searchEmailListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchEmailListBox);
            this.Controls.Add(this.addEmailListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.emailSearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailAddTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Email keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailAddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailSearchTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox addEmailListBox;
        private System.Windows.Forms.ListBox searchEmailListBox;
    }
}

