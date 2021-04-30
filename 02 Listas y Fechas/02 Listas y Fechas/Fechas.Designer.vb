<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fechas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMeses = New System.Windows.Forms.CheckBox()
        Me.chkSemanas = New System.Windows.Forms.CheckBox()
        Me.chkDias = New System.Windows.Forms.CheckBox()
        Me.chkHoras = New System.Windows.Forms.CheckBox()
        Me.chkMinutos = New System.Windows.Forms.CheckBox()
        Me.chkSegundos = New System.Windows.Forms.CheckBox()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtMeses = New System.Windows.Forms.TextBox()
        Me.txtSemanas = New System.Windows.Forms.TextBox()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.txtSegundos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaActual = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce una fecha correta"
        '
        'chkMeses
        '
        Me.chkMeses.AutoSize = True
        Me.chkMeses.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkMeses.Location = New System.Drawing.Point(12, 51)
        Me.chkMeses.Name = "chkMeses"
        Me.chkMeses.Size = New System.Drawing.Size(78, 28)
        Me.chkMeses.TabIndex = 1
        Me.chkMeses.Text = "Meses"
        Me.chkMeses.UseVisualStyleBackColor = True
        '
        'chkSemanas
        '
        Me.chkSemanas.AutoSize = True
        Me.chkSemanas.Location = New System.Drawing.Point(9, 85)
        Me.chkSemanas.Name = "chkSemanas"
        Me.chkSemanas.Size = New System.Drawing.Size(96, 28)
        Me.chkSemanas.TabIndex = 2
        Me.chkSemanas.Text = "Semanas"
        Me.chkSemanas.UseVisualStyleBackColor = True
        '
        'chkDias
        '
        Me.chkDias.AutoSize = True
        Me.chkDias.Location = New System.Drawing.Point(9, 119)
        Me.chkDias.Name = "chkDias"
        Me.chkDias.Size = New System.Drawing.Size(61, 28)
        Me.chkDias.TabIndex = 3
        Me.chkDias.Text = "Dias"
        Me.chkDias.UseVisualStyleBackColor = True
        '
        'chkHoras
        '
        Me.chkHoras.AutoSize = True
        Me.chkHoras.Location = New System.Drawing.Point(9, 153)
        Me.chkHoras.Name = "chkHoras"
        Me.chkHoras.Size = New System.Drawing.Size(74, 28)
        Me.chkHoras.TabIndex = 4
        Me.chkHoras.Text = "Horas"
        Me.chkHoras.UseVisualStyleBackColor = True
        '
        'chkMinutos
        '
        Me.chkMinutos.AutoSize = True
        Me.chkMinutos.Location = New System.Drawing.Point(9, 187)
        Me.chkMinutos.Name = "chkMinutos"
        Me.chkMinutos.Size = New System.Drawing.Size(93, 28)
        Me.chkMinutos.TabIndex = 5
        Me.chkMinutos.Text = "Minutos"
        Me.chkMinutos.UseVisualStyleBackColor = True
        '
        'chkSegundos
        '
        Me.chkSegundos.AutoSize = True
        Me.chkSegundos.Location = New System.Drawing.Point(9, 221)
        Me.chkSegundos.Name = "chkSegundos"
        Me.chkSegundos.Size = New System.Drawing.Size(105, 28)
        Me.chkSegundos.TabIndex = 6
        Me.chkSegundos.Text = "Segundos"
        Me.chkSegundos.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(9, 279)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(101, 41)
        Me.btnAnterior.TabIndex = 11
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(144, 279)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(101, 41)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(336, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 41)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtMeses
        '
        Me.txtMeses.Location = New System.Drawing.Point(119, 49)
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.ReadOnly = True
        Me.txtMeses.Size = New System.Drawing.Size(126, 32)
        Me.txtMeses.TabIndex = 14
        '
        'txtSemanas
        '
        Me.txtSemanas.Location = New System.Drawing.Point(119, 83)
        Me.txtSemanas.Name = "txtSemanas"
        Me.txtSemanas.ReadOnly = True
        Me.txtSemanas.Size = New System.Drawing.Size(126, 32)
        Me.txtSemanas.TabIndex = 15
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(119, 117)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.ReadOnly = True
        Me.txtDias.Size = New System.Drawing.Size(126, 32)
        Me.txtDias.TabIndex = 16
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(119, 151)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.ReadOnly = True
        Me.txtHoras.Size = New System.Drawing.Size(126, 32)
        Me.txtHoras.TabIndex = 17
        '
        'txtMinutos
        '
        Me.txtMinutos.Location = New System.Drawing.Point(119, 185)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.ReadOnly = True
        Me.txtMinutos.Size = New System.Drawing.Size(126, 32)
        Me.txtMinutos.TabIndex = 18
        '
        'txtSegundos
        '
        Me.txtSegundos.Location = New System.Drawing.Point(119, 219)
        Me.txtSegundos.Name = "txtSegundos"
        Me.txtSegundos.ReadOnly = True
        Me.txtSegundos.Size = New System.Drawing.Size(126, 32)
        Me.txtSegundos.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha Actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Introduce una Fecha"
        '
        'txtFechaActual
        '
        Me.txtFechaActual.Location = New System.Drawing.Point(265, 182)
        Me.txtFechaActual.Name = "txtFechaActual"
        Me.txtFechaActual.ReadOnly = True
        Me.txtFechaActual.Size = New System.Drawing.Size(168, 32)
        Me.txtFechaActual.TabIndex = 22
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(265, 115)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(168, 32)
        Me.txtFecha.TabIndex = 23
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(276, 279)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(157, 41)
        Me.btnLimpiar.TabIndex = 24
        Me.btnLimpiar.Text = "Limpiar Datos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Fechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 335)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtFechaActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSegundos)
        Me.Controls.Add(Me.txtMinutos)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.txtSemanas)
        Me.Controls.Add(Me.txtMeses)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.chkSegundos)
        Me.Controls.Add(Me.chkMinutos)
        Me.Controls.Add(Me.chkHoras)
        Me.Controls.Add(Me.chkDias)
        Me.Controls.Add(Me.chkSemanas)
        Me.Controls.Add(Me.chkMeses)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Fechas"
        Me.Text = "Fechas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkMeses As CheckBox
    Friend WithEvents chkSemanas As CheckBox
    Friend WithEvents chkDias As CheckBox
    Friend WithEvents chkHoras As CheckBox
    Friend WithEvents chkMinutos As CheckBox
    Friend WithEvents chkSegundos As CheckBox
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents txtSemanas As TextBox
    Friend WithEvents txtDias As TextBox
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtMinutos As TextBox
    Friend WithEvents txtSegundos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaActual As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnLimpiar As Button
End Class
