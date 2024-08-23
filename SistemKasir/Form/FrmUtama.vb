Imports System.IO
Public Class FrmUtama
    Dim noform As Integer
    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        Dim frmexplo As New frmExplo
        With frmexplo
            .MdiParent = Me
            noform = +1
            .Text = "Master " & noform
            .Tag = "mast"
            .Show()
        End With
    End Sub

    Private Sub FrmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            DOKPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            IMGPath = DOKPath
            DOKPath = Path.Combine(DOKPath, "APP")
            My.Application.ChangeCulture("id-ID") 'english united kingdoom
            CreateFolderApp(DOKPath)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek ID")
        End Try
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim frmexplo As New frmExplo2
        With frmexplo
            .MdiParent = Me
            noform = +1
            .Text = "Penjualan " & noform
            .Tag = "jual"
            .Show()
        End With
    End Sub


    Private Sub HorisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorisonToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VertikalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub BertumpukToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BertumpukToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
