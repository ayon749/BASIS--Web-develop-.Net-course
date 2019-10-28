using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformation.BLL;
using BookInformation.Models;

namespace BookInformation
{
    public partial class AddBookUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButon_Click(object sender, EventArgs e)
        {
            
            string name = inputName.Value;
            string isbn = inputIsbn.Value;
            string author = inputAuthor.Value;
            Book aBook = new Book(name,isbn,author);
            BookManager bookManager=new BookManager();
            string message = bookManager.InsertBook(aBook);
            if (message == "Book saved Successfully.")
            {
                successMessage.Text = message;
                successMessage.ForeColor = Color.Green;
            }
            else
            {
                successMessage.Text = message;
                successMessage.ForeColor=Color.Red;
            }


        }
    }
}