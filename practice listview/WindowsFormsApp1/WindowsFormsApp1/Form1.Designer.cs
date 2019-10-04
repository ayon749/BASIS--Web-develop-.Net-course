namespace WindowsFormsApp1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.numberTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.infoShowListView = new System.Windows.Forms.ListView();
			this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(200, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(283, 64);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 20);
			this.nameTextBox.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(200, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Number";
			// 
			// numberTextBox
			// 
			this.numberTextBox.Location = new System.Drawing.Point(283, 121);
			this.numberTextBox.Name = "numberTextBox";
			this.numberTextBox.Size = new System.Drawing.Size(100, 20);
			this.numberTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(200, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Addres";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(283, 183);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(500, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// infoShowListView
			// 
			this.infoShowListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Number,
            this.columnHeader1});
			this.infoShowListView.FullRowSelect = true;
			this.infoShowListView.GridLines = true;
			this.infoShowListView.HideSelection = false;
			this.infoShowListView.LabelEdit = true;
			this.infoShowListView.Location = new System.Drawing.Point(242, 240);
			this.infoShowListView.Name = "infoShowListView";
			this.infoShowListView.Size = new System.Drawing.Size(293, 173);
			this.infoShowListView.TabIndex = 4;
			this.infoShowListView.UseCompatibleStateImageBehavior = false;
			this.infoShowListView.View = System.Windows.Forms.View.Details;
			this.infoShowListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.infoShowListView_ItemMouseHover);
			this.infoShowListView.DoubleClick += new System.EventHandler(this.infoShowListView_DoubleClick);
			// 
			// Name
			// 
			this.Name.Text = "Name";
			// 
			// Number
			// 
			this.Number.Text = "Number";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Address";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.infoShowListView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.numberTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label1);
			
			this.Text = "ListviewUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox numberTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView infoShowListView;
	
		private System.Windows.Forms.ColumnHeader Name;
		private System.Windows.Forms.ColumnHeader Number;
		private System.Windows.Forms.ColumnHeader columnHeader1;
	}
}

