Imports System.Data
Imports System.Data.SqlClient
Partial Class faculty
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "Select * from login where username=" + "'" + TextBox1.Text + "'" + " and password=" + "'" + TextBox2.Text + "'" + " and roleid='FACULTY'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            reader = cmd1.ExecuteReader()
            Dim dep As String
            Do While reader.Read()
                dep = reader("department")
                found = 1
            Loop
            reader.Close()
            conn.Close()
            If found = 1 Then


                Session("dep") = dep
                'Session("logname") = TextBox1.Text
                ''Session("add") = add
                'Session("mob") = mob



                Response.Redirect("facultypage.aspx")
            Else
                Response.Write("<script>alert('Login Unsuccessful,Please Try Again ');window.location='faculty.aspx';</script>")
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
