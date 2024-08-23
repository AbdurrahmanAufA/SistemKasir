Public Class FrmSearch
    Dim WithEvents dttemp As New tempdt2
    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dttemp.lvTag = Me.Tag
        dttemp.lv1 = Me.lv
        dttemp.pb2 = Me.pb
        If Me.Tag = "pemasok" Then dtSearch()
        If Me.Tag = "member" Then dtSearch()
    End Sub

    Public Sub MenuPemasok()


    End Sub

    Public Sub dtSearch()
        Try
            csql = ""
            If Me.Tag = "pemasok" Then csql = "select PemasokID,Nama,Alamat from billmaster.dbo.Pemasok order by PemasokID"
            If Me.Tag = "member" Then csql = "select MemberID,Nama,Alamat from billmaster.dbo.Member order by MemberID"

            If csql = "" Then Exit Sub
            lvListAuto(lv, pb, csql)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try

    End Sub

    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv.DoubleClick
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If Me.Tag = "pemasok" Then
                'dttemp.PKey = lvi.Text
                FrmTransaksi2.tb3.Text = lvi.Text
                Me.Close()

            ElseIf Me.Tag = "member" Then
                'dttemp.PKey = lvi.Text
                FrmTransaksi.tb3.Text = lvi.Text
                Me.Close()
            End If

        End With
    End Sub
End Class