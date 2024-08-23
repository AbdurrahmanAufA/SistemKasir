Public Class FrmTransaksi2
    Dim WithEvents dttemp As New tempdt2
    Dim WithEvents cpro As New msaConn
    Dim noform As Integer
    Private Sub FrmTransaksi2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        'Label1.Text = ""
        'If dttemp.ndKey = "tb" Then Label1.Text = "TRANSAKSI BELI"

        tb1.Focus() : SendKeys.Send("{end}")
        ambilKaryawan()
        ambilToko()
        listHeader()
    End Sub

    Private Sub FrmTransaksi2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub

    Private Sub tb3_TextChanged(sender As Object, e As EventArgs) Handles tb3.TextChanged
        Try

            tb4.Text = ""
            If dttemp.ndKey = "tb" Then
                csql = "select Nama,Alamat from BillMaster.dbo.Pemasok where PemasokID='" & tb3.Text & "'"
            End If
            If tb3.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb4.Text = dt(0)
                tb5.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub tb11_TextChanged(sender As Object, e As EventArgs) Handles tb11.TextChanged
        Try

            tb14.Text = ""
            tb12.Text = ""
            tb13.Text = ""
            tb15.Text = ""
            tb16.Text = ""
            tb17.Text = ""
            If dttemp.ndKey = "tb" Then
                csql = "select a.Satuan, a.Nama from BillMaster.dbo.Barang a where BarangID='" & tb11.Text & "'"
            End If
            If tb11.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb12.Text = dt(1)
                tb13.Text = dt(0)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        Dim frmsearch As New FrmSearch
        With frmsearch
            .Text = "Pemasok "
            .Tag = "pemasok"
            .Show()
        End With
    End Sub

    Private Sub ambilToko()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Nama from BillMaster.dbo.Toko"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("Nama"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub

    Private Sub ambilKaryawan()
        cb2.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Username from BillMaster.dbo.Karyawan"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb2
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("Username"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub

    Private Sub FrmTransaksi2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, cb1.KeyPress, cb2.KeyPress, tb3.KeyPress, tb11.KeyPress, tb14.KeyPress, tb12.KeyPress, tb13.KeyPress, tb15.KeyPress, tb16.KeyPress, tb17.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then cb2.Focus() : cb2.DroppedDown = True
            If sender.Equals(cb2) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb11.Focus() : SendKeys.Send("{end}")

            If sender.Equals(tb11) Then tb14.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb14) Then tb15.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb15) Then tb16.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb16) Then tb17.Focus() : hargaTotal() : lb1.Text = tb17.Text : SendKeys.Send("{end}")
            If sender.Equals(tb17) Then
                'simpan
                'dtpro("sim")
                listTambah()
                HitungTotal()
                dtpro("bar")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(cb1) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb2) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(tb3) Then cb2.Focus() : cb2.DroppedDown = True
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub listHeader()
        lv.Columns.Add("ID", 80, HorizontalAlignment.Left)
        lv.Columns.Add("Barang", 100, HorizontalAlignment.Left)
        lv.Columns.Add("Satuan", 100, HorizontalAlignment.Left)
        lv.Columns.Add("Jumlah", 80, HorizontalAlignment.Left)
        lv.Columns.Add("Harga", 80, HorizontalAlignment.Left)
        lv.Columns.Add("Diskon", 80, HorizontalAlignment.Left)
        lv.Columns.Add("Total", 80, HorizontalAlignment.Left)
    End Sub

    Private Sub listTambah()
        Dim newitem As New ListViewItem(tb11.Text)
        newitem.SubItems.Add(tb12.Text)
        newitem.SubItems.Add(tb13.Text)
        newitem.SubItems.Add(tb14.Text)
        newitem.SubItems.Add(tb15.Text)
        newitem.SubItems.Add(tb16.Text)
        newitem.SubItems.Add(tb17.Text)

        lv.Items.Add(newitem)

    End Sub

    Private Sub hargaTotal()
        tb17.Text = (100 - tb16.Text) * tb15.Text / 100 * tb14.Text
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Then
                For x = 0 To lv.Items.Count - 1
                    'csql = "INSERT INTO Bill.dbo.TransBeliPot (TransBeliID,Pot,PPn) Values ('" & lv.Items(x).SubItems(0).Text & "', '" & lv.Items(x).SubItems(1).Text & "','" & lv.Items(x).SubItems(2).Text & "')"
                    csql = "exec bill.dbo.sp_Bill#1Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','','" & cb1.Text & "','" & cb2.Text & "','" & tb3.Text & "','','" & lv.Items(x).SubItems(0).Text & "', '" & lv.Items(x).SubItems(3).Text & "','" & lv.Items(x).SubItems(4).Text & "','" & lv.Items(x).SubItems(5).Text & "',''"

                    cpro.ExecNonQuery(csql)

                Next
                MsgBox("Messages Saved")
                lv.Items.Clear()
                dtpro("bar")
                tb1.Text = ""
                tb3.Text = ""
                tb4.Text = ""
                tb5.Text = ""
                cb1.Text = ""
                cb2.Text = ""
                tb1.Focus()
            ElseIf mpro = "bar" Then
                tb11.Text = ""
                tb12.Text = ""
                tb13.Text = ""
                tb14.Text = ""
                tb15.Text = ""
                tb16.Text = ""
                tb15.Text = ""
                tb11.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        dtpro("sim")
    End Sub
    Private Sub HitungTotal()
        Dim hitung = 0
        For baris = 0 To lv.Items.Count - 1
            hitung = hitung + lv.Items(baris).SubItems(6).Text
        Next
        lb1.Text = hitung
    End Sub

    Private Sub tb19_TextChanged(sender As Object, e As EventArgs) Handles tb19.TextChanged
        tb20.Text = tb19.Text - lb1.Text
    End Sub
End Class