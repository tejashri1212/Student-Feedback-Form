<%@ Page Language="VB" AutoEventWireup="false" CodeFile="student.aspx.vb" Inherits="student" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>BMS FEEDBACK SYSTEM</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="css/style.css"/>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div id="container">
  <div id="header"> 
      <asp:Image ID="Image1" runat="server" Height="73px" ImageUrl="~/feedback.png" 
          Width="136px" />
      <asp:Image ID="Image2" runat="server" Height="73px" ImageUrl="~/bmscw_logo.png" 
          Width="477px" />
    </div>
  <div id="menu"> <a href="index.php"></a> &nbsp; &nbsp; &nbsp; <strong>&nbsp; 
      <a href="admin.aspx">ADMIN</a> &nbsp; &nbsp; &nbsp; &nbsp; 
      <a href="faculty.aspx">FACULTY</a> &nbsp; &nbsp; &nbsp; &nbsp; <a href="student.aspx">
      STUDENT</a> &nbsp; &nbsp; &nbsp; &nbsp; </strong></div>
  <div id="main">
    <p>&nbsp;</p>
      <p>&nbsp;</p>
      <table class="style1">
          <tr>
              <td>
                  DEPARTMENT</td>
              <td>
                  <asp:DropDownList ID="DropDownList1" runat="server">
                      <asp:ListItem>BCA</asp:ListItem>
                      <asp:ListItem>BCOM</asp:ListItem>
                      <asp:ListItem>BBM</asp:ListItem>
                      <asp:ListItem>BSC</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  SEMESTER</td>
              <td>
                  <asp:DropDownList ID="DropDownList2" runat="server">
                      <asp:ListItem>1</asp:ListItem>
                      <asp:ListItem>2</asp:ListItem>
                      <asp:ListItem>3</asp:ListItem>
                      <asp:ListItem>4</asp:ListItem>
                      <asp:ListItem>5</asp:ListItem>
                      <asp:ListItem>6</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  PROGRAM NAME</td>
              <td>
                  <asp:DropDownList ID="DropDownList3" runat="server" Height="16px">
                  </asp:DropDownList>
&nbsp;&nbsp;
                  <asp:LinkButton ID="LinkButton1" runat="server">FETCH PROGRAMS</asp:LinkButton>
              </td>
          </tr>
          <tr>
              <td>
                  PROGRAM TITLE</td>
              <td>
                  <asp:Label ID="Label1" runat="server"></asp:Label>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="SUBMIT" />
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
          </tr>
      </table>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
  </div>
</div>
<div align=center></div>
    </form>
</body>
</html>
