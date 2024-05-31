Public Class Frm_editar_preco

    Private idperfil As Integer
    Private aux_perfil As String
    Private resp As String
    Private Sub btn_cadastar_Click(sender As Object, e As EventArgs) Handles btn_cadastar.Click
        If txt_perfilpreco.Text = "" Or txt_precolegenda.Text = "" Or txt_precodiferenca.Text = "" Or txt_precosimples.Text = "" Or txt_precomedia.Text = "" Or txt_precocomplexa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf idperfil <> 0 Then
            Try
                sql = "update tb_perfil_precos set nome_perfil_precos = '" & txt_perfilpreco.Text &
                                            "',legenda_por_minuto = '" & txt_precolegenda.Text &
                                            "', diff_bruto_e_final =  '" & txt_precodiferenca.Text &
                                            "', edicao_simples = '" & txt_precosimples.Text &
                                            "', edicao_mediana = '" & txt_precomedia.Text &
                                            "', edicao_complexa = '" & txt_precocomplexa.Text &
                                            "' where id_perfil_precos = " & idperfil & ""
                tabela = banco.Execute(sql)
                MsgBox("Perfil editado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                carrgar_dados()
                idperfil = 0
            Catch ex As Exception
                MsgBox("Erro ao editar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            End Try

        Else
            Try
                sql = "select * from tb_perfil_precos where nome_perfil_precos = '" & txt_perfilpreco.Text & "'"
                tabela = banco.Execute(sql)
                If tabela.EOF = True Then
                    sql = "insert into tb_perfil_precos (nome_perfil_precos,legenda_por_minuto, diff_bruto_e_final, edicao_simples, edicao_mediana, edicao_complexa)" &
                                                "values ('" & txt_perfilpreco.Text & "', '" &
                                                            txt_precolegenda.Text & "', '" &
                                                            txt_precodiferenca.Text & "', '" &
                                                            txt_precosimples.Text & "', '" &
                                                            txt_precomedia.Text & "', '" &
                                                            txt_precocomplexa.Text & "')"
                    tabela = banco.Execute(sql)
                    MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    Limpar_dados()
                    carrgar_dados()
                Else
                    MsgBox("Este perfil ja existe!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Erro ao Gravar os dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            End Try
        End If
    End Sub

    Sub Limpar_dados()
        txt_perfilpreco.Text = ""
        txt_precolegenda.Text = ""
        txt_precodiferenca.Text = ""
        txt_precosimples.Text = ""
        txt_precomedia.Text = ""
        txt_precocomplexa.Text = ""
    End Sub

    Sub carrgar_dados()
        Try
            sql = "select * from tb_perfil_precos where id_perfil_precos <> 1 order by nome_perfil_precos ASC"
            tabela = banco.Execute(sql)
            With dgv_precos
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value,
                        tabela.Fields(1).Value)
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Frm_editar_preco_Load(sender As Object, e As EventArgs) Handles Me.Load
        carrgar_dados()

    End Sub

    Private Sub dgv_precos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_precos.CellContentClick
        With dgv_precos
            Try
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_perfil = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja apagar o perfil: '" & aux_perfil & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_perfil_precos where id_perfil_precos = " & .CurrentRow.Cells(0).Value & ""
                        tabela = banco.Execute(sql)
                        MsgBox("Perfil excluido com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        carrgar_dados()
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MsgBox("Erro ao excluir dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try

            Try
                If .CurrentRow.Cells(2).Selected = True Then
                    idperfil = CInt(.CurrentRow.Cells(0).Value)

                    sql = "select * from tb_perfil_precos where id_perfil_precos =" & idperfil
                    tabela = banco.Execute(sql)
                    If idperfil = tabela.Fields(0).Value Then
                        txt_perfilpreco.Text = tabela.Fields(1).Value
                        txt_precolegenda.Text = tabela.Fields(2).Value
                        txt_precodiferenca.Text = tabela.Fields(3).Value
                        txt_precosimples.Text = tabela.Fields(4).Value
                        txt_precomedia.Text = tabela.Fields(5).Value
                        txt_precocomplexa.Text = tabela.Fields(6).Value
                    End If
                End If
            Catch ex As Exception
                MsgBox("Não foi possível entrar no modo edição!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            End Try
        End With
    End Sub
End Class