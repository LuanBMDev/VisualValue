Public Class Frm_editar_custos
    Dim contador As Integer
    Dim aux_nome_custo
    Dim aux_id_perfil
    Dim prox_indice

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        validar_caixa_de_preco(txt_precocusto)
        If txt_nomecusto.Text = "" Or txt_precocusto.Text = "" Then
            MsgBox("Informe um nome e preço para o custo a ser adicionado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            With dgv_listacusto

                prox_indice = (.Rows(.Rows.Count - 1).Cells(0).Value) + 1

                .Rows.Add(prox_indice, txt_nomecusto.Text, txt_precocusto.Text, Nothing)
            End With

            txt_nomecusto.Clear()
            txt_precocusto.Clear()
            txt_nomecusto.Focus()
        End If
    End Sub

    Private Sub dgv_listacusto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listacusto.CellContentClick
        With dgv_listacusto
            If .CurrentRow.Cells(3).Selected = True Then
                aux_nome_custo = .CurrentRow.Cells(1).Value
                resp = MsgBox("Deseja remover o custo " & aux_nome_custo & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    Dim custo_mensal_atual = .CurrentRow.Cells(0).Value

                    If modo_edicao = True Then
                        sql = "DELETE FROM tb_custos_mensais WHERE id_perfil_custos = " & aux_id_perfil & " AND id_custo_mensal = " & custo_mensal_atual
                        tabela = banco.Execute(sql)
                        .Rows.Remove(.Rows.Item(.CurrentCell.RowIndex))
                        Exit Sub
                    End If

                    While custo_mensal_atual < .Rows.Count
                        .Rows(custo_mensal_atual).Cells(0).Value = custo_mensal_atual
                        custo_mensal_atual += 1
                    End While

                    .Rows.Remove(.Rows.Item(.CurrentCell.RowIndex))
                End If
            End If
        End With
    End Sub

    Private Sub txt_precocusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precocusto.KeyPress
        permitir_apenas_numeros_e_virgula(e)
    End Sub

    Private Sub btn_cadastar_Click(sender As Object, e As EventArgs) Handles btn_cadastar.Click
        If txt_perfilcustos.Text = "" Or cmb_diatrabalhado.Text = "" Or cmb_horatrabalhada.Text = "" Then
            MsgBox("Preencha os campos de nome do perfil de custos, dias trabalhados por mês e horas trabalhadas por dia",
                    MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf modo_edicao = False Then
            sql = "SELECT * FROM tb_perfil_custos WHERE nome_perfil_custos = '" & txt_perfilcustos.Text & "'"
            tabela = banco.Execute(sql)

            If tabela.EOF = False Then
                MsgBox("O perfil '" & txt_perfilcustos.Text & "' já existe!",
                            MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                txt_perfilcustos.Clear()
                txt_perfilcustos.Focus()
            Else
                sql = "INSERT INTO tb_perfil_custos (nome_perfil_custos, dias_trabalhados, horas_trabalhadas)" &
                                    "VALUES ('" & txt_perfilcustos.Text & "', " &
                                                  cmb_diatrabalhado.Text & ", " &
                                                  cmb_horatrabalhada.Text & ")"
                tabela = banco.Execute(UCase(sql))

                contador = 0

                sql = "SELECT * FROM tb_perfil_custos WHERE nome_perfil_custos = '" & txt_perfilcustos.Text & "'"
                tabela = banco.Execute(sql)

                aux_id_perfil = CInt(tabela.Fields(0).Value)

                With dgv_listacusto
                    While contador < .RowCount
                        sql = "INSERT INTO tb_custos_mensais (id_custo_mensal, nome_custo_mensal, valor_custo_mensal, id_perfil_custos) VALUES (" &
                                           .Rows(contador).Cells(0).Value & ", " &
                                     "'" & .Rows(contador).Cells(1).Value & "', " &
                                     "'" & .Rows(contador).Cells(2).Value & "', " &
                                           aux_id_perfil & ")"
                        tabela = banco.Execute(UCase(sql))

                        contador += 1
                    End While
                End With

                MsgBox("Custos mensais cadastrados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                carregar_custos_mensais()
                limpar_custos_mensais()
            End If

        Else
            sql = "UPDATE tb_perfil_custos SET nome_perfil_custos = '" & txt_perfilcustos.Text & "', " &
                                              "dias_trabalhados = " & cmb_diatrabalhado.Text & ", " &
                                              "horas_trabalhadas = " & cmb_horatrabalhada.Text &
                                              " WHERE id_perfil_custos = " & aux_id_perfil
            tabela = banco.Execute(UCase(sql))

            contador = 0

            With dgv_listacusto
                Do While contador < .RowCount
                    sql = "UPDATE tb_custos_mensais SET nome_custo_mensal = '" & .Rows(contador).Cells(1).Value & "', " &
                                                       "valor_custo_mensal = '" & .Rows(contador).Cells(2).Value & "' " &
                                                       " WHERE id_perfil_custos = " & aux_id_perfil & " AND id_custo_mensal = " & .Rows(contador).Cells(0).Value
                    tabela = banco.Execute(UCase(sql))

                    sql = "SELECT COUNT(*) FROM tb_custos_mensais WHERE id_perfil_custos = " & aux_id_perfil
                    tabela = banco.Execute(sql)

                    Dim quant_custos = tabela.Fields(0).Value

                    If .RowCount > quant_custos And contador >= quant_custos Then
                        sql = "INSERT INTO tb_custos_mensais (id_custo_mensal, nome_custo_mensal, valor_custo_mensal, id_perfil_custos) VALUES (" &
                                           .Rows(contador).Cells(0).Value & ", " &
                                     "'" & .Rows(contador).Cells(1).Value & "', " &
                                     "'" & .Rows(contador).Cells(2).Value & "', " &
                                           aux_id_perfil & ")"
                        tabela = banco.Execute(UCase(sql))
                    End If
                    contador += 1
                Loop
            End With

            MsgBox("Perfil de custos mensais editado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            alt_modo_edicao_custos_mensais(aux_id_perfil, False)
        End If
    End Sub

    Private Sub dgv_listaperfil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaperfil.CellContentClick
        With dgv_listaperfil
            If .CurrentRow.Cells(3).Selected Then
                resp = MsgBox("Deseja apagar o perfil '" & .CurrentRow.Cells(1).Value & "'?",
                    MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                If resp = MsgBoxResult.Yes Then
                    aux_id_perfil = .CurrentRow.Cells(0).Value

                    sql = "DELETE FROM tb_perfil_custos WHERE id_perfil_custos = " & aux_id_perfil
                    tabela = banco.Execute(sql)

                    sql = "DELETE FROM tb_custos_mensais WHERE id_perfil_custos = " & aux_id_perfil
                    tabela = banco.Execute(sql)

                    MsgBox("Perfil de custos mensais deletado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    carregar_custos_mensais()
                End If
            End If

            If .CurrentRow.Cells(2).Selected Then
                aux_id_perfil = .CurrentRow.Cells(0).Value
                alt_modo_edicao_custos_mensais(aux_id_perfil, True)
            End If
        End With
    End Sub

    Private Sub Frm_editar_custos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alt_modo_edicao_custos_mensais(aux_id_perfil, False)
        carregar_custos_mensais()
    End Sub

    Private Sub btn_sair_modo_edicao_Click(sender As Object, e As EventArgs) Handles btn_sair_modo_edicao.Click
        alt_modo_edicao_custos_mensais(aux_id_perfil, False)
    End Sub
End Class