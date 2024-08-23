<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster5
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
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(196, 162)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(184, 26)
        Me.tb3.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Harga"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(720, 576)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(143, 16)
        Me.pb.TabIndex = 78
        Me.pb.Visible = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(-2, 573)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(42, 20)
        Me.lbrec.TabIndex = 77
        Me.lbrec.Text = "Rec."
        '
        'lv
        '
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(2, 290)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(862, 280)
        Me.lv.TabIndex = 76
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(196, 64)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(143, 26)
        Me.tb1.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Kode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Label1"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(196, 128)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(143, 28)
        Me.cb1.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Karyawan"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(196, 96)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(184, 26)
        Me.tb2.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Barang"
        '
        'FrmMaster5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 602)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMaster5"
        Me.Text = "FrmMaster5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents lbrec As Label
    Friend WithEvents lv As ListView
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label3 As Label
End Class
