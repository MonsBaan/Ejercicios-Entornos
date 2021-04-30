<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstNombres = New System.Windows.Forms.ListBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnPasar = New System.Windows.Forms.Button()
        Me.btnEliminarSel = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.TimerInicio = New System.Windows.Forms.Timer(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNombres
        '
        Me.lstNombres.FormattingEnabled = True
        Me.lstNombres.ItemHeight = 24
        Me.lstNombres.Location = New System.Drawing.Point(8, 116)
        Me.lstNombres.Name = "lstNombres"
        Me.lstNombres.Size = New System.Drawing.Size(143, 220)
        Me.lstNombres.TabIndex = 0
        '
        'btnAñadir
        '
        Me.btnAñadir.Enabled = False
        Me.btnAñadir.Location = New System.Drawing.Point(8, 63)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(101, 34)
        Me.btnAñadir.TabIndex = 1
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(120, 63)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 34)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(8, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(213, 32)
        Me.txtNombre.TabIndex = 4
        '
        'btnPasar
        '
        Me.btnPasar.Enabled = False
        Me.btnPasar.Location = New System.Drawing.Point(157, 200)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(113, 49)
        Me.btnPasar.TabIndex = 5
        Me.btnPasar.Text = "Pasar"
        Me.btnPasar.UseVisualStyleBackColor = True
        '
        'btnEliminarSel
        '
        Me.btnEliminarSel.Enabled = False
        Me.btnEliminarSel.Location = New System.Drawing.Point(157, 287)
        Me.btnEliminarSel.Name = "btnEliminarSel"
        Me.btnEliminarSel.Size = New System.Drawing.Size(113, 49)
        Me.btnEliminarSel.TabIndex = 7
        Me.btnEliminarSel.Text = "Eliminar"
        Me.btnEliminarSel.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Enabled = False
        Me.btnVaciar.Location = New System.Drawing.Point(157, 116)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(113, 49)
        Me.btnVaciar.TabIndex = 8
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'cbNombres
        '
        Me.cbNombres.FormattingEnabled = True
        Me.cbNombres.Location = New System.Drawing.Point(279, 116)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(186, 32)
        Me.cbNombres.TabIndex = 9
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.Location = New System.Drawing.Point(364, 328)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(101, 41)
        Me.btnSiguiente.TabIndex = 10
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'TimerInicio
        '
        Me.TimerInicio.Interval = 1000
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(357, 25)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(101, 41)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(12, 342)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.ReadOnly = True
        Me.txtTiempo.Size = New System.Drawing.Size(57, 32)
        Me.txtTiempo.TabIndex = 12
        Me.txtTiempo.Text = "2:00"
        Me.txtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tiempo (min:seg)"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnAñadir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 380)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.cbNombres)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnEliminarSel)
        Me.Controls.Add(Me.btnPasar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lstNombres)
        Me.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNombres As ListBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnPasar As Button
    Friend WithEvents btnEliminarSel As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents cbNombres As ComboBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents TimerInicio As Timer
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents Label2 As Label
End Class
