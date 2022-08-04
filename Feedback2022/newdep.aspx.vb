Imports System.Data
Imports System.Data.SqlClient
Partial Class newdep
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "insert into departments values(@f,@m)"
            Dim cmd As New SqlCommand(qry, conn)
            adp.InsertCommand = cmd

            adp.InsertCommand.Parameters.Add(New SqlParameter("@f", TextBox1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@m", DropDownList1.Text))

            

            conn.Open()
            adp.InsertCommand.ExecuteNonQuery()
            conn.Close()

            Response.Write("<script>alert('Registered successfully ');window.location='adminpage.aspx';</script>")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TextBox1.Text = ""
            
        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
    End Sub
End Class
