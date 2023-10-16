Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formulario5 As New Form1()
        formulario5.Show()
        Me.Finalize()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class