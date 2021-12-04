Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Module ModGlobal
#Region "Declaration"
    Public objApp As clsApplication = New clsApplication()
    Public Servername, DBName, UserID, Password As String
    Public con As SqlConnection
    Public da As SqlDataAdapter
    Public dt, dt1, dt2, dt3, dt4 As DataTable
    Public ds As DataSet
    Public dv As DataView
    Public strquery As String
    Public stage = FrmDoubleBarcode.pnlmain
    Public colvalue() As String
    Public rpt As ReportDocument
#End Region
#Region "Main Function"
    Sub Main()

    End Sub
#End Region
End Module
