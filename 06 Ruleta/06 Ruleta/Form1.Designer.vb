<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ruleta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl01 = New System.Windows.Forms.Label()
        Me.lbl02 = New System.Windows.Forms.Label()
        Me.lbl03 = New System.Windows.Forms.Label()
        Me.lbl04 = New System.Windows.Forms.Label()
        Me.lbl05 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl09 = New System.Windows.Forms.Label()
        Me.lbl08 = New System.Windows.Forms.Label()
        Me.lbl07 = New System.Windows.Forms.Label()
        Me.lbl06 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.lbl19 = New System.Windows.Forms.Label()
        Me.lbl18 = New System.Windows.Forms.Label()
        Me.lbl17 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.timerVentana = New System.Windows.Forms.Timer(Me.components)
        Me.timerRuleta = New System.Windows.Forms.Timer(Me.components)
        Me.timerExtra = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelRes = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elige un Numero"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 37)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(169, 32)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._06_Ruleta.My.Resources.Resources.BotonActivo
        Me.PictureBox1.Location = New System.Drawing.Point(148, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(12, 148)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(169, 204)
        Me.ListBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Registro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Iniciar Ruleta"
        '
        'lbl01
        '
        Me.lbl01.AutoSize = True
        Me.lbl01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl01.Location = New System.Drawing.Point(213, 90)
        Me.lbl01.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.Size = New System.Drawing.Size(34, 27)
        Me.lbl01.TabIndex = 23
        Me.lbl01.Text = "01"
        '
        'lbl02
        '
        Me.lbl02.AutoSize = True
        Me.lbl02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl02.Location = New System.Drawing.Point(267, 90)
        Me.lbl02.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl02.Name = "lbl02"
        Me.lbl02.Size = New System.Drawing.Size(34, 27)
        Me.lbl02.TabIndex = 8
        Me.lbl02.Text = "02"
        '
        'lbl03
        '
        Me.lbl03.AutoSize = True
        Me.lbl03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl03.Location = New System.Drawing.Point(321, 90)
        Me.lbl03.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl03.Name = "lbl03"
        Me.lbl03.Size = New System.Drawing.Size(34, 27)
        Me.lbl03.TabIndex = 9
        Me.lbl03.Text = "03"
        '
        'lbl04
        '
        Me.lbl04.AutoSize = True
        Me.lbl04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl04.Location = New System.Drawing.Point(375, 90)
        Me.lbl04.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl04.Name = "lbl04"
        Me.lbl04.Size = New System.Drawing.Size(34, 27)
        Me.lbl04.TabIndex = 10
        Me.lbl04.Text = "04"
        '
        'lbl05
        '
        Me.lbl05.AutoSize = True
        Me.lbl05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl05.Location = New System.Drawing.Point(429, 90)
        Me.lbl05.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl05.Name = "lbl05"
        Me.lbl05.Size = New System.Drawing.Size(34, 27)
        Me.lbl05.TabIndex = 11
        Me.lbl05.Text = "05"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl10.Location = New System.Drawing.Point(483, 278)
        Me.lbl10.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(34, 27)
        Me.lbl10.TabIndex = 16
        Me.lbl10.Text = "10"
        '
        'lbl09
        '
        Me.lbl09.AutoSize = True
        Me.lbl09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl09.Location = New System.Drawing.Point(483, 231)
        Me.lbl09.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl09.Name = "lbl09"
        Me.lbl09.Size = New System.Drawing.Size(34, 27)
        Me.lbl09.TabIndex = 15
        Me.lbl09.Text = "09"
        '
        'lbl08
        '
        Me.lbl08.AutoSize = True
        Me.lbl08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl08.Location = New System.Drawing.Point(483, 184)
        Me.lbl08.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl08.Name = "lbl08"
        Me.lbl08.Size = New System.Drawing.Size(34, 27)
        Me.lbl08.TabIndex = 14
        Me.lbl08.Text = "08"
        '
        'lbl07
        '
        Me.lbl07.AutoSize = True
        Me.lbl07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl07.Location = New System.Drawing.Point(483, 137)
        Me.lbl07.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl07.Name = "lbl07"
        Me.lbl07.Size = New System.Drawing.Size(34, 27)
        Me.lbl07.TabIndex = 13
        Me.lbl07.Text = "07"
        '
        'lbl06
        '
        Me.lbl06.AutoSize = True
        Me.lbl06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl06.Location = New System.Drawing.Point(483, 90)
        Me.lbl06.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl06.Name = "lbl06"
        Me.lbl06.Size = New System.Drawing.Size(34, 27)
        Me.lbl06.TabIndex = 12
        Me.lbl06.Text = "06"
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl15.Location = New System.Drawing.Point(267, 325)
        Me.lbl15.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(34, 27)
        Me.lbl15.TabIndex = 21
        Me.lbl15.Text = "15"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl14.Location = New System.Drawing.Point(321, 325)
        Me.lbl14.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(34, 27)
        Me.lbl14.TabIndex = 20
        Me.lbl14.Text = "14"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl13.Location = New System.Drawing.Point(375, 325)
        Me.lbl13.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(34, 27)
        Me.lbl13.TabIndex = 19
        Me.lbl13.Text = "13"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl12.Location = New System.Drawing.Point(429, 325)
        Me.lbl12.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(34, 27)
        Me.lbl12.TabIndex = 18
        Me.lbl12.Text = "12"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl11.Location = New System.Drawing.Point(483, 325)
        Me.lbl11.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(34, 27)
        Me.lbl11.TabIndex = 17
        Me.lbl11.Text = "11"
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl20.Location = New System.Drawing.Point(213, 137)
        Me.lbl20.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(34, 27)
        Me.lbl20.TabIndex = 7
        Me.lbl20.Text = "20"
        '
        'lbl19
        '
        Me.lbl19.AutoSize = True
        Me.lbl19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl19.Location = New System.Drawing.Point(213, 184)
        Me.lbl19.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl19.Name = "lbl19"
        Me.lbl19.Size = New System.Drawing.Size(34, 27)
        Me.lbl19.TabIndex = 25
        Me.lbl19.Text = "19"
        '
        'lbl18
        '
        Me.lbl18.AutoSize = True
        Me.lbl18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl18.Location = New System.Drawing.Point(213, 231)
        Me.lbl18.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(34, 27)
        Me.lbl18.TabIndex = 24
        Me.lbl18.Text = "18"
        '
        'lbl17
        '
        Me.lbl17.AutoSize = True
        Me.lbl17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl17.Location = New System.Drawing.Point(213, 278)
        Me.lbl17.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl17.Name = "lbl17"
        Me.lbl17.Size = New System.Drawing.Size(34, 27)
        Me.lbl17.TabIndex = 23
        Me.lbl17.Text = "17"
        '
        'lbl16
        '
        Me.lbl16.AutoSize = True
        Me.lbl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl16.Location = New System.Drawing.Point(213, 325)
        Me.lbl16.Margin = New System.Windows.Forms.Padding(10)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(34, 27)
        Me.lbl16.TabIndex = 22
        Me.lbl16.Text = "16"
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelNumero.Location = New System.Drawing.Point(441, 6)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(35, 29)
        Me.labelNumero.TabIndex = 27
        Me.labelNumero.Text = "00"
        '
        'timerVentana
        '
        Me.timerVentana.Interval = 10
        '
        'timerRuleta
        '
        Me.timerRuleta.Interval = 50
        '
        'timerExtra
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "El numero ganador es:"
        '
        'LabelRes
        '
        Me.LabelRes.AutoSize = True
        Me.LabelRes.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelRes.Location = New System.Drawing.Point(297, 43)
        Me.LabelRes.Name = "LabelRes"
        Me.LabelRes.Size = New System.Drawing.Size(0, 37)
        Me.LabelRes.TabIndex = 29
        Me.LabelRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ruleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 366)
        Me.Controls.Add(Me.LabelRes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.lbl19)
        Me.Controls.Add(Me.lbl18)
        Me.Controls.Add(Me.lbl17)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl09)
        Me.Controls.Add(Me.lbl08)
        Me.Controls.Add(Me.lbl07)
        Me.Controls.Add(Me.lbl06)
        Me.Controls.Add(Me.lbl05)
        Me.Controls.Add(Me.lbl04)
        Me.Controls.Add(Me.lbl03)
        Me.Controls.Add(Me.lbl02)
        Me.Controls.Add(Me.lbl01)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MaximumSize = New System.Drawing.Size(555, 480)
        Me.MinimumSize = New System.Drawing.Size(205, 405)
        Me.Name = "Ruleta"
        Me.Text = "RuletAlmi"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl01 As Label
    Friend WithEvents lbl02 As Label
    Friend WithEvents lbl03 As Label
    Friend WithEvents lbl04 As Label
    Friend WithEvents lbl05 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl09 As Label
    Friend WithEvents lbl08 As Label
    Friend WithEvents lbl07 As Label
    Friend WithEvents lbl06 As Label
    Friend WithEvents lbl15 As Label
    Friend WithEvents lbl14 As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl20 As Label
    Friend WithEvents lbl19 As Label
    Friend WithEvents lbl18 As Label
    Friend WithEvents lbl17 As Label
    Friend WithEvents lbl16 As Label
    Friend WithEvents labelNumero As Label
    Friend WithEvents timerVentana As Timer
    Friend WithEvents timerRuleta As Timer
    Friend WithEvents timerExtra As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelRes As Label
End Class
