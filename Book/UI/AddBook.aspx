<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Book.UI.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      .auto-style2 {
        text-align: right;
        width: 189px;
      }
      .auto-style3 {
        width: 189px;
      }
        .auto-style4 {
            width: 189px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            text-align: right;
            width: 189px;
            height: 34px;
        }
        .auto-style7 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h1>Add Book</h1>
    </div>
      <table style="width:100%;">
        <tr>
          <td class="auto-style2">Name:</td>
          <td>
            <asp:TextBox ID="NameTextBox" runat="server" Height="24px" Width="208px" required></asp:TextBox>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td class="auto-style6">ISBN:</td>
          <td class="auto-style7">
            <asp:TextBox ID="ISBNTextBox" runat="server" Height="24px" Width="208px" required></asp:TextBox>
          </td>
          <td class="auto-style7"></td>
        </tr>
        <tr>
          <td class="auto-style2">Author:</td>
          <td>
            <asp:TextBox ID="AuthorTextBox" runat="server" Height="24px" Width="208px" required></asp:TextBox>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td class="auto-style4"></td>
          <td class="auto-style5">
            <asp:Button ID="SaveButton" runat="server" Height="25px" Text="Save" Width="102px" OnClick="SaveButton_Click" />
              <asp:Button ID="updateBtn" runat="server" Height="25px" OnClick="updateBtn_Click" Text="Update" Width="90px" />
          </td>
          <td class="auto-style5"></td>
        </tr>
        <tr>
          <td class="auto-style3">
              <asp:HiddenField ID="IdHiddenField" runat="server" />
            </td>
          <td>
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>
          </td>
          <td>&nbsp;</td>
        </tr>
      </table>
  <a href="home.aspx">Go To Home</a>
        <asp:GridView ID="BookGridView" runat="server" OnSelectedIndexChanged="BookGridView_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                       <asp:TemplateField HeaderText="Book ID">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="bookIdLabel" Text='<%#Eval("BookId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Name">
                    <ItemTemplate>  
                        <asp:Label ID="BookNameLabel" runat="server" Text='<%#Eval("BookName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book ISBN">
                    <ItemTemplate>
                        <asp:Label runat="server" Id="BookISBNLabel" Text='<%#Eval("BookISBN") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Authors">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="BookAuthorLabel" Text='<%#Eval("BookAuthor") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
         
                  <asp:TemplateField>
                      <ItemTemplate>
                          <asp:LinkButton runat="server" Text="Update" Id="lnkSelect" CommandName="Select"></asp:LinkButton>
                      </ItemTemplate>
                  </asp:TemplateField>
            </Columns>
           
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
           
        </asp:GridView>
    </form>
  </body>
</html>
