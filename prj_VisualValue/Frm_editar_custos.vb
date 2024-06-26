﻿Public Class Frm_editar_custos
    Dim contador As Integer
    Dim aux_nome_custo
    Dim aux_id_perfil
    Dim prox_indice

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Try
            validar_caixa_de_preco(txt_precocusto)
            If txt_nomecusto.Text = "" Or txt_precocusto.Text = "" Then
                MsgBox("Informe um nome e preço para o custo a ser adicionado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                With dgv_listacusto
                    If modo_edicao = False Then
                        prox_indice = .RowCount + 1
                    Else
                        prox_indice = (.Rows(.Rows.Count - 1).Cells(0).Value) + 1
                    End If

                    .Rows.Add(prox_indice, UCase(txt_nomecusto.Text), FormatNumber(txt_precocusto.Text, 2), Nothing)
                End With

                txt_nomecusto.Clear()
                txt_precocusto.Clear()
                txt_nomecusto.Focus()
            End If
        Catch ex As Exception
            MsgBox("Falha ao adicionar custo mensal.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_listacusto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listacusto.CellContentClick
        With dgv_listacusto
            Try
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
            Catch ex As Exception
                MsgBox("Falha ao remover custo mensal.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try
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
            Try
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
            Catch ex As Exception
                MsgBox("Erro ao cadastrar perfil de custos mensais.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        Else
            Try
                txt_nomecusto.Focus()

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
            Catch ex As Exception
                MsgBox("Erro ao editar perfil de custos mensais.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End If
    End Sub

    Private Sub dgv_listaperfil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaperfil.CellContentClick
        With dgv_listaperfil
            Try
                If .RowCount > 0 Then
                    If .CurrentRow.Cells(3).Selected Then
                        resp = MsgBox("Deseja apagar o perfil '" & .CurrentRow.Cells(1).Value & "'?",
                            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then
                            If modo_edicao = True Then
                                limpar_custos_mensais()
                                alt_modo_edicao_custos_mensais(aux_id_perfil, False)
                            End If

                            aux_id_perfil = .CurrentRow.Cells(0).Value

                            sql = "DELETE FROM tb_perfil_custos WHERE id_perfil_custos = " & aux_id_perfil
                            tabela = banco.Execute(sql)

                            sql = "DELETE FROM tb_custos_mensais WHERE id_perfil_custos = " & aux_id_perfil
                            tabela = banco.Execute(sql)

                            MsgBox("Perfil de custos mensais deletado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            carregar_custos_mensais()
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao excluir perfil de custos mensais.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End Try

            Try
                If .RowCount > 0 Then
                    If .CurrentRow.Cells(2).Selected Then
                        aux_id_perfil = .CurrentRow.Cells(0).Value
                        alt_modo_edicao_custos_mensais(aux_id_perfil, True)
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao entrar no modo de edição")
            End Try
        End With
    End Sub

    Private Sub Frm_editar_custos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alt_modo_edicao_custos_mensais(aux_id_perfil, False)
        carregar_custos_mensais()
        Frm_Menu.Hide()
    End Sub

    Private Sub btn_sair_modo_edicao_Click(sender As Object, e As EventArgs) Handles btn_sair_modo_edicao.Click
        alt_modo_edicao_custos_mensais(aux_id_perfil, False)
    End Sub

    Private Sub dgv_listacusto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listacusto.CellValueChanged
        Try
            Dim cont = 0
            With dgv_listacusto
                Do While cont < .RowCount
                    If .Rows(cont).Cells(2).Value < 0 Then
                        .Rows(cont).Cells(2).Value *= -1
                        Exit Sub
                    End If
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Insira apenas números e vírgula", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Frm_editar_custos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_Menu.Show()
    End Sub

    Private Sub txt_perfilcustos_TextChanged(sender As Object, e As EventArgs) Handles txt_perfilcustos.TextChanged
        If txt_perfilcustos.Text = "" Then
            Label19.Show()
        Else
            Label19.Hide()
        End If
    End Sub

    Private Sub cmb_diatrabalhado_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_diatrabalhado.SelectedValueChanged
        If cmb_diatrabalhado.SelectedIndex = 0 Then
            Label6.Show()
        Else
            Label6.Hide()
        End If
    End Sub

    Private Sub cmb_horatrabalhada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_horatrabalhada.SelectedIndexChanged
        If cmb_diatrabalhado.SelectedIndex = 0 Then
            Label7.Show()
        Else
            Label7.Hide()
        End If
    End Sub
End Class