using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInformation.Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string name, string iSBN, string authoor):this()
        {
            Name = name;
            ISBN = iSBN;
            Authoor = authoor;
        }

        public Book(int bookiId, string name, string iSBN, string authoor):this()
        {
            BookiId = bookiId;
            Name = name;
            ISBN = iSBN;
            Authoor = authoor;
        }

        public int BookiId { set; get; }
        public string Name { set; get; }
        public  string ISBN { set; get; }
        public string Authoor { set; get; }
    }
}