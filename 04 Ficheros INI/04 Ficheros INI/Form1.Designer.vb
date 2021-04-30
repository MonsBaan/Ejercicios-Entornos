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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSecciones = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbArchivo = New System.Windows.Forms.RadioButton()
        Me.rbSystem = New System.Windows.Forms.RadioButton()
        Me.rbWin = New System.Windows.Forms.RadioButton()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnElegir = New System.Windows.Forms.Button()
        Me.dlgAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contenido del Fichero"
        '
        'txtContenido
        '
        Me.txtContenido.Location = New System.Drawing.Point(12, 133)
        Me.txtContenido.Multiline = True
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(540, 273)
        Me.txtContenido.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(574, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Secciones"
        '
        'lstSecciones
        '
        Me.lstSecciones.FormattingEnabled = True
        Me.lstSecciones.ItemHeight = 15
        Me.lstSecciones.Location = New System.Drawing.Point(574, 133)
        Me.lstSecciones.Name = "lstSecciones"
        Me.lstSecciones.Size = New System.Drawing.Size(120, 274)
        Me.lstSecciones.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbSystem)
        Me.GroupBox1.Controls.Add(Me.rbWin)
        Me.GroupBox1.Location = New System.Drawing.Point(574, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 104)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'rbArchivo
        '
        Me.rbArchivo.AutoSize = True
        Me.rbArchivo.Checked = True
        Me.rbArchivo.Location = New System.Drawing.Point(10, 76)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(98, 19)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.TabStop = True
        Me.rbArchivo.Text = "Elegir Archivo"
        Me.rbArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbArchivo.UseVisualStyleBackColor = True
        '
        'rbSystem
        '
        Me.rbSystem.AutoSize = True
        Me.rbSystem.Location = New System.Drawing.Point(10, 47)
        Me.rbSystem.Name = "rbSystem"
        Me.rbSystem.Size = New System.Drawing.Size(79, 19)
        Me.rbSystem.TabIndex = 1
        Me.rbSystem.Text = "System.ini"
        Me.rbSystem.UseVisualStyleBackColor = True
        '
        'rbWin
        '
        Me.rbWin.AutoSize = True
        Me.rbWin.Location = New System.Drawing.Point(10, 17)
        Me.rbWin.Name = "rbWin"
        Me.rbWin.Size = New System.Drawing.Size(62, 19)
        Me.rbWin.TabIndex = 0
        Me.rbWin.Text = "Win.ini"
        Me.rbWin.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(12, 79)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(521, 23)
        Me.txtArchivo.TabIndex = 5
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(481, 12)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(87, 52)
        Me.btnCargar.TabIndex = 6
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 52)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnElegir
        '
        Me.btnElegir.Location = New System.Drawing.Point(539, 79)
        Me.btnElegir.Name = "btnElegir"
        Me.btnElegir.Size = New System.Drawing.Size(29, 23)
        Me.btnElegir.TabIndex = 8
        Me.btnElegir.Text = "..."
        Me.btnElegir.UseVisualStyleBackColor = True
        '
        'dlgAbrir
        '
        Me.dlgAbrir.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 414)
        Me.Controls.Add(Me.btnElegir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstSecciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContenido)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtContenido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSecciones As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbArchivo As RadioButton
    Friend WithEvents rbSystem As RadioButton
    Friend WithEvents rbWin As RadioButton
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnElegir As Button
    Friend WithEvents dlgAbrir As OpenFileDialog
End Class
