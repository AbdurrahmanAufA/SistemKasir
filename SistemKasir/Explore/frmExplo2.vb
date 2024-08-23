Imports SistemKasir

Public Class frmExplo2
    Dim WithEvents dttemp As New tempdt2

    Private Sub isiPD(ByVal thn As Integer)
        With cbPD
            .Items.Clear()
            csql = "select Periode from billmaster.dbo.ft_Periode('" & thn & "')"
            For Each dt As DataRow In dttemp.ExecQuery(csql).Rows
                .Items.Add(dt(0))
            Next
            .Text = thn.ToString & Format(Now, "MM")
        End With
    End Sub


    Private Sub frmExplo_Load(sender As Object, e As EventArgs) Handles Me.Load
        dttemp.lvTag = Me.Tag
        dttemp.tv = Me.tv
        dttemp.lv1 = Me.lv1
        dttemp.pb = Me.pb
        tthn.Text = Now.Year
        If Me.Tag = "jual" Then
            dttemp.MenuTransaksi()
        End If

    End Sub

    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        dttemp.ndKey = tv.SelectedNode.Name
        If Me.Tag = "jual" Then dttemp.dtMaster()

        'Me.ts1.Text = Me.tv.SelectedNode.Text

    End Sub

    Private Sub frmExplo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dttemp = Nothing
    End Sub

    Private Sub lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv1.SelectedIndexChanged
        With lv1
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)


            'Me.ts2.Text = "Sorot " & lvi.Text & " " & lvi.Index & " dari " & .Items.Count
        End With
    End Sub

    Private Sub BukaFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFormToolStripMenuItem.Click
        dttemp.BukaForm(Me.Tag)
    End Sub

    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv1.DoubleClick
        With lv1
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If dttemp.ndKey = "pro" Then


            End If

        End With

    End Sub

    Private Sub tthn_TextChanged(sender As Object, e As EventArgs) Handles tthn.TextChanged, cbPD.TextChanged
        If sender.Equals(tthn) Then
            If Len(tthn.Text) = 4 Then
                isiPD(tthn.Text)
            End If
        ElseIf sender.Equals(cbPD) Then
            csql = "select nmPeriode from billmaster.dbo.ft_Periode('" & tthn.Text & "') where periode='" & cbPD.Text & "'"
            lbPD.Text = ""
            For Each dt As DataRow In dttemp.ExecQuery(csql).Rows
                lbPD.Text = dt(0)
            Next
        End If
    End Sub

    Private Sub tthn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tthn.KeyPress
        e.KeyChar = Chr(BatasAngka(e.KeyChar))
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim waktu = Now.ToLongTimeString
        Dim filexlxs As String = DOKPath & "\" & Format(Now, "yyyyMM") & " - " & waktu & ".xlsx"
        Dim Xcel As String = Format(Now, "yyyyMM") & " - " & waktu & ".xlsx"
        Dim lvitems = lv1.Items
        Dim lvutama = lv1
        Dim rec = lv1.Items.Count
        exportExcelCekfileExist(filexlxs, Xcel, filetxt, rec, lvitems, lvutama)
    End Sub
End Class

Public Class tempdt2
    Inherits msaConn
    Implements ClassInterface.explore2
    Implements ClassInterface.nKey

    Dim ntv As TreeView, nlv1 As ListView, nlv2 As ListView, nlvtag As String, nPB As ToolStripProgressBar, nPB2 As ProgressBar
    Dim troot As TreeNode, troot1 As TreeNode, troot2 As TreeNode

    Public Property tv As TreeView Implements ClassInterface.explore2.tv
        Get
            tv = ntv
        End Get
        Set(value As TreeView)
            ntv = value
        End Set
    End Property

    Public Property lv1 As ListView Implements ClassInterface.explore2.lv1
        Get
            lv1 = nlv1
        End Get
        Set(value As ListView)
            nlv1 = value
        End Set
    End Property

    Public Property lv2 As ListView Implements ClassInterface.explore2.lv2
        Get
            lv2 = nlv2
        End Get
        Set(value As ListView)
            nlv2 = value
        End Set
    End Property

    Public Property lvTag As String Implements ClassInterface.explore2.lvTag
        Get
            lvTag = nlvtag
        End Get
        Set(value As String)
            nlvtag = value
        End Set
    End Property

    Public Property pb As ToolStripProgressBar Implements ClassInterface.explore2.pb
        Get
            pb = nPB
        End Get
        Set(value As ToolStripProgressBar)
            nPB = value
        End Set
    End Property

    Public Property ndKey As String Implements ClassInterface.explore2.ndKey
        Get
            ndKey = nKey
        End Get
        Set(value As String)
            nKey = value
        End Set
    End Property

    Public Property PKey As String Implements ClassInterface.nKey.PKey
        Get
            PKey = nPKey
        End Get
        Set(value As String)
            nPKey = value
        End Set
    End Property

    Public Property SKey As String Implements ClassInterface.nKey.SKey
        Get
            SKey = nSKey
        End Get
        Set(value As String)
            nSKey = value
        End Set
    End Property

    Public Property Tkey As String Implements ClassInterface.nKey.Tkey
        Get
            Tkey = nTkey
        End Get
        Set(value As String)
            nTkey = value
        End Set
    End Property

    Public Property pb2 As ProgressBar Implements ClassInterface.explore2.pb2
        Get
            pb2 = nPB2
        End Get
        Set(value As ProgressBar)
            nPB2 = value
        End Set
    End Property

    Public Sub MenuTransaksi()
        With tv
            troot = .Nodes.Add("tp", "Penjualan")
            troot.Expand()

            troot = .Nodes.Add("tb", "Pembelian")
            troot.Expand()

        End With
    End Sub

    Public Sub dtMaster()
        Try
            csql = ""
            If ndKey = "tp" Then csql = "Select a.TransID,a.tglinput,a.TokoID,a.KarID,a.MemberID,a.Tanggal,b.BarangID,b.Jumlah,b.Harga,b.pot,c.PPn from Bill.dbo.TransJual a
	                                            inner join Bill.dbo.TransJualDet b on a.TransID = b.TransID
	                                            inner join Bill.dbo.TransJualPot c on b.TransID = c.TransID order by a.TransID"
            If ndKey = "tb" Then csql = "Select a.TransBeliID,a.tglinput,a.TokoID,a.KarID,a.PemasokID,a.Tanggal,b.BarangID,b.Jumlah,b.Harga,c.pot,c.PPn from Bill.dbo.TransBeli a
	                                            inner join Bill.dbo.TransBeliDet b on a.TransBeliID = b.TransBeliID
	                                            inner join Bill.dbo.TransBeliPot c on b.TransBeliID = c.TransBeliID order by a.TransBeliID"

            lvListAutoMain(lv1, pb, csql)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try

    End Sub

    Public Sub BukaForm(ByVal meTag As String)
        If meTag = "jual" Then
            Select Case ndKey
                Case "tp"
                    FrmTransaksi.Show()
                Case "tb"
                    FrmTransaksi2.Show()
            End Select


        End If
    End Sub
End Class
