<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formsimgaji
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Jk = New System.Windows.Forms.TextBox()
        Me.Jl = New System.Windows.Forms.TextBox()
        Me.Th = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Um = New System.Windows.Forms.TextBox()
        Me.Tg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perhitungan Gaji Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jml lembur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jml jam kerja"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jml tidak hadir"
        '
        'Jk
        '
        Me.Jk.Location = New System.Drawing.Point(162, 68)
        Me.Jk.Name = "Jk"
        Me.Jk.Size = New System.Drawing.Size(138, 26)
        Me.Jk.TabIndex = 4
        '
        'Jl
        '
        Me.Jl.Location = New System.Drawing.Point(162, 119)
        Me.Jl.Name = "Jl"
        Me.Jl.Size = New System.Drawing.Size(138, 26)
        Me.Jl.TabIndex = 5
        '
        'Th
        '
        Me.Th.Location = New System.Drawing.Point(162, 173)
        Me.Th.Name = "Th"
        Me.Th.Size = New System.Drawing.Size(138, 26)
        Me.Th.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "uang makan :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "total gaji :"
        '
        'Um
        '
        Me.Um.Location = New System.Drawing.Point(456, 122)
        Me.Um.Name = "Um"
        Me.Um.Size = New System.Drawing.Size(158, 26)
        Me.Um.TabIndex = 10
        '
        'Tg
        '
        Me.Tg.Location = New System.Drawing.Point(456, 68)
        Me.Tg.Name = "Tg"
        Me.Tg.Size = New System.Drawing.Size(158, 26)
        Me.Tg.TabIndex = 11
        '
        'Formsimgaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 263)
        Me.Controls.Add(Me.Tg)
        Me.Controls.Add(Me.Um)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Th)
        Me.Controls.Add(Me.Jl)
        Me.Controls.Add(Me.Jk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formsimgaji"
        Me.Text = "sim gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Jk As System.Windows.Forms.TextBox
    Friend WithEvents Jl As System.Windows.Forms.TextBox
    Friend WithEvents Th As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Um As System.Windows.Forms.TextBox
    Friend WithEvents Tg As System.Windows.Forms.TextBox

End Class
