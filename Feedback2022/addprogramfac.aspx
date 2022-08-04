<%@ Page Language="VB" AutoEventWireup="false" CodeFile="addprogramfac.aspx.vb" Inherits="addprogramfac" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>BMS FEEDBACK SYSTEM</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="css/style.css"/>
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
        .style2
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
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span 
          class="style1">&nbsp;</span><a href="index.aspx" >LOGOUT</a>&nbsp;
      <asp:Image ID="Image1" runat="server" Height="16px" ImageUrl="~/logout.jpg" 
          Width="34px" />
    </div>
  <div id="menu"> <a href="facultypage.aspx"></a> <strong>&nbsp; 
      <a href="admin.aspx">HOME</a>  
      <a href="addprogramfac.aspx">ADD PROGRAM</a>&nbsp;
      
      <a href="viewrepofac.aspx">      VIEW-REPORT</a>&nbsp;
    
     </strong></div>
  <div id="main">
      <table class="style2">
          <tr>
              <td colspan="2" style="text-align: center">
                  ADD PROGRAM DETAILS</td>
          </tr>
          <tr>
              <td>
                  SLNO</td>
              <td>
                  <asp:DropDownList ID="DropDownList1" runat="server">
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  DEPARTMENT</td>
              <td>
                  <asp:Label ID="Label1" runat="server"></asp:Label>
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
                  DATE</td>
              <td>
                  <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td>
                  TITLE OF THE PROGRAM</td>
              <td>
                  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
              <td>
                  RESOURCE PERSON</td>
              <td>
                  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                      ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
              <td>
                  INTERNAL OR EXTERNAL PROGRAM</td>
              <td>
                  <asp:DropDownList ID="DropDownList3" runat="server">
                      <asp:ListItem>INTERNAL</asp:ListItem>
                      <asp:ListItem>EXTERNAL</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  ORGANIZATION</td>
              <td>
                  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
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
                  <asp:Button ID="Button1" runat="server" Text="ADD PROGRAM" />
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
      <p>&nbsp;</p>
      <p>&nbsp;</p>
  </div>
</div>
<div align=center></div>
    </form>
</body>
</html>
