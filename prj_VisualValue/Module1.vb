Module Module1
    Public banco As New ADODB.Connection
    Public tabela As New ADODB.Recordset
    Public sql As String
    Public dir_banco = Application.StartupPath & "\Banco\db_visual_value.mdb"

    Sub Conectar_banco()
        Try
            banco = CreateObject("ADODB.Connection")
            banco.Open("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & dir_banco)
        Catch ex As Exception
            Console.WriteLine(ex)
            MsgBox("Erro de Conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
