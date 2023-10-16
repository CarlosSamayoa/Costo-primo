Public Class DOMICILIO
    Public a(999999), i, c As Integer
    Public s(999999) As String

    ' Declaro e inicializo objeto para hacer la conexión a mi base de datos Access 2013
    Public conex As New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.4.0;Data Source=C:\Users\scajl\source\repos\proyecto de contabilidad menu\proyecto de contabilidad menu\Biblioteca.accdb")

    ' Por medio de este objeto voy a enviar todos los comandos de SQL a la tabla por medio de la conexión
    Public comm As New OleDb.OleDbCommand
    ' Declaro una variable para armar la instrucción SQL
    Dim sql As String

    ' Al cargar la aplicación, intenta conectarse a la base de datos
    Private Sub DOMICILIO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ' Trato de abrir la conexión
            conex.Open()
            ' Inicializo el objeto Command
            comm.Connection = conex
            comm.CommandType = CommandType.Text
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("No se pudo encontrar el archivo de la base de datos", MsgBoxStyle.Exclamation, "ordenes")
                Return
            Else
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "ordenes")
            End If
        End Try
    End Sub

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

    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        a(i) = 10
        i = i + 1
        s(i) = ("Bebida pepsi             Q.10.00")
        ListBox1.Items.Add(s(i))

    End Sub

    Public Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Verifico que haya escrito el ISBN (bueno, debería verificarlos todos, pero como esta es la clave principal...)
        If nombre.Text = "" Then
            ' Si no lo escribió, mando mensaje de error
            MsgBox("Debe incluir su nombre")
            nombre.Select()
        Else
            ' Si sí lo escribió, comienza la diversión (jeje)
            ' Armo la instrucción INSERT en la variable SQL
            sql = "INSERT INTO Ordenes (Nombre,Apellido,NIT,Direccion,Precio) VALUES ('" &
                nombre.Text & "','" & apellido.Text & "','" & NIT.Text & "','" &
                Direccion.Text & "'," & total.Text & ")"

            ' Asigno la instrucción SQL que se va a ejecutar
            comm.CommandText = sql

            Try
                comm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, "ordenes")
            End Try
        End If
    End Sub




    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a(i) = 35
        i = i + 1
        s(i) = ("Pizza de Full cheese     Q.35.00")
        ListBox1.Items.Add(s(i))


        ' Si sí lo escribió, comienza la diversión (jeje)
        ' Armo la instrucción INSERT en la variable SQL
        sql = "INSERT INTO Pizzas (producto,Precio) VALUES ('" &
                "Pizza de Full cheese" & "','" & "35.00" & "')"

            ' Asigno la instrucción SQL que se va a ejecutar
            comm.CommandText = sql

            Try
                comm.ExecuteNonQuery()
            Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "ordenes")
        End Try

    End Sub

    Public Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        a(i) = 45
        i = i + 1
        s(i) = ("Pizza Cheese pop´s       Q.45.00")
        ListBox1.Items.Add(s(i))


        ' Si sí lo escribió, comienza la diversión (jeje)
        ' Armo la instrucción INSERT en la variable SQL
        sql = "INSERT INTO Pizzas (producto,Precio) VALUES ('" &
                "Pizza Cheese pop´s" & "','" & "45.00" & "')"

        ' Asigno la instrucción SQL que se va a ejecutar
        comm.CommandText = sql

        Try
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "ordenes")
        End Try
    End Sub

    Public Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
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

        total.Text = subtotal


    End Sub

    Public Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        a(i) = 10
        i = i + 1
        s(i) = ("Bebida 7UP               Q.10.00")
        ListBox1.Items.Add(s(i))


    End Sub

    Public Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        a(i) = 10
        i = i + 1
        s(i) = ("Bebida Té de Frambuesa  Q.15.00")
        ListBox1.Items.Add(s(i))


    End Sub



    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a(i) = 40
        i = i + 1
        s(i) = ("Pizza de peperoni        Q.40.00")
        ListBox1.Items.Add(s(i))



        ' Si sí lo escribió, comienza la diversión (jeje)
        ' Armo la instrucción INSERT en la variable SQL
        sql = "INSERT INTO Pizzas (producto,Precio) VALUES ('" &
                "Pizza de peperoni" & "','" & "40.00" & "')"

        ' Asigno la instrucción SQL que se va a ejecutar
        comm.CommandText = sql

        Try
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "ordenes")
        End Try
    End Sub
    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a(i) = 40
        i = i + 1
        s(i) = ("Pizza de Jamón           Q.40.00")
        ListBox1.Items.Add(s(i))

        ' Si sí lo escribió, comienza la diversión (jeje)
        ' Armo la instrucción INSERT en la variable SQL
        sql = "INSERT INTO Pizzas (producto,Precio) VALUES ('" &
                "Pizza de Jamón" & "','" & "40.00" & "')"

        ' Asigno la instrucción SQL que se va a ejecutar
        comm.CommandText = sql

        Try
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "ordenes")
        End Try
    End Sub
End Class