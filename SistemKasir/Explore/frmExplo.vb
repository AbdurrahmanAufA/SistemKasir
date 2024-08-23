Imports SistemKasir

Public Class frmExplo
    Dim WithEvents dttemp As New tempdt

    Private Sub frmExplo_Load(sender As Object, e As EventArgs) Handles Me.Load
        dttemp.lvTag = Me.Tag
        dttemp.tv = Me.tv
        dttemp.lv = Me.lv
        dttemp.pb = Me.pb
        If Me.Tag = "mast" Then
            dttemp.MenuMaster()
        End If

    End Sub

    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        dttemp.ndKey = tv.SelectedNode.Name
        If Me.Tag = "mast" Then dttemp.dtMaster()

        Me.ts1.Text = Me.tv.SelectedNode.Text

    End Sub

    Private Sub frmExplo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dttemp = Nothing
    End Sub

    Private Sub lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv.SelectedIndexChanged
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)


            Me.ts2.Text = "Sorot " & lvi.Text & " " & lvi.Index & " dari " & .Items.Count
        End With
    End Sub

    Private Sub BukaFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFormToolStripMenuItem.Click
        dttemp.BukaForm(Me.Tag)
    End Sub

    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv.DoubleClick
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If dttemp.ndKey = "pro" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "jen" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "kab" Or dttemp.ndKey = "kec" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "pmk" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "mbr" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "tk" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "krw" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "brd" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "brj" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)

            End If

        End With

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim waktu = Now.ToLongTimeString
        Dim filexlxs As String = DOKPath & "\" & Format(Now, "yyyyMM") & " - " & waktu & ".xlsx"
        Dim Xcel As String = Format(Now, "yyyyMM") & " - " & waktu & ".xlsx"
        Dim lvitems = lv.Items
        Dim lvutama = lv
        Dim rec = lv.Items.Count
        exportExcelCekfileExist(filexlxs, Xcel, filetxt, rec, lvitems, lvutama)
    End Sub
End Class

Public Class tempdt
    Inherits msaConn
    Implements ClassInterface.explore1
    Implements ClassInterface.nKey

    Dim ntv As TreeView, nlv As ListView, nlvtag As String, nPB As ToolStripProgressBar
    Dim troot As TreeNode, troot1 As TreeNode, troot2 As TreeNode

    Public Property tv As TreeView Implements ClassInterface.explore1.tv
        Get
            tv = ntv
        End Get
        Set(value As TreeView)
            ntv = value
        End Set
    End Property

    Public Property lv As ListView Implements ClassInterface.explore1.lv
        Get
            lv = nlv
        End Get
        Set(value As ListView)
            nlv = value
        End Set
    End Property

    Public Property lvTag As String Implements ClassInterface.explore1.lvTag
        Get
            lvTag = nlvtag
        End Get
        Set(value As String)
            nlvtag = value
        End Set
    End Property

    Public Property pb As ToolStripProgressBar Implements ClassInterface.explore1.pb
        Get
            pb = nPB
        End Get
        Set(value As ToolStripProgressBar)
            nPB = value
        End Set
    End Property

    Public Property ndKey As String Implements ClassInterface.explore1.ndKey
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

    Public Sub MenuMaster()
        With tv
            troot = .Nodes.Add("wil", "Wilayah")
            troot1 = troot.Nodes.Add("pro", "Propinsi")
            troot1 = troot.Nodes.Add("kab", "Kabupaten")
            troot1 = troot.Nodes.Add("kec", "Kecamatan")
            troot.Expand()

            troot = .Nodes.Add("brg", "Barang")
            troot1 = troot.Nodes.Add("brd", "Data Barang")
            troot1 = troot.Nodes.Add("jen", "Jenis Barang")
            troot1 = troot.Nodes.Add("brj", "Barang Jual")
            troot.Expand()

            troot = .Nodes.Add("pmk", "Pemasok")
            troot.Expand()

            troot = .Nodes.Add("mbr", "Member")
            troot.Expand()

            troot = .Nodes.Add("tk", "Toko")
            troot.Expand()

            troot = .Nodes.Add("krw", "Karyawan")
            troot.Expand()
        End With
    End Sub

    Public Sub dtMaster()
        Try
            csql = ""
            If ndKey = "pro" Then csql = "select ProID,Keterangan from billmaster.dbo.wilprop order by proID"
            If ndKey = "kab" Then csql = "select KabID,KetKab from billmaster.dbo.vwilKab order by kabID"
            If ndKey = "kec" Then csql = "select KecID,Keterangan from billmaster.dbo.vwilkec order by KecID"

            If ndKey = "brd" Then csql = "select BarangID,Keterangan,jumlah from billmaster.dbo.vBar order by BarangID"
            If ndKey = "jen" Then csql = "select Jenis,KetJenis from billmaster.dbo.Barangjen order by Jenis"
            If ndKey = "brj" Then csql = "select BarangID,Harga from billmaster.dbo.BarangJual order by BarangID"

            If ndKey = "pmk" Then csql = "select PemasokID,Nama,Alamat from billmaster.dbo.Pemasok order by PemasokID"

            If ndKey = "mbr" Then csql = "select MemberID,Nama,Alamat from billmaster.dbo.Member order by MemberID"

            If ndKey = "tk" Then csql = "select TokoID,Nama,Alamat from billmaster.dbo.Toko order by TokoID"

            If ndKey = "krw" Then csql = "select KarID,Username,Alamat from billmaster.dbo.Karyawan order by KarID"

            If csql = "" Then Exit Sub
            lvListAutoMain(lv, pb, csql)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try

    End Sub

    Public Sub BukaForm(ByVal meTag As String)
        If meTag = "mast" Then
            Select Case ndKey
                Case "pro"
                    FrmMaster.Show()
                Case "jen"
                    FrmMaster.Show()
                Case "kab", "kec"
                    frmMasterR.Show()
                Case "pmk", "tk"
                    FrmMaster1.Show()
                Case "mbr"
                    FrmMaster2.Show()
                Case "krw"
                    FrmMaster3.Show()
                Case "brd"
                    FrmMaster4.Show()
                Case "brj"
                    FrmMaster5.Show()
            End Select


        End If

    End Sub



End Class