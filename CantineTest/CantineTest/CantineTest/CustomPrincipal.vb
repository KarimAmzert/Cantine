Imports System.Security.Principal

Public Class CustomPrincipal
    Implements IPrincipal
    Private ReadOnly User       As New USER_ASSEMBLER_SQL

    Private customid As CustomIdentity

    Public Sub New(ByVal username As String)
        customid = New CustomIdentity(username)
    End Sub

    Public ReadOnly Property Identity As IIdentity Implements IPrincipal.Identity
        Get
            Return customid
        End Get
    End Property

    Public Function IsInRole(role As String) As Boolean Implements IPrincipal.IsInRole
        Return User.GetUserRoleByName(customid.Name, role)
    End Function
End Class

Public Class CustomIdentity
    Implements IIdentity

    Private _name As String

    Public Sub New(ByVal username As String)
        _name = username
    End Sub

    Public ReadOnly Property AuthenticationType As String Implements IIdentity.AuthenticationType
        Get
            Return "CustomAuthentication"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements IIdentity.IsAuthenticated
        Get
            Return Not String.IsNullOrEmpty(_name)
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IIdentity.Name
        Get
            Return _name
        End Get
    End Property
End Class
