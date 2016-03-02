Partial Class UsuariosTarjetasDataSet
    Partial Public Class UsuariosDataTable
        Private Sub UsuariosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NombreColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class TableDataTable
    End Class
End Class
