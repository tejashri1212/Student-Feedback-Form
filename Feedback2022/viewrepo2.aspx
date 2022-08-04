<%@ Page Language="VB" AutoEventWireup="false" CodeFile="viewrepo2.aspx.vb" Inherits="viewrepo2" %>


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
          </table>
    
      <table id="customers">
          <tr>
              <td>
                  SLNO</td>
              <td>
                  PARAMETER</td>
              <td colspan="4">
                  RATING 
                  IN PERCENTAGE</td>
          </tr>
          <tr>
              <td>
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
              <td>
                  POOR %</td>
              <td>
                  AVERAGE %</td>
              <td>
                  GOOD %</td>
              <td>
                  EXCELLENT %</td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label7" runat="server" Text="1"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label37" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label45" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label47" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label48" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label49" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label50" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label51" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label52" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label53" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label54" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label55" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label56" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label57" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label58" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label59" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label60" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label61" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label62" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label63" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label64" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label65" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label66" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label67" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label68" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label69" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label70" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label71" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label72" runat="server" Text="Label"></asp:Label>
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
                  <asp:Label ID="Label73" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label74" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label75" runat="server" Text="Label"></asp:Label>
              </td>
              <td>
                  <asp:Label ID="Label76" runat="server" Text="Label"></asp:Label>
              </td>
          </tr>
      </table>
      <table id="customers">
          <tr>
              <td style="text-align: center">
                  TOTAL NO OF STUDENTS REVIEWED&nbsp;
                  <asp:Label ID="Label36" runat="server"></asp:Label>
                  </td>
              <td>
                  &nbsp;</td>
          </tr>
      </table>
    
    </form>
</body>
</html>
