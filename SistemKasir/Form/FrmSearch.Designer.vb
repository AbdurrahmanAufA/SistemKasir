<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(730, 387)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(143, 16)
        Me.pb.TabIndex = 34
        Me.pb.Visible = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(8, 384)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(42, 20)
        Me.lbrec.TabIndex = 33
        Me.lbrec.Text = "Rec."
        '
        'lv
        '
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(12, 101)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(862, 280)
        Me.lv.TabIndex = 32
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(32, 55)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(822, 26)
        Me.TextBox6.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Text Pencarian"
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Name = "FrmSearch"
        Me.Text = "FrmSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb As ProgressBar
    Friend WithEvents lbrec As Label
    Friend WithEvents lv As ListView
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
End Class
