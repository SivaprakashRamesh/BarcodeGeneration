Imports System.Data.SqlClient
Public Class clsApplication
#Region "Declaration"

#End Region
#Region "User Functions"
    Public Function FunCheckLicense() As Boolean
        Try
            Dim TDate As String = Date.Today.ToString("yyyyMMdd")
            If TDate < "20211101" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try
    End Function
    Public Sub FunConnectDB()
        Try
            Dim objreader As System.IO.StreamReader = New System.IO.StreamReader(Application.StartupPath + "\DBInfo.ini")
            Do While Not objreader.EndOfStream
                Dim txtline As String = objreader.ReadLine().ToString().Trim()
                If txtline.StartsWith("Servername") Then
                    Servername = txtline.Substring(txtline.LastIndexOf(":") + 1).Trim()
                ElseIf txtline.StartsWith("DBName") Then
                    DBName = txtline.Substring(txtline.LastIndexOf(":") + 1).Trim()
                ElseIf txtline.StartsWith("USERID") Then
                    UserID = txtline.Substring(txtline.LastIndexOf(":") + 1).Trim()
                ElseIf txtline.StartsWith("PASSWORD") Then
                    Password = txtline.Substring(txtline.LastIndexOf(":") + 1).Trim()
                End If
            Loop
            If Not IsNothing(con) Then
                con = Nothing
            End If
            con = New SqlConnection("DATA SOURCE = '" + Servername + "'; INTEGRATED SECURITY = false; INITIAL CATALOG = '" + DBName + "'; USER ID ='" + UserID + "'; PASSWORD ='" + Password + "';")

            con.Open()
            con.Close()

        Catch ex As Exception
            MsgBox("Connection error Check service  : " + vbNewLine + ex.ToString(), , "SQL CONNCETION ERROR")
        End Try
    End Sub

    Public Function FunFillDT(ByVal str_query As String) As DataTable
        Try
            con.Open()
            dt = New DataTable
            da = New SqlDataAdapter(str_query, con)
            da.Fill(dt)
            con.Close()
        Catch ex As Exception
            MsgBox("Datatable error check query :" + vbNewLine + ex.ToString(), , "SQL DATATABLE ERROR")
        End Try
        Return dt
    End Function
    Public Function FunDateConvertion(ByVal date1 As String) As String
        Dim date2 As String = ""
        Try
            date2 = date1.Substring(6, 4) & date1.Substring(3, 2) & date1.Substring(0, 2) ' & "-" & date1.Substring(3, 2) & "-" & date1.Substring(6, 4)
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return date2
        End Try
        Return date2
    End Function

    Public Function FunGetPrintLableText(ByVal barcode, ByVal brand, ByVal color, ByVal model, ByVal size, ByVal price, ByVal PrintQty)
        Dim TextToBePrinted As String = ""

        TextToBePrinted = vbNewLine + "^XA"
        TextToBePrinted += vbNewLine + "^PRA "
        TextToBePrinted += vbNewLine + "^LH0,0^FS"
        TextToBePrinted += vbNewLine + "^LL260"
        TextToBePrinted += vbNewLine + "^MD17"
        TextToBePrinted += vbNewLine + "^MNY"
        TextToBePrinted += vbNewLine + "^LH0,0^FS"
        TextToBePrinted += vbNewLine + "^BY1,3.0^FO207,11^BCN,63,N,Y,N^FR^FD " + barcode + " ^FS"
        TextToBePrinted += vbNewLine + "^FO222,81^A0N,27,23^CI13^FR^FD " + barcode + " ^FS"
        TextToBePrinted += vbNewLine + "^FO25,15^A0N,24,21^CI13^FR^FD " + brand + " ^FS"
        TextToBePrinted += vbNewLine + "^FO25,48^A0N,24,21^CI13^FR^FD " + model + " ^FS"
        TextToBePrinted += vbNewLine + "^FO111,15^A0N,24,21^CI13^FR^FD " + color + " ^FS"
        TextToBePrinted += vbNewLine + "^FO93,48^A0N,24,21^CI13^FR^FD " + size + " ^FS"
        TextToBePrinted += vbNewLine + "^FO17,82^A0N,24,21^CI13^FR^FDMRP Rs.^FS"
        TextToBePrinted += vbNewLine + "^FO96,82^A0N,24,21^CI13^FR^FD " + price + " ^FS"
        TextToBePrinted += vbNewLine + "^PQ" + PrintQty + ",0,0,N"
        TextToBePrinted += vbNewLine + "^XZ"


        Return TextToBePrinted
    End Function
#End Region
End Class
