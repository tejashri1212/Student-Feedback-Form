Imports System.Data
Imports System.Data.SqlClient
Partial Class newprg
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "Select * from PROGRAMNAME "
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 1
            Dim reader As SqlDataReader
            conn.Open()
            reader = cmd1.ExecuteReader()
            Do While reader.Read()

                found = found + 1
            Loop
            reader.Close()
            conn.Close()
            TextBox1.Text = found


        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            qry = "insert into programname values(@a,@b)"
            Dim cmd As New SqlCommand(qry, conn)
            adp.InsertCommand = cmd

            adp.InsertCommand.Parameters.Add(New SqlParameter("@a", TextBox1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@b", TextBox2.Text))



            conn.Open()
            adp.InsertCommand.ExecuteNonQuery()
            conn.Close()

            Response.Write("<script>alert('Registered successfully ');window.location='adminpage.aspx';</script>")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TextBox1.Text = ""
            TextBox2.Text = ""
            
        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub
End Class
