Imports System.Data
Imports System.Data.SqlClient
Partial Class admin
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "Select * from login where username=" + "'" + TextBox1.Text + "'" + " and password=" + "'" + TextBox2.Text + "'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            Dim uname As String
            uname = ""
            reader = cmd1.ExecuteReader()
            Do While reader.Read()
                uname = reader("username")
                found = 1
            Loop
            reader.Close()
            conn.Close()
            If found = 1 Then


                Session("gname") = uname
                'Session("logname") = TextBox1.Text
                ''Session("add") = add
                'Session("mob") = mob

                '  Response.Write("tst=" + uname)

                Response.Redirect("adminpage.aspx")
            Else
                Response.Write("<script>alert('Login Unsuccessful,Please Try Again ');window.location='adminlogin.aspx';</script>")
            End If


        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
    End Sub
End Class
