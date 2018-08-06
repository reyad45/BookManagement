using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Book.Model;

namespace Book.Getway
{
  public class BookGetway
  {
    private string connecton = WebConfigurationManager.ConnectionStrings["BookDataBase"].ConnectionString;
    BookModel aBookModel=new BookModel();

    public bool IsExist(long ISBN)
    {
        SqlConnection con = new SqlConnection(connecton);
        con.Open();
        string querry = "SELECT * FROM AddBook WHERE BookISBN = '" + ISBN + "'";
        SqlCommand cmd = new SqlCommand(querry, con);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.HasRows)
        {
            return true;
        }
        return false;

    }
    public int save(BookModel aBookModel)
    {
      SqlConnection con=new SqlConnection(connecton);
      con.Open();
      string querry = "INSERT INTO AddBook (BookName, BookISBN, BookAuthor)values('" + aBookModel.BookName+ "','" + aBookModel.BookISBN+ "', '" + aBookModel.BookAuthor+ "')";
      SqlCommand cmd=new SqlCommand(querry, con);
      int rowCount = cmd.ExecuteNonQuery();
        con.Close();
      return rowCount;

    }

      public List<BookModel> GetAllStudent()
      {
          SqlConnection con=new SqlConnection(connecton);
          con.Open();
          string querry = "SELECT * FROM AddBook";
          SqlCommand cmd=new SqlCommand(querry, con);
          SqlDataReader reader = cmd.ExecuteReader();
          List<BookModel>bookModels=new List<BookModel>();
          while (reader.Read())
          {
              BookModel aBookModel=new BookModel();
              aBookModel.BookName = reader["BookName"].ToString();
              aBookModel.BookISBN = Convert.ToInt64(reader["BookISBN"]);
              aBookModel.BookAuthor = reader["BookAuthor"].ToString();
              aBookModel.BookId = Convert.ToInt32(reader["BookId"]);
              bookModels.Add(aBookModel);
          }
          reader.Close();
          con.Close();
          return bookModels;
      }

  }
}