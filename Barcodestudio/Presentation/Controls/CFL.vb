Public Class CFL

#Region "User Function"
    Sub LoadCurrentRow()
        Try
            If dgvfill.RowCount > 0 Then
                ReDim colvalue(dgvfill.ColumnCount - 1)
                For i As Integer = 0 To dgvfill.ColumnCount - 1
                    colvalue(i) = dgvfill.Rows(dgvfill.CurrentCell.RowIndex).Cells(i).Value.ToString()
                Next
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception

        End Try
     
    End Sub
    Public Sub FunLoadCFL(ByVal str_query As String, Optional ByVal width As Integer = 550, Optional ByVal height As Integer = 350)
        Try
            Me.StartPosition = FormStartPosition.Manual
            Dim left As Integer = (FrmDoubleBarcode.Location.X + FrmDoubleBarcode.Width) - (Me.Width + 10)
            Dim top As Integer = (FrmDoubleBarcode.Location.Y + FrmDoubleBarcode.Height + FrmDoubleBarcode.pnlfullgrn.Height) - (Me.Height + FrmDoubleBarcode.pnlheader.Height)
            Me.DesktopLocation = New Point(left, top)
            Me.Width = width
            Me.Height = height
            dgvfill.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dt2 = New DataTable
            dt2 = objApp.FunFillDT(str_query)
            dv = dt2.DefaultView
            dgvfill.DataSource = dt2
            dt3 = dt2.Copy()
            dgvfill.Columns(0).DefaultCellStyle.Font = New Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold)
            If dt2.Rows.Count = 0 Then
                MsgBox("No Record Found Between Date Range ", MsgBoxStyle.Information, "No Data Found")
            Else
                Me.ShowDialog()
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub CFL_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                LoadCurrentRow()
            End If
            If e.KeyCode = Keys.Escape Then
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
            If e.KeyCode = Keys.Down Then
                If dgvfill.Focused = False Then
                    dgvfill.Focus()
                End If
            End If
            If e.KeyCode = Keys.Up Then
                If dgvfill.CurrentCell.RowIndex = 0 Then
                    txtsearch.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub CFL_Load(sender As Object, e As EventArgs) Handles Me.Load
        colvalue = Nothing
        txtsearch.Text = ""
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgvfill_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvfill.MouseClick
        LoadCurrentRow()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If txtsearch.Text.Trim() <> "" Then
                For i As Integer = 0 To dgvfill.RowCount - 1
                    If dgvfill.Rows(i).Cells(0).Value.ToString = txtsearch.Text Then
                        dgvfill.Rows(i).Selected = True
                        dgvfill.CurrentCell = dgvfill.Item(0, i)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region
   
End Class