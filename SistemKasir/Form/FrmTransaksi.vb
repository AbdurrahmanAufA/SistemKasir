Public Class FrmTransaksi
    Dim WithEvents dttemp As New tempdt2
    Dim WithEvents cpro As New msaConn
    Dim noform As Integer
    Private Sub FrmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        'Label1.Text = ""
        'If dttemp.ndKey = "tb" Then Label1.Text = "TRANSAKSI BELI"

        tb1.Focus() : SendKeys.Send("{end}")
        ambilToko()
        ambilKaryawan()
        listHeader()
        HitungTotal()
    End Sub

    Private Sub FrmTransaksi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub

    Private Sub tb3_TextChanged(sender As Object, e As EventArgs) Handles tb3.TextChanged
        Try

            tb4.Text = ""
            If dttemp.ndKey = "tp" Then
                csql = "select Nama,Alamat from BillMaster.dbo.Member where MemberID='" & tb3.Text & "'"
            End If
            If tb3.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb4.Text = dt(0)
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
            If dttemp.ndKey = "tp" Then
                csql = "select a.Satuan, a.Nama, b.Harga from BillMaster.dbo.Barang a 
                        inner join Billmaster.dbo.BarangJual b on a.BarangID = b.BarangID where b.BarangID='" & tb11.Text & "'"
            End If
            If tb11.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb12.Text = dt(1)
                tb13.Text = dt(0)
                tb15.Text = dt(2)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
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
            If sender.Equals(cb2) Then cb3.Focus() : cb3.DroppedDown = True
            'If cb3.Text = "MEMBER" Then
            '    If sender.Equals(cb3) Then tb3.Focus() : SendKeys.Send("{end}")
            '    If sender.Equals(tb3) Then tb11.Focus() : SendKeys.Send("{end}")
            'End If

            If sender.Equals(tb11) Then tb14.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb14) Then tb16.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb16) Then tb17.Focus() : hargaTotal() : SendKeys.Send("{end}")
            If sender.Equals(tb17) Then
                'simpan
                'dtpro("sim")
                cekStok()
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

    Private Sub cb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb3.SelectedIndexChanged
        If cb3.Text = "MEMBER" Then
            tb3.Enabled = True
        Else
            tb3.Text = "0"
            tb3.Enabled = False
        End If
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

        If lv.Items.Count = 0 Then
            newitem.SubItems.Add(tb12.Text)
            newitem.SubItems.Add(tb13.Text)
            newitem.SubItems.Add(tb14.Text)
            newitem.SubItems.Add(tb15.Text)
            newitem.SubItems.Add(tb16.Text)
            newitem.SubItems.Add(tb17.Text)
            lv.Items.Add(newitem)
            MsgBox("Masuk")
        Else

            For x = 0 To lv.Items.Count - 1
                If (lv.Items(x).SubItems(0).Text = tb11.Text) Then
                    lv.Items(x).SubItems(3).Text = tb14.Text
                    MsgBox("Tambah")
                    Exit For
                Else
                    newitem.SubItems.Add(tb12.Text)
                    newitem.SubItems.Add(tb13.Text)
                    newitem.SubItems.Add(tb14.Text)
                    newitem.SubItems.Add(tb15.Text)
                    newitem.SubItems.Add(tb16.Text)
                    newitem.SubItems.Add(tb17.Text)
                    lv.Items.Add(newitem)
                    MsgBox("Masuuuuuk")
                End If
            Next
        End If
    End Sub

    Private Sub hargaTotal()
        tb17.Text = (100 - tb16.Text) * tb15.Text / 100 * tb14.Text
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Then

                For x = 0 To lv.Items.Count - 1
                    csql = "exec bill.dbo.sp_Bill#1Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','','" & cb1.Text & "','" & cb2.Text & "','" & tb3.Text & "','','" & lv.Items(x).SubItems(0).Text & "','" & lv.Items(x).SubItems(3).Text & "','" & lv.Items(x).SubItems(4).Text & "','" & lv.Items(x).SubItems(5).Text & "',''"

                    cpro.ExecNonQuery(csql)

                Next
                MsgBox("Messages Saved")
                lv.Items.Clear()
                dtpro("bar")
                tb1.Text = ""
                tb3.Text = ""
                tb4.Text = ""
                cb1.Text = ""
                cb2.Text = ""
                cb3.Text = ""
                lb1.Text = 0
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtpro("sim")
    End Sub

    Private Sub cekStok()
        csql = "select jumlah from BillMaster.dbo.Barang where BarangID='" & tb11.Text & "'"
        For Each dt As DataRow In cpro.ExecQuery(csql).Rows
            If (tb14.Text <= dt(0)) Then
                listTambah()
            Else
                MsgBox("Stok tidak cukup")
            End If
        Next
    End Sub

    Private Sub tb19_TextChanged(sender As Object, e As EventArgs) Handles tb19.TextChanged
        tb20.Text = tb19.Text - lb1.Text
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        Dim frmsearch As New FrmSearch
        With frmsearch
            .Text = "Member "
            .Tag = "member"
            .Show()
        End With
    End Sub

    Private Sub HitungTotal()
        Dim hitung = 0
        For baris = 0 To lv.Items.Count - 1
            hitung = hitung + lv.Items(baris).SubItems(6).Text
        Next
        lb1.Text = hitung
    End Sub

    Private Sub lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv.SelectedIndexChanged
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            tb11.Text = lvi.Text

            'tb17.Text = .SelectedItems(6).Text

            For x = lvi.Index To lv.SelectedIndices.Count
                'lv.Items(x).SubItems(3).Text = tb14.Text
                tb14.Text = lv.Items(x).SubItems(3).Text
                tb17.Text = lv.Items(x).SubItems(6).Text
                Exit For
            Next
        End With
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim StoreName As String, StoreAddress As String, kota As String, notlpn As String, hari As String, jam As String, tanggal As String, TransDate As String
    '    Dim nopompa As String, noselang As String, TransNo As String, jenisbbm As String, liter As String, hrgliter As String, total As String
    '    Dim operatorSPBU As String
    '    StoreName = cb1.Text
    '    StoreAddress = TbAlamat.Text
    '    kota = tbkota.Text
    '    notlpn = tbnotlp.Text
    '    hari = cbHari.Text
    '    jam = cbjam.Text + ":" & cbmnt.Text + ":" & cbdetik.Text
    '    tanggal = Format(dtp.Value, "dd-MM-yyyy")
    '    TransDate = hari + ", " & tanggal + " " & jam
    '    '===================================================
    '    nopompa = tbnopompa.Text
    '    noselang = tbnoselang.Text
    '    TransNo = tbTrans.Text
    '    jenisbbm = cbjenisbbm.Text
    '    liter = tbliter.Text
    '    hrgliter = tbhrg.Text
    '    total = lb1.Text
    '    '===================================================
    '    operatorSPBU = cb2.Text
    '    'Data_Load()
    '    Printer.NewPrint()

    '    'Printer.Print(Img, 200, 100) 'TANPA LOGO

    '    'Setting Font
    '    Printer.SetFont("Courier New", 14, FontStyle.Bold)
    '    Printer.Print(StoreName) 'Store Name | Nama Toko

    '    'Setting Font
    '    Printer.SetFont("Courier New", 8, FontStyle.Regular)
    '    Printer.Print(StoreAddress & ";", {280}, 0) 'Store Address | Alamat Toko
    '    Printer.Print(kota & ";", {280}, 0) 'Store Address | Alamat Toko
    '    'Setting Font
    '    Printer.SetFont("Courier New", 8, FontStyle.Regular)
    '    Printer.Print("TELP " & notlpn & ";", {280}, 0) 'Store Address | Alamat Toko
    '    Printer.Print(TransDate) ' Trans Date | Tanggal transaksi
    '    '===================================================
    '    Printer.Print("--------------------------------") 'line
    '    Printer.Print("Operator     : " & operatorSPBU) 'spacing
    '    Printer.Print("--------------------------------") 'line
    '    'spacing
    '    'Printer.Print(" ")
    '    Printer.Print("Nomor Pompa  : " & nopompa) ' Transaction No | Nomor transaksi
    '    Printer.Print("Nomor Selang : " & noselang) ' Transaction No | Nomor transaksi
    '    Printer.Print("Nomor Nota   : " & TransNo) ' Transaction No | Nomor transaksi
    '    Printer.Print("Jenis BBM    : " & jenisbbm) ' Trans Date | Tanggal transaksi
    '    Printer.Print("Liter        : " & Space(13 - Len(liter)) & liter) ' rata kanan
    '    Printer.Print("Harga/liter  : Rp" & Space(9 - Len(Format(hrgliter, "#,#0"))) & Format(hrgliter, "#,#0")) 'format angka
    '    Printer.Print("Total        : Rp" & Space(9 - Len(Format(total, "#,#0"))) & Format(total, "#,#0")) 'format angka
    '    Printer.Print("================================") 'line

    '    Printer.SetFont("Courier New", 7, FontStyle.Regular)
    '    Printer.Print("SELAMAT JALAN DAN TERIMAKASIH") 'spacing
    '    Printer.DoPrint()

    'End Sub
End Class