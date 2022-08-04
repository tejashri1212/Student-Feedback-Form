Imports System.Data
Imports System.Data.SqlClient
Partial Class addfac
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "insert into login values(@a,@b,@c,@d)"
            Dim cmd As New SqlCommand(qry, conn)
            adp.InsertCommand = cmd

            adp.InsertCommand.Parameters.Add(New SqlParameter("@a", TextBox1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@b", TextBox2.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@c", TextBox3.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@d", DropDownList1.Text))


            conn.Open()
            adp.InsertCommand.ExecuteNonQuery()
            conn.Close()

            Response.Write("<script>alert('Registered successfully ');window.location='adminpage.aspx';</script>")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Text = ""

        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)

        Try

            qry = "Select distinct(departments) from departments "
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()

            reader = cmd1.ExecuteReader()
            Do While reader.Read()
                DropDownList1.Items.Add(reader.GetString(0))
            Loop
            reader.Close()
            conn.Close()


        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub
End Class
