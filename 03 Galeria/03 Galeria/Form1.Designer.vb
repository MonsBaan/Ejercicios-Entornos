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
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.BarraHorizontal = New System.Windows.Forms.HScrollBar()
        Me.BarraVertical = New System.Windows.Forms.VScrollBar()
        Me.chkCuadrado = New System.Windows.Forms.CheckBox()
        Me.chkAjustar = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCarpeta = New System.Windows.Forms.TextBox()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnCarpeta = New System.Windows.Forms.Button()
        Me.panelManual = New System.Windows.Forms.Panel()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.dlgCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnAmpliar = New System.Windows.Forms.Button()
        Me.timerVentana = New System.Windows.Forms.Timer(Me.components)
        Me.panelModo = New System.Windows.Forms.GroupBox()
        Me.rbAuto = New System.Windows.Forms.RadioButton()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.panelAuto = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.numTiempo = New System.Windows.Forms.NumericUpDown()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.timerAuto = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelManual.SuspendLayout()
        Me.panelModo.SuspendLayout()
        Me.panelAuto.SuspendLayout()
        CType(Me.numTiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFoto
        '
        Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFoto.Location = New System.Drawing.Point(12, 9)
        Me.picFoto.MaximumSize = New System.Drawing.Size(400, 400)
        Me.picFoto.MinimumSize = New System.Drawing.Size(50, 50)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(50, 50)
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'BarraHorizontal
        '
        Me.BarraHorizontal.Location = New System.Drawing.Point(12, 437)
        Me.BarraHorizontal.Maximum = 400
        Me.BarraHorizontal.Minimum = 50
        Me.BarraHorizontal.Name = "BarraHorizontal"
        Me.BarraHorizontal.Size = New System.Drawing.Size(420, 19)
        Me.BarraHorizontal.TabIndex = 1
        Me.BarraHorizontal.Value = 50
        '
        'BarraVertical
        '
        Me.BarraVertical.Location = New System.Drawing.Point(441, 9)
        Me.BarraVertical.Maximum = 400
        Me.BarraVertical.Minimum = 50
        Me.BarraVertical.Name = "BarraVertical"
        Me.BarraVertical.Size = New System.Drawing.Size(19, 420)
        Me.BarraVertical.TabIndex = 2
        Me.BarraVertical.Value = 50
        '
        'chkCuadrado
        '
        Me.chkCuadrado.AutoSize = True
        Me.chkCuadrado.Checked = True
        Me.chkCuadrado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCuadrado.Location = New System.Drawing.Point(504, 36)
        Me.chkCuadrado.Name = "chkCuadrado"
        Me.chkCuadrado.Size = New System.Drawing.Size(77, 19)
        Me.chkCuadrado.TabIndex = 3
        Me.chkCuadrado.Text = "Cuadrado"
        Me.chkCuadrado.UseVisualStyleBackColor = True
        '
        'chkAjustar
        '
        Me.chkAjustar.AutoSize = True
        Me.chkAjustar.Checked = True
        Me.chkAjustar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAjustar.Location = New System.Drawing.Point(504, 61)
        Me.chkAjustar.Name = "chkAjustar"
        Me.chkAjustar.Size = New System.Drawing.Size(63, 19)
        Me.chkAjustar.TabIndex = 4
        Me.chkAjustar.Text = "Ajustar"
        Me.chkAjustar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Carpeta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 510)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Archivo"
        '
        'txtCarpeta
        '
        Me.txtCarpeta.Location = New System.Drawing.Point(66, 474)
        Me.txtCarpeta.Name = "txtCarpeta"
        Me.txtCarpeta.ReadOnly = True
        Me.txtCarpeta.Size = New System.Drawing.Size(394, 23)
        Me.txtCarpeta.TabIndex = 7
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(66, 507)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.ReadOnly = True
        Me.txtArchivo.Size = New System.Drawing.Size(394, 23)
        Me.txtArchivo.TabIndex = 8
        '
        'btnCarpeta
        '
        Me.btnCarpeta.Location = New System.Drawing.Point(489, 474)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.btnCarpeta.Size = New System.Drawing.Size(126, 23)
        Me.btnCarpeta.TabIndex = 9
        Me.btnCarpeta.Text = "Buscar Carpeta"
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'panelManual
        '
        Me.panelManual.Controls.Add(Me.btnUltimo)
        Me.panelManual.Controls.Add(Me.btnSiguiente)
        Me.panelManual.Controls.Add(Me.btnAnterior)
        Me.panelManual.Controls.Add(Me.btnPrimero)
        Me.panelManual.Location = New System.Drawing.Point(489, 86)
        Me.panelManual.Name = "panelManual"
        Me.panelManual.Size = New System.Drawing.Size(126, 169)
        Me.panelManual.TabIndex = 11
        '
        'btnUltimo
        '
        Me.btnUltimo.Enabled = False
        Me.btnUltimo.Location = New System.Drawing.Point(16, 127)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(93, 31)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.Location = New System.Drawing.Point(16, 90)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(93, 31)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Enabled = False
        Me.btnAnterior.Location = New System.Drawing.Point(16, 53)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(93, 31)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Enabled = False
        Me.btnPrimero.Location = New System.Drawing.Point(16, 16)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(93, 31)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAmpliar
        '
        Me.btnAmpliar.Location = New System.Drawing.Point(584, 285)
        Me.btnAmpliar.Name = "btnAmpliar"
        Me.btnAmpliar.Size = New System.Drawing.Size(31, 160)
        Me.btnAmpliar.TabIndex = 12
        Me.btnAmpliar.Text = ">>"
        Me.btnAmpliar.UseVisualStyleBackColor = True
        '
        'timerVentana
        '
        Me.timerVentana.Interval = 1
        '
        'panelModo
        '
        Me.panelModo.Controls.Add(Me.rbAuto)
        Me.panelModo.Controls.Add(Me.rbManual)
        Me.panelModo.Enabled = False
        Me.panelModo.Location = New System.Drawing.Point(698, 105)
        Me.panelModo.Name = "panelModo"
        Me.panelModo.Size = New System.Drawing.Size(143, 81)
        Me.panelModo.TabIndex = 15
        Me.panelModo.TabStop = False
        Me.panelModo.Text = "Modo"
        '
        'rbAuto
        '
        Me.rbAuto.AutoSize = True
        Me.rbAuto.Location = New System.Drawing.Point(16, 51)
        Me.rbAuto.Name = "rbAuto"
        Me.rbAuto.Size = New System.Drawing.Size(51, 19)
        Me.rbAuto.TabIndex = 1
        Me.rbAuto.Text = "Auto"
        Me.rbAuto.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Checked = True
        Me.rbManual.Location = New System.Drawing.Point(16, 22)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(65, 19)
        Me.rbManual.TabIndex = 0
        Me.rbManual.TabStop = True
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'panelAuto
        '
        Me.panelAuto.Controls.Add(Me.ProgressBar1)
        Me.panelAuto.Controls.Add(Me.btnReiniciar)
        Me.panelAuto.Controls.Add(Me.btnEmpezar)
        Me.panelAuto.Controls.Add(Me.numTiempo)
        Me.panelAuto.Controls.Add(Me.lblTiempo)
        Me.panelAuto.Enabled = False
        Me.panelAuto.Location = New System.Drawing.Point(698, 259)
        Me.panelAuto.Name = "panelAuto"
        Me.panelAuto.Size = New System.Drawing.Size(143, 197)
        Me.panelAuto.TabIndex = 16
        Me.panelAuto.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 163)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(120, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 4
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(30, 128)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnReiniciar.TabIndex = 3
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnEmpezar
        '
        Me.btnEmpezar.Location = New System.Drawing.Point(30, 85)
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpezar.TabIndex = 2
        Me.btnEmpezar.Text = "Empezar"
        Me.btnEmpezar.UseVisualStyleBackColor = True
        '
        'numTiempo
        '
        Me.numTiempo.Location = New System.Drawing.Point(30, 43)
        Me.numTiempo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTiempo.Name = "numTiempo"
        Me.numTiempo.Size = New System.Drawing.Size(75, 23)
        Me.numTiempo.TabIndex = 1
        Me.numTiempo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(12, 19)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(82, 15)
        Me.lblTiempo.TabIndex = 0
        Me.lblTiempo.Text = "Tiempo (Seg):"
        '
        'timerAuto
        '
        Me.timerAuto.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(639, 546)
        Me.Controls.Add(Me.panelAuto)
        Me.Controls.Add(Me.panelModo)
        Me.Controls.Add(Me.btnAmpliar)
        Me.Controls.Add(Me.panelManual)
        Me.Controls.Add(Me.btnCarpeta)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.txtCarpeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAjustar)
        Me.Controls.Add(Me.chkCuadrado)
        Me.Controls.Add(Me.BarraVertical)
        Me.Controls.Add(Me.BarraHorizontal)
        Me.Controls.Add(Me.picFoto)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelManual.ResumeLayout(False)
        Me.panelModo.ResumeLayout(False)
        Me.panelModo.PerformLayout()
        Me.panelAuto.ResumeLayout(False)
        Me.panelAuto.PerformLayout()
        CType(Me.numTiempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents picFoto As PictureBox
    Friend WithEvents BarraHorizontal As HScrollBar
    Friend WithEvents BarraVertical As VScrollBar
    Friend WithEvents chkCuadrado As CheckBox
    Friend WithEvents chkAjustar As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCarpeta As TextBox
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents btnCarpeta As Button
    Friend WithEvents panelManual As Panel
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents dlgCarpeta As FolderBrowserDialog
    Friend WithEvents btnAmpliar As Button
    Friend WithEvents timerVentana As Timer
    Friend WithEvents panelModo As GroupBox
    Friend WithEvents rbAuto As RadioButton
    Friend WithEvents rbManual As RadioButton
    Friend WithEvents panelAuto As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnEmpezar As Button
    Friend WithEvents numTiempo As NumericUpDown
    Friend WithEvents lblTiempo As Label
    Friend WithEvents timerAuto As Timer
End Class
