Imports System.IO
Module ModMain
    'variabel public
    Public csql As String, csql1 As String, csql2 As String, itm() As String
    Public crPro As Integer = 80, IMGPath As String, DOKPath As String, sqllogin As Integer = 30, sqlDatafill As Integer = 30
    Public pHostNM As String = "", pIPLoc As String = "", pMac As String = "", jmlkolom As Integer = 0, LvKolom As String = String.Empty, tagkibcEx As String = String.Empty
    Private mlvtag As String = String.Empty : Private mlVW As ListView : Private mpb As ProgressBar
    Public waktu As String = String.Empty

    '-- interface nodeKey
    Public nKey As String, nPKey As String, nSKey As String, nTkey As String

    'milik ModulMain
    Public BKAD As Single = 0, ThnPost As Integer, Thnbk As Integer, footer As String = String.Empty, filetxt As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\PTM-CEMPAKA\datexport.txt"


    Public Function HurufBesar(ByVal keyascii As String) As String
        HurufBesar = UCase(Chr(Asc(keyascii)))
    End Function

    Public Function BatasAngka(ByVal keyascii As String) As Integer
        BatasAngka = Asc(keyascii)
        'MsgBox(Asc(keyascii) & " " & Asc(vbBack))
        If Not (Asc(keyascii) >= Asc("0") And Asc(keyascii) <= Asc("9") Or Asc(keyascii) = Asc(vbBack) Or Asc(keyascii) = Asc("-") Or Asc(keyascii) = Asc(".") Or Asc(keyascii) = Asc(",")) Then
            BatasAngka = 0
        End If
    End Function

    Public Function BatasTanggal(ByVal keyascii As String) As Integer
        BatasTanggal = Asc(keyascii)
        'MsgBox(Asc(keyascii) & " " & Asc(vbBack))
        If Not (Asc(keyascii) >= Asc("0") And Asc(keyascii) <= Asc("9") Or Asc(keyascii) = Asc(vbBack) Or Asc(keyascii) = Asc("/") Or Asc(keyascii) = Asc("-")) Then
            BatasTanggal = 0
        End If
    End Function

    Public Sub CreateFolderApp(ByVal path As String)
        If (Not System.IO.Directory.Exists(path)) Then
            System.IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Public Sub exportExcelCekfileExist(ByVal filexlxs As String, ByVal Xcel As String, ByVal filetxt As String, ByVal rec As String, ByVal lvitems As ListView.ListViewItemCollection, ByVal lvutama As ListView)

        If FileOpenTest(filexlxs) = True Then
            'Dim mesBoX = MsgBox("File Excel dengan nama file " & "(" & Xcel & ") masih terbuka. Pilih No untuk buka File, Pilih Yes untuk Download ulang Excel", vbYesNo, "Cek File Excel")
            ''MsgBox("Tutup dan simpan jika perlu Excel dengan nama file " & "(" & Xcel & ")", vbInformation, "Cek File Excel")
            'If mesBoX = vbYes Then
            '    ExportlvtoExcelFastnew(filetxt, DOKPath & "\" & FrmUtama.cbBln.Text & " - " & waktu & ".xlsx", rec, lvitems, lvutama)
            'Else
            openXcel(Xcel)
            'End If

        Else
            ExportlvtoExcelFastnew(filetxt, filexlxs, rec, lvitems, lvutama)
        End If
    End Sub

    Public Function FileOpenTest(ByVal WorkBookName As String) As Boolean
        Dim fs As FileStream
        FileOpenTest = False
        Try
            fs = System.IO.File.OpenWrite(WorkBookName)
            fs.Close()
        Catch ex As Exception
            FileOpenTest = True
        End Try

        Return FileOpenTest
    End Function
    Public Sub openXcel(ByVal WorkBookName As String)
        Dim LocalpathParent As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Try
            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.WorkingDirectory = LocalpathParent
            Dim files As String() = System.IO.Directory.GetFiles(LocalpathParent, WorkBookName)
            For Each fileName In files
                psi.FileName = fileName
                Process.Start(psi)
            Next
        Catch
            'Console.WriteLine("The process failed: {0}", e.ToString())
        End Try
    End Sub

End Module
