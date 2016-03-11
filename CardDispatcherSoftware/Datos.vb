Public Class Datos

    Dim ds As New UsuariosTarjetasDataSetTableAdapters.UsuariosTableAdapter
    Dim usuariosDataTable As New UsuariosTarjetasDataSet.UsuariosDataTable

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsuariosTarjetasDataSet.Usuarios' table. You can move, or remove it, as needed.
        ' Me.UsuariosTableAdapter.Fill(Me.UsuariosTarjetasDataSet.Usuarios)
        ds.FillBy(usuariosDataTable)
        DataGridView1.DataSource = usuariosDataTable
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True And TextBox1.Text <> "" Then
            ds.FillDataPorNombre(usuariosDataTable, TextBox1.Text)
            DataGridView1.DataSource = usuariosDataTable
        ElseIf RadioButton2.Checked = True And TextBox2.Text <> "" Then
            ds.FillDataPorApellido(usuariosDataTable, TextBox2.Text)
            DataGridView1.DataSource = usuariosDataTable
        ElseIf RadioButton3.Checked = True And TextBox3.Text <> "" Then
            ds.FillDataPorci(usuariosDataTable, TextBox3.Text)
            DataGridView1.DataSource = usuariosDataTable
        ElseIf RadioButton4.Checked = True Then
            ds.FillByDataPorUltimaEscritura(usuariosDataTable, DateTimePicker1.Text)
            DataGridView1.DataSource = usuariosDataTable
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.UsuariosTableAdapter.FillBy(Me.UsuariosTarjetasDataSet.Usuarios)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            DateTimePicker1.Enabled = False
            Button2.Enabled = True

            TextBox2.Text = ""
            TextBox3.Text = ""
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = True
            TextBox3.Enabled = False
            DateTimePicker1.Enabled = False
            Button2.Enabled = True

            TextBox1.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = True
            DateTimePicker1.Enabled = False
            Button2.Enabled = True

            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            DateTimePicker1.Enabled = True
            Button2.Enabled = True

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strFilePath As String
        Dim stm As IO.StreamWriter
        Dim i As Integer
        Dim j As Integer = 5
        Dim directorioImagenes As New FolderBrowserDialog

        directorioImagenes.SelectedPath = "C:\"

        If directorioImagenes.ShowDialog() = DialogResult.OK Then
            strFilePath = directorioImagenes.SelectedPath + "\datos.txt"
        End If

        Try
            stm = New IO.StreamWriter(strFilePath, False)

            For i = 0 To usuariosDataTable.Columns.Count - 2

                stm.Write(usuariosDataTable.Columns(i).ColumnName + " | ")

            Next i
            stm.Write(usuariosDataTable.Columns(i).ColumnName)
            stm.WriteLine()

            For Each row As DataRow In usuariosDataTable.Rows
                Dim array() As Object = row.ItemArray

                For i = 0 To array.Length - 2
                    stm.Write(array(i).ToString() + " | ")
                Next i
                stm.Write(array(i).ToString())
                stm.WriteLine()
            Next row

            stm.Close()
            MsgBox("Datos Exportados")
        Catch ex As Exception
            MsgBox("Datos No Exportados")
        End Try

    End Sub
End Class