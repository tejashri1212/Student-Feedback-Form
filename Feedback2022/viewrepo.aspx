<%@ Page Language="VB" AutoEventWireup="false" CodeFile="viewrepo.aspx.vb" Inherits="viewrepo" %>


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
      <asp:Image ID="Image3" runat="server" Height="73px" ImageUrl="~/feedback.png" 
          Width="136px" />
      <asp:Image ID="Image2" runat="server" Height="73px" ImageUrl="~/bmscw_logo.png" 
          Width="477px" />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="index.aspx">LOGOUT</a>&nbsp;
      <asp:Image ID="Image1" runat="server" Height="16px" ImageUrl="~/logout.jpg" 
          Width="34px" />
    </div>
  <div id="menu"> <a href="index.php"></a> <strong>&nbsp; 
      <a href="admin.aspx">HOME</a>  
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
              <td colspan="2">
                  GENERATE REPORT</td>
          </tr>
          <tr>
              <td>
                  YEAR</td>
              <td>
                  <asp:DropDownList ID="DropDownList1" runat="server">
                      <asp:ListItem>2022</asp:ListItem>
                      <asp:ListItem>2023</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  DEPARTMENT</td>
              <td>
                  <asp:DropDownList ID="DropDownList3" runat="server">
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
                  <asp:DropDownList ID="DropDownList4" runat="server">
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="VIEW REPORT" />
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
  </div>
</div>
<div align=center></div>
    </form>
</body>
</html>
