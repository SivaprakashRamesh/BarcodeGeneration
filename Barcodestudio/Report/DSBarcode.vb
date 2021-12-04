Partial Class DSBarcode
    Partial Class DataTable_BarcodeDataTable

        Private Sub DataTable_BarcodeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BARCODEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
