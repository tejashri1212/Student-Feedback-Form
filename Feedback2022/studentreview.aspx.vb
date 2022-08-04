Imports System.Data
Imports System.Data.SqlClient
Partial Class studentreview
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
        'Session("dep") = DEP
        'Session("sem") = SEM
        'Session("pn") = PN
        'Session("pt") = PT
        Label1.Text = Session("DEP")
        Label2.Text = Session("SEM")
        Label5.Text = Session("PN")
        Label6.Text = Session("ptit")
        Label4.Text = Date.Now.Date().ToString()

        Try

            qry = "Select * from program where programname=" + "'" + Label5.Text + "'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            reader = cmd1.ExecuteReader()
            Dim resp As String

            Do While reader.Read()
                resp = reader.GetString(5)
                found = 1
            Loop
            reader.Close()
            conn.Close()
           
            Label3.Text = resp

        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try


        '************************************************************
        Try

            qry = "Select * from programparameter where programname=" + "'" + Label5.Text + "'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            reader = cmd1.ExecuteReader()
            Dim resp As String

            Do While reader.Read()
                Label17.Text = reader.GetString(2)
                Label18.Text = reader.GetString(3)
                Label19.Text = reader.GetString(4)
                Label20.Text = reader.GetString(5)
                Label21.Text = reader.GetString(6)
                Label22.Text = reader.GetString(7)
                Label23.Text = reader.GetString(8)
                Label24.Text = reader.GetString(9)
                Label25.Text = reader.GetString(10)
                Label26.Text = reader.GetString(11)
              

                found = 1
            Loop
            reader.Close()
            conn.Close()



        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            qry = "insert into student values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o,@p,@q,@r,@s,@t,@u,@v,@w,@x)"
            Dim cmd As New SqlCommand(qry, conn)
            adp.InsertCommand = cmd

            adp.InsertCommand.Parameters.Add(New SqlParameter("@a", ""))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@b", Label4.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@c", TextBox1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@d", TextBox2.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@e", Label1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@f", Label2.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@g", Label5.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@h", Label6.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@i", Label4.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@j", Label3.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@k", "tst"))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@l", DropDownList1.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@m", DropDownList2.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@n", DropDownList3.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@o", DropDownList4.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@p", DropDownList5.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@q", DropDownList6.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@r", DropDownList7.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@s", DropDownList8.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@t", DropDownList9.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@u", DropDownList10.Text))

            adp.InsertCommand.Parameters.Add(New SqlParameter("@v", DropDownList11.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@w", DropDownList12.Text))
            adp.InsertCommand.Parameters.Add(New SqlParameter("@x", TextBox3.Text))


            conn.Open()
            adp.InsertCommand.ExecuteNonQuery()
            conn.Close()

            Response.Write("<script>alert('Registered successfully ');window.location='student.aspx';</script>")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            '   TextBox4.Text = ""
            'TextBox5.Text = ""
            'TextBox6.Text = ""
            'TextBox7.Text = ""
            'TextBox8.Text = ""
            'TextBox9.Text = ""
            'TextBox10.Text = ""

        Catch ex As Exception
            Label27.Text = ex.ToString()
        End Try
    End Sub
End Class
