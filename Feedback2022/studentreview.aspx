<%@ Page Language="VB" AutoEventWireup="false" CodeFile="studentreview.aspx.vb" Inherits="studentreview" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>BMS FEEDBACK SYSTEM</title>
  <style>
    #customers {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#customers td, #customers th {
  
  padding: 8px;
}

#customers tr:nth-child(even){background-color:#B4E7FA;}

#customers tr:hover {background-color: #F04E00;}

#customers th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: black;
}
</style>
    

    <style type="text/css">
        .style1
        {
            width: 205px;
        }
        .style2
        {
        }
        .style3
        {
            width: 100%;
            text-align: center;
        }
        .style4
        {
        }
        .style6
        {
            text-align: center;
        }
        .style7
        {
            width: 163px;
        }
    </style>

    

</head>
<body>
    <form id="form1" runat="server">

      <table id="customers">
          <tr>
              <td class="style3" colspan="4">
                  <asp:Image ID="Image1" runat="server" Height="73px" ImageUrl="~/feedback.png" 
                      Width="136px" />
                  <asp:Image ID="Image2" runat="server" Height="73px" ImageUrl="~/bmscw_logo.png" 
                      Width="477px" />
              </td>
          </tr>
          <tr>
              <td class="style3" colspan="4">
                  FEEDBACK ON AUGUMENTATION OF TRAINING PROGRAM&nbsp;</td>
          </tr>
          <tr>
              <td class="style4">
                  DEPARTMENT&nbsp;
                  <asp:Label ID="Label1" runat="server"></asp:Label>
              </td>
              <td class="style2" colspan="2">
                  SEMESTER&nbsp;
                  <asp:Label ID="Label2" runat="server"></asp:Label>
              </td>
              <td class="style1">
                  DATE&nbsp;&nbsp;
                  <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
              </td>
          </tr>
          <tr>
              <td class="style4">
                  NAME OF THE PROGRAM OR TRAINING&nbsp;&nbsp;&nbsp;
                  </td>
              <td class="style7">
                  <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  TITLE OF THE PROGRAM&nbsp;
                  </td>
              <td class="style1">
                  <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
              </td>
          </tr>
          <tr>
              <td class="style4">
                  RESOURCE PERSON NAME&nbsp;&nbsp;&nbsp;
                  </td>
              <td class="style7">
                  <asp:Label ID="Label3" runat="server"></asp:Label>
              </td>
              <td>
                  &nbsp;</td>
              <td class="style1">
                  &nbsp;</td>
          </tr>
          <tr>
              <td class="style4" colspan="2">
                  STUDENT REGISTER NO
                  <asp:TextBox ID="TextBox1" runat="server" Width="95px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TextBox1" ErrorMessage="USNONO CANNOT BE EMPTY"></asp:RequiredFieldValidator>
              </td>
              <td colspan="2">
                  STUDENTNAME
                  <asp:TextBox ID="TextBox2" runat="server" Width="101px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TextBox2" ErrorMessage="NAME CANNOT BE EMPTY"></asp:RequiredFieldValidator>
                  </td>
          </tr>
          </table>
    
      <table id="customers">
          <tr>
              <td>
                  SLNO</td>
              <td>
                  PARAMETER</td>
              <td>
                  RATING</td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label7" runat="server" Text="1"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList1" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label8" runat="server" Text="2"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList2" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label9" runat="server" Text="3"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList3" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label10" runat="server" Text="4"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList4" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label11" runat="server" Text="5"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList5" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label12" runat="server" Text="6"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList6" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label13" runat="server" Text="7"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList7" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label14" runat="server" Text="8"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList8" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label15" runat="server" Text="9"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList9" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label16" runat="server" Text="10"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:DropDownList ID="DropDownList10" runat="server">
                      <asp:ListItem>SELECT</asp:ListItem>
                      <asp:ListItem>POOR</asp:ListItem>
                      <asp:ListItem>AVERAGE</asp:ListItem>
                      <asp:ListItem>GOOD</asp:ListItem>
                      <asp:ListItem>EXCELLENT</asp:ListItem>
                  </asp:DropDownList>
              </td>
          </tr>
      </table>
      <table id="customers">
          <tr>
              <td colspan="2" style="font-weight: 700; text-align: center">
                  On a 10 point scale rate yourself before and after attending the program with 
                  respect to the training program</td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td style="text-align: center">
                  Before the Program
                  <asp:DropDownList ID="DropDownList11" runat="server">
                      <asp:ListItem>1</asp:ListItem>
                      <asp:ListItem>2</asp:ListItem>
                      <asp:ListItem>3</asp:ListItem>
                      <asp:ListItem>4</asp:ListItem>
                      <asp:ListItem>5</asp:ListItem>
                      <asp:ListItem>6</asp:ListItem>
                      <asp:ListItem>7</asp:ListItem>
                      <asp:ListItem>8</asp:ListItem>
                      <asp:ListItem>9</asp:ListItem>
                      <asp:ListItem>10</asp:ListItem>
                  </asp:DropDownList>
              </td>
              <td style="text-align: center">
                  After the Program
                  <asp:DropDownList ID="DropDownList12" runat="server">
                      <asp:ListItem>1</asp:ListItem>
                      <asp:ListItem>2</asp:ListItem>
                      <asp:ListItem>3</asp:ListItem>
                      <asp:ListItem>4</asp:ListItem>
                      <asp:ListItem>5</asp:ListItem>
                      <asp:ListItem>6</asp:ListItem>
                      <asp:ListItem>7</asp:ListItem>
                      <asp:ListItem>8</asp:ListItem>
                      <asp:ListItem>9</asp:ListItem>
                      <asp:ListItem>10</asp:ListItem>
                  </asp:DropDownList>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td class="style6" colspan="2">
                  Any Suggestions or Improvements
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td class="style6" colspan="2">
                  <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="857px"></asp:TextBox>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td colspan="2" style="text-align: center">
                  <asp:Button ID="Button1" runat="server" style="text-align: center" 
                      Text="SUBMIT" />
              &nbsp;
                  <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  &nbsp;</td>
          </tr>
      </table>
    
    </form>
</body>
</html>
