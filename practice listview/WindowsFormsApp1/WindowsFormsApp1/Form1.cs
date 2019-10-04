using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string name = nameTextBox.Text;
			string number = numberTextBox.Text;
			string address =addressTextBox.Text;
			ListViewItem itm = new ListViewItem(name);
			itm.SubItems.Add(number);
			itm.SubItems.Add(address);
			infoShowListView.Items.Add(itm);
			
		}

		private void infoShowListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
		{
			MessageBox.Show("hi there");

		}

		private void infoShowListView_DoubleClick(object sender, EventArgs e)
		{
			ListViewItem item = infoShowListView.SelectedItems[0];
			string name = item.Text;
			string number = item.SubItems[1].Text;
			string address = item.SubItems[2].Text;
			string messgae = "name: " + name + "\n" + "number: " + number + "\n" + "address: " + address + ".";
			MessageBox.Show(messgae);
		}
	}
}
