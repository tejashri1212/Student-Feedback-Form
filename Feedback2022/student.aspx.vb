Imports System.Data
Imports System.Data.SqlClient
Partial Class student
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Label1.Text = Session("dep")
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
       
        'Try

        '    qry = "Select distinct(programname) from PROGRAMNAME "
        '    Dim cmd1 As New SqlCommand(qry, conn)
        '    Dim found As Integer = 0
        '    Dim reader As SqlDataReader
        '    conn.Open()

        '    reader = cmd1.ExecuteReader()
        '    Do While reader.Read()
        '        DropDownList4.Items.Add(reader.GetString(0))
        '    Loop
        '    reader.Close()
        '    conn.Close()


        'Catch ex As Exception
        '    Label1.Text = ex.ToString()
        'End Try
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Try

            qry = "Select distinct(PROGRAMNAME) FROM PROGRAM WHERE DEPARTMENT=" + "'" + DropDownList1.Text + "'" + " AND SEMESTER=" + "'" + DropDownList2.Text + "'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()

            reader = cmd1.ExecuteReader()
            Do While reader.Read()
                DropDownList3.Items.Add(reader.GetString(0))
            Loop
            reader.Close()
            conn.Close()


            '*********************************
            qry = "Select TITLE FROM PROGRAM WHERE DEPARTMENT=" + "'" + DropDownList1.Text + "'" + " AND SEMESTER=" + "'" + DropDownList2.Text + "'" + " and programname=" + "'" + DropDownList3.Text + "'"
            Dim cmd11 As New SqlCommand(qry, conn)

            Dim reader1 As SqlDataReader
            conn.Open()

            reader1 = cmd11.ExecuteReader()
            Do While reader1.Read()

                Label1.Text = reader1("title")
            Loop
            reader.Close()
            conn.Close()

        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
        '*****************************
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DEP As String
        Dim SEM As String
        Dim PN As String
        Dim PT As String
        DEP = DropDownList1.Text
        SEM = DropDownList2.Text
        PN = DropDownList3.Text
        PT = Label1.Text

        Session("dep") = DEP
        Session("sem") = SEM
        Session("pn") = PN
        Session("ptit") = PT


        Response.Redirect("studentreview.aspx")
    End Sub
End Class
