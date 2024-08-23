<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExplo
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
        Me.ststrip = New System.Windows.Forms.StatusStrip()
        Me.ts1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.ct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BukaFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.lv = New System.Windows.Forms.ListView()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.ststrip.SuspendLayout()
        Me.ct.SuspendLayout()
        Me.SuspendLayout()
        '
        'ststrip
        '
        Me.ststrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ststrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts1, Me.ts2, Me.pb})
        Me.ststrip.Location = New System.Drawing.Point(0, 562)
        Me.ststrip.Name = "ststrip"
        Me.ststrip.Size = New System.Drawing.Size(683, 22)
        Me.ststrip.TabIndex = 0
        Me.ststrip.Text = "StatusStrip1"
        '
        'ts1
        '
        Me.ts1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ts1.Name = "ts1"
        Me.ts1.Size = New System.Drawing.Size(4, 17)
        Me.ts1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ts2
        '
        Me.ts2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ts2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ts2.Name = "ts2"
        Me.ts2.Size = New System.Drawing.Size(4, 17)
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(100, 24)
        Me.pb.Visible = False
        '
        'ct
        '
        Me.ct.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaFormToolStripMenuItem, Me.ToolStripSeparator1, Me.KeluarToolStripMenuItem})
        Me.ct.Name = "ct"
        Me.ct.Size = New System.Drawing.Size(170, 70)
        '
        'BukaFormToolStripMenuItem
        '
        Me.BukaFormToolStripMenuItem.Name = "BukaFormToolStripMenuItem"
        Me.BukaFormToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.BukaFormToolStripMenuItem.Text = "Buka Form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'tv
        '
        Me.tv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tv.ContextMenuStrip = Me.ct
        Me.tv.Location = New System.Drawing.Point(0, 2)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(248, 550)
        Me.tv.TabIndex = 2
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(254, 2)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(429, 550)
        Me.lv.TabIndex = 3
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(69, 479)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(84, 42)
        Me.bt1.TabIndex = 4
        Me.bt1.Text = "Cetak"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'frmExplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 584)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tv)
        Me.Controls.Add(Me.ststrip)
        Me.Name = "frmExplo"
        Me.Text = "frmExplo"
        Me.ststrip.ResumeLayout(False)
        Me.ststrip.PerformLayout()
        Me.ct.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ststrip As StatusStrip
    Friend WithEvents ts1 As ToolStripStatusLabel
    Friend WithEvents ts2 As ToolStripStatusLabel
    Friend WithEvents pb As ToolStripProgressBar
    Friend WithEvents ct As ContextMenuStrip
    Friend WithEvents BukaFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tv As TreeView
    Friend WithEvents lv As ListView
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents bt1 As Button
End Class
