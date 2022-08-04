Imports System.Data
Imports System.Data.SqlClient
Partial Class actdect1
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection()
    Dim adp As New SqlDataAdapter
    Dim adp1 As New SqlDataAdapter
    Dim qry As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcon As String = ConfigurationManager.ConnectionStrings("dbconnection").ConnectionString
        conn = New SqlConnection(strcon)
        Dim sno, st As String
        sno = Request.QueryString.Get(0)
        st = Request.QueryString.Get(0)
        Try

            If (st = "DE-ACTIVATE") Then
                qry = "update program set status='ACTIVE' where SNO=" + "'" + sno + "'"
            Else
                qry = "update program set status='DE-ACTIVE' where SNO=" + "'" + sno + "'"
            End If

            Dim cmd1 As New SqlCommand(qry, conn)
            adp.InsertCommand = cmd1
            conn.Open()
            adp.InsertCommand.ExecuteNonQuery()
            conn.Close()




            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
        Response.Write("<script>alert('Program Status Changed.... ');window.location='adminpage.aspx';</script>")
    End Sub
End Class
