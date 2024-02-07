Public Class Strings

Public Shared Function ExtractNextValue(ByRef liste As String, ByVal separator As String) As String
        Dim pos As Integer
        Dim item As String
        pos = InStr(liste, separator)

        If pos = 0 Then
            item = liste
            liste = ""
        Else
            item = Mid(liste, 1, pos - 1)
            liste = Mid(liste, pos + Len(separator))
        End If

        Return item
    End Function
Public Shared Function CompressString(text As String) As String
           Dim buffer__1 As Byte() = System.Text.Encoding.UTF8.GetBytes(text)
           Dim memoryStream as New IO.MemoryStream()
           Using gZipStream as New IO.Compression.GZipStream(memoryStream, IO.Compression.CompressionMode.Compress, True)
                  gZipStream.Write(buffer__1, 0, buffer__1.Length)
           End Using

           memoryStream.Position = 0

           Dim compressedData as Byte() = New Byte(memoryStream.Length - 1) {}
           memoryStream.Read(compressedData, 0, compressedData.Length)


           Dim gZipBuffer as Byte() = New Byte(compressedData.Length + 3) {}
           Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length)
           Buffer.BlockCopy(BitConverter.GetBytes(buffer__1.Length), 0, gZipBuffer, 0, 4)
           
        Return Convert.ToBase64String(gZipBuffer)
    End Function
    Public Shared Function DecompressString(compressedText As String) As String
           Dim gZipBuffer As Byte() = Convert.FromBase64String(compressedText)
           Dim memoryStream As New System.IO.MemoryStream()
              Dim dataLength As Integer = BitConverter.ToInt32(gZipBuffer, 0)
              memoryStream.Write(gZipBuffer,  4, gZipBuffer.Length - 4)

              Dim buffer = New Byte(dataLength - 1) {}

              memoryStream.Position = 0
              Dim gZipStream as new System.IO.Compression.GZipStream(memoryStream, System.IO.Compression.CompressionMode.Decompress)
                     
        gZipStream.Read(buffer, 0, buffer.Length)
       
              Return System.Text.Encoding.UTF8.GetString(buffer)
    End Function


End Class
