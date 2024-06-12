Imports System.Data.SqlClient

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

    Dim aux_id_perfil As Integer
    Dim aux_nome_perfil_custos As String
    Dim aux_nome_perfil_precos

    Private Sub Precificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_perfil_custo_mensal()
        Frm_Menu.Hide()
        carregar_dados()
    End Sub

    Private Sub Frm_Precificar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Frm_Menu.Show()
    End Sub

    Private Sub txt_tempoproducao_TextChanged(sender As Object, e As EventArgs) Handles txt_tempoproducao.TextChanged
        'calculo_precificar()
    End Sub

    Private Sub calculo_precificar()
        precomin.Text = FormatNumber(custo_hora * CDbl(txt_tempoproducao.Text), 2)


        tempo_bruto = CDbl(txt_horas_bruto.Text)
        'tempo_final = CDbl(txt_tempofinal.Text)
        resultado_tempo_video = tempo_bruto / tempo_final
        resultado_tempo_video = CDbl(valordiferenca.Text) * resultado_tempo_video

        precofinal.Text = CDbl(precomin.Text) + resultado_tempo_video
        If cb_legendas.Checked Then
            precofinal.Text = tempo_final * CDbl(valorlegenda.Text)
        End If

        If tipo_de_pacote = 1 Then
            precofinal.Text = CDbl(precofinal.Text) + CDbl(valorsimples.Text)
        ElseIf tipo_de_pacote = 2 Then
            precofinal.Text = CDbl(precofinal.Text) + CDbl(valormedia.Text)
        ElseIf tipo_de_pacote = 3 Then
            precofinal.Text = CDbl(precofinal.Text) + CDbl(valorcomplexo.Text)
        End If
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


    End Sub

    Private Sub cb_edicaosimples_OnChange(sender As Object, e As EventArgs) Handles cb_edicaosimples.OnChange
        If cb_edicaosimples.Checked = True Then
            cb_edicaomedia.Checked = False
            cb_edicaocomplexa.Checked = False
            tipo_de_pacote = 1
        End If
    End Sub

    Private Sub cb_edicaomedia_OnChange(sender As Object, e As EventArgs) Handles cb_edicaomedia.OnChange
        If cb_edicaomedia.Checked = True Then
            cb_edicaocomplexa.Checked = False
            cb_edicaosimples.Checked = False
            tipo_de_pacote = 2
        End If
    End Sub

    Private Sub cb_edicaocomplexa_OnChange(sender As Object, e As EventArgs) Handles cb_edicaocomplexa.OnChange
        If cb_edicaocomplexa.Checked = True Then
            cb_edicaosimples.Checked = False
            cb_edicaomedia.Checked = False
            tipo_de_pacote = 3
        End If
    End Sub

    Private Sub cmb_perfilcusto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_perfilcusto.SelectedIndexChanged
        aux_nome_perfil_custos = cmb_perfilcusto.SelectedItem.ToString()
        somar_custos_mensais()
        calcular_valor_hora()
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
                'caixa_horas.Text = 0

                Do While .Text - 60 >= 0
                    .Text -= 60
                    caixa_horas.Text += 1
                Loop
            End If
        End With
    End Sub

    Private Sub txt_horas_bruto_Leave(sender As Object, e As EventArgs) Handles txt_horas_bruto.Leave
        validar_caixa_tempo(txt_horas_bruto)
    End Sub

    Private Sub txt_minutos_bruto_Leave(sender As Object, e As EventArgs) Handles txt_minutos_bruto.Leave
        validar_caixa_tempo(txt_minutos_bruto)
        minuto_para_hora(txt_minutos_bruto, txt_horas_bruto)
    End Sub

    Private Sub txt_minutos_final_Leave(sender As Object, e As EventArgs) Handles txt_minutos_final.Leave
        validar_caixa_tempo(txt_minutos_final)
        minuto_para_hora(txt_minutos_final, txt_horas_final)
    End Sub

    Private Sub txt_horas_final_Leave(sender As Object, e As EventArgs) Handles txt_horas_final.Leave
        validar_caixa_tempo(txt_horas_final)
    End Sub

    Private Sub txt_tempoproducao_Leave(sender As Object, e As EventArgs) Handles txt_tempoproducao.Leave
        validar_caixa_tempo(txt_tempoproducao)
    End Sub
End Class
