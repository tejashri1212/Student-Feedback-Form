<%@ Page Language="VB" AutoEventWireup="false" CodeFile="addfac.aspx.vb" Inherits="addfac" %>



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
        .style2
        {
            width: 293px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div id="container">
  <div id="header"> 
      <asp:Image ID="Image3" runat="server" Height="73px" ImageUrl="~/feedback.png" 
          Width="136px" />
      <asp:Image ID="Image2" runat="server" Height="73px" ImageUrl="~/bmscw_logo.png" 
          Width="477px" />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="index.aspx">LOGOUT</a>
      <asp:Image ID="Image1" runat="server" Height="16px" ImageUrl="~/logout.jpg" 
          Width="34px" />
    </div>
  <div id="menu"> <a href="index.php"></a> <strong>&nbsp; 
     <a href="adminpage.aspx">HOME</a>  
      <a href="addparameter.aspx">ADD PARAMETER</a>&nbsp;
       <a href="actdect.aspx">      ACTIVATE-DEACTIVATE</a> &nbsp;
      <a href="addfac.aspx">      ADD FACULTY</a> &nbsp;
      <a href="viewrepo.aspx">      VIEW-REPORT</a>&nbsp;
     <a href="newprg.aspx"> NEW PROGRAM</a>&nbsp;
   <a href="newdep.aspx"> NEW DEPARTMENT</a>&nbsp;
     </strong></div>
  <div id="main">
      <table class="style1">
          <tr>
              <td colspan="2" style="text-align: center">
                  ADD FACULTY</td>
          </tr>
          <tr>
              <td class="style2">
                  USERNAME</td>
              <td>
                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TextBox1" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
              <td class="style2">
                  PASSWORD</td>
              <td>
                  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
              <td class="style2">
                  ROLEID</td>
              <td>
                  <asp:TextBox ID="TextBox3" runat="server">FACULTY</asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="style2">
                  DEPARTMENT</td>
              <td>
                  <asp:DropDownList ID="DropDownList1" runat="server">
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td class="style2">
                  <asp:Button ID="Button1" runat="server" Text="ADD FACULTY" />
              </td>
              <td>
                  <asp:Label ID="Label1" runat="server"></asp:Label>
              </td>
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
      <p>&nbsp;</p>
      <p>&nbsp;</p>
  </div>
</div>
<div align=center></div>
    </form>
</body>
</html>
