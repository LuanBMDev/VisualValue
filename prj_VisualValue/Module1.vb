﻿Module Module1
    Public banco As New ADODB.Connection
    Public tabela As New ADODB.Recordset
    Public sql As String
    Public dir_banco = Application.StartupPath & "\Banco\db_visual_value.mdb"
    Public resp

    Sub Conectar_banco()
        Try
            banco = CreateObject("ADODB.Connection")
            banco.Open("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & dir_banco)
        Catch ex As Exception
            Console.WriteLine(ex)
            MsgBox("Erro de Conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub permitir_apenas_numeros_e_virgula(tecla As KeyPressEventArgs)
        If Not IsNumeric(tecla.KeyChar) And Asc(tecla.KeyChar) <> 8 And Asc(tecla.KeyChar) <> 44 Then
            tecla.Handled = True
        End If
    End Sub

    Sub validar_caixa_de_preco(caixa_texto As Object)
        With caixa_texto
            If .Text.StartsWith(",") Or .Text.EndsWith(",") Or tem_virgula_repetida(.Text) Then
                MsgBox("O preço não pode conter mais de uma vírgula, nem começar ou terminar com uma." & vbNewLine & vbNewLine &
                       "Tente Novamente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                .Clear()
            End If
        End With
    End Sub

    Function tem_virgula_repetida(texto As String) As Boolean
        Dim i = 0
        Dim contador_virgulas = 0

        While i < texto.Length
            If texto.ElementAt(i) = "," Then
                contador_virgulas += 1
            End If
            i += 1
        End While

        If contador_virgulas > 1 Then
            Return True
        End If

        Return False
    End Function
End Module
