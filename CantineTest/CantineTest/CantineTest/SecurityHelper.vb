Imports System.Security.Cryptography

Public Class SecurityHelper
    Public Shared Function GenerateSalt(ByVal nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {}

        Using provider = New RNGCryptoServiceProvider()
            provider.GetNonZeroBytes(saltBytes)
        End Using

        Return Convert.ToBase64String(saltBytes)
    End Function

    Public Shared Function HashPassword(ByVal password As String, ByVal salt As String, ByVal nIterations As Integer, ByVal nHash As Integer) As String
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, saltBytes, nIterations)
            Return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash))
        End Using
    End Function

    Public Shared Function CheckPassword(byval password As String, ByVal hashedPassword As String, ByVal salt As String)
        Dim newHashed = HashPassword(password, salt, 10101, 70)
        Return newHashed.Equals(hashedPassword)
    End Function
End Class
