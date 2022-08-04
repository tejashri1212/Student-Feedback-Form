<%@ Page Language="VB" AutoEventWireup="false" CodeFile="achpwd.aspx.vb" Inherits="achpwd" %>


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
     <a href="adminpage.aspx">HOME</a>  
      <a href="addparameter.aspx">ADD PARAMETER</a>&nbsp;
       <a href="actdect.aspx">      ACTIVATE-DEACTIVATE</a> &nbsp;
      <a href="addfac.aspx">      ADD FACULTY</a> &nbsp;
      <a href="viewrepo.aspx">      VIEW-REPORT</a>&nbsp;
     <a href="newprg.aspx"> NEW PROGRAM</a>&nbsp;
   <a href="newdep.aspx"> NEW DEPARTMENT</a>&nbsp;</strong></div>
  <div id="main">
    <p>&nbsp;</p>
      <p>&nbsp;</p>
      <table class="style1">
          <tr>
              <td colspan="2" style="text-align: center">
                  CHANGE OR RESET PASSWORD</td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  USERNAME</td>
              <td>
                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  OLD
                  PASSWORD</td>
              <td>
                  <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
              &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  NEW PASSWORD</td>
              <td>
                  <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  CONFIRM PASSWORD</td>
              <td>
                  <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                      ControlToValidate="TextBox4" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="RESET PASSWORD" />
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
