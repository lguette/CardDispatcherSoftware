Public Class Principal

    Dim rd As COMRD800Lib.RD800
    Public icdev As Integer

    Dim directorios As New UsuariosTarjetasDataSetTableAdapters.DirectoriosTableAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminDisp As AdminDisp
        adminDisp = New AdminDisp

        adminDisp.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lecturaTarjeta As LecturaTarjeta
        lecturaTarjeta = New LecturaTarjeta

        lecturaTarjeta.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim directorioImagenes As New FolderBrowserDialog

        directorioImagenes.SelectedPath = directorios.BuscarDirectorio(1)

        If directorioImagenes.ShowDialog() = DialogResult.OK Then
            directorios.ActualizarDirectorio(directorioImagenes.SelectedPath, 1)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim escribirTarjeta As New EscribirTarjeta

        escribirTarjeta.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim datos As New Datos

        datos.Show()
    End Sub
End Class
