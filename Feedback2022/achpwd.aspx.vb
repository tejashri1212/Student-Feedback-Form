Imports System.Data
Imports System.Data.SqlClient
Partial Class achpwd
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = Session("gname")
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "Select * from login where username=" + "'" + TextBox1.Text + "'"
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

                qry = "update  login set password=@p where username=@u"
                Dim cmd As New SqlCommand(qry, conn)
                adp.InsertCommand = cmd

                adp.InsertCommand.Parameters.Add(New SqlParameter("@p", TextBox3.Text))
                adp.InsertCommand.Parameters.Add(New SqlParameter("@u", TextBox1.Text))

             


                conn.Open()
                adp.InsertCommand.ExecuteNonQuery()
                conn.Close()

                Response.Write("<script>alert('Password Updated Successfully');window.location='adminpage.aspx';</script>")
            Else
                Response.Write("<script>alert('Login Unsuccessful,Please Try Again ');window.location='achpwd.aspx';</script>")
            End If


        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub
End Class
