using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Book.BLL;
using Book.Model;

namespace Book.UI
{
  public partial class ShowUI : System.Web.UI.Page
  {
      
    BookBLL aBookBll = new BookBLL();
      
    protected void Page_Load(object sender, EventArgs e)
    {
     
   
    }



    protected void ShowButton_Click(object sender, EventArgs e)
    {

       string bookSearch = ShowTextBox.Text;

        
        if (bookSearch != "")
        {
            List<BookModel> aBookModel = aBookBll.showGetway(bookSearch);
            ShowGridView.DataSource = aBookModel;
            ShowGridView.DataBind();

        }

        else
        {
           BookModel aBookModel = new BookModel();
             List<BookModel> abook = aBookBll.GetAllGrideViewBLL(aBookModel);
            ShowGridView.DataSource = abook;
            ShowGridView.DataBind();
            
        }
       
      }
 
  
    
    protected void ShowGridView_SelectedIndexChanged(object sender, EventArgs e)
    {

      

      
    }
  }
}