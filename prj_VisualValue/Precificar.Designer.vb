﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Precificar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Precificar))
        Me.cmb_perfilcusto = New System.Windows.Forms.ComboBox()
        Me.cmb_perfilpreco = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_edicaosimples = New ns1.BunifuCheckbox()
        Me.cb_edicaomedia = New ns1.BunifuCheckbox()
        Me.cb_edicaocomplexa = New ns1.BunifuCheckbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_horas_bruto = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.cb_legendas = New ns1.BunifuCheckbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.somacustomensal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.valorhora = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_tempoproducao = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.precomin = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.precofinal = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.valorlegenda = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.valordiferenca = New System.Windows.Forms.Label()
        Me.valorsimples = New System.Windows.Forms.Label()
        Me.valormedia = New System.Windows.Forms.Label()
        Me.valorcomplexo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_minutos_bruto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_minutos_final = New System.Windows.Forms.TextBox()
        Me.txt_horas_final = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_total_diferenca = New System.Windows.Forms.Label()
        Me.lbl_preco_legenda = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_perfilcusto
        '
        Me.cmb_perfilcusto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_perfilcusto.FormattingEnabled = True
        Me.cmb_perfilcusto.Location = New System.Drawing.Point(73, 112)
        Me.cmb_perfilcusto.Name = "cmb_perfilcusto"
        Me.cmb_perfilcusto.Size = New System.Drawing.Size(154, 21)
        Me.cmb_perfilcusto.TabIndex = 0
        '
        'cmb_perfilpreco
        '
        Me.cmb_perfilpreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_perfilpreco.FormattingEnabled = True
        Me.cmb_perfilpreco.Location = New System.Drawing.Point(73, 166)
        Me.cmb_perfilpreco.Name = "cmb_perfilpreco"
        Me.cmb_perfilpreco.Size = New System.Drawing.Size(154, 21)
        Me.cmb_perfilpreco.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(70, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Custos mensais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(70, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tabelas de Preços"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(12, 193)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator1.TabIndex = 87
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(167, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 24)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Tempo de Vídeo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(662, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 24)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Tipos de Edição"
        '
        'cb_edicaosimples
        '
        Me.cb_edicaosimples.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_edicaosimples.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_edicaosimples.Checked = False
        Me.cb_edicaosimples.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.cb_edicaosimples.ForeColor = System.Drawing.Color.White
        Me.cb_edicaosimples.Location = New System.Drawing.Point(598, 272)
        Me.cb_edicaosimples.Name = "cb_edicaosimples"
        Me.cb_edicaosimples.Size = New System.Drawing.Size(20, 20)
        Me.cb_edicaosimples.TabIndex = 8
        '
        'cb_edicaomedia
        '
        Me.cb_edicaomedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_edicaomedia.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_edicaomedia.Checked = False
        Me.cb_edicaomedia.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.cb_edicaomedia.ForeColor = System.Drawing.Color.White
        Me.cb_edicaomedia.Location = New System.Drawing.Point(598, 314)
        Me.cb_edicaomedia.Name = "cb_edicaomedia"
        Me.cb_edicaomedia.Size = New System.Drawing.Size(20, 20)
        Me.cb_edicaomedia.TabIndex = 9
        '
        'cb_edicaocomplexa
        '
        Me.cb_edicaocomplexa.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_edicaocomplexa.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_edicaocomplexa.Checked = False
        Me.cb_edicaocomplexa.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.cb_edicaocomplexa.ForeColor = System.Drawing.Color.White
        Me.cb_edicaocomplexa.Location = New System.Drawing.Point(598, 362)
        Me.cb_edicaocomplexa.Name = "cb_edicaocomplexa"
        Me.cb_edicaocomplexa.Size = New System.Drawing.Size(20, 20)
        Me.cb_edicaocomplexa.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(63, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Tempo bruto de vídeo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(63, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Duração final do vídeo"
        '
        'txt_horas_bruto
        '
        Me.txt_horas_bruto.Location = New System.Drawing.Point(66, 274)
        Me.txt_horas_bruto.Name = "txt_horas_bruto"
        Me.txt_horas_bruto.Size = New System.Drawing.Size(55, 20)
        Me.txt_horas_bruto.TabIndex = 2
        Me.txt_horas_bruto.Text = "0"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(12, 415)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator2.TabIndex = 14
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'cb_legendas
        '
        Me.cb_legendas.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_legendas.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_legendas.Checked = False
        Me.cb_legendas.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.cb_legendas.ForeColor = System.Drawing.Color.White
        Me.cb_legendas.Location = New System.Drawing.Point(65, 382)
        Me.cb_legendas.Name = "cb_legendas"
        Me.cb_legendas.Size = New System.Drawing.Size(20, 20)
        Me.cb_legendas.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(91, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Legendas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(127, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "por minuto de vídeo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(123, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = " a cada 10 min de diferença): "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(624, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Edição Simples:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(624, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 24)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Edição Média:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(624, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Edição Complexa:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label14.Location = New System.Drawing.Point(625, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "(Transições, Trilha Sonora)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label15.Location = New System.Drawing.Point(625, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "(Simples + Efeitos especiais)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label16.Location = New System.Drawing.Point(625, 386)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "(Simples + Média + Efeitos Extras)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(331, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(265, 24)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Soma dos Custos Mensais: R$"
        '
        'somacustomensal
        '
        Me.somacustomensal.AutoSize = True
        Me.somacustomensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.somacustomensal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.somacustomensal.Location = New System.Drawing.Point(612, 96)
        Me.somacustomensal.Name = "somacustomensal"
        Me.somacustomensal.Size = New System.Drawing.Size(55, 24)
        Me.somacustomensal.TabIndex = 27
        Me.somacustomensal.Text = "00,00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(349, 138)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(218, 29)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Sua hora vale: R$"
        '
        'valorhora
        '
        Me.valorhora.AutoSize = True
        Me.valorhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorhora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.valorhora.Location = New System.Drawing.Point(573, 138)
        Me.valorhora.Name = "valorhora"
        Me.valorhora.Size = New System.Drawing.Size(76, 29)
        Me.valorhora.TabIndex = 30
        Me.valorhora.Text = "00,00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label22.Location = New System.Drawing.Point(293, 169)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(408, 13)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "(Total de Custos Mensais / Dias Trabalhados por Mês  /  Horas Trabalhadas por Dia" &
    ")"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(70, 495)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(216, 13)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Tempo estimado para a conclusão do vídeo"
        '
        'txt_tempoproducao
        '
        Me.txt_tempoproducao.Location = New System.Drawing.Point(73, 511)
        Me.txt_tempoproducao.Name = "txt_tempoproducao"
        Me.txt_tempoproducao.Size = New System.Drawing.Size(154, 20)
        Me.txt_tempoproducao.TabIndex = 6
        Me.txt_tempoproducao.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(358, 475)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 25)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Preço Mínimo"
        '
        'precomin
        '
        Me.precomin.AutoSize = True
        Me.precomin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precomin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.precomin.Location = New System.Drawing.Point(435, 505)
        Me.precomin.Name = "precomin"
        Me.precomin.Size = New System.Drawing.Size(66, 25)
        Me.precomin.TabIndex = 36
        Me.precomin.Text = "00,00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label27.Location = New System.Drawing.Point(686, 469)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(162, 31)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Preço Final"
        '
        'precofinal
        '
        Me.precofinal.AutoSize = True
        Me.precofinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precofinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.precofinal.Location = New System.Drawing.Point(761, 503)
        Me.precofinal.Name = "precofinal"
        Me.precofinal.Size = New System.Drawing.Size(87, 31)
        Me.precofinal.TabIndex = 38
        Me.precofinal.Text = "00,00"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label29.Location = New System.Drawing.Point(294, 541)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(302, 13)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "(Preço da hora X Tempo Estimado para a Conclusão do Vídeo"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label31.Location = New System.Drawing.Point(645, 540)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(233, 13)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "(Preço Mínimo + Soma dos Serviços de Edição)"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Location = New System.Drawing.Point(62, 407)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(21, 13)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "R$"
        '
        'valorlegenda
        '
        Me.valorlegenda.AutoSize = True
        Me.valorlegenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.valorlegenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.valorlegenda.Location = New System.Drawing.Point(89, 405)
        Me.valorlegenda.Name = "valorlegenda"
        Me.valorlegenda.Size = New System.Drawing.Size(38, 16)
        Me.valorlegenda.TabIndex = 44
        Me.valorlegenda.Text = "00,00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label35.Location = New System.Drawing.Point(60, 300)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(27, 13)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "(R$ "
        '
        'valordiferenca
        '
        Me.valordiferenca.AutoSize = True
        Me.valordiferenca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.valordiferenca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.valordiferenca.Location = New System.Drawing.Point(85, 298)
        Me.valordiferenca.Name = "valordiferenca"
        Me.valordiferenca.Size = New System.Drawing.Size(38, 16)
        Me.valordiferenca.TabIndex = 46
        Me.valordiferenca.Text = "00,00"
        '
        'valorsimples
        '
        Me.valorsimples.AutoSize = True
        Me.valorsimples.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorsimples.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.valorsimples.Location = New System.Drawing.Point(813, 268)
        Me.valorsimples.Name = "valorsimples"
        Me.valorsimples.Size = New System.Drawing.Size(55, 24)
        Me.valorsimples.TabIndex = 47
        Me.valorsimples.Text = "00,00"
        '
        'valormedia
        '
        Me.valormedia.AutoSize = True
        Me.valormedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valormedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.valormedia.Location = New System.Drawing.Point(803, 314)
        Me.valormedia.Name = "valormedia"
        Me.valormedia.Size = New System.Drawing.Size(55, 24)
        Me.valormedia.TabIndex = 48
        Me.valormedia.Text = "00,00"
        '
        'valorcomplexo
        '
        Me.valorcomplexo.AutoSize = True
        Me.valorcomplexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorcomplexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.valorcomplexo.Location = New System.Drawing.Point(823, 362)
        Me.valorcomplexo.Name = "valorcomplexo"
        Me.valorcomplexo.Size = New System.Drawing.Size(55, 24)
        Me.valorcomplexo.TabIndex = 49
        Me.valorcomplexo.Text = "00,00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(727, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 80)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'txt_minutos_bruto
        '
        Me.txt_minutos_bruto.Location = New System.Drawing.Point(153, 274)
        Me.txt_minutos_bruto.Name = "txt_minutos_bruto"
        Me.txt_minutos_bruto.Size = New System.Drawing.Size(55, 20)
        Me.txt_minutos_bruto.TabIndex = 3
        Me.txt_minutos_bruto.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(123, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 16)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "h"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(210, 278)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 16)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "min"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(210, 339)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 16)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "min"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Location = New System.Drawing.Point(123, 339)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 16)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "h"
        '
        'txt_minutos_final
        '
        Me.txt_minutos_final.Location = New System.Drawing.Point(153, 335)
        Me.txt_minutos_final.Name = "txt_minutos_final"
        Me.txt_minutos_final.Size = New System.Drawing.Size(55, 20)
        Me.txt_minutos_final.TabIndex = 5
        Me.txt_minutos_final.Text = "0"
        '
        'txt_horas_final
        '
        Me.txt_horas_final.Location = New System.Drawing.Point(66, 335)
        Me.txt_horas_final.Name = "txt_horas_final"
        Me.txt_horas_final.Size = New System.Drawing.Size(55, 20)
        Me.txt_horas_final.TabIndex = 4
        Me.txt_horas_final.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(278, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 24)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "R$"
        '
        'lbl_total_diferenca
        '
        Me.lbl_total_diferenca.AutoSize = True
        Me.lbl_total_diferenca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_diferenca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_total_diferenca.Location = New System.Drawing.Point(331, 292)
        Me.lbl_total_diferenca.Name = "lbl_total_diferenca"
        Me.lbl_total_diferenca.Size = New System.Drawing.Size(55, 24)
        Me.lbl_total_diferenca.TabIndex = 63
        Me.lbl_total_diferenca.Text = "00,00"
        '
        'lbl_preco_legenda
        '
        Me.lbl_preco_legenda.AutoSize = True
        Me.lbl_preco_legenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco_legenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_preco_legenda.Location = New System.Drawing.Point(207, 377)
        Me.lbl_preco_legenda.Name = "lbl_preco_legenda"
        Me.lbl_preco_legenda.Size = New System.Drawing.Size(55, 24)
        Me.lbl_preco_legenda.TabIndex = 65
        Me.lbl_preco_legenda.Text = "00,00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label32.Location = New System.Drawing.Point(168, 377)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 24)
        Me.Label32.TabIndex = 64
        Me.Label32.Text = "R$"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label34.Location = New System.Drawing.Point(774, 269)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(33, 24)
        Me.Label34.TabIndex = 66
        Me.Label34.Text = "R$"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label36.Location = New System.Drawing.Point(764, 314)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 24)
        Me.Label36.TabIndex = 67
        Me.Label36.Text = "R$"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label37.Location = New System.Drawing.Point(790, 362)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(33, 24)
        Me.Label37.TabIndex = 68
        Me.Label37.Text = "R$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(229, 516)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 16)
        Me.Label24.TabIndex = 69
        Me.Label24.Text = "horas"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label38.Location = New System.Drawing.Point(359, 505)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(33, 24)
        Me.Label38.TabIndex = 70
        Me.Label38.Text = "R$"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label39.Location = New System.Drawing.Point(686, 503)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(51, 31)
        Me.Label39.TabIndex = 71
        Me.Label39.Text = "R$"
        '
        'Frm_Precificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 601)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lbl_preco_legenda)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.lbl_total_diferenca)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txt_minutos_final)
        Me.Controls.Add(Me.txt_horas_final)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_minutos_bruto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.valorcomplexo)
        Me.Controls.Add(Me.valormedia)
        Me.Controls.Add(Me.valorsimples)
        Me.Controls.Add(Me.valordiferenca)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.valorlegenda)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.precofinal)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.precomin)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_tempoproducao)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.valorhora)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.somacustomensal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_legendas)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.txt_horas_bruto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_edicaocomplexa)
        Me.Controls.Add(Me.cb_edicaomedia)
        Me.Controls.Add(Me.cb_edicaosimples)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_perfilpreco)
        Me.Controls.Add(Me.cmb_perfilcusto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Precificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precificar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_perfilcusto As ComboBox
    Friend WithEvents cmb_perfilpreco As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_edicaosimples As ns1.BunifuCheckbox
    Friend WithEvents cb_edicaomedia As ns1.BunifuCheckbox
    Friend WithEvents cb_edicaocomplexa As ns1.BunifuCheckbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_horas_bruto As TextBox
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents cb_legendas As ns1.BunifuCheckbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents somacustomensal As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents valorhora As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_tempoproducao As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents precomin As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents precofinal As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents valorlegenda As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents valordiferenca As Label
    Friend WithEvents valorsimples As Label
    Friend WithEvents valormedia As Label
    Friend WithEvents valorcomplexo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_minutos_bruto As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_minutos_final As TextBox
    Friend WithEvents txt_horas_final As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_total_diferenca As Label
    Friend WithEvents lbl_preco_legenda As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
End Class
