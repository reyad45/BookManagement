using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Book.Getway;
using Book.Model;

namespace Book.BLL
{
  public class BookBLL
  {
    private BookGetway aBookGetway = new BookGetway();
    private ShowGetway aShowGetway = new ShowGetway();

        public bool IsExistBLL(long ISBN)
        {
            return aBookGetway.IsExist(ISBN);
        }

    public string save(BookModel aBookModel)
    {
        if(IsExistBLL(aBookModel.BookISBN))
        {
            return "ISBN already Exist!!!";
        }
      if (aBookGetway.save(aBookModel) > 0)
      {
        return "save";
      }
      else
      {
        return "INVALID";
      }
       

    }

      public List<BookModel> GetAllStudent()
      {
          List<BookModel> bookModels = aBookGetway.GetAllStudent();
          return bookModels;
      }


      public List<BookModel> showGetway(string bookSearch)
    {
        return aShowGetway.showGetway(bookSearch);

    }

    public List<BookModel> GetAllGrideViewBLL(BookModel aBookModel)
    {
      return aShowGetway.showGetwayall(aBookModel);
    }
  }
}