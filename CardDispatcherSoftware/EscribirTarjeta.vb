Public Class EscribirTarjeta
    Dim campoVacio As ComunicacionIniciada
    Dim idTarjeta As String
    Dim nombre As String
    Dim apellido As String
    Dim ci As String
    Dim ultimaEscritura As String
    Dim foto As String

    Dim usuarios As New UsuariosTarjetasDataSetTableAdapters.UsuariosTableAdapter
    Dim rd As COMRD800Lib.IRD800

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            campoVacio = New ComunicacionIniciada
            campoVacio.Show()
            campoVacio.Label1.Text = "      Campo(s) Vacío"
            campoVacio.Label1.ForeColor = Color.FromArgb(255, 68, 72)
            Exit Sub
        End If

        idTarjeta = TextBox1.Text
        nombre = TextBox2.Text
        apellido = TextBox3.Text
        ci = TextBox4.Text
        ultimaEscritura = DateTimePicker1.Text

        If usuarios.BuscarCi(idTarjeta) = "" Then
            Dim TarjetaOk As New ComunicacionIniciada
            usuarios.InsertarUsuario(idTarjeta, nombre, apellido, ci, ultimaEscritura, foto)
            TarjetaOk.Show()
            TarjetaOk.Label1.Text = "      Tarjeta Agregada"
        Else

            Dim msg As String
            Dim title As String
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            msg = "Tarjeta usada desea reescribirla?"   ' Define message.
            style = MsgBoxStyle.DefaultButton2 Or
               MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
            title = "Tarjeta Usada"   ' Define title.
            ' Display message.
            response = MsgBox(msg, style, title)
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                Dim TarjetaOk As New ComunicacionIniciada
                usuarios.ActualizarUsuario(idTarjeta, nombre, apellido, ci, ultimaEscritura, foto, idTarjeta)
                TarjetaOk.Show()
                TarjetaOk.Label1.Text = "      Tarjeta Agregada"

                rd.dc_init(100, 115200)
                rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF"

                If response = 0 Then
                    For i = 1 To 5
                        rd.dc_authentication(0, i)

                        Select Case i
                            Case 1

                            Case 2
                                rd.put_bstrRBuffer = nombre
                            Case 3
                                rd.put_bstrRBuffer = apellido
                            Case 4
                                rd.put_bstrRBuffer = ci
                            Case 5
                                rd.put_bstrRBuffer = ultimaEscritura
                        End Select
                        rd.dc_write(i * 4)
                    Next
                End If
                rd.dc_exit()

            Else
                ' Perform some other action.
            End If

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not e.KeyChar = Convert.ToChar(Keys.Back) AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EscribirTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rd = New COMRD800Lib.RD800
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.PNG)|*.PNG|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            foto = openFileDialog1.FileName
            PictureBox1.BackgroundImage = Image.FromFile(foto)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class