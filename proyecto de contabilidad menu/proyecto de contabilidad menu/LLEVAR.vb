Public Class LLEVAR
    Public a(999999), i As Integer
    Public s(999999), c As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DOMICILIO As New Form3()
        DOMICILIO.Show()
        Me.Finalize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        a(i) = 10
        i = i + 1
        s(c) = ("Bebida pepsi             Q.10.00")
        ListBox1.Items.Add(s(c))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim LLEVAR As New UBICACION()
        LLEVAR.Show()
        Me.Finalize()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a(i) = 35
        i = i + 1
        s(c) = ("Pizza de Full cheese     Q.35.00")
        ListBox1.Items.Add(s(c))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        a(i) = 45
        i = i + 1
        s(c) = ("Pizza Cheese pop´s       Q.45.00")
        ListBox1.Items.Add(s(c))
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim k As Integer
        Dim subtotal As Integer
        k = i - 1
        For i = 0 To k
            If a(i) = 45 Then
                subtotal = subtotal + 45
            End If
            If a(i) = 35 Then
                subtotal = subtotal + 35
            End If
            If a(i) = 40 Then
                subtotal = subtotal + 40
            End If
            If a(i) = 10 Then
                subtotal = subtotal + 10
            End If
            If a(i) = 15 Then
                subtotal = subtotal + 15
            End If
        Next

        TextBox1.Text = subtotal

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        a(i) = 10
        i = i + 1
        s(c) = ("Bebida 7UP               Q.10.00")
        ListBox1.Items.Add(s(c))
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        a(i) = 10
        i = i + 1
        s(c) = ("Bebida Té de Frambuesa  Q.15.00")
        ListBox1.Items.Add(s(c))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a(i) = 40
        i = i + 1
        s(c) = ("Pizza de peperoni        Q.40.00")
        ListBox1.Items.Add(s(c))
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a(i) = 40
        i = i + 1
        s(c) = ("Pizza de Jamón           Q.40.00")
        ListBox1.Items.Add(s(c))
    End Sub
End Class