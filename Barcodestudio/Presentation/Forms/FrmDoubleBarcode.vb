Public Class FrmDoubleBarcode

#Region "Declaration"
    Dim oldsearch As String = ""
    Dim oldsrow As Integer = 0
    Dim checkcount As Integer = 0
#End Region

#Region "User Functions"
    Sub FunClearAll()
        Try
            txtdate.Text = ""
            txtgrndocentry.Text = ""
            txtsearch.Text = ""
            txtsupplier.Text = ""
            btnnext.Enabled = False
            dropfullpartial.SelectedIndex = 0
            FrmSingleBarcode.txtsearch.Text = ""
            datefrom.Value = Date.Now().AddDays(-1)
            dateto.Value = Date.Now()
            txtgrndocentry.Focus()
            dgvgrnline.Rows.Clear()
            FrmBarcodeSeries.dgvbseries.Rows.Clear()
            stage.Controls.Clear()
            stage.Controls.Add(pnldouble)
            FrmBarcodeSeries.selecteditems = ""
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Function FunValidate() As Boolean
        Try
            Dim rtnval As Boolean = False
            For i As Integer = 0 To dgvgrnline.RowCount - 1
                If dgvgrnline(1, i).Value = True Then
                    rtnval = True
                    Exit For
                End If
            Next
            If rtnval = False Then
                MsgBox("No Line Item Is Selected", MsgBoxStyle.Exclamation, "Check Line Validation")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return False
        End Try
      
    End Function

    Sub FunLoadGrnLine()
        Try
            dgvgrnline.ColumnCount = 5
            dgvgrnline.ColumnHeadersVisible = True

            ' Set the column header style.
            Dim columnHeaderStyle As DataGridViewCellStyle = New DataGridViewCellStyle()

            columnHeaderStyle.BackColor = Color.Beige
            columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
            dgvgrnline.ColumnHeadersDefaultCellStyle = columnHeaderStyle

            ' Set the column header names.
            dgvgrnline.Columns(0).Name = "S.No"
            dgvgrnline.Columns(1).Name = "Select"
            dgvgrnline.Columns(2).Name = "Item Code"
            dgvgrnline.Columns(3).Name = "Item Name"
            dgvgrnline.Columns(4).Name = "Quantity"

            dgvgrnline.Columns(0).ReadOnly = True
            dgvgrnline.Columns(2).ReadOnly = True
            dgvgrnline.Columns(3).ReadOnly = True
            dgvgrnline.Columns(4).ReadOnly = True

            dgvgrnline.Columns(0).FillWeight = 70
            dgvgrnline.Columns(0).Width = 70
            dgvgrnline.Columns(1).FillWeight = 70
            dgvgrnline.Columns(1).Width = 70
            dgvgrnline.Columns(2).FillWeight = 150
            dgvgrnline.Columns(2).Width = 150
            dgvgrnline.Columns(4).FillWeight = 150
            dgvgrnline.Columns(4).Width = 150

            strquery = "select ItemCode 'Item Code', (select itemname from oitm where itemcode = a.ItemCode ) 'Item Name', Quantity   from PDN1 a where a.Docentry = '" + txtdocentry.Text + "'"
            dt1 = New DataTable
            dt1 = objApp.FunFillDT(strquery)
            dgvgrnline.Rows.Clear()
            For i As Integer = 0 To dt1.Rows.Count - 1
                dgvgrnline.Rows.Add()
                dgvgrnline.Rows(i).Cells(0).Value = i + 1
                Try
                    Dim CheckBoxCell As DataGridViewCheckBoxCell = New DataGridViewCheckBoxCell()
                    CheckBoxCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvgrnline(1, i) = CheckBoxCell
                    If dropfullpartial.SelectedItem = "Full" Then
                        dgvgrnline(1, i).Value = True
                    End If
                Catch ex As Exception

                End Try
                dgvgrnline.Rows(i).Cells(2).Value = dt1(i)(0)
                dgvgrnline.Rows(i).Cells(3).Value = dt1(i)(1)
                dgvgrnline.Rows(i).Cells(4).Value = dt1(i)(2)
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
                If oldsrow = dgvgrnline.RowCount Then
                    oldsearch = ""
                End If
                For i As Integer = oldsrow To dgvgrnline.RowCount - 1
                    If dgvgrnline.Rows(i).Cells(2).Value.ToString.ToLower.Contains(txtsearch.Text.ToLower) Then
                        dgvgrnline.Rows(i).Selected = True
                        dgvgrnline.CurrentCell = dgvgrnline.Item(2, i)
                        oldsearch = txtsearch.Text
                        oldsrow = i + 1
                        Exit For
                    ElseIf dgvgrnline.Rows(i).Cells(3).Value.ToString.ToLower.Contains(txtsearch.Text.ToLower) Then
                        dgvgrnline.Rows(i).Selected = True
                        dgvgrnline.CurrentCell = dgvgrnline.Item(3, i)
                        oldsearch = txtsearch.Text
                        oldsrow = i + 1
                        Exit For
                    Else
                        oldsearch = ""
                        dgvgrnline.CurrentCell = Nothing
                    End If
                Next
            Else
                dgvgrnline.CurrentCell = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub FunGridCheck(ByVal gridcheck As Boolean)
        Try
            For i As Integer = 0 To dgvgrnline.RowCount - 1
                dgvgrnline(1, i).Value = gridcheck
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub FunRefreshGrid()

    End Sub
#End Region

#Region "Events"

    Private Sub FrmDoubleBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtgrndocentry.Focused = True Then
                    If txtgrndocentry.Text <> "" Then
                        FunLoadGrnLine()
                        If dgvgrnline.RowCount > 0 Then
                            btnnext.Enabled = True
                            txtsearch.Enabled = True
                            txtsearch.Focus()
                        End If
                    Else
                        dgvgrnline.Rows.Clear()
                        CFL.FunLoadCFL("select DocNum 'GRN.No',convert(date,DocDate) 'Date', CardName 'Supplier',DocEntry  from OPDN where DocDate between '" + objApp.FunDateConvertion(datefrom.Text) + "' and '" + objApp.FunDateConvertion(dateto.Text) + "'")
                        If Not IsNothing(colvalue) Then
                            txtgrndocentry.Text = colvalue(0)
                            txtdate.Text = colvalue(1).Substring(0, 10).Trim()
                            txtsupplier.Text = colvalue(2)
                            txtdocentry.Text = colvalue(3)
                        End If
                        FunLoadGrnLine()
                        If dgvgrnline.RowCount > 0 Then
                            btnnext.Enabled = True
                            txtsearch.Enabled = True
                            txtsearch.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmDoubleBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If objApp.FunCheckLicense() = True Then
                btncfl.BackgroundImage = Image.FromFile(Application.StartupPath + "\images\cflimg.png")
                dropfullpartial.SelectedIndex = 1
                objApp.FunConnectDB()
                datefrom.Format = DateTimePickerFormat.Custom
                dateto.Format = DateTimePickerFormat.Custom
                datefrom.CustomFormat = "dd-MM-yyyy"
                dateto.CustomFormat = "dd-MM-yyyy"
                datefrom.Value = Date.Now().AddDays(-1)
                dateto.Value = Date.Now()
                txtgrndocentry.Text = ""
            Else
                End
            End If
        Catch ex As Exception
            MsgBox(ex.ToString(), , "Form Load")
        End Try
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Try
            If FunValidate() = True Then
                If FrmBarcodeSeries.dgvbseries.RowCount <= 0 Then
                    FrmBarcodeSeries.dropfullpartial.SelectedIndex = dropfullpartial.SelectedIndex
                    If FrmBarcodeSeries.FunLoadSeriesLine() = True Then
                        stage.Controls.Clear()
                        stage.Controls.Add(FrmBarcodeSeries.pnlbseries)
                        Me.Refresh()
                    Else
                        MsgBox("No Barcode Found On Selected Items", MsgBoxStyle.Exclamation, "No Barcode Found")
                    End If
                Else
                    If FrmBarcodeSeries.FunLoadSeriesLine() = True Then
                        stage.Controls.Clear()
                        stage.Controls.Add(FrmBarcodeSeries.pnlbseries)
                        Me.Refresh()
                    Else
                        MsgBox("No Barcode Found On Selected Items", MsgBoxStyle.Exclamation, "No Barcode Found")
                    End If
                End If
                FrmBarcodeSeries.txtsearch.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub dgvgrnline_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvgrnline.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub menustsingle_Click(sender As Object, e As EventArgs) Handles menustsingle.Click
        Try
            FrmSingleBarcode.FunClearAll()
            stage.Controls.Clear()
            stage.Controls.Add(FrmSingleBarcode.pnlsingle)
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub menustdouble_Click(sender As Object, e As EventArgs) Handles menustdouble.Click
        Try
            stage.Controls.Clear()
            stage.Controls.Add(pnldouble)
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub menustclose_Click(sender As Object, e As EventArgs) Handles menustclose.Click
        End
    End Sub

    Private Sub menustnew_Click(sender As Object, e As EventArgs) Handles menustnew.Click
        FunClearAll()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim result As DialogResult = MessageBox.Show("Are You Want To Quit ?", "Quit", MessageBoxButtons.YesNoCancel)
        If result = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text <> "" Then
                FunSearch()
            End If
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        FunSearch()
    End Sub

    Private Sub dropfullpartial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropfullpartial.SelectedIndexChanged
        Try
            If dropfullpartial.SelectedIndex = 0 Then
                FrmBarcodeSeries.dgvbseries.Rows.Clear()
                FrmBarcodeSeries.dropfullpartial.SelectedIndex = dropfullpartial.SelectedIndex
                FunGridCheck(True)
            Else
                FrmBarcodeSeries.dgvbseries.Rows.Clear()
                FrmBarcodeSeries.dropfullpartial.SelectedIndex = dropfullpartial.SelectedIndex
                FunGridCheck(False)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub txtgrndocentry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgrndocentry.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btncfl_Click(sender As Object, e As EventArgs) Handles btncfl.Click
        Try
            CFL.FunLoadCFL("select DocNum 'GRN.No',convert(date,DocDate) 'Date', CardName 'Supplier',DocEntry  from OPDN where DocDate between '" + objApp.FunDateConvertion(datefrom.Text) + "' and '" + objApp.FunDateConvertion(dateto.Text) + "'")
            If Not IsNothing(colvalue) Then
                txtgrndocentry.Text = colvalue(0)
                txtdate.Text = colvalue(1).Substring(0, 10).Trim()
                txtsupplier.Text = colvalue(2)
                txtdocentry.Text = colvalue(3)
            End If
            FunLoadGrnLine()
            If dgvgrnline.RowCount > 0 Then
                btnnext.Enabled = True
                txtsearch.Enabled = True
                txtsearch.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub menustprinter_Click(sender As Object, e As EventArgs) Handles menustprinter.Click
        dialogprinter.ShowDialog()
    End Sub

    Private Sub menusthelp_Click(sender As Object, e As EventArgs) Handles menusthelp.Click
        DialogHelp.ShowDialog()
    End Sub

#End Region
    
End Class
