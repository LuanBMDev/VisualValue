Imports System.Data.SqlClient

Public Class Frm_Precificar

    Dim tipo_de_pacote As Integer

    Private Sub Precificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Menu.Hide()
        carregar_dados()
    End Sub

    Private Sub Frm_Precificar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Frm_Menu.Show()
    End Sub

    Private Sub txt_tempoproducao_TextChanged(sender As Object, e As EventArgs) Handles txt_tempoproducao.TextChanged
        calculo_precificar()
    End Sub

    Private Sub calculo_precificar()

        Dim total_custos_mensais As Double = 0
        Dim total_dias_tabalhados As Double = 0
        Dim total_custo_diario As Double = 0
        Dim horas_trabalhadas As Double = 0
        Dim custo_hora As Double = 0
        Dim tempo_bruto As Double
        Dim tempo_final As Double
        Dim resultado_tempo_video As Double


        total_custo_diario = total_custos_mensais / total_dias_tabalhados
        custo_hora = total_custo_diario / horas_trabalhadas

        precomin.Text = FormatNumber(custo_hora * CDbl(txt_tempoproducao.Text), 2)


        tempo_bruto = CDbl(txt_tempobruto.Text)
        tempo_final = CDbl(txt_tempofinal.Text)
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

    Private Sub cmb_perfilpreco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_perfilpreco.SelectedIndexChanged

        Dim aux_nome_perfil As String

        aux_nome_perfil = cmb_perfilpreco.SelectedItem.ToString()

        sql = "select * from tb_perfil_precos where nome_perfil_precos = '" & aux_nome_perfil & "'"
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
End Class
