using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book.Model
{
  public class BookModel
  {
    public string BookName { get; set; }
    public long BookISBN { get; set; }
    public string BookAuthor { get; set; }
    public int BookId { get; set; }
  }
}