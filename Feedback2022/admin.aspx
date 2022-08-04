<%@ Page Language="VB" AutoEventWireup="false" CodeFile="admin.aspx.vb" Inherits="admin" %>


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
            margin-left: 0px;
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
              <td colspan="2" style="text-align: center">
                  ADMIN LOGIN</td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  USERNAME</td>
              <td>
                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TextBox1" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  PASSWORD</td>
              <td>
                  <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="LOGIN" />
              </td>
              <td>
                  <asp:Label ID="Label1" runat="server"></asp:Label>
              </td>
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
