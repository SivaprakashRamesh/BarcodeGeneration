Imports CrystalDecisions.CrystalReports.Engine
'Imports BarcodeLib.Barcode.Linear
Imports Zen.Barcode
Imports System.IO
Imports Microsoft.Win32.SafeHandles
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing

Public Class FrmSingleBarcode

#Region "Declaration"
    Dim dtrow As DataRow
    Dim TextToBePrinted As String
#End Region

#Region "User Function"
    Sub FunLoadCrystal()
        Try
            dt4 = New DataTable
            dt4 = objApp.FunFillDT("select DistNumber BARCODE,convert(decimal(18,2),isnull(u_mrp,0)) 'PRICE', (select itemname from oitm where itemcode = a.itemcode) 'itemname' , itemcode ,(select U_brand from oitm where itemcode = a.itemcode) 'BRAND', isnull((select U_o7_color from oitm where itemcode = a.itemcode),'') 'COLOR', isnull((select SWW from oitm where itemcode = a.itemcode),'') 'MODEL', isnull((select U_o8_siz from oitm where itemcode = a.itemcode),'') 'SIZE'  from OSRN a where DistNumber = '" + txtsearch.Text + "'")

            If dt4.Rows.Count > 0 Then
                FunCrystalDt()

                Dim maxheight As Integer = 25
                Dim barcode128 As Code128BarcodeDraw = BarcodeDrawFactory.Code128WithChecksum
                Dim img As Image = barcode128.Draw(dt4.Rows(0).Item("BARCODE").ToString(), maxheight)
                Dim converter As ImageConverter = New ImageConverter()
                Dim barcodevalue As Byte() = CType(converter.ConvertTo(img, GetType(Byte())), Byte())

                'Dim barcode1 As Linear
                'barcode1 = New Linear
                'barcode1.Type = BarcodeType.CODE128
                'barcode1.UOM = UnitOfMeasure.Pixel
                'barcode1.BarWidth = 1
                'barcode1.BarHeight = 80
                'barcode1.LeftMargin = 10
                'barcode1.TopMargin = 10
                'barcode1.ShowText = False
                'barcode1.Data = dt4.Rows(0).Item("BARCODE")
                'Dim barcodevalue As Byte() = barcode1.drawBarcodeAsBytes

                dtrow = dt1.NewRow
                dtrow("BARCODE") = barcodevalue
                dtrow("BARCODETEXT") = dt4.Rows(0).Item("BARCODE")
                dtrow("BRAND") = dt4.Rows(0).Item("BRAND")
                dtrow("COLOR") = dt4.Rows(0).Item("COLOR")
                dtrow("MODEL") = dt4.Rows(0).Item("MODEL")
                dtrow("SIZE") = dt4.Rows(0).Item("SIZE")
                dtrow("PRICE") = dt4.Rows(0).Item("PRICE")

                dt1.Rows.Add(dtrow)

                rpt = New ReportDocument
                rpt.Load(Application.StartupPath & "\Barcode.rpt")
                rpt.SetDataSource(dt1)
                rptviewer.ReportSource = rpt
                rptviewer.Refresh()
                btnprint.Enabled = True
            Else
                MsgBox("Invalid Barcode Serial", MsgBoxStyle.Exclamation, "No Barcode Found")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub FunCrystalDt()
        Try
            dt1 = New DataTable
            With dt1.Columns
                .Add("BARCODE", GetType(Byte()))
                .Add("BARCODETEXT", GetType(String))
                .Add("BRAND", GetType(String))
                .Add("COLOR", GetType(String))
                .Add("MODEL", GetType(String))
                .Add("SIZE", GetType(String))
                .Add("PRICE", GetType(Double))
            End With
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub FunClearAll()
        Try
            txtsearch.Text = ""
            rptviewer.ReportSource = Nothing
            btnprint.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Sub FunPrintByPRN()
        Dim result As DialogResult = MessageBox.Show("Are You Want To Print This ?", "Print", MessageBoxButtons.YesNoCancel)


        If result = Windows.Forms.DialogResult.Yes Then
            'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'rpt.PrintToPrinter(1, False, 0, 0)
            Dim barcode, brand, color, model, size, price, total_label As String
            barcode = "" : brand = "" : color = "" : size = "" : price = "" : total_label = ""
            barcode = dt4.Rows(0).Item("BARCODE").ToString()
            brand = dt4.Rows(0).Item("BRAND").ToString()
            color = dt4.Rows(0).Item("COLOR").ToString()
            model = dt4.Rows(0).Item("MODEL").ToString()
            size = dt4.Rows(0).Item("SIZE").ToString()
            price = dt4.Rows(0).Item("PRICE").ToString()
            total_label = "1"
            TextToBePrinted = objApp.FunGetPrintLableText(barcode, brand, color, model, size, price, total_label)

            Dim s As String = TextToBePrinted
            Dim printerSetting As PrinterSettings = New PrinterSettings()
            RawPrinterHelper.SendStringToPrinter(printerSetting.PrinterName, s)
            Dim pd As PrintDialog = New PrintDialog()
            pd.PrinterSettings = New PrinterSettings()

            If DialogResult.OK = pd.ShowDialog(Me) Then
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s)
            End If

            'Dim prn As New Printing.PrintDocument
            'Using (prn)

            '    AddHandler prn.PrintPage, _
            '       AddressOf Me.PrintPageHandler
            '    prn.Print()
            '    RemoveHandler prn.PrintPage, _
            '       AddressOf Me.PrintPageHandler
            'End Using
        Else
            rptviewer.ReportSource = Nothing
            rptviewer.Refresh()
        End If
    End Sub

#End Region

#Region "Events"
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            FunPrintByPRN()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtsearch.Focus() = True Then
                    FunLoadCrystal()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    'Private Sub PrintPageHandler(ByVal sender As Object, _
    'ByVal args As Printing.PrintPageEventArgs)
    '    Try
    '        Dim myFont As New Font("Courier New", 9)
    '        args.Graphics.DrawString(TextToBePrinted, _
    '           New Font(myFont, FontStyle.Regular), _
    '           Brushes.Black, 50, 50)
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '    End Try

    'End Sub

#End Region

End Class