Public Class frmMasterR
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn

    Private Sub tampdt()
        With dttemp
            .lvTag = .ndKey
            If .ndKey = "kab" Then csql = "select KabID,KetKab from billmaster.dbo.vwilKab order by kabID"
            If .ndKey = "kec" Then csql = "select KecID,Keterangan from billmaster.dbo.vwilkec order by KecID"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        End With
    End Sub
    Private Sub frmMasterR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        Label1.Text = ""
        If dttemp.ndKey = "kab" Then Label1.Text = "KABUPATEN"
        If dttemp.ndKey = "kec" Then Label1.Text = "KECAMATAN"
        tampdt()
        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
    End Sub
    Private Sub FrmMasterR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub

    Private Sub tb_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged, tb3.TextChanged
        If sender.Equals(tb2) Or sender.Equals(tb3) Then
            Try
                lbRelasi.Text = ""
                If dttemp.ndKey = "kab" Then csql = "select * from billmaster.dbo.ft_Wilkab#dt('" & tb2.Text & "','" & tb3.Text & "')"
                If dttemp.ndKey = "kec" Then csql = "select * from billmaster.dbo.ft_WilKec#dt('" & tb2.Text & "','" & tb3.Text & "')"
                If tb1.Text = "" Then Exit Sub
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    lbRelasi.Text = dt(3)
                    'If sender.Equals(tb2) Then tb3.Text = dt(1)
                    'If sender.Equals(tb3) Then tb3.Text = dt(2)
                    tb4.Text = dt(2)
                Next
            Catch ex As Exception
                MsgBox(Err.Description, vbInformation, "Cek err")
            Finally
                tb1.Text = tb2.Text & "." & tb3.Text
            End Try
        End If
    End Sub

    Private Sub lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv.SelectedIndexChanged
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)


        End With

    End Sub

    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv.DoubleClick
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If dttemp.lvTag = "prol" Or dttemp.lvTag = "kabl" Then
                tb2.Text = lvi.Text
                tb3.Focus() : SendKeys.Send("{end}")
            Else
                With dttemp
                    If .ndKey = "kab" Then
                        tb1.Text = lvi.Text
                        itm = Split(tb1.Text, ".")
                        tb2.Text = itm(0) : tb3.Text = itm(1)
                        tb2.Focus() : SendKeys.Send("{end}")

                    ElseIf .ndKey = "kec" Then
                        tb1.Text = lvi.Text
                        itm = Split(tb1.Text, ".")
                        tb2.Text = itm(0) + "." + itm(1) : tb3.Text = itm(2)
                        tb2.Focus() : SendKeys.Send("{end}")

                    Else
                        tb1.Text = lvi.Text
                        tb2.Focus() : SendKeys.Send("{end}")
                    End If
                End With
            End If
        End With
    End Sub

    Private Sub btR_Click(sender As Object, e As EventArgs) Handles btR.Click
        With dttemp
            If .ndKey = "kab" Then
                csql = "select proID,Keterangan from billmaster.dbo.wilprop where proid+Keterangan like '%'+Replace('" & tb2.Text & "',' ' ,'%')+'%'"
                .lvTag = "prol"
            ElseIf .ndKey = "kec" Then
                csql = "select kabID,Keterangan from billmaster.dbo.wilkab where kabid+Keterangan like '%'+Replace('" & tb2.Text & "',' ' ,'%')+'%'"
                .lvTag = "prol"
            End If
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count

        End With
    End Sub

    Private Sub tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress, tb3.KeyPress, tb4.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then
                With dttemp
                    If .ndKey = "kab" Then
                        itm = Split(tb1.Text, ".")
                        tb2.Text = itm(0) : tb3.Text = itm(1)
                    ElseIf .ndKey = "kec" Then
                        itm = Split(tb1.Text, ".")
                        tb2.Text = itm(0) + "." + itm(1) : tb3.Text = itm(2)
                    End If
                End With
                tb2.Focus() : SendKeys.Send("{end}")

            End If
            If sender.Equals(tb2) Then
                If lbRelasi.Text = "" Then
                    btR_Click(sender, e)
                Else
                    tb3.Focus()
                    SendKeys.Send("{end}")
                End If
            End If
            If sender.Equals(tb3) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then
                'simpan
                dtPro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb3.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
        If sender.Equals(tb1) Then
            e.KeyChar = Chr(0)
        ElseIf sender.Equals(tb3) Then
            e.KeyChar = Chr(BatasAngka(e.KeyChar))
        End If

    End Sub

    Private Sub tb_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown, tb3.KeyDown, tb4.KeyDown
        If e.Control = True And (e.KeyCode = Asc("S") Or e.KeyCode = Asc("s")) Then
            dtpro("sim")
        ElseIf e.Control = True And (e.KeyCode = Asc("D") Or e.KeyCode = Asc("d")) Then
            dtpro("hap")
        ElseIf e.Control = True And (e.KeyCode = Asc("N") Or e.KeyCode = Asc("n")) Then
            dtpro("bar")
        End If
    End Sub

    Private Sub dtPro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then
                If lbRelasi.Text = "" Then
                    MsgBox("Relasi tidak ditemukan", vbInformation, "Cek err")
                    Exit Sub
                End If
                csql = "exec billmaster.dbo.sp_Master#1Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','" & tb2.Text & "','" & tb3.Text & "','" & tb4.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtPro("bar")
            ElseIf mpro = "bar" Then
                tb3.Text = "" : tb2.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub lv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lv.KeyPress
        If e.KeyChar = Chr(13) Then lv_DoubleClick(sender, e)
    End Sub
End Class