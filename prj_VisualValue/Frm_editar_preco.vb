Public Class Frm_editar_preco

    Private idperfil As String
    Private Sub btn_cadastar_Click(sender As Object, e As EventArgs) Handles btn_cadastar.Click
        If txt_perfilpreco.Text = "" Or txt_precolegenda.Text = "" Or txt_precodiferenca.Text = "" Or txt_precosimples.Text = "" Or txt_precomedia.Text = "" Or txt_precocomplexa.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf idperfil <> "" Then


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
            sql = "select * from tb_perfil_precos order by nome_perfil_precos ASC"
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
End Class