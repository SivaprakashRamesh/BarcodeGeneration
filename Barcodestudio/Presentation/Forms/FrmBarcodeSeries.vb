Imports CrystalDecisions.CrystalReports.Engine
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports System.IO
'Imports BarcodeLib.Barcode.Linear
'Imports Limilabs.Barcode
Imports Zen.Barcode
Imports System.Drawing.Printing

Public Class FrmBarcodeSeries

#Region "Declaration"
    Public selecteditems As String
    Dim oldsearch As String = ""
    Dim oldsrow As Integer = 0
    Dim dtrow As DataRow
    Friend TextToBePrinted As String
#End Region

#Region "User Function"

    Sub FunPrintByPRN()
        Try
            selecteditems = ""
            For i As Integer = 0 To dgvbseries.RowCount - 1
                If dgvbseries(1, i).Value = True Then
                    selecteditems += "'" + dgvbseries(2, i).Value + "', "
                End If
            Next
            If selecteditems <> "" Then
                selecteditems = selecteditems.Substring(0, selecteditems.Length() - 2).Trim()
                dt4 = New DataTable
                dt4 = objApp.FunFillDT("select DistNumber BARCODE,convert(decimal(18,2),isnull(u_mrp,0)) 'PRICE', (select itemname from oitm where itemcode = a.itemcode) 'itemname' , itemcode ,(select U_brand from oitm where itemcode = a.itemcode) 'BRAND', isnull((select U_o7_color from oitm where itemcode = a.itemcode),'') 'COLOR', isnull((select SWW from oitm where itemcode = a.itemcode),'') 'MODEL', isnull((select U_o8_siz from oitm where itemcode = a.itemcode),'') 'SIZE'  from OSRN a where DistNumber in (" + selecteditems + ")")

                TextToBePrinted = ""
                Dim barcode, brand, color, model, size, price, total_label As String
                barcode = "" : brand = "" : color = "" : size = "" : price = "" : total_label = ""
                For i As Integer = 0 To dt4.Rows.Count - 1
                    barcode = dt4.Rows(i).Item("BARCODE").ToString()
                    brand = dt4.Rows(i).Item("BRAND").ToString()
                    color = dt4.Rows(i).Item("COLOR").ToString()
                    model = dt4.Rows(i).Item("MODEL").ToString()
                    size = dt4.Rows(i).Item("SIZE").ToString()
                    price = dt4.Rows(i).Item("PRICE").ToString()
                    total_label = dt4.Rows.Count.ToString()
                    'total_label = (i + 1).ToString()
                    TextToBePrinted = objApp.FunGetPrintLableText(barcode, brand, color, model, size, price, total_label)


                    Dim s As String = TextToBePrinted
                    Dim printerSetting As PrinterSettings = New PrinterSettings()
                    RawPrinterHelper.SendStringToPrinter(printerSetting.PrinterName, s)

                    'Dim pd As PrintDialog = New PrintDialog()
                    'pd.PrinterSettings = New PrinterSettings()

                    'If DialogResult.OK = pd.ShowDialog(Me) Then
                    '    RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s)
                    'End If

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub FunPrintByCrystal()
        Try
            FunBarcodePreview()
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize

            rpt.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub FunBarcodePreview()
        Try
            selecteditems = ""
            For i As Integer = 0 To dgvbseries.RowCount - 1
                If dgvbseries(1, i).Value = True Then
                    selecteditems += "'" + dgvbseries(2, i).Value + "', "
                End If
            Next
            If selecteditems <> "" Then
                selecteditems = selecteditems.Substring(0, selecteditems.Length() - 2).Trim()
                dt4 = New DataTable
                dt4 = objApp.FunFillDT("select DistNumber BARCODE,convert(decimal(18,2),isnull(u_mrp,0)) 'MRP', (select itemname from oitm where itemcode = a.itemcode) 'itemname' , itemcode ,(select U_brand from oitm where itemcode = a.itemcode) 'FIRMCODE', isnull((select U_o7_color from oitm where itemcode = a.itemcode),'') 'COLOR', isnull((select SWW from oitm where itemcode = a.itemcode),'') 'SWW', isnull((select U_o8_siz from oitm where itemcode = a.itemcode),'') 'SIZE'  from OSRN a where DistNumber in (" + selecteditems + ")")

                If dt4.Rows.Count > 0 Then
                    FunCrystalDt()
                    For i As Integer = 0 To dt4.Rows.Count - 1

                        Dim maxheight As Integer = 25
                        Dim barcode128 As Code128BarcodeDraw = BarcodeDrawFactory.Code128WithChecksum
                        Dim img As Image = barcode128.Draw(dt4.Rows(i).Item("BARCODE").ToString(), maxheight)
                        Dim converter As ImageConverter = New ImageConverter()
                        Dim barcodevalue As Byte() = CType(converter.ConvertTo(img, GetType(Byte())), Byte())

                        'Dim barcode1 As Barcode128
                        'barcode1 = BarcodeFactory.GetBarcode(Symbology.Code128)
                        'barcode1.Number = dt4.Rows(i).Item("BARCODE")
                        'barcode1.ChecksumAdd = True
                        'barcode1.ChecksumVisible = True
                        'barcode1.Height = 33
                        'barcode1.FontHeight = 0.15
                        'barcode1.NarrowBarWidth = 1
                        'barcode1.Rotation = RotationType.Degrees0
                        'barcode1.CustomText = ""
                        'Dim bitmap As Bitmap = barcode1.Render()
                        'Dim converter As ImageConverter = New ImageConverter()
                        'Dim barcodevalue As Byte() = CType(converter.ConvertTo(bitmap, GetType(Byte())), Byte())

                        'Dim barcode1 As Linear
                        'barcode1 = New Linear
                        'barcode1.Type = BarcodeType.CODE128
                        'barcode1.UOM = UnitOfMeasure.Pixel
                        'barcode1.BarWidth = 1
                        'barcode1.BarHeight = 80
                        'barcode1.LeftMargin = 10
                        'barcode1.TopMargin = 10
                        'barcode1.ShowText = False
                        'barcode1.Data = dt4.Rows(i).Item("BARCODE")
                        'Dim barcodevalue As Byte() = barcode1.drawBarcodeAsBytes

                        dtrow = dt1.NewRow
                        dtrow("BARCODE") = barcodevalue
                        dtrow("BARCODETEXT") = dt4.Rows(i).Item("BARCODE")
                        dtrow("FIRMCODE") = dt4.Rows(i).Item("FIRMCODE")
                        dtrow("COLOR") = dt4.Rows(i).Item("COLOR")
                        dtrow("SWW") = dt4.Rows(i).Item("SWW")
                        dtrow("SIZE") = dt4.Rows(i).Item("SIZE")
                        dtrow("MRP") = dt4.Rows(i).Item("MRP")

                        dt1.Rows.Add(dtrow)
                    Next

                    rpt = New ReportDocument
                    rpt.Load(Application.StartupPath & "\Barcode.rpt")
                    rpt.SetDataSource(dt1)
                    rptviewer.ReportSource = rpt
                    rptviewer.Refresh()
                End If
            Else
                MsgBox("No Record Is Selected", MsgBoxStyle.Exclamation, "Not Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub FunExportToExcel()
        Try
            Dim xls As New Excel.Application
            Dim xlsWorkBook As Excel.Workbook
            Dim xlsWorkSheet As Excel.Worksheet
            Dim resourcesFolder = Application.StartupPath + "\Excel"
            Dim di As DirectoryInfo = New DirectoryInfo(resourcesFolder)
            Dim misValue As Object = System.Reflection.Missing.Value
            If Not di.Exists Then
                di.Create()
            End If
            xlsWorkBook = xls.Workbooks.Add(misValue)
            xlsWorkSheet = xlsWorkBook.Worksheets(1)
            xlsWorkSheet.Name = "Barcode_Serial"

            Try
                Dim xlsWorkSheet1 As Excel.Worksheet = xlsWorkBook.Worksheets(2)
                xlsWorkSheet1.Delete()
            Catch ex As Exception

            End Try
            Try
                Dim xlsWorkSheet2 As Excel.Worksheet = xlsWorkBook.Worksheets("Sheet3")
                xlsWorkSheet2.Delete()
            Catch ex As Exception

            End Try

            Dim style As Excel.Style = xlsWorkSheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
            style.Font.Bold = True
            style.Font.Size = 12
            style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DodgerBlue)
            style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
            style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            style.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            xlsWorkSheet.Cells(1, 1) = "S.No"
            xlsWorkSheet.Cells(1, 2) = "Serial/Barcode"
            xlsWorkSheet.Cells(1, 3) = "MRP"
            xlsWorkSheet.Cells(1, 4) = "Item Name"
            xlsWorkSheet.Cells(1, 5) = "Item Code"

            xlsWorkSheet.Cells(1, 1).Style = "NewStyle"
            xlsWorkSheet.Cells(1, 2).Style = "NewStyle"
            xlsWorkSheet.Cells(1, 3).Style = "NewStyle"
            xlsWorkSheet.Cells(1, 4).Style = "NewStyle"
            xlsWorkSheet.Cells(1, 5).Style = "NewStyle"

            Dim range As Integer = 5 * dgvbseries.RowCount
            Dim rand As New Random
            Dim rno As Integer = 1
            For i As Integer = 0 To dgvbseries.RowCount - 1
                If dgvbseries(1, i).Value = True Then
                    rno = rno + 1
                    xlsWorkSheet.Cells(rno, 1) = rno
                    xlsWorkSheet.Cells(rno, 2) = dgvbseries.Rows(i).Cells(2).Value.ToString()
                    xlsWorkSheet.Cells(rno, 3) = dgvbseries.Rows(i).Cells(3).Value.ToString()
                    xlsWorkSheet.Cells(rno, 4) = dgvbseries.Rows(i).Cells(4).Value.ToString()
                    xlsWorkSheet.Cells(rno, 5) = dgvbseries.Rows(i).Cells(5).Value.ToString()
                End If
            Next
            Using sfd As New SaveFileDialog
                sfd.FileName = "Barcode Serial " + DateTime.Now().Day.ToString() + DateTime.Now().Month.ToString() + DateTime.Now().Year.ToString() + "_" + DateTime.Now().Hour.ToString() + DateTime.Now().Minute.ToString() + DateTime.Now().Second.ToString()
                sfd.Filter = "Execl files | *.xls, *.xlsx"
                sfd.Title = "Save Sample"
                sfd.InitialDirectory = resourcesFolder
                If sfd.ShowDialog() = DialogResult.OK Then
                    xlsWorkBook.SaveAs(sfd.FileName)
                End If
            End Using
            xlsWorkBook.Close()
            xls.Quit()
            Marshal.FinalReleaseComObject(xlsWorkSheet)
            Marshal.FinalReleaseComObject(xlsWorkBook)
            Marshal.FinalReleaseComObject(xls)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Function FunLoadSeriesLine() As Boolean
        Try
            rptviewer.ReportSource = Nothing
            dgvbseries.ColumnCount = 6
            dgvbseries.ColumnHeadersVisible = True

            ' Set the column header style.
            Dim columnHeaderStyle As DataGridViewCellStyle = New DataGridViewCellStyle()

            columnHeaderStyle.BackColor = Color.Beige
            columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
            dgvbseries.ColumnHeadersDefaultCellStyle = columnHeaderStyle

            ' Set the column header names.
            dgvbseries.Columns(0).Name = "S.No"
            dgvbseries.Columns(1).Name = "Select"
            dgvbseries.Columns(2).Name = "Serial/Barcode"
            dgvbseries.Columns(3).Name = "MRP"
            dgvbseries.Columns(4).Name = "Item Name"
            dgvbseries.Columns(5).Name = "Item Code"

            dgvbseries.Columns(0).ReadOnly = True
            dgvbseries.Columns(2).ReadOnly = True
            dgvbseries.Columns(3).ReadOnly = True
            dgvbseries.Columns(4).ReadOnly = True
            dgvbseries.Columns(5).ReadOnly = True

            dgvbseries.Columns(0).FillWeight = 70
            dgvbseries.Columns(0).Width = 70
            dgvbseries.Columns(1).FillWeight = 70
            dgvbseries.Columns(1).Width = 70
            dgvbseries.Columns(2).FillWeight = 150
            dgvbseries.Columns(2).Width = 150
            dgvbseries.Columns(3).FillWeight = 100
            dgvbseries.Columns(3).Width = 100
            dgvbseries.Columns(5).FillWeight = 100
            dgvbseries.Columns(5).Width = 100

            selecteditems = ""
            For i As Integer = 0 To FrmDoubleBarcode.dgvgrnline.RowCount - 1
                If FrmDoubleBarcode.dgvgrnline(1, i).Value = True Then
                    selecteditems += "'" + FrmDoubleBarcode.dgvgrnline(2, i).Value + "', "
                End If
            Next

            If selecteditems <> "" Then
                selecteditems = selecteditems.Substring(0, selecteditems.Length() - 2).Trim()
                dt1 = New DataTable
                'strquery = "select DistNumber 'Barcode',convert(decimal(18,2),isnull(u_mrp,0)) 'MRP', (select itemname from oitm where itemcode = a.itemcode) 'Item Name' , itemcode 'Item Code',(select FirmCode from oitm where itemcode = a.itemcode) 'Firm Code', isnull((select U_o7_color from oitm where itemcode = a.itemcode),'') 'Color', isnull((select SWW from oitm where itemcode = a.itemcode),'') 'SWW', isnull((select U_o8_siz from oitm where itemcode = a.itemcode),'') 'Size'  from OSRN a where ItemCode in (" + selecteditems + ")"
                strquery = " SELECT "
                strquery += " T5.[DistNumber] 'BARCODE',"
                strquery += " convert(decimal(18,2),isnull(T5.[u_mrp],0)) 'PRICE',"
                strquery += " T2.[ItemName] 'ITEM NAME',"
                strquery += " T2.[ItemCode] 'ITEM CODE',"
                strquery += " T2.[U_brand] 'BRAND',"
                strquery += " T2.[U_o7_color] 'COLOR',"
                strquery += " T2.[SWW] 'MODEL',"
                strquery += " T2.[U_o8_siz] 'SIZE'"
                strquery += " FROM"
                strquery += " OPDN T0"
                strquery += " INNER JOIN PDN1 T1 ON T0.DocEntry = T1.DocEntry"
                strquery += " INNER JOIN OITM T2 ON T1.ItemCode = T2.ItemCode"
                strquery += " INNER JOIN OITL T3 ON T3.DocEntry = T0.DocEntry AND T3.DocType = T0.ObjType AND T3.DocLine = T1.LineNum"
                strquery += " LEFT JOIN ITL1 T4 ON T3.LogEntry = T4.LogEntry"
                strquery += " LEFT JOIN OSRN T5 ON T4.MdAbsEntry = T5.AbsEntry"
                strquery += " WHERE"
                strquery += " T0.DocEntry = '" + FrmDoubleBarcode.txtdocentry.Text.Trim() + "' and"
                strquery += " T1.[ItemCode] in (" + selecteditems + ")"
                dt1 = objApp.FunFillDT(strquery)

                If dt1.Rows.Count > 0 Then
                    dgvbseries.Rows.Clear()
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        dgvbseries.Rows.Add()
                        dgvbseries.Rows(i).Cells(0).Value = i + 1
                        Try
                            Dim CheckBoxCell As DataGridViewCheckBoxCell = New DataGridViewCheckBoxCell()
                            CheckBoxCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                            dgvbseries(1, i) = CheckBoxCell
                            If dropfullpartial.SelectedItem = "Full" Then
                                dgvbseries(1, i).Value = True
                            End If
                        Catch ex As Exception

                        End Try
                        dgvbseries.Rows(i).Cells(2).Value = dt1(i)(0)
                        dgvbseries.Rows(i).Cells(3).Value = dt1(i)(1)
                        dgvbseries.Rows(i).Cells(4).Value = dt1(i)(2)
                        dgvbseries.Rows(i).Cells(5).Value = dt1(i)(3)
                    Next
                Else
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try
    End Function

    Sub FunGridCheck(ByVal gridcheck As Boolean)
        Try
            For i As Integer = 0 To dgvbseries.RowCount - 1
                dgvbseries(1, i).Value = gridcheck
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub FunSearch()
        Try
            If txtsearch.Text.Trim() <> "" Then
                If Not txtsearch.Text = oldsearch Then
                    oldsrow = 0
                End If
                If oldsrow = dgvbseries.RowCount Then
                    oldsearch = ""
                End If
                For i As Integer = oldsrow To dgvbseries.RowCount - 1
                    If dgvbseries.Rows(i).Cells(2).Value.ToString.ToLower.Contains(txtsearch.Text.ToLower) Then
                        dgvbseries.Rows(i).Selected = True
                        dgvbseries.CurrentCell = dgvbseries.Item(2, i)
                        oldsearch = txtsearch.Text
                        oldsrow = i + 1
                        Exit For
                    Else
                        oldsearch = ""
                        dgvbseries.CurrentCell = Nothing
                    End If
                Next
            Else
                dgvbseries.CurrentCell = Nothing
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
                .Add("FIRMCODE", GetType(String))
                .Add("COLOR", GetType(String))
                .Add("SWW", GetType(String))
                .Add("SIZE", GetType(String))
                .Add("MRP", GetType(Double))
            End With
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Try
            stage.Controls.Clear()
            stage.Controls.Add(FrmDoubleBarcode.pnldouble)
            FrmDoubleBarcode.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub dgvbseries_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvbseries.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dropfullpartial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropfullpartial.SelectedIndexChanged
        Try
            If dropfullpartial.SelectedIndex = 0 Then
                FunGridCheck(True)
            Else
                FunGridCheck(False)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtsearch.Text <> "" Then
                    FunSearch()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        FunSearch()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        'FunPrintByCrystal()
        FunPrintByPRN()
    End Sub

    Private Sub btnpreview_Click(sender As Object, e As EventArgs) Handles btnpreview.Click
        FunBarcodePreview()
    End Sub

    Private Sub btnexexcel_Click(sender As Object, e As EventArgs) Handles btnexexcel.Click
        FunExportToExcel()
    End Sub

    'Private Sub PrintPageHandler(ByVal sender As Object, _
    ' ByVal args As Printing.PrintPageEventArgs)
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