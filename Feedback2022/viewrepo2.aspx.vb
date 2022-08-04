Imports System.Data
Imports System.Data.SqlClient
Partial Class viewrepo2

    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
        Label1.Text = Session("dep")
        Label2.Text = Session("sem")
        Label5.Text = Session("pn")
        Label36.Text = Session("cnt")

        'Label6.Text = Session("ptit")
        'Label4.Text = Date.Now.Date().ToString()

        Try

            qry = "Select * from program where programname=" + "'" + Label5.Text + "'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            reader = cmd1.ExecuteReader()
            Dim resp As String = ""

            Do While reader.Read()
                resp = reader.GetString(5)
                found = 1
            Loop
            'reader.Close()
            conn.Close()

            Label3.Text = resp

        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
        '************************************************
        Try

            qry = "Select TITLE,RESOURCE,date FROM PROGRAM WHERE DEPARTMENT=" + "'" + Label1.Text + "'" + " AND SEMESTER=" + "'" + Label2.Text + "'" + " and programname=" + "'" + Label5.Text + "'"
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            reader = cmd1.ExecuteReader()
            Dim title As String
            Dim dt As String
            '    Dim resp As String

            Do While reader.Read()
                title = reader.GetString(0)
                dt = reader.GetString(2)
                '  resp = reader.GetString(1)
                found = 1
            Loop
            'reader.Close()
            conn.Close()

            Label6.Text = title
            Label4.Text = dt

        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try


        ' ''************************************************************
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

            Label37.Text = Val(Session("p1")) * 100 / 3
            Label37.Text = Label37.Text + "%"

            Label38.Text = Val(Session("a1")) * 100 / 3
            Label38.Text = Label38.Text + "%"

            Label39.Text = Val(Session("g1")) * 100 / 3
            Label39.Text = Label39.Text + "%"

            Label40.Text = Val(Session("ex1")) * 100 / 3
            Label40.Text = Label40.Text + "%"

            ''''''''''''''''''''''''''''''''''''''''
            Label41.Text = Val(Session("p2")) * 100 / 3
            Label41.Text = Label41.Text + "%"

            Label42.Text = Val(Session("a2")) * 100 / 3
            Label42.Text = Label42.Text + "%"

            Label43.Text = Val(Session("g2")) * 100 / 3
            Label43.Text = Label43.Text + "%"

            Label44.Text = Val(Session("ex2")) * 100 / 3
            Label44.Text = Label44.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Label45.Text = Val(Session("p3")) * 100 / 3
            Label45.Text = Label45.Text + "%"

            Label46.Text = Val(Session("a3")) * 100 / 3
            Label46.Text = Label46.Text + "%"

            Label47.Text = Val(Session("g3")) * 100 / 3
            Label47.Text = Label47.Text + "%"

            Label48.Text = Val(Session("ex3")) * 100 / 3
            Label48.Text = Label48.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Label49.Text = Val(Session("p4")) * 100 / 3
            Label49.Text = Label49.Text + "%"

            Label50.Text = Val(Session("a4")) * 100 / 3
            Label50.Text = Label50.Text + "%"

            Label51.Text = Val(Session("g4")) * 100 / 3
            Label51.Text = Label51.Text + "%"

            Label52.Text = Val(Session("ex4")) * 100 / 3
            Label52.Text = Label52.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Label53.Text = Val(Session("p5")) * 100 / 3
            Label53.Text = Label53.Text + "%"

            Label54.Text = Val(Session("a5")) * 100 / 3
            Label54.Text = Label54.Text + "%"

            Label55.Text = Val(Session("g5")) * 100 / 3
            Label55.Text = Label55.Text + "%"

            Label56.Text = Val(Session("ex5")) * 100 / 3
            Label56.Text = Label56.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Label57.Text = Val(Session("p6")) * 100 / 3
            Label57.Text = Label57.Text + "%"

            Label58.Text = Val(Session("a6")) * 100 / 3
            Label58.Text = Label58.Text + "%"

            Label59.Text = Val(Session("g6")) * 100 / 3
            Label59.Text = Label59.Text + "%"

            Label60.Text = Val(Session("ex6")) * 100 / 3
            Label60.Text = Label60.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Label61.Text = Val(Session("p7")) * 100 / 3
            Label61.Text = Label61.Text + "%"

            Label62.Text = Val(Session("a7")) * 100 / 3
            Label62.Text = Label62.Text + "%"

            Label63.Text = Val(Session("g7")) * 100 / 3
            Label63.Text = Label63.Text + "%"

            Label64.Text = Val(Session("ex7")) * 100 / 3
            Label64.Text = Label64.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Label65.Text = Val(Session("p8")) * 100 / 3
            Label65.Text = Label65.Text + "%"

            Label66.Text = Val(Session("a8")) * 100 / 3
            Label66.Text = Label66.Text + "%"

            Label67.Text = Val(Session("g8")) * 100 / 3
            Label67.Text = Label67.Text + "%"

            Label68.Text = Val(Session("ex8")) * 100 / 3
            Label68.Text = Label68.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Label69.Text = Val(Session("p9")) * 100 / 3
            Label69.Text = Label69.Text + "%"

            Label70.Text = Val(Session("a9")) * 100 / 3
            Label70.Text = Label70.Text + "%"

            Label71.Text = Val(Session("g9")) * 100 / 3
            Label71.Text = Label71.Text + "%"

            Label72.Text = Val(Session("ex9")) * 100 / 3
            Label72.Text = Label72.Text + "%"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Label73.Text = Val(Session("p10")) * 100 / 3
            Label73.Text = Label73.Text + "%"

            Label74.Text = Val(Session("a10")) * 100 / 3
            Label74.Text = Label74.Text + "%"

            Label75.Text = Val(Session("g10")) * 100 / 3
            Label75.Text = Label75.Text + "%"

            Label76.Text = Val(Session("ex10")) * 100 / 3
            Label76.Text = Label76.Text + "%"

        Catch ex As Exception
            Label36.Text = ex.ToString()
        End Try
    End Sub
End Class
