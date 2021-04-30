<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProductos
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbDiferente = New System.Windows.Forms.RadioButton()
        Me.rbIgual = New System.Windows.Forms.RadioButton()
        Me.rbMenorIgual = New System.Windows.Forms.RadioButton()
        Me.rbMenor = New System.Windows.Forms.RadioButton()
        Me.rbMayorIgual = New System.Windows.Forms.RadioButton()
        Me.rbMayor = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce valor a buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(368, 40)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 36)
        Me.txtBuscar.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.rbDiferente)
        Me.GroupBox1.Controls.Add(Me.rbIgual)
        Me.GroupBox1.Controls.Add(Me.rbMenorIgual)
        Me.GroupBox1.Controls.Add(Me.rbMenor)
        Me.GroupBox1.Controls.Add(Me.rbMayorIgual)
        Me.GroupBox1.Controls.Add(Me.rbMayor)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 377)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(46, 327)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(89, 34)
        Me.rbTodos.TabIndex = 6
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbDiferente
        '
        Me.rbDiferente.AutoSize = True
        Me.rbDiferente.Location = New System.Drawing.Point(46, 274)
        Me.rbDiferente.Name = "rbDiferente"
        Me.rbDiferente.Size = New System.Drawing.Size(61, 34)
        Me.rbDiferente.TabIndex = 5
        Me.rbDiferente.TabStop = True
        Me.rbDiferente.Text = "<>"
        Me.rbDiferente.UseVisualStyleBackColor = True
        '
        'rbIgual
        '
        Me.rbIgual.AutoSize = True
        Me.rbIgual.Location = New System.Drawing.Point(46, 233)
        Me.rbIgual.Name = "rbIgual"
        Me.rbIgual.Size = New System.Drawing.Size(46, 34)
        Me.rbIgual.TabIndex = 4
        Me.rbIgual.TabStop = True
        Me.rbIgual.Text = "="
        Me.rbIgual.UseVisualStyleBackColor = True
        '
        'rbMenorIgual
        '
        Me.rbMenorIgual.AutoSize = True
        Me.rbMenorIgual.Location = New System.Drawing.Point(46, 192)
        Me.rbMenorIgual.Name = "rbMenorIgual"
        Me.rbMenorIgual.Size = New System.Drawing.Size(61, 34)
        Me.rbMenorIgual.TabIndex = 3
        Me.rbMenorIgual.TabStop = True
        Me.rbMenorIgual.Text = "<="
        Me.rbMenorIgual.UseVisualStyleBackColor = True
        '
        'rbMenor
        '
        Me.rbMenor.AutoSize = True
        Me.rbMenor.Location = New System.Drawing.Point(46, 139)
        Me.rbMenor.Name = "rbMenor"
        Me.rbMenor.Size = New System.Drawing.Size(46, 34)
        Me.rbMenor.TabIndex = 2
        Me.rbMenor.TabStop = True
        Me.rbMenor.Text = "<"
        Me.rbMenor.UseVisualStyleBackColor = True
        '
        'rbMayorIgual
        '
        Me.rbMayorIgual.AutoSize = True
        Me.rbMayorIgual.Location = New System.Drawing.Point(46, 86)
        Me.rbMayorIgual.Name = "rbMayorIgual"
        Me.rbMayorIgual.Size = New System.Drawing.Size(61, 34)
        Me.rbMayorIgual.TabIndex = 1
        Me.rbMayorIgual.TabStop = True
        Me.rbMayorIgual.Text = ">="
        Me.rbMayorIgual.UseVisualStyleBackColor = True
        '
        'rbMayor
        '
        Me.rbMayor.AutoSize = True
        Me.rbMayor.Checked = True
        Me.rbMayor.Location = New System.Drawing.Point(46, 45)
        Me.rbMayor.Name = "rbMayor"
        Me.rbMayor.Size = New System.Drawing.Size(46, 34)
        Me.rbMayor.TabIndex = 0
        Me.rbMayor.TabStop = True
        Me.rbMayor.Text = ">"
        Me.rbMayor.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(180, 102)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(139, 58)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.ItemHeight = 30
        Me.lstProductos.Location = New System.Drawing.Point(417, 214)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(275, 334)
        Me.lstProductos.TabIndex = 4
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(479, 135)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(163, 59)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar Datos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(479, 593)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 44)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'BuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 679)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "BuscarProductos"
        Me.Text = "BuscarProductos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbDiferente As RadioButton
    Friend WithEvents rbIgual As RadioButton
    Friend WithEvents rbMenorIgual As RadioButton
    Friend WithEvents rbMenor As RadioButton
    Friend WithEvents rbMayorIgual As RadioButton
    Friend WithEvents rbMayor As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
