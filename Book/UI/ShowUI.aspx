<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowUI.aspx.cs" Inherits="Book.UI.ShowUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      .auto-style1 {
        width: 259px;
      }
      .auto-style2 {
        width: 180px;
        text-align: right;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> How Book</h1>
      <table style="width:100%; height: 85px;">
        <tr>
          <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name</td>
          <td class="auto-style1">
            <asp:TextBox ID="ShowTextBox" runat="server" Height="25px" Width="248px"></asp:TextBox>
          </td>
          <td>
            <asp:Button ID="ShowButton" runat="server" Height="29px" Text="Search" Width="108px" OnClick="ShowButton_Click" />
          </td>
        </tr>
        <tr>
          <td class="auto-style2">
              &nbsp;</td>
          <td class="auto-style1">&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td class="auto-style2">&nbsp;</td>
          <td class="auto-style1">&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
      </table>
    
    </div>
            <asp:GridView ID="ShowGridView" runat="server"  AutoGenerateColumns="False" Width="641px" OnSelectedIndexChanged="ShowGridView_SelectedIndexChanged" AllowSorting="True" BackColor="#33CCFF" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Caption="Show Book" CellPadding="2" CellSpacing="3" Height="212px" style="text-align: center"  >
              <Columns>
                <asp:TemplateField Visible="False">
                     <ItemTemplate>
                        
                          <asp:Label runat="server" ID="BookIdLabel" Text='<%#Eval("BookId") %>' ></asp:Label>
                    </ItemTemplate>
                    
                    
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Serial No">
                     <ItemTemplate>
                       
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
                

                     <asp:TemplateField HeaderText="ISBN">
                    <ItemTemplate>
                       <asp:Label runat="server" ID="isbn" Text='<%#Eval("BookISBN") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                       <asp:Label runat="server" ID="Name" Text='<%#Eval("BookName") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField HeaderText="Author">
                    <ItemTemplate>
                       <asp:Label runat="server" ID="Author" Text='<%#Eval("BookAuthor") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
               
                </Columns>
              
            </asp:GridView>
    </form>
    <br />
    <br />
    <br />
  <a href="home.aspx">Go To Home</a>
</body>
</html>
