Imports System.Text.RegularExpressions

Module Functions_Specific
    Public Const DB_LOCATION                    As String = "C:\Users\TEMP.FORCES.002\Desktop\CantineTest\CantineTest\CantineTest\Cantine.mdb"
    Public Const IMAGE_TEMPLATE                 As String = "TEMPLATE.jpg"
    Public ReadOnly IMAGE_LOCATION              As String = AppDomain.CurrentDomain.BaseDirectory
    Public Const BARCODE_FIELD_DELIMITER        As String = "!"

    Public Sub DisplayErrorMessage(ByVal msg As String)
        MsgBox(msg, vbCritical, "Cantine")
    End Sub

    Public Sub SyncManager(ByVal TypeList As ArrayList)
        For i As Integer = 0 To Application.OpenForms.Count - 1
            If TypeList.IndexOf(Application.OpenForms.Item(i).GetType) > -1 Then
                CType(Application.OpenForms.Item(i), IFormDatagridview).RefreshGrid()
            End If
        Next
    End Sub

    Public Function ContainsNumbers(input As String) As Boolean
        Return Regex.IsMatch(input, "[0-9]")
    End Function

    Public Sub OpenPDF(ByVal PDF As String)
        Process.Start(PDF)
    End Sub
End Module
