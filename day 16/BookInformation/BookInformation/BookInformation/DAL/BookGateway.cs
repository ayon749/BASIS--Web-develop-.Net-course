using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using BookInformation.Models;

namespace BookInformation.DAL
{
    public class BookGateway
    {
        private string connectionString =
            @"Server=PC-301-14\SQLEXPRESS;Database=BookiInformationDB;Integrated Security=true;";

        public int AddBook(Book aBook)
        {
           

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string query = "INSERT INTO Book_tbl(name, ISBN, Author)VALUES('" + aBook.Name + "','" + aBook.ISBN + "','" + aBook.Authoor +"')";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int rowEffect = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (rowEffect > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
               
            

        }

        public List<Book> Showbooks(string name)
        {
            List<Book> books=new List<Book>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query;
           
                 query= "SELECT * FROM Book_tbl WHERE name LIKE '%" + name + "%'";
           
            //else
            //{
            //    query = "SELECT * FROM Book_tbl ";
            //}

            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Book aBook=new Book();
                aBook.BookiId = (int) reader["BookiId"];
                aBook.Name = reader["name"].ToString();
                aBook.ISBN = reader["ISBN"].ToString();
                aBook.Authoor = reader["Author"].ToString();
                books.Add(aBook);
            }
            sqlConnection.Close();
            return books;



        }
    }
}