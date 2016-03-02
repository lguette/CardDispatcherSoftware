Public Class LecturaTarjeta
    Dim rd As COMRD800Lib.IRD800

    Dim snr As Integer
    Dim response As Integer = 1
    Dim idSerial As String
    Dim nombre As String
    Dim apellido As String
    Dim ci As String
    Dim ultimaEscritura As String
    Dim st As Integer
    Dim i As Integer = 1
    Dim direccionImagen As String
    Dim foto As String

    Dim ds As New UsuariosTarjetasDataSetTableAdapters.UsuariosTableAdapter
    Dim directorios As New UsuariosTarjetasDataSetTableAdapters.DirectoriosTableAdapter

    Dim tarjetaNoEncontrada As ComunicacionIniciada

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.BackgroundWorker1.CancelAsync()
        Me.Close()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        rd.dc_init(100, 115200)
        response = rd.dc_card(5, snr)

        rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF"
        st = rd.dc_load_key(0, 0)

        If response = 0 Then
            For i = 1 To 5
                rd.dc_authentication(0, i)
                rd.dc_read(i * 4)
                Select Case i
                    Case 1
                        idSerial = snr
                    Case 2
                        nombre = rd.get_bstrRBuffer
                    Case 3
                        apellido = rd.get_bstrRBuffer
                    Case 4
                        ci = rd.get_bstrRBuffer
                    Case 5
                        ultimaEscritura = rd.get_bstrRBuffer
                End Select
            Next
        End If
        rd.dc_exit()
    End Sub

    Private Sub LecturaTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rd = New COMRD800Lib.RD800


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        tarjetaNoEncontrada = New ComunicacionIniciada

        If BackgroundWorker1.IsBusy = False Then
            If response = 0 Then
                TextBox1.Text = idSerial
                TextBox2.Text = nombre
                TextBox3.Text = apellido
                TextBox4.Text = ci
                TextBox5.Text = ultimaEscritura

                If TextBox4.Text <> ds.BuscarCi(idSerial) Then
                    tarjetaNoEncontrada.Show()
                    Principal.Label1.ForeColor = Color.FromArgb(255, 68, 72)
                    tarjetaNoEncontrada.Label1.Text = "Tarjeta no encontrada"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                Else
                    foto = ds.BuscarFoto(idSerial)
                    If foto <> "" Then
                        Try
                            PictureBox1.BackgroundImage = Image.FromFile(foto)
                        Catch ex As Exception
                            Dim imagenNoEncontrada As New ComunicacionIniciada
                            imagenNoEncontrada.Show()
                            Principal.Label1.ForeColor = Color.FromArgb(255, 68, 72)
                            imagenNoEncontrada.Label1.Text = "Imagen no encontrada"
                        End Try

                    End If
                End If

                End If
                Timer1.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not BackgroundWorker1.IsBusy Then
            BackgroundWorker1.RunWorkerAsync()
            Timer1.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        If TextBox1.Text <> "" Then
            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.PNG)|*.PNG|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                direccionImagen = openFileDialog1.FileName
                PictureBox1.BackgroundImage = Image.FromFile(direccionImagen)
                My.Computer.FileSystem.CopyFile(
                 direccionImagen,
                   directorios.BuscarDirectorio(1) + TextBox4.Text + ".jpg",
                    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                     Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                ds.InsertarFoto(direccionImagen, idSerial)
            End If
        End If

    End Sub

End Class