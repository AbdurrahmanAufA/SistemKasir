Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Module ModExcel
    Private meLV As ListView

    Public Property lvtoExcel As ListView
        Get
            lvtoExcel = meLV
        End Get
        Set(value As ListView)
            meLV = value
        End Set
    End Property

    Public Sub KillProcess(ByVal processName As String)

        On Error GoTo ErrHandler

        Dim oWMI
        Dim ret
        Dim sService
        Dim oWMIServices
        Dim oWMIService
        Dim oServices
        Dim oService
        Dim servicename

        oWMI = GetObject("winmgmts:")
        oServices = oWMI.InstancesOf("win32_process")

        For Each oService In oServices

            servicename = LCase(Trim(CStr(oService.Name) & ""))

            If InStr(1, servicename, LCase(processName), vbTextCompare) > 0 Then
                ret = oService.Terminate
            End If

        Next

        oServices = Nothing
        oWMI = Nothing

ErrHandler:
        Err.Clear()
    End Sub
    Public Sub ExportlvtoExcel(ByVal lv As ListView, ByVal pb As ToolStripProgressBar)
        Dim exc As Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        'Dim err As Object = System.Reflection.Missing.Value

        Dim n As Double, X As Integer, Y As Integer
        Dim JumWorksheet As Double 'jumlah worksheet
        Dim JumRecord As Double

        exc = New Excel.Application
        wb = exc.Workbooks.Add
        ws = wb.Worksheets(1)

        JumRecord = lv.Items.Count
        JumWorksheet = 0

        pb.Value = 0
        pb.Maximum = JumRecord
        pb.Visible = True
        n = 1

        Dim iFieldsCount As Integer
        Dim TotalField As Integer
        'jumlah record
        TotalField = lv.Columns.Count

        Cursor.Current = Cursors.WaitCursor
        Try
            For iFieldsCount = 1 To TotalField
                ws.Cells(1, iFieldsCount) = lv.Columns(iFieldsCount - 1).Text
                ws.Cells(1, iFieldsCount).Font.Bold = True
            Next iFieldsCount

            For X = 1 To JumRecord
                For Y = 1 To TotalField
                    If Y = 1 Then
                        ws.Cells(X + 1, Y) = "" & lv.Items(X - 1).Text
                        ws.Cells(X + 1, Y).Font.Bold = False
                    Else
                        ws.Cells(X + 1, Y) = "" & lv.Items(X - 1).SubItems(Y - 1).Text
                        ws.Cells(X + 1, Y).Font.Bold = False
                    End If
                Next Y
                pb.Value = n
                n = n + 1
            Next
            pb.Value = 0
            MsgBox("Proses Selesai ", vbInformation, "Export Ke Excel")
            wb.Activate()
            wb.RefreshAll()
            exc.Visible = True
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "ExportlvtoExcel")
            exc.Quit()
        Finally
            pb.Visible = False
            pb.Value = 0
            ws = Nothing
            wb = Nothing
            exc = Nothing
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Public Sub ExportlvtoExcelFastnew(ByVal txt As String, ByVal xls As String, ByVal rec As String, ByVal lvitems As ListView.ListViewItemCollection, ByVal lvutama As ListView)
        Dim lvi As ListViewItem
        Dim sb As New System.Text.StringBuilder
        If File.Exists(txt) Then
            File.Delete(txt)
        End If
        If File.Exists(xls) Then
            File.Delete(xls)
        End If
        'For i = 0 To lvutama.Columns.Count - 1
        'sb.Append(lvutama.Columns.Item(i).Text & "/")
        'Next
        'sb.Append(vbCrLf)
        For i = 0 To lvutama.Columns.Count - 1
            sb.Append(lvutama.Columns.Item(i).Text)
            If i < lvutama.Columns.Count - 1 Then
                sb.Append(vbTab)
            Else
                sb.Append(vbCrLf)
            End If
        Next
        For Each lvi In lvitems
            For ix As Integer = 0 To lvi.SubItems.Count - 1
                sb.Append(lvi.SubItems(ix).Text)
                If ix < lvi.SubItems.Count - 1 Then
                    sb.Append(vbTab)
                Else
                    sb.Append(vbCrLf)
                End If
            Next
        Next
        Dim sw As New StreamWriter(txt)
        sw.Write(sb.ToString)
        sw.Close()
        Dim oExcel = CreateObject("Excel.Application")
        oExcel.Workbooks.OpenText(FileName:=txt)
        oExcel.Worksheets(1).Name = "Worksheet"
        oExcel.Worksheets(1).SaveAs(xls, FileFormat:=51)
        oExcel.Quit()
        oExcel = Nothing
        rec = lvitems.Count
        System.Diagnostics.Process.Start(xls)
        If File.Exists(txt) Then
            File.Delete(txt)
        End If
        HapusDumpProses()
    End Sub


End Module
