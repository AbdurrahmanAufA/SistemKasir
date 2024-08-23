<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExplo2
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.ct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BukaFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbPD = New System.Windows.Forms.Label()
        Me.cbPD = New System.Windows.Forms.ComboBox()
        Me.tthn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.lv2 = New System.Windows.Forms.ListView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ct.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.pb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 512)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(697, 30)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(100, 24)
        Me.pb.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.bt1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 512)
        Me.SplitContainer1.SplitterDistance = 261
        Me.SplitContainer1.TabIndex = 1
        '
        'bt1
        '
        Me.bt1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bt1.Location = New System.Drawing.Point(82, 440)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(84, 42)
        Me.bt1.TabIndex = 5
        Me.bt1.Text = "Cetak"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'tv
        '
        Me.tv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tv.ContextMenuStrip = Me.ct
        Me.tv.Location = New System.Drawing.Point(4, 157)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(254, 351)
        Me.tv.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbPD)
        Me.Panel1.Controls.Add(Me.cbPD)
        Me.Panel1.Controls.Add(Me.tthn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 151)
        Me.Panel1.TabIndex = 0
        '
        'lbPD
        '
        Me.lbPD.AutoSize = True
        Me.lbPD.Location = New System.Drawing.Point(118, 101)
        Me.lbPD.Name = "lbPD"
        Me.lbPD.Size = New System.Drawing.Size(63, 20)
        Me.lbPD.TabIndex = 4
        Me.lbPD.Text = "Periode"
        '
        'cbPD
        '
        Me.cbPD.FormattingEnabled = True
        Me.cbPD.Location = New System.Drawing.Point(122, 67)
        Me.cbPD.Name = "cbPD"
        Me.cbPD.Size = New System.Drawing.Size(104, 28)
        Me.cbPD.TabIndex = 3
        '
        'tthn
        '
        Me.tthn.Location = New System.Drawing.Point(122, 32)
        Me.tthn.Name = "tthn"
        Me.tthn.Size = New System.Drawing.Size(88, 26)
        Me.tthn.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Periode"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(54, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Tahun"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lv1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lv2)
        Me.SplitContainer2.Size = New System.Drawing.Size(432, 512)
        Me.SplitContainer2.SplitterDistance = 209
        Me.SplitContainer2.TabIndex = 0
        '
        'lv1
        '
        Me.lv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv1.FullRowSelect = True
        Me.lv1.Location = New System.Drawing.Point(1, 3)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(426, 202)
        Me.lv1.TabIndex = 0
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'lv2
        '
        Me.lv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv2.FullRowSelect = True
        Me.lv2.Location = New System.Drawing.Point(0, 2)
        Me.lv2.Name = "lv2"
        Me.lv2.Size = New System.Drawing.Size(427, 290)
        Me.lv2.TabIndex = 1
        Me.lv2.UseCompatibleStateImageBehavior = False
        '
        'frmExplo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 542)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmExplo2"
        Me.Text = "Explo2"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ct.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tv As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lv1 As ListView
    Friend WithEvents lv2 As ListView
    Friend WithEvents lbPD As Label
    Friend WithEvents cbPD As ComboBox
    Friend WithEvents tthn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents pb As ToolStripProgressBar
    Friend WithEvents ct As ContextMenuStrip
    Friend WithEvents BukaFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bt1 As Button
End Class
