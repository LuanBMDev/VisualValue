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

    Function SoNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then

            SoNumeros = 0

        Else

            SoNumeros = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumeros = Keyascii

            Case 13

                SoNumeros = Keyascii

            Case 32

                SoNumeros = Keyascii

        End Select

    End Function
End Module
