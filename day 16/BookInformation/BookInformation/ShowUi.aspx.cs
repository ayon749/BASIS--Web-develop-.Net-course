using BookInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformation.BLL;

namespace BookInformation
{
    public partial class ShowUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = inputNameSearch.Value;
            ShowSearchBook(name);

        }

        private void ShowSearchBook(string name)
        {
            BookManager bookManager=new BookManager();

           List<Book>books=new List<Book>();
           books = bookManager.ShowBooks(name);
           searchGridView.DataSource = books;
           searchGridView.DataBind();
        }
    }
}