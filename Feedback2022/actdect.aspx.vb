Imports System.Data
Imports System.Data.SqlClient
Partial Class actdect
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)

        Try
            Dim td As String
            Dim s As String
            Dim d As String
            'td = Request.QueryString.Get(0)
            's = Request.QueryString.Get(1)
            'd = Request.QueryString.Get(2)





            ''''''''''''''''''''''''''''''''''''''''
            'Dim em As String
            'em = Session("logname").ToString()
            qry = "Select * from program"


            '   Response.Write(qry)
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            Response.Write("  <table id=customers>          <tr>              <td class=style colspan=4>")
            Response.Write("   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <img src=feedback.png  Width=136 height=136></img>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ")
            Response.Write("    <img src=bmscw_logo.png  Width=500 height=136></img> ")
            Response.Write(" </td>          </tr>          </table>")
            Response.Write("<h3 align=center><A HREF=adminpage.aspx>HOME</a> </H1><BR>")
            Response.Write("<table id=customers border=5 align=center><tr><td>SLNO</td><td>DEPARTMENT</td>")
            Response.Write("<td>DATE</td><td>TITLE</td>")
            Response.Write("<td>PROGRAM-NAME</td><td>ACTION</td></tr>")
            ''  Response.Write("<td>B-CAPACITY</td><td>B-AVAILABLE</td><td>B-FARE</td>")
            ''   Response.Write("<td>DATE OF JOURNEY</td></tr>")
            conn.Open()
            reader = cmd1.ExecuteReader()
            Dim cnt As Integer = 0
            Do While reader.Read()
                Response.Write("<tr><td>" + reader("sno") + "</td>")
                Response.Write("<td>" + reader("department") + "</td>")
                Response.Write("<td>" + reader("title") + "</td>")
                Response.Write("<td>" + reader("date") + "</td>")
                Response.Write("<td>" + reader("programname") + "</td>")

                'Response.Write("<td>" + reader("ecapacity") + "</td>")
                'Response.Write("<td>" + reader("eavailability") + "</td>")
                'Response.Write("<td>" + reader("efare") + "</td>")
                'Response.Write("<td>" + reader("bcapacity") + "</td>")
                'Response.Write("<td>" + reader("bavailability") + "</td>")
                'Response.Write("<td>" + reader("bfare") + "</td>")
                'Response.Write("<td>" + reader("dateofjourney") + "</td>")
                'Response.Write("<td><img src=" + reader("photo") + " width=100 height=100></img></td>")
                If (reader("status") = "ACTIVE") Then
                    Response.Write("<td> <a href=actdect1.aspx?sno=" + reader("sno") + "&st=" + reader("status") + ">DE-ACTIVATE</a></td></tr>")
                Else

                    Response.Write("<td> <a href=actdect1.aspx?sno=" + reader("sno") + "&st=" + reader("status") + ">ACTIVATE</a></td></tr>")


                End If
                cnt = 1
            Loop
            If cnt = 0 Then
                Response.Write("<script>alert('Sorry,No Programs are Registered  ');window.location='adminpage.aspx';</script>")
            End If
            reader.Close()
            conn.Close()
            '   Response.Write("</tr></table><br><h1 align=center><a href=index.html>Home Page</a></h1>")


        Catch ex As Exception
            Response.Write(ex.ToString())
        End Try
    End Sub
End Class
