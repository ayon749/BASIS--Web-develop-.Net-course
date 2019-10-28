using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformation.DAL;
using BookInformation.Models;

namespace BookInformation.BLL
{
    public class BookManager
    {
      BookGateway bookGateway=new BookGateway();

      public string InsertBook(Book aBook)
      {
          if (aBook.ISBN.Length == 13)
          {
              int row = bookGateway.AddBook(aBook);
              if (row == 1)
              {
                  return "Book saved Successfully.";
                }
              else
              {
                  return "Can not save the book.";
              }
             
                  
              
          }
          else
          {
              return "ISBN should be  13 character.";
            }

      }

      public List<Book> ShowBooks(string name)
      {
          List<Book>books=new List<Book>();
         books= bookGateway.Showbooks(name);
         return books;
      }

    }
}