Public Class ReasonChange
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "OK button"
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close
    End Sub
#End Region
End Class