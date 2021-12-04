Imports System.Windows.Forms


Public Class dialogprinter

#Region "User Function"

    Sub FunLoadImage()
        picbox.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\logo.png")
        btnclose.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\closebtn.png")
    End Sub

    Sub FunLoadPrinter()
        cmbprinter.Items.Clear()
        For Each printer As String In Printing.PrinterSettings.InstalledPrinters
            cmbprinter.Items.Add(printer)
        Next printer
    End Sub

    Sub FunSetDefaultPrinter()
        If Me.cmbprinter.SelectedItem IsNot Nothing Then
            Dim strCurrPrinter As String
            Dim WsNetwork As Object
            Try
                strCurrPrinter = cmbprinter.SelectedItem
                WsNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

                WsNetwork.SetDefaultPrinter(strCurrPrinter)


            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub dialogprinter_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DialogPrinterSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunLoadImage()
        FunLoadPrinter()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        FunSetDefaultPrinter()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

End Class
