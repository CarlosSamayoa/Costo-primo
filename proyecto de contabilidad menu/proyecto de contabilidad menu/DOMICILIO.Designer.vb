<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DOMICILIO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NIT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.OrdenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesDataSet1 = New proyecto_de_contabilidad_menu.ordenesDataSet1()
        Me.OrdenesTableAdapter = New proyecto_de_contabilidad_menu.ordenesDataSet1TableAdapters.OrdenesTableAdapter()
        Me.BibliotecaDataSet1 = New proyecto_de_contabilidad_menu.BibliotecaDataSet()
        CType(Me.OrdenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1057, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(926, 397)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "MAIN MENÚ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(41, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "PEPERONI         Q.40.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(230, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "JAMÓN        Q.40.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(33, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "FULL CHEESE      Q.35.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(221, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CHEESE POP'S         Q.45.00"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button7.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(975, 288)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 73)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "Finalizar pedido"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(954, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(193, 156)
        Me.ListBox1.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(972, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "RESUMEN DE ORDEN"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.SystemColors.MenuText
        Me.total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.total.Location = New System.Drawing.Point(1076, 207)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(43, 22)
        Me.total.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(437, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "7UP 1.5L          Q.10.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(437, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "TÉ DE FRAMBUESA      Q.15.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(437, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "PEPSI 1.5 L    Q.10.00"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button11.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(975, 207)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(76, 20)
        Me.Button11.TabIndex = 42
        Me.Button11.Text = "Sub-total"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(1054, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Q."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(1119, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = ".00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(53, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(267, 25)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "ESPECIALIDADES"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(435, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 25)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "BEBIDAS"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.CEpaywvW8AA1Aeg
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button10.Location = New System.Drawing.Point(440, 316)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(162, 94)
        Me.Button10.TabIndex = 35
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.descargar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button9.Location = New System.Drawing.Point(440, 204)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(162, 94)
        Me.Button9.TabIndex = 34
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.descargar__2_
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.Location = New System.Drawing.Point(440, 89)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(162, 94)
        Me.Button8.TabIndex = 16
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.cheese_pops
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(208, 268)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(162, 142)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.pizza_jamon
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(208, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 142)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.full_cheese
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(21, 268)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 142)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.pizza_peperoni
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(21, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 142)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"5a. Ave 7-61, Cdad. de Guatemala 01064", "5a calle 701, Cdad. de Guatemala"})
        Me.ComboBox1.Location = New System.Drawing.Point(656, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(815, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 25)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Nombre"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(706, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 25)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Sede"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(656, 151)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(260, 20)
        Me.nombre.TabIndex = 50
        '
        'apellido
        '
        Me.apellido.Location = New System.Drawing.Point(656, 209)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(260, 20)
        Me.apellido.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(805, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 25)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Apellido"
        '
        'NIT
        '
        Me.NIT.Location = New System.Drawing.Point(656, 266)
        Me.NIT.Name = "NIT"
        Me.NIT.Size = New System.Drawing.Size(260, 20)
        Me.NIT.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(819, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 25)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "NIT"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(656, 329)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(260, 20)
        Me.Direccion.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("Magneto", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(793, 301)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 25)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Direccion"
        '
        'OrdenesBindingSource
        '
        Me.OrdenesBindingSource.DataMember = "Ordenes"
        Me.OrdenesBindingSource.DataSource = Me.OrdenesDataSet1
        '
        'OrdenesDataSet1
        '
        Me.OrdenesDataSet1.DataSetName = "ordenesDataSet1"
        Me.OrdenesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdenesTableAdapter
        '
        Me.OrdenesTableAdapter.ClearBeforeFill = True
        '
        'BibliotecaDataSet1
        '
        Me.BibliotecaDataSet1.DataSetName = "BibliotecaDataSet"
        Me.BibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DOMICILIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_de_contabilidad_menu.My.Resources.Resources.fondo_ordenar
        Me.ClientSize = New System.Drawing.Size(1183, 590)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NIT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DOMICILIO"
        Me.Text = "DOMICILIO"
        CType(Me.OrdenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents apellido As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents NIT As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Direccion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents OrdenesDataSet1 As ordenesDataSet1
    Friend WithEvents OrdenesBindingSource As BindingSource
    Friend WithEvents OrdenesTableAdapter As ordenesDataSet1TableAdapters.OrdenesTableAdapter
    Friend WithEvents BibliotecaDataSet1 As BibliotecaDataSet
End Class
