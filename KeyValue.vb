Public Class KeyValue

    Public Shared Function GetSize() As KeyValuePair(Of String, String)()


        Dim kvp As KeyValuePair(Of String, String)() =
           New KeyValuePair(Of String, String)() {
                New KeyValuePair(Of String, String)("7", "Ｓサイズ"),
                New KeyValuePair(Of String, String)("9", "Ｍサイズ"),
                New KeyValuePair(Of String, String)("11", "Ｌサイズ")
        }

        Return kvp

    End Function


End Class
