Public Class MsgBoxSpectrum
    Inherits System.Windows.Forms.Form
    Friend WithEvents btn As New Windows.Forms.Button
    Friend WithEvents rtb As New Windows.Forms.RichTextBox

    Friend WithEvents botonSi As New Windows.Forms.Button
    Friend WithEvents botonNo As New Windows.Forms.Button
    Friend WithEvents label1 As New Windows.Forms.Label

    Public Sub New()
        Me.SuspendLayout()
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.None
        Dim botonSiPoint As Point
        Me.Width = 450
        Me.Height = 200
        botonSiPoint.X = 180
        botonSiPoint.Y = 100
        botonSi.Location = botonSiPoint
        botonSi.Text = "Si"
        Me.Controls.Add(botonSi)

        Me.ResumeLayout(False)
    End Sub

    Private Sub botonSi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles botonSi.Click
        Me.Close()
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.Click

        Me.Close()

    End Sub

    Public Overrides Property Text() As String
        Get
            If Me.rtb Is Nothing Then
                Return ""
            Else
                Return Me.rtb.Text
            End If
        End Get
        Set(ByVal value As String)
            Me.rtb.Text = value
        End Set
    End Property

End Class
