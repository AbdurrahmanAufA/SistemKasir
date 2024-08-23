<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster1
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
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(734, 531)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(143, 16)
        Me.pb.TabIndex = 31
        Me.pb.Visible = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(12, 528)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(42, 20)
        Me.lbrec.TabIndex = 30
        Me.lbrec.Text = "Rec."
        '
        'lv
        '
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(16, 245)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(862, 280)
        Me.lv.TabIndex = 29
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Kecamatan"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(207, 120)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(143, 26)
        Me.tb2.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nama"
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(207, 186)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(309, 26)
        Me.tb3.TabIndex = 22
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(207, 85)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(143, 26)
        Me.tb1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Kode"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(207, 152)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(121, 28)
        Me.cb1.TabIndex = 32
        '
        'FrmMaster1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 560)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMaster1"
        Me.Text = "FrmMaster1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents lbrec As Label
    Friend WithEvents lv As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb1 As ComboBox
End Class
