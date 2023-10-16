Public Class LOG_IN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        Dim Password As Integer

        user = txt_user.Text
        Password = txt_Password.Text

        If (user = "bambino") And (Password = "1234") Then
            Form2.Show()
            Me.Finalize()
        Else
            MsgBox("Usuario o Contraseña errada, Verifique")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formulario2 As New Form1()
        formulario2.Show()
        Me.Finalize()
    End Sub
End Class