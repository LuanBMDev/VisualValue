Public Class Frm_editar_custos
    Dim contador = 1
    Dim aux_nome_custo

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        validar_caixa_de_preco(txt_precocusto)

        If txt_nomecusto.Text = "" Or txt_precocusto.Text = "" Then
            MsgBox("Informe um nome e preço para o custo a ser adicionado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            With dgv_listacusto
                .Rows.Add(.Rows.Count + 1, txt_nomecusto.Text, txt_precocusto.Text, Nothing)
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
                    contador = .CurrentRow.Index
                    While contador < .Rows.Count
                        .Rows(contador).Cells(0).Value = contador
                        contador += 1
                    End While

                    .Rows.Remove(.Rows.Item(.CurrentCell.RowIndex))
                End If
            End If
        End With
    End Sub

    Private Sub txt_precocusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precocusto.KeyPress
        permitir_apenas_numeros_e_virgula(e)
    End Sub
End Class