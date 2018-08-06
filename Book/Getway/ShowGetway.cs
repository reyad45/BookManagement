using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Book.Model;

namespace Book.Getway
{
  public class ShowGetway
  {
    private string connecton = WebConfigurationManager.ConnectionStrings["BookDataBase"].ConnectionString;
      private BookModel aBookModel = null;

      public List<BookModel>  showGetway(string bookSearch)
    {
      SqlConnection con = new SqlConnection(connecton);
      con.Open();
      string query = "SELECT * FROM AddBook where BookName='" + bookSearch + "'";
      SqlCommand cmd = new SqlCommand(query, con);
      SqlDataReader reader = cmd.ExecuteReader();
      //List<BookModel> bookModels = new List<BookModel>();
      List<BookModel> bookModels = new List<BookModel>();
      while (reader.Read())
      {
          BookModel aBookModels = new BookModel();
          aBookModels.BookName = reader["BookName"].ToString();
          aBookModels.BookISBN = Convert.ToInt64(reader["BookISBN"]);
          aBookModels.BookAuthor = reader["BookAuthor"].ToString();
          bookModels.Add(aBookModels);


      }
      reader.Close();
      con.Close();
      return bookModels;
    }


    public List<BookModel> showGetwayall(BookModel aBookModel)
    {
      SqlConnection con = new SqlConnection(connecton);
      con.Open();
      string query = "SELECT * FROM AddBook ";
      SqlCommand cmd = new SqlCommand(query, con);
      SqlDataReader reader = cmd.ExecuteReader();
      List<BookModel> bookModels = new List<BookModel>();
      while (reader.Read())
      {
        BookModel aBookModels = new BookModel();
        aBookModels.BookName = reader["BookName"].ToString();
        aBookModels.BookISBN = Convert.ToInt64(reader["BookISBN"]);
        aBookModels.BookAuthor = reader["BookAuthor"].ToString();
        bookModels.Add(aBookModels);

      }
      reader.Close();
      con.Close();
      return bookModels;
    }
  }
}