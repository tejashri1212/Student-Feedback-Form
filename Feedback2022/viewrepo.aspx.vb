Imports System.Data
Imports System.Data.SqlClient
Partial Class viewrepo
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

            qry = "Select distinct(programname) from PROGRAMNAME "
            Dim cmd1 As New SqlCommand(qry, conn)
            Dim found As Integer = 0
            Dim reader As SqlDataReader
            conn.Open()

            reader = cmd1.ExecuteReader()
            Do While reader.Read()
                DropDownList4.Items.Add(reader.GetString(0))
            Loop
            reader.Close()
            conn.Close()


        Catch ex As Exception
            ' Label1.Text = ex.ToString()
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DEP As String
        Dim SEM As String
        Dim PN As String

        DEP = DropDownList3.Text
        SEM = DropDownList2.Text
        PN = DropDownList4.Text


        Session("dep") = DEP
        Session("sem") = SEM
        Session("pn") = PN


        Response.Redirect("viewrepo1.aspx")
    End Sub
End Class
