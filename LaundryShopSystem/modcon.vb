Imports System.Data.SqlClient

Module modcon
    'database
    Public Sub Connected()
        With con
            Try
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = chan.Decrypt("WTz5qXNeZMhz3i1NPB0KL9P2+F3d482lkdjNj0ZHAqFCcyFC3vJjYo2JbCqaKrMSq/yzuSYRQ3i10QrxWPXVoiUuThnbq0QXRKcYkQxKlwM=", coder) 'Encrypted Con String
                .Open()

            Catch
                MsgBox("Error in Database! Contact Administrator.")
                End
            End Try
        End With
    End Sub
    'cmd use
    Sub CommandDB()
        cmd = New OleDb.OleDbCommand(sql, con)
    End Sub

End Module
