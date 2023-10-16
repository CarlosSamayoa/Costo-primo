Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formulario4 As New Form1()
        formulario4.Show()
        Me.Finalize()
    End Sub
End Class