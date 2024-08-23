Module ModList
    Dim csql As String = String.Empty
    Dim temptable As DataTable, db As msaConn
    Dim itm() As String

    Public Sub lvListMain(ByVal lv As ListView, ByVal pb As ToolStripProgressBar, ByVal JumCol As Integer, ByVal ColString As String, ByVal cSQL As String)
        Dim itmdata() As String, itmcol() As String
        Dim lvColumnHeader As ColumnHeader, lvItem As ListViewItem
        Dim n As Single = 0

        Cursor.Current = Cursors.WaitCursor
        db = New msaConn
        itmdata = Split(ColString, ",")
        With lv
            .Columns.Clear()
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            'columnsheader
            For i As Integer = 0 To JumCol - 1
                itmcol = Split(itmdata(i), ":")
                lvColumnHeader = lv.Columns.Add(itmcol(0))
                lvColumnHeader.Width = itmcol(1)
                If itmcol(2) = 1 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                ElseIf itmcol(2) = 2 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Center
                ElseIf itmcol(2) = 3 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                    lvColumnHeader.Tag = "2d" '2 digit (decimal)
                Else
                    lvColumnHeader.TextAlign = HorizontalAlignment.Left
                End If
            Next
            'list item
            Try
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                temptable = db.ExecQuery(cSQL)
                If temptable.Rows.Count > 0 Then
                    pb.Visible = True
                    pb.Maximum = temptable.Rows.Count
                    For Each dtrow As DataRow In temptable.Rows
                        lvItem = .Items.Add(dtrow(0))
                        For x As Integer = 1 To JumCol - 1
                            If lv.Columns.Item(x).TextAlign = HorizontalAlignment.Right Then
                                If lv.Columns.Item(x).Tag = "2d" Then
                                    lvItem.SubItems.Add(x).Text = FormatNumber(Val(dtrow(x)), 2,, TriState.True, TriState.True)
                                Else
                                    lvItem.SubItems.Add(x).Text = Format(Val(dtrow(x)), "#,#0")
                                End If
                            Else
                                lvItem.SubItems.Add(x).Text = dtrow(x)
                            End If
                        Next
                        pb.Value = n
                        n += 1
                    Next
                    pb.Value = 0
                    pb.Visible = False
                    'MainMenu.ActiveForm.Cursor = Cursors.Default
                End If
            Catch ex As Exception
                MsgBox(Err.Description & Chr(10) & cSQL)
            Finally
                pb.Value = 0
                pb.Visible = False
                Cursor.Current = Cursors.Default
                If lv.Items.Count > 0 Then
                    'lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    ResizeListViewColumns(lv)
                End If
            End Try
        End With
    End Sub

    Public Sub lvList(ByVal lv As ListView, ByVal pb As ToolStripProgressBar, ByVal JumCol As Integer, ByVal ColString As String, ByVal cSQL As String)
        Dim itmdata() As String, itmcol() As String
        Dim lvColumnHeader As ColumnHeader, lvItem As ListViewItem
        Dim n As Single = 0
        Cursor.Current = Cursors.WaitCursor
        db = New msaConn
        itmdata = Split(ColString, ",")
        With lv
            .Columns.Clear()
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            'columnsheader
            For i As Integer = 0 To JumCol - 1
                itmcol = Split(itmdata(i), ":")
                lvColumnHeader = lv.Columns.Add(itmcol(0))
                lvColumnHeader.Width = itmcol(1)
                If itmcol(2) = 1 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                ElseIf itmcol(2) = 2 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Center
                ElseIf itmcol(2) = 3 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                    lvColumnHeader.Tag = "2d" '2 digit (decimal)
                Else
                    lvColumnHeader.TextAlign = HorizontalAlignment.Left
                End If
            Next
            'list item
            Try
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                temptable = db.ExecQuery(cSQL)
                If temptable.Rows.Count > 0 Then
                    pb.Visible = True
                    pb.Maximum = temptable.Rows.Count
                    For Each dtrow As DataRow In temptable.Rows
                        lvItem = .Items.Add(dtrow(0))
                        For x As Integer = 1 To JumCol - 1
                            If lv.Columns.Item(x).TextAlign = HorizontalAlignment.Right Then
                                If lv.Columns.Item(x).Tag = "2d" Then
                                    lvItem.SubItems.Add(x).Text = FormatNumber(Val(dtrow(x)), 2,, TriState.True, TriState.True)
                                Else
                                    lvItem.SubItems.Add(x).Text = Format(Val(dtrow(x)), "#,#0")
                                End If
                            Else
                                lvItem.SubItems.Add(x).Text = dtrow(x)
                            End If
                        Next
                        pb.Value = n
                        n += 1
                    Next
                    pb.Value = 0
                    pb.Visible = False
                    'MainMenu.ActiveForm.Cursor = Cursors.Default
                End If
            Catch ex As Exception
                MsgBox(Err.Description & Chr(10) & cSQL)
            Finally
                pb.Value = 0
                pb.Visible = False
                Cursor.Current = Cursors.Default
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                If lv.Items.Count > 0 Then
                    'lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    ResizeListViewColumns(lv)
                End If

            End Try
        End With
    End Sub

    Sub lvListAutoMain(ByVal lv As ListView, ByVal pb As ToolStripProgressBar, ByVal cSQL As String)
        Dim JumCol As Integer = 0, ColString As String = String.Empty
        ambilkolomLV(cSQL)
        If jmlkolom < 1 Then Exit Sub
        JumCol = jmlkolom : ColString = LvKolom.Substring(0, LvKolom.Length - 1)
        Dim itmdata() As String, itmcol() As String
        Dim lvColumnHeader As ColumnHeader, lvItem As ListViewItem
        Dim n As Single = 0
        Dim style = ColumnHeaderAutoResizeStyle.HeaderSize
        Cursor.Current = Cursors.WaitCursor
        db = New msaConn
        itmdata = Split(ColString, ",")
        With lv
            .Columns.Clear()
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            'columnsheader
            For i As Integer = 0 To JumCol - 1
                itmcol = Split(itmdata(i), ":")
                lvColumnHeader = lv.Columns.Add(itmcol(0))
                'lvColumnHeader.Width = itmcol(1)
                style = ColumnHeaderAutoResizeStyle.ColumnContent
                If itmcol(1) = 1 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                ElseIf itmcol(1) = 2 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Center
                ElseIf itmcol(1) = 3 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                    lvColumnHeader.Tag = "2d" '2 digit (decimal)
                Else
                    lvColumnHeader.TextAlign = HorizontalAlignment.Left
                End If
            Next
            'list item
            Try
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                temptable = db.ExecQuery(cSQL)
                If temptable.Rows.Count > 0 Then
                    pb.Visible = True
                    pb.Maximum = temptable.Rows.Count
                    For Each dtrow As DataRow In temptable.Rows
                        lvItem = .Items.Add(dtrow(0))
                        For x As Integer = 1 To JumCol - 1
                            If lv.Columns.Item(x).TextAlign = HorizontalAlignment.Right Then
                                If lv.Columns.Item(x).Tag = "2d" Then
                                    lvItem.SubItems.Add(x).Text = FormatNumber(Val(dtrow(x)), 2,, TriState.True, TriState.True)
                                Else
                                    lvItem.SubItems.Add(x).Text = Format(Val(dtrow(x)), "#,#0")
                                End If
                            Else
                                lvItem.SubItems.Add(x).Text = dtrow(x)
                            End If
                        Next
                        pb.Value = n
                        n += 1
                    Next
                    pb.Value = 0
                    pb.Visible = False
                    'MainMenu.ActiveForm.Cursor = Cursors.Default
                End If
            Catch ex As Exception
                MsgBox(Err.Description & Chr(10) & cSQL)
            Finally
                pb.Value = 0
                pb.Visible = False
                Cursor.Current = Cursors.Default
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                If lv.Items.Count > 0 Then
                    'lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    ResizeListViewColumns(lv)
                End If

            End Try
        End With
    End Sub
    Sub lvListAuto(ByVal lv As ListView, ByVal pb As ProgressBar, ByVal cSQL As String)
        Dim JumCol As Integer = 0, ColString As String = String.Empty
        ambilkolomLV(cSQL)
        If jmlkolom < 1 Then Exit Sub
        JumCol = jmlkolom : ColString = LvKolom.Substring(0, LvKolom.Length - 1)
        Dim itmdata() As String, itmcol() As String
        Dim lvColumnHeader As ColumnHeader, lvItem As ListViewItem
        Dim n As Single = 0
        Dim style = ColumnHeaderAutoResizeStyle.HeaderSize
        Cursor.Current = Cursors.WaitCursor
        db = New msaConn
        itmdata = Split(ColString, ",")
        With lv
            .Columns.Clear()
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            'columnsheader
            For i As Integer = 0 To JumCol - 1
                itmcol = Split(itmdata(i), ":")
                lvColumnHeader = lv.Columns.Add(itmcol(0))
                'lvColumnHeader.Width = itmcol(1)
                style = ColumnHeaderAutoResizeStyle.ColumnContent
                If itmcol(1) = 1 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                ElseIf itmcol(1) = 2 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Center
                ElseIf itmcol(1) = 3 Then
                    lvColumnHeader.TextAlign = HorizontalAlignment.Right
                    lvColumnHeader.Tag = "2d" '2 digit (decimal)
                Else
                    lvColumnHeader.TextAlign = HorizontalAlignment.Left
                End If
            Next
            'list item
            Try
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                temptable = db.ExecQuery(cSQL)
                If temptable.Rows.Count > 0 Then
                    pb.Visible = True
                    pb.Maximum = temptable.Rows.Count
                    For Each dtrow As DataRow In temptable.Rows
                        lvItem = .Items.Add(dtrow(0))
                        For x As Integer = 1 To JumCol - 1
                            If lv.Columns.Item(x).TextAlign = HorizontalAlignment.Right Then
                                If lv.Columns.Item(x).Tag = "2d" Then
                                    lvItem.SubItems.Add(x).Text = FormatNumber(Val(dtrow(x)), 2,, TriState.True, TriState.True)
                                Else
                                    lvItem.SubItems.Add(x).Text = Format(Val(dtrow(x)), "#,#0")
                                End If
                            Else
                                lvItem.SubItems.Add(x).Text = dtrow(x)
                            End If
                        Next
                        pb.Value = n
                        n += 1
                    Next
                    pb.Value = 0
                    pb.Visible = False
                    'MainMenu.ActiveForm.Cursor = Cursors.Default
                End If
            Catch ex As Exception
                MsgBox(Err.Description & Chr(10) & cSQL)
            Finally
                pb.Value = 0
                pb.Visible = False
                Cursor.Current = Cursors.Default
                'MainMenu.ActiveForm.Cursor = Cursors.WaitCursor
                If lv.Items.Count > 0 Then
                    'lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    ResizeListViewColumns(lv)
                End If

            End Try
        End With
    End Sub


    Public Sub ResizeListViewColumns(listView As ListView)
        Dim items = listView.Items.Cast(Of ListViewItem).ToArray()
        Dim itemCount = items.Length
        Dim g As Graphics = Nothing

        'Create a single Graphics object with which to measure text if and only if it is needed..
        If itemCount > 0 Then
            g = listView.CreateGraphics()
        End If

        For Each column As ColumnHeader In listView.Columns
            'Assume that we're autosizing based on the header unless determined otherwise.
            Dim style = ColumnHeaderAutoResizeStyle.HeaderSize

            If itemCount > 0 Then
                If column.Text Is Nothing Then
                    column.Text = "--"
                End If
                Dim kolomTxt As String = String.Empty
                kolomTxt = column.Text

                'Get the pixel width of the header text.
                'Dim headerWidth = g.MeasureString(column.Text, listView.Font).Width 'lama
                Dim headerWidth = g.MeasureString(kolomTxt, listView.Font).Width

                'get the greatest pixel width of the subitems.
                Dim maxSubItemWidth = IIf(items.Max(Function(item) g.MeasureString(item.SubItems(column.Index).Text, listView.Font).Width) > 300, 300, items.Max(Function(item) g.MeasureString(item.SubItems(column.Index).Text, listView.Font).Width))

                If maxSubItemWidth > headerWidth Then
                    If maxSubItemWidth < 300 Then
                        style = ColumnHeaderAutoResizeStyle.ColumnContent
                        column.AutoResize(style)
                    Else
                        column.Width = maxSubItemWidth
                    End If
                Else
                    'style = ColumnHeaderAutoResizeStyle.ColumnContent
                    column.AutoResize(style)
                End If
            End If


        Next

        'Dispose the Graphics object if and only if we created one.
        g?.Dispose()
    End Sub

    Public Sub HapusDumpProses()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ambilkolomLV(ByVal kueri As String)
        Dim TempDS As DataSet = Nothing, dbcon As msaConn, jdata As Integer, cdata() As String, n As Integer = 0, dtTipe As String = String.Empty, UnitDtTipe As Integer = 0
        Dim LvKolomList As String = String.Empty
        dbcon = New msaConn
        Try
            csql = kueri
            TempDS = dbcon.ExecQueryDS(csql)
            For Each tb As DataTable In TempDS.Tables
                jdata = tb.Columns.Count - 1
                ReDim cdata(jdata)
                For Each cl As DataColumn In tb.Columns
                    cdata(n) = cl.ColumnName
                    dtTipe = cl.DataType.ToString()
                    'MsgBox(dtTipe)
                    If dtTipe = "System.Decimal" Then
                        UnitDtTipe = 3
                    ElseIf dtTipe = "System.Int32" Then
                        UnitDtTipe = 1
                    Else
                        UnitDtTipe = 0
                    End If
                    n += 1
                    LvKolomList = LvKolomList + cl.ColumnName.ToString() + ":" & UnitDtTipe & ","
                Next
            Next
        Catch ex As Exception
            MsgBox("error")
        Finally
            jmlkolom = n
            LvKolom = LvKolomList
        End Try

    End Sub

End Module
