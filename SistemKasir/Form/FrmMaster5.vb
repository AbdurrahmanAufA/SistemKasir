﻿Public Class FrmMaster5
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Private Sub tampdt()
        With dttemp
            .lvTag = .ndKey
            If .ndKey = "brj" Then csql = "select BarangID,Harga from billmaster.dbo.BarangJual order by BarangID"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        End With
    End Sub
    Private Sub FrmMaster5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        Label1.Text = ""
        If dttemp.ndKey = "brj" Then Label1.Text = "BARANG JUAL"
        tampdt()
        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
        ambilKaryawan()
    End Sub

    Private Sub FrmMaster5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub

    Private Sub ambilKaryawan()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Username from BillMaster.dbo.Karyawan"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
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
    Private Sub FrmMaster5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress, cb1.KeyPress, tb3.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then cb1.Focus() : cb1.DroppedDown = True
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub FrmMaster5_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown, cb1.KeyDown, tb3.KeyDown
        If e.Control = True And (e.KeyCode = Asc("S") Or e.KeyCode = Asc("s")) Then
            dtpro("sim")
        ElseIf e.Control = True And (e.KeyCode = Asc("D") Or e.KeyCode = Asc("d")) Then
            dtpro("hap")
        ElseIf e.Control = True And (e.KeyCode = Asc("N") Or e.KeyCode = Asc("n")) Then
            dtpro("bar")
        End If
    End Sub
    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Try

            tb2.Text = ""
            If dttemp.ndKey = "brj" Then
                csql = "select BarangID,Nama from BillMaster.dbo.Barang where BarangID='" & tb1.Text & "'"
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then

                csql = "exec billmaster.dbo.sp_Master#5Pro '" & dttemp.ndKey & "','" & mpro & "','','" & cb1.Text & "','','" & tb1.Text & "','" & tb3.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb3.Text = ""
                cb1.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
End Class