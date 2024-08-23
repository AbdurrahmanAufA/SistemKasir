Public Class FrmMaster2
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Private Sub tampdt()
        With dttemp
            .lvTag = .ndKey
            If .ndKey = "mbr" Then csql = "select MemberID,Nama,Alamat from billmaster.dbo.Member order by MemberID"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        End With
    End Sub
    Private Sub FrmMaster2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        Label1.Text = ""
        If dttemp.ndKey = "mbr" Then Label1.Text = "MEMBER"

        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
        ambilKec()
        ambilToko()
    End Sub

    Private Sub FrmMaster2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub

    Private Sub ambilKec()
        cb2.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Keterangan from BillMaster.dbo.wilkec"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb2
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("Keterangan"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
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

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Try

            tb2.Text = ""
            tb3.Text = ""
            tb4.Text = ""
            If dttemp.ndKey = "mbr" Then
                csql = "select b.Nama Toko,a.NoKTP,a.Nama,a.Alamat,c.Keterangan from BillMaster.dbo.Member a 
	                        inner join BillMaster.dbo.Toko b on a.TokoID = b.TokoID 
	                        inner join BillMaster.dbo.WilKec c on a.KecID = c.KecID where MemberID='" & tb1.Text & "'"
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                cb1.Text = dt(0)
                tb2.Text = dt(1)
                tb3.Text = dt(2)
                tb4.Text = dt(3)
                cb2.Text = dt(4)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub FrmMaster2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress, cb1.KeyPress, tb3.KeyPress, cb2.KeyPress, tb4.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then cb2.Focus() : cb2.DroppedDown = True
            If sender.Equals(cb2) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(cb1) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(tb3) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb2) Then tb4.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub FrmMaster2_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown, cb1.KeyDown, tb3.KeyDown, cb2.KeyDown, tb4.KeyDown
        If e.Control = True And (e.KeyCode = Asc("S") Or e.KeyCode = Asc("s")) Then
            dtpro("sim")
        ElseIf e.Control = True And (e.KeyCode = Asc("D") Or e.KeyCode = Asc("d")) Then
            dtpro("hap")
        ElseIf e.Control = True And (e.KeyCode = Asc("N") Or e.KeyCode = Asc("n")) Then
            dtpro("bar")
        End If
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then

                csql = "exec billmaster.dbo.sp_Master#2Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','" & cb1.Text & "','" & tb2.Text & "','" & cb2.Text & "','" & tb3.Text & "','" & tb4.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb3.Text = ""
                cb1.Text = ""
                cb2.Text = ""
                tb4.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
End Class