using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Book.BLL;
using Book.Model;

namespace Book.UI
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                updateBtn.Enabled = false;
                SaveButton.Enabled = true;
                List<BookModel> abookModels = GetAllStudent();
                BookGridView.DataSource = abookModels;
                BookGridView.DataBind();
            }

        }

        private BookBLL aBookBll = new BookBLL();
        private BookModel aBookModel = new BookModel();

        protected void SaveButton_Click(object sender, EventArgs e)
        {

            if (ISBNTextBox.Text.Length == 13)
            {

                aBookModel.BookName = NameTextBox.Text;
                aBookModel.BookISBN = Convert.ToInt64(ISBNTextBox.Text);
                aBookModel.BookAuthor = AuthorTextBox.Text;
                MessageLabel.Text = aBookBll.save(aBookModel);
               
            }
            else
            {
                MessageLabel.Text = "Please Input ISBN 13 Caracter";
            }


        }

        public List<BookModel> GetAllStudent()
        {
            return aBookBll.GetAllStudent();

        }

        protected void BookGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = BookGridView.SelectedRow;
            NameTextBox.Text = ((Label)row.FindControl("BookNameLabel")).Text;
            ISBNTextBox.Text = ((Label)row.FindControl("BookISBNLabel")).Text;
            AuthorTextBox.Text = ((Label)row.FindControl("BookAuthorLabel")).Text;
            IdHiddenField.Value = ((Label)row.FindControl("bookIdLabel")).Text;
            updateBtn.Enabled = true;
            SaveButton.Enabled = false;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            BookModel aBookModel=new BookModel();

        }
    }
}