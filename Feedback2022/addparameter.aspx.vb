Imports System.Data
Imports System.Data.SqlClient
Partial Class addparameter
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try

            qry = "Select distinct(SLNO) from PROGRAMNAME "
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
        '*******************************************************************
        Try

            qry = "Select distinct(programname) from PROGRAMNAME "
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()

            reader = cmd1.ExecuteReader()
            Do While reader.Read()
                DropDownList2.Items.Add(reader.GetString(0))
            Loop
            reader.Close()
            conn.Close()


        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "insert into programparameter values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l)"
            Dim cmd As New SqlCommand(qry, conn)
            adp.InsertCommand = cmd

            adp.InsertCommand.Parameters.Add(New SqlParameter("@a", DropDownList1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@b", DropDownList2.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@c", TextBox1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@d", TextBox2.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@e", TextBox3.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@f", TextBox4.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@g", TextBox5.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@h", TextBox6.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@i", TextBox7.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@j", TextBox8.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@k", TextBox9.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@l", TextBox10.Text))


            conn.Open()
            adp.InsertCommand.ExecuteNonQuery()
            conn.Close()

            Response.Write("<script>alert('Registered successfully ');window.location='adminpage.aspx';</script>")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            
        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub
End Class
