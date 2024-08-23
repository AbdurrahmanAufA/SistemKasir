<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BertumpukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertikalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BertumpukToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertikalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.WindowsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.WindowsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BertumpukToolStripMenuItem, Me.HorisonToolStripMenuItem, Me.VertikalToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(217, 30)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'BertumpukToolStripMenuItem
        '
        Me.BertumpukToolStripMenuItem.Name = "BertumpukToolStripMenuItem"
        Me.BertumpukToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.BertumpukToolStripMenuItem.Text = "Bertumpuk"
        '
        'HorisonToolStripMenuItem
        '
        Me.HorisonToolStripMenuItem.Name = "HorisonToolStripMenuItem"
        Me.HorisonToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.HorisonToolStripMenuItem.Text = "Horisontal"
        '
        'VertikalToolStripMenuItem
        '
        Me.VertikalToolStripMenuItem.Name = "VertikalToolStripMenuItem"
        Me.VertikalToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.VertikalToolStripMenuItem.Text = "Vertikal"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.TransToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.TransaksiToolStripMenuItem.Text = "&Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'WindowsToolStripMenuItem1
        '
        Me.WindowsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BertumpukToolStripMenuItem1, Me.VertikalToolStripMenuItem1, Me.HorizontalToolStripMenuItem})
        Me.WindowsToolStripMenuItem1.Name = "WindowsToolStripMenuItem1"
        Me.WindowsToolStripMenuItem1.Size = New System.Drawing.Size(98, 29)
        Me.WindowsToolStripMenuItem1.Text = "Windows"
        '
        'BertumpukToolStripMenuItem1
        '
        Me.BertumpukToolStripMenuItem1.Name = "BertumpukToolStripMenuItem1"
        Me.BertumpukToolStripMenuItem1.Size = New System.Drawing.Size(210, 30)
        Me.BertumpukToolStripMenuItem1.Text = "Bertumpuk"
        '
        'VertikalToolStripMenuItem1
        '
        Me.VertikalToolStripMenuItem1.Name = "VertikalToolStripMenuItem1"
        Me.VertikalToolStripMenuItem1.Size = New System.Drawing.Size(210, 30)
        Me.VertikalToolStripMenuItem1.Text = "Vertikal"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'TransToolStripMenuItem
        '
        Me.TransToolStripMenuItem.Name = "TransToolStripMenuItem"
        Me.TransToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.TransToolStripMenuItem.Text = "Trans"
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(515, 479)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmUtama"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BertumpukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorisonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BertumpukToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VertikalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransToolStripMenuItem As ToolStripMenuItem
End Class
