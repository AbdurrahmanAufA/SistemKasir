
Public Class ClassInterface

    Public Interface UserTrans
        Property pg As String
        Property toko As String
        Property wil As String
        Property tgltrans As Date

    End Interface
    Public Interface explore1
        Property tv() As TreeView
        Property ndKey() As String

        Property lv() As ListView

        Property lvTag() As String

        Property pb() As ToolStripProgressBar

    End Interface

    Public Interface explore2
        Property tv() As TreeView
        Property ndKey() As String
        Property lv1() As ListView
        Property lv2() As ListView
        Property lvTag() As String

        Property pb() As ToolStripProgressBar
        Property pb2() As ProgressBar
    End Interface

    Public Interface nKey
        Property PKey As String
        Property SKey As String
        Property Tkey As String

    End Interface

End Class
