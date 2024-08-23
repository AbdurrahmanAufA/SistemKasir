<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterR
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
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btR = New System.Windows.Forms.Button()
        Me.lbRelasi = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(203, 182)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(309, 26)
        Me.tb4.TabIndex = 9
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(203, 83)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(143, 26)
        Me.tb1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Relasi"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(203, 118)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(99, 26)
        Me.tb2.TabIndex = 11
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(203, 150)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(65, 26)
        Me.tb3.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Indek"
        '
        'btR
        '
        Me.btR.Location = New System.Drawing.Point(308, 120)
        Me.btR.Name = "btR"
        Me.btR.Size = New System.Drawing.Size(38, 24)
        Me.btR.TabIndex = 14
        Me.btR.Text = "..."
        Me.btR.UseVisualStyleBackColor = True
        '
        'lbRelasi
        '
        Me.lbRelasi.AutoSize = True
        Me.lbRelasi.Location = New System.Drawing.Point(352, 121)
        Me.lbRelasi.Name = "lbRelasi"
        Me.lbRelasi.Size = New System.Drawing.Size(53, 20)
        Me.lbRelasi.TabIndex = 15
        Me.lbRelasi.Text = "Relasi"
        '
        'lv
        '
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(12, 243)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(862, 280)
        Me.lv.TabIndex = 16
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(8, 526)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(42, 20)
        Me.lbrec.TabIndex = 17
        Me.lbrec.Text = "Rec."
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(730, 529)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(143, 16)
        Me.pb.TabIndex = 18
        Me.pb.Visible = False
        '
        'frmMasterR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 554)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.lbRelasi)
        Me.Controls.Add(Me.btR)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Relasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btR As Button
    Friend WithEvents lbRelasi As Label
    Friend WithEvents lv As ListView
    Friend WithEvents lbrec As Label
    Friend WithEvents pb As ProgressBar
End Class
