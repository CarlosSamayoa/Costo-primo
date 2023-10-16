Public Class Form1
    ' 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formulario As New Form3()
        formulario.Show()
        Me.Finalize()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim formulario As New Form5()
        formulario.Show()
        Me.Finalize()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        Dim formulario As New LOG_IN()
        formulario.Show()
        Me.Finalize()
    End Sub
End Class
