Imports System.Data
Imports System.Data.SqlClient
Partial Class viewrepo1
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 As Integer
    Dim g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 As Integer
    Dim ex1, ex2, ex3, ex4, ex5, ex6, ex7, ex8, ex9, ex10 As Integer
    Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 As Integer
    Dim p, g, a, ex As Integer
    Dim qry As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dep As String = Session("dep")
        Dim sem As String = Session("sem")

        Dim pn As String = Session("pn")

        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
        Try
            qry = "select * from student where department=" + "'" + dep + "'" + " and semester=" + "'" + sem + "'" + " and programname=" + "'" + pn + "'"
            Response.Write("<br><br><br><br><br><br>" + qry)

            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()
            Dim uname As String
            uname = ""
            Dim CNT As Integer

            reader = cmd1.ExecuteReader()
            Dim Q1 As Integer
            Q1 = 0
            Do While reader.Read()

                '    Response.Write("tst1")


                If ((reader("parameter1") = "POOR")) Then
                    p1 = p1 + 1
                    '   Response.Write("tstpoor")
                ElseIf ((reader("parameter1") = "EXCELLENT")) Then
                    ex1 = ex1 + 1
                    '        Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter1") = "GOOD")) Then
                    g1 = g1 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter1") = "AVERAGE")) Then
                    a1 = a1 + 1
                    '  Response.Write("tstex")
                    'End If


                End If


                '''''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter2") = "POOR")) Then
                    p2 = p2 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter2") = "EXCELLENT")) Then
                    ex2 = ex2 + 1
                    '       Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter2") = "GOOD")) Then
                    g2 = g2 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter2") = "AVERAGE")) Then
                    a2 = a2 + 1
                    ' Response.Write("tstex")



                End If

                ''''''''''''''''''''''''''''''''''''''

                If ((reader("parameter3") = "POOR")) Then
                    p3 = p3 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter3") = "EXCELLENT")) Then
                    ex3 = ex3 + 1
                    '      Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter3") = "GOOD")) Then
                    g3 = g3 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter3") = "AVERAGE")) Then
                    a3 = a3 + 1
                    '   Response.Write("tstex")



                End If

                ''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter4") = "POOR")) Then
                    p4 = p4 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter4") = "EXCELLENT")) Then
                    ex4 = ex4 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter4") = "GOOD")) Then
                    g4 = g4 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter4") = "AVERAGE")) Then
                    a4 = a4 + 1
                    '   Response.Write("tstex")



                End If


                '''''''''''''''''''''''''''

                If ((reader("parameter5") = "POOR")) Then
                    p5 = p5 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter5") = "EXCELLENT")) Then
                    ex5 = ex5 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter5") = "GOOD")) Then
                    g5 = g5 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter5") = "AVERAGE")) Then
                    a5 = a5 + 1
                    '   Response.Write("tstex")



                End If

                '''''''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter6") = "POOR")) Then
                    p6 = p6 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter6") = "EXCELLENT")) Then
                    ex6 = ex6 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter6") = "GOOD")) Then
                    g6 = g6 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter6") = "AVERAGE")) Then
                    a6 = a6 + 1
                    '   Response.Write("tstex")



                End If







                '''''''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter7") = "POOR")) Then
                    p7 = p7 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter7") = "EXCELLENT")) Then
                    ex7 = ex7 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter7") = "GOOD")) Then
                    g7 = g7 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter7") = "AVERAGE")) Then
                    a8 = a8 + 1
                    '   Re8sponse.Write("tstex")



                End If




                '''''''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter8") = "POOR")) Then
                    p8 = p8 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter8") = "EXCELLENT")) Then
                    ex8 = ex8 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter8") = "GOOD")) Then
                    g8 = g8 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter8") = "AVERAGE")) Then
                    a8 = a8 + 1
                    '   Response.Write("tstex")



                End If
                ''''''''''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter9") = "POOR")) Then
                    p9 = p9 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter9") = "EXCELLENT")) Then
                    ex9 = ex9 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter9") = "GOOD")) Then
                    g9 = g9 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter9") = "AVERAGE")) Then
                    a9 = a9 + 1
                    '   Response.Write("tstex")



                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''
                If ((reader("parameter10") = "POOR")) Then
                    p10 = p10 + 1
                    '  Response.Write("tstpoor")
                ElseIf ((reader("parameter10") = "EXCELLENT")) Then
                    ex10 = ex10 + 1
                    '   Response.Write("tstex")
                    'End If
                ElseIf ((reader("parameter10") = "GOOD")) Then
                    g10 = g10 + 1
                    ' Response.Write("tstpoor")
                ElseIf ((reader("parameter10") = "AVERAGE")) Then
                    a10 = a10 + 1
                    '   Response.Write("tstex")



                End If

                CNT = CNT + 1
            Loop


            'Dim pavg As Integer
            'Dim exavg As Integer
            'Dim aavg As Integer
            'Dim gavg As Integer
            'Response.Write("<br>p1=" + Str(p1))
            'Response.Write("<br>ex1=" + Str(ex1))
            'Response.Write("<br>g1=" + Str(g1))
            'Response.Write("<br>a1=" + Str(a1))

            'Response.Write("<br>p2=" + Str(p2))
            'Response.Write("<br>ex2=" + Str(ex2))
            'Response.Write("<br>g2=" + Str(g2))
            'Response.Write("<br>a2=" + Str(a2))


            'Response.Write("<br>P2=" + Str(p2))
            'Response.Write("<br>P3=" + Str(p3))
            'Response.Write("<br>p4=" + Str(p4))
            'Response.Write("<br>P5=" + Str(p5))
            'Response.Write("<br>P6=" + Str(p6))
            'Response.Write("<br>p7=" + Str(p7))
            'Response.Write("<br>P8=" + Str(p8))
            'Response.Write("<br>P9=" + Str(p9))
            'Response.Write("<br>P10=" + Str(p10))


            'pavg = p / CNT
            'exavg = ex / CNT
            'gavg = g / CNT
            'aavg = a / CNT
            'Response.Write("p=" + Str(pavg) + "," + "ex=" + Str(exavg) + "g=" + Str(gavg) + "," + "av=" + Str(aavg))
            reader.Close()
            conn.Close()
            Session("p1") = Str(p1)
            Session("a1") = Str(a1)
            Session("g1") = Str(g1)
            Session("ex1") = Str(ex1)


            Session("p2") = Str(p2)
            Session("a2") = Str(a2)
            Session("g2") = Str(g2)
            Session("ex2") = Str(ex2)

            Session("p3") = Str(p3)
            Session("a3") = Str(a3)
            Session("g3") = Str(g3)
            Session("ex3") = Str(ex3)

            Session("p4") = Str(p4)
            Session("a4") = Str(a4)
            Session("g4") = Str(g4)
            Session("ex4") = Str(ex4)

            Session("p5") = Str(p5)
            Session("a5") = Str(a5)
            Session("g5") = Str(g5)
            Session("ex5") = Str(ex5)


            Session("p6") = Str(p6)
            Session("a6") = Str(a6)
            Session("g6") = Str(g6)
            Session("ex6") = Str(ex6)


            Session("p7") = Str(p7)
            Session("a7") = Str(a7)
            Session("g7") = Str(g7)
            Session("ex7") = Str(ex7)

            Session("p8") = Str(p8)
            Session("a8") = Str(a8)
            Session("g8") = Str(g8)
            Session("ex8") = Str(ex8)

            Session("p9") = Str(p9)
            Session("a9") = Str(a9)
            Session("g9") = Str(g9)
            Session("ex9") = Str(ex9)

            Session("p10") = Str(p10)
            Session("a10") = Str(a10)
            Session("g10") = Str(g10)
            Session("ex10") = Str(ex10)


            Session("cnt") = Str(CNT)

            'Session("p9") = Str(p9)
            'Session("p10") = Str(p10)

            'Session("ex1") = Str(p1)
            'Session("ex2") = Str(p2)
            'Session("ex3") = Str(p3)
            'Session("ex4") = Str(p4)
            'Session("ex5") = Str(p5)
            'Session("ex6") = Str(p6)
            'Session("ex7") = Str(p7)
            'Session("ex8") = Str(p8)
            'Session("ex9") = Str(p9)
            'Session("ex10") = Str(p10)

            'Response.Write("<br>p1=" + Str(p1))
            'Response.Write("<br>a1=" + Str(a1))
            'Response.Write("<br>ex1=" + Str(ex1))
            'Response.Write("<br>g1=" + Str(g1))

            'Response.Write("<br>p2=" + Str(p2))
            'Response.Write("<br>a2=" + Str(a2))
            'Response.Write("<br>ex2=" + Str(ex2))
            'Response.Write("<br>g2=" + Str(g2))


            'Response.Write("p1=" + Str(p2))
            'Response.Write("ex1=" + Str(ex1))
            'Response.Write("ex1=" + Str(ex2))
            Response.Redirect("viewrepo2.aspx")


        Catch ex As Exception
            Response.Write(ex)
        End Try


    End Sub
End Class
