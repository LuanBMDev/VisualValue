Module Module1
    Public banco As New ADODB.Connection
    Public tabela As New ADODB.Recordset
    Public sql As String
    Public dir_banco = Application.StartupPath & "\Banco\db_visual_value.mdb"
    Public resp
    Public modo_edicao = False

    Sub Conectar_banco()
        Try
            banco = CreateObject("ADODB.Connection")
            banco.Open("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & dir_banco)
        Catch ex As Exception
            Console.WriteLine(ex)
            MsgBox("Erro de Conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_custos_mensais()
        Try
            sql = "SELECT * FROM tb_perfil_custos"
            tabela = banco.Execute(sql)
            With Frm_editar_custos.dgv_listaperfil
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value,
                        tabela.Fields(1).Value,
                        Nothing,
                        Nothing)
                    tabela.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Não foi possível carregar os custos mensais", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_custos_mensais()
        With Frm_editar_custos
            .txt_perfilcustos.Clear()
            .txt_nomecusto.Clear()
            .txt_precocusto.Clear()
            .cmb_diatrabalhado.Text = ""
            .cmb_horatrabalhada.Text = ""
            .dgv_listacusto.Rows.Clear()
            .dgv_listacusto.Refresh()
        End With
    End Sub

    Sub alt_modo_edicao_custos_mensais(id_perfil As Integer, esta_na_edicao As Boolean)
        modo_edicao = esta_na_edicao

        With Frm_editar_custos
            If modo_edicao = False Then
                limpar_custos_mensais()
                .btn_cadastar.Text = "CADASTRAR"
                .btn_sair_modo_edicao.Hide()
            Else
                limpar_custos_mensais()
                .btn_cadastar.Text = "SALVAR ALTERAÇÕES"
                .btn_sair_modo_edicao.Show()
                .txt_nomecusto.Clear()
                .txt_precocusto.Clear()

                sql = "SELECT * FROM tb_perfil_custos WHERE id_perfil_custos = " & id_perfil
                tabela = banco.Execute(sql)

                If tabela.EOF = False Then
                    .txt_perfilcustos.Text = tabela.Fields(1).Value
                    .cmb_diatrabalhado.Text = tabela.Fields(2).Value
                    .cmb_horatrabalhada.Text = tabela.Fields(3).Value
                End If

                sql = "SELECT * FROM tb_custos_mensais WHERE id_perfil_custos = " & id_perfil
                tabela = banco.Execute(sql)

                Do While tabela.EOF = False
                    .dgv_listacusto.Rows.Add(tabela.Fields(0).Value,
                                             tabela.Fields(1).Value,
                                             FormatNumber(tabela.Fields(2).Value, 2))
                    tabela.MoveNext()
                Loop
            End If
        End With
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


    Public Sub limpar_precificacao()
        With Frm_Precificar
            .txt_horas_bruto.Text = 0
            .txt_minutos_bruto.Text = 0

            .txt_horas_final.Text = 0
            .txt_minutos_final.Text = 0

            .cb_legendas.Checked = False

            .cb_edicaosimples.Checked = False
            .cb_edicaomedia.Checked = False
            .cb_edicaocomplexa.Checked = False

            .txt_tempoproducao.Text = 0

            .precofinal.Text = FormatNumber(0, 2)
        End With
    End Sub
End Module
