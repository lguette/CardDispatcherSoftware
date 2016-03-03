Public Class AdminDisp
    Dim rd As COMRD800Lib.RD800

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comunicacionIniciada As ComunicacionIniciada

        comunicacionIniciada = New ComunicacionIniciada

        rd = New COMRD800Lib.RD800

        Principal.icdev = rd.dc_init(100, 115200)
        If Principal.icdev > 0 Then
            rd.dc_beep(10)
            comunicacionIniciada.Show()
            comunicacionIniciada.Label1.Text = "Comunicación Iniciada"
            Principal.Label1.Text = "     Dispositivo Conectado"
            Principal.Label1.ForeColor = Color.FromArgb(31, 66, 105)
            Principal.Button2.Enabled = True
            Principal.Button3.Enabled = True
            Principal.Button4.Enabled = True
            Principal.Button6.Enabled = True
            rd.dc_exit()
            Me.Close()
        Else
            comunicacionIniciada.Show()
            comunicacionIniciada.Label1.Text = "Error de Comunicación"
            rd.dc_exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rd = New COMRD800Lib.RD800

        If Principal.icdev > 0 Then
            rd.dc_exit()
            Principal.icdev = 0
            ComunicacionIniciada.Show()
            Principal.Label1.Text = "Dispositivo Desconectado"
            Principal.Label1.ForeColor = Color.FromArgb(255, 68, 72)
            ComunicacionIniciada.Label1.Text = "Comunicación Terminada"
            Principal.Button2.Enabled = False
            Principal.Button3.Enabled = False
            Principal.Button4.Enabled = False
            Principal.Button6.Enabled = False
            Me.Close()
        Else
            rd.dc_exit()
            ComunicacionIniciada.Show()
            ComunicacionIniciada.Label1.Text = "Error de Comunicación"
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub


End Class