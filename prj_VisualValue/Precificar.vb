Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports ns1

Public Class Frm_Precificar

    Dim tipo_de_pacote As Integer

    Dim total_custos_mensais As Double = 0
    Dim total_dias_tabalhados As Double = 0
    Dim total_custo_diario As Double = 0
    Dim horas_trabalhadas As Double = 0
    Dim custo_hora As Double = 0
    Dim tempo_bruto As Double
    Dim tempo_final As Double
    Dim resultado_tempo_video As Double
    Dim custo_pacote_edicao As Double
    Dim preco_legenda As Double
    Dim preco_minimo As Double

    Dim aux_id_perfil As Integer
    Dim aux_nome_perfil_custos As String
    Dim aux_nome_perfil_precos

    Private Sub Precificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_precificacao()

        preco_minimo = FormatNumber(0, 2)
        tipo_de_pacote = 0
        preco_legenda = FormatNumber(0, 2)
        resultado_tempo_video = FormatNumber(0, 2)

        carregar_perfil_custo_mensal()
        Frm_Menu.Hide()
        carregar_dados()
    End Sub

    Private Sub Frm_Precificar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Frm_Menu.Show()
    End Sub

    Private Sub txt_tempoproducao_TextChanged(sender As Object, e As EventArgs) Handles txt_tempoproducao.TextChanged
        'update_preco_minimo()
    End Sub

    Private Sub selecionar_pacote_edicao()
        Select Case tipo_de_pacote
            Case 0
                custo_pacote_edicao = 0

            Case 1
                custo_pacote_edicao = CDbl(valorsimples.Text)

            Case 2
                custo_pacote_edicao = CDbl(valormedia.Text)

            Case 3
                custo_pacote_edicao = CDbl(valorcomplexo.Text)

            Case Else
                MsgBox("Erro ao selecionar pacote de edição.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Select

        'MsgBox("Pacote de edição: R$ " & custo_pacote_edicao)
    End Sub

    Private Sub carregar_dados()

        Try
            sql = "select nome_perfil_precos from tb_perfil_precos"
            tabela = banco.Execute(sql)
            cmb_perfilpreco.Items.Clear()

            While tabela.EOF = False
                cmb_perfilpreco.Items.Add(tabela.Fields(0).Value)
                tabela.MoveNext()
            End While

            cmb_perfilpreco.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Não foi possível carregar os preços personalizados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try


    End Sub

    Private Sub carregar_perfil_custo_mensal()
        sql = "SELECT nome_perfil_custos FROM tb_perfil_custos"
        tabela = banco.Execute(sql)

        Try
            With cmb_perfilcusto
                .Items.Clear()

                While tabela.EOF = False
                    cmb_perfilcusto.Items.Add(tabela.Fields(0).Value)
                    tabela.MoveNext()
                End While

                cmb_perfilcusto.SelectedIndex = 0
            End With
        Catch ex As Exception
            MsgBox("Cadastre PELO MENOS UM Perfil de Custos Mensais, antes de precificar um vídeo.",
                                                                   MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub somar_custos_mensais()
        Try
            total_custos_mensais = 0

            sql = "SELECT id_perfil_custos FROM tb_perfil_custos WHERE nome_perfil_custos = '" & aux_nome_perfil_custos & "'"
            tabela = banco.Execute(sql)

            aux_id_perfil = tabela.Fields(0).Value

            sql = "SELECT valor_custo_mensal FROM tb_custos_mensais WHERE id_perfil_custos = " & aux_id_perfil
            tabela = banco.Execute(sql)

            Do While tabela.EOF = False
                total_custos_mensais += tabela.Fields(0).Value
                tabela.MoveNext()
            Loop

            somacustomensal.Text = FormatNumber(total_custos_mensais, 2)
        Catch ex As Exception
            MsgBox("Erro ao somar custos mensais.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub calcular_valor_hora()
        Try
            sql = "SELECT dias_trabalhados, horas_trabalhadas FROM tb_perfil_custos WHERE nome_perfil_custos = '" & aux_nome_perfil_custos & "'"
            tabela = banco.Execute(sql)

            total_dias_tabalhados = tabela.Fields(0).Value
            horas_trabalhadas = tabela.Fields(1).Value

            total_custo_diario = total_custos_mensais / total_dias_tabalhados
            custo_hora = total_custo_diario / horas_trabalhadas

            valorhora.Text = FormatNumber(custo_hora, 2)
        Catch ex As Exception
            MsgBox("Erro ao calcular a hora.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub cmb_perfilpreco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_perfilpreco.SelectedIndexChanged
        aux_nome_perfil_precos = cmb_perfilpreco.SelectedItem.ToString()

        sql = "select * from tb_perfil_precos where nome_perfil_precos = '" & aux_nome_perfil_precos & "'"
        tabela = banco.Execute(sql)

        valorlegenda.Text = FormatNumber(tabela.Fields(2).Value, 2).ToString
        valordiferenca.Text = FormatNumber(tabela.Fields(3).Value, 2).ToString
        valorsimples.Text = FormatNumber(tabela.Fields(4).Value, 2).ToString
        valormedia.Text = FormatNumber(tabela.Fields(5).Value, 2).ToString
        valorcomplexo.Text = FormatNumber(tabela.Fields(6).Value, 2).ToString

        calc_diff_bruto_e_final()
        selecionar_pacote_edicao()
        calc_preco_legenda(cb_legendas)
        update_preco_minimo()
        calcular_preco_final()
    End Sub

    Private Sub cb_edicaosimples_OnChange(sender As Object, e As EventArgs) Handles cb_edicaosimples.OnChange
        If cb_edicaosimples.Checked = True Then
            cb_edicaomedia.Checked = False
            cb_edicaocomplexa.Checked = False
            tipo_de_pacote = 1

        Else
            tipo_de_pacote = 0
        End If

        selecionar_pacote_edicao()
        calcular_preco_final()
    End Sub

    Private Sub cb_edicaomedia_OnChange(sender As Object, e As EventArgs) Handles cb_edicaomedia.OnChange
        If cb_edicaomedia.Checked = True Then
            cb_edicaocomplexa.Checked = False
            cb_edicaosimples.Checked = False
            tipo_de_pacote = 2
        Else
            tipo_de_pacote = 0
        End If

        selecionar_pacote_edicao()
        calcular_preco_final()
    End Sub

    Private Sub cb_edicaocomplexa_OnChange(sender As Object, e As EventArgs) Handles cb_edicaocomplexa.OnChange
        If cb_edicaocomplexa.Checked = True Then
            cb_edicaosimples.Checked = False
            cb_edicaomedia.Checked = False
            tipo_de_pacote = 3

        Else
            tipo_de_pacote = 0
        End If

        selecionar_pacote_edicao()
        calcular_preco_final()
    End Sub

    Private Sub cmb_perfilcusto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_perfilcusto.SelectedIndexChanged
        aux_nome_perfil_custos = cmb_perfilcusto.SelectedItem.ToString()
        somar_custos_mensais()
        calcular_valor_hora()
        update_preco_minimo()
        calcular_preco_final()
    End Sub

    Private Sub validar_caixa_tempo(caixa_texto As TextBox)
        With caixa_texto
            If .Text = "" Then
                .Text = 0
            End If

            If .Text - Int(.Text) <> 0 Then
                .Text = Int(.Text)
            End If
        End With
    End Sub

    Private Function hora_para_minuto(horas As TextBox)
        Dim minutos = horas.Text * 60

        Return minutos
    End Function

    Private Sub minuto_para_hora(caixa_minutos As TextBox, caixa_horas As TextBox)
        With caixa_minutos
            If CDbl(.Text) >= 60 Then
                Do While .Text - 60 >= 0
                    .Text -= 60
                    caixa_horas.Text += 1
                Loop
            End If
        End With
    End Sub

    Private Sub preencher_horas(caixa_horas As TextBox)
        With caixa_horas
            If txt_horas_final.Text = 0 Then
                txt_horas_final.Text = .Text
            End If

            txt_tempoproducao.Text = .Text + 2
        End With
    End Sub

    Private Sub preencher_minutos(caixa_minutos As TextBox)
        With caixa_minutos
            If txt_minutos_final.Text = 0 Then
                txt_minutos_final.Text = .Text
            End If
        End With
    End Sub

    Private Sub inputs_campo_tempo(tecla As KeyPressEventArgs)
        If Not IsNumeric(tecla.KeyChar) And Asc(tecla.KeyChar) <> 8 And Asc(tecla.KeyChar) <> 13 And Asc(tecla.KeyChar) <> 9 Then
            tecla.Handled = True
        End If

        If Asc(tecla.KeyChar) = 13 Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Function minutos_totais(caixa_horas As TextBox, caixa_minutos As TextBox)
        Dim horas_convertidas = hora_para_minuto(caixa_horas)

        Return horas_convertidas + caixa_minutos.Text
    End Function

    Private Sub calc_diff_bruto_e_final()
        Dim duracao_bruta = minutos_totais(txt_horas_bruto, txt_minutos_bruto)
        Dim duracao_final = minutos_totais(txt_horas_final, txt_minutos_final)
        Dim diferenca_minutos = duracao_bruta - duracao_final

        If diferenca_minutos < 0 Then
            diferenca_minutos *= -1
        End If

        Dim qtd_dez_minutos = Int(diferenca_minutos / 10)

        Dim preco_diferenca = valordiferenca.Text

        resultado_tempo_video = qtd_dez_minutos * preco_diferenca

        lbl_total_diferenca.Text = FormatNumber(resultado_tempo_video, 2)
    End Sub

    Private Sub txt_horas_bruto_Leave(sender As Object, e As EventArgs) Handles txt_horas_bruto.Leave
        validar_caixa_tempo(txt_horas_bruto)
        preencher_horas(txt_horas_bruto)
        calc_diff_bruto_e_final()
    End Sub

    Private Sub txt_minutos_bruto_Leave(sender As Object, e As EventArgs) Handles txt_minutos_bruto.Leave
        validar_caixa_tempo(txt_minutos_bruto)
        minuto_para_hora(txt_minutos_bruto, txt_horas_bruto)
        preencher_minutos(txt_minutos_bruto)
        calc_diff_bruto_e_final()
    End Sub

    Private Sub txt_minutos_final_Leave(sender As Object, e As EventArgs) Handles txt_minutos_final.Leave
        validar_caixa_tempo(txt_minutos_final)
        minuto_para_hora(txt_minutos_final, txt_horas_final)
        calc_diff_bruto_e_final()
        calc_preco_legenda(cb_legendas)
    End Sub

    Private Sub txt_horas_final_Leave(sender As Object, e As EventArgs) Handles txt_horas_final.Leave
        validar_caixa_tempo(txt_horas_final)
        calc_diff_bruto_e_final()
        calc_preco_legenda(cb_legendas)
    End Sub

    Private Sub calc_preco_legenda(box_legenda As BunifuCheckbox)
        If box_legenda.Checked Then
            Dim duracao_final = minutos_totais(txt_horas_final, txt_minutos_final)
            Dim preco = valorlegenda.Text

            preco_legenda = duracao_final * preco
        Else
            preco_legenda = 0
        End If

        lbl_preco_legenda.Text = FormatNumber(preco_legenda, 2)
    End Sub

    Private Sub update_preco_minimo()
        Dim sua_hora = CDbl(valorhora.Text)
        Dim tempo_producao = CDbl(txt_tempoproducao.Text)

        preco_minimo = FormatNumber(sua_hora * tempo_producao, 2)

        precomin.Text = FormatNumber(preco_minimo, 2)
    End Sub

    Private Sub calcular_preco_final()
        Dim soma_custos_edicao = FormatNumber(resultado_tempo_video + preco_legenda + custo_pacote_edicao, 2)
        precofinal.Text = FormatNumber(preco_minimo + soma_custos_edicao, 2)
    End Sub

    Private Sub txt_tempoproducao_Leave(sender As Object, e As EventArgs) Handles txt_tempoproducao.Leave
        validar_caixa_tempo(txt_tempoproducao)
        update_preco_minimo()
    End Sub

    Private Sub txt_horas_bruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_horas_bruto.KeyPress
        inputs_campo_tempo(e)
    End Sub

    Private Sub txt_minutos_bruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_minutos_bruto.KeyPress
        inputs_campo_tempo(e)
    End Sub

    Private Sub txt_horas_final_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_horas_final.KeyPress
        inputs_campo_tempo(e)
    End Sub

    Private Sub txt_minutos_final_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_minutos_final.KeyPress
        inputs_campo_tempo(e)
    End Sub

    Private Sub txt_tempoproducao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tempoproducao.KeyPress
        inputs_campo_tempo(e)
    End Sub

    Private Sub cb_legendas_OnChange(sender As Object, e As EventArgs) Handles cb_legendas.OnChange
        calc_preco_legenda(cb_legendas)
        calcular_preco_final()
    End Sub

    Private Sub lbl_total_diferenca_TextChanged(sender As Object, e As EventArgs) Handles lbl_total_diferenca.TextChanged
        calcular_preco_final()
    End Sub

    Private Sub lbl_preco_legenda_TextChanged(sender As Object, e As EventArgs) Handles lbl_preco_legenda.TextChanged
        calcular_preco_final()
    End Sub

    Private Sub precomin_TextChanged(sender As Object, e As EventArgs) Handles precomin.TextChanged
        calcular_preco_final()
    End Sub
End Class
