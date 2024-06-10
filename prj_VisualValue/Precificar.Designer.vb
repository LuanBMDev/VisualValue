<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.txt_tempobruto = New System.Windows.Forms.TextBox()
        Me.txt_tempofinal = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.cb_legendas = New ns1.BunifuCheckbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.somacustomensal = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.valorhora = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_tempoproducao = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.precomin = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.precofinal = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.valorlegenda = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.valordiferenca = New System.Windows.Forms.Label()
        Me.valorsimples = New System.Windows.Forms.Label()
        Me.valormedia = New System.Windows.Forms.Label()
        Me.valorcomplexo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_perfilcusto
        '
        Me.cmb_perfilcusto.FormattingEnabled = True
        Me.cmb_perfilcusto.Location = New System.Drawing.Point(73, 112)
        Me.cmb_perfilcusto.Name = "cmb_perfilcusto"
        Me.cmb_perfilcusto.Size = New System.Drawing.Size(154, 21)
        Me.cmb_perfilcusto.TabIndex = 0
        '
        'cmb_perfilpreco
        '
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
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Custos mensais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(70, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
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
        Me.BunifuSeparator1.TabIndex = 4
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
        Me.Label3.TabIndex = 5
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
        Me.Label4.TabIndex = 6
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
        Me.cb_edicaosimples.TabIndex = 7
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
        Me.cb_edicaomedia.TabIndex = 8
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
        Me.cb_edicaocomplexa.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(70, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tempo bruto de vídeo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(70, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Duração final do vídeo"
        '
        'txt_tempobruto
        '
        Me.txt_tempobruto.Location = New System.Drawing.Point(73, 300)
        Me.txt_tempobruto.Name = "txt_tempobruto"
        Me.txt_tempobruto.Size = New System.Drawing.Size(154, 20)
        Me.txt_tempobruto.TabIndex = 12
        '
        'txt_tempofinal
        '
        Me.txt_tempofinal.Location = New System.Drawing.Point(73, 362)
        Me.txt_tempofinal.Name = "txt_tempofinal"
        Me.txt_tempofinal.Size = New System.Drawing.Size(154, 20)
        Me.txt_tempofinal.TabIndex = 13
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
        Me.cb_legendas.Location = New System.Drawing.Point(270, 300)
        Me.cb_legendas.Name = "cb_legendas"
        Me.cb_legendas.Size = New System.Drawing.Size(20, 20)
        Me.cb_legendas.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(296, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Legendas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(324, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "por minuto de vídeo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(332, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = " a cada 10 min de"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(267, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = " diferença entre o bruto e o final)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(624, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Edição Simples"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(624, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 24)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Edição Média"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(624, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Edição Complexa"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(625, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "(efeitos de transição, trilha sonora): R$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(625, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "(simples + efeitos especiais): R$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(625, 386)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(253, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "(simples + mediana + Modelagem3D, Animação): R$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(416, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(265, 24)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Soma dos Custos Mensais: R$"
        '
        'somacustomensal
        '
        Me.somacustomensal.AutoSize = True
        Me.somacustomensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.somacustomensal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.somacustomensal.Location = New System.Drawing.Point(681, 96)
        Me.somacustomensal.Name = "somacustomensal"
        Me.somacustomensal.Size = New System.Drawing.Size(55, 24)
        Me.somacustomensal.TabIndex = 27
        Me.somacustomensal.Text = "00,00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(416, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(460, 24)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "(TotalCustos) / (DiasTrabalhados) = R$ (PreçoSeuDia)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(416, 166)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(158, 24)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Sua hora vale: R$"
        '
        'valorhora
        '
        Me.valorhora.AutoSize = True
        Me.valorhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.valorhora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.valorhora.Location = New System.Drawing.Point(580, 166)
        Me.valorhora.Name = "valorhora"
        Me.valorhora.Size = New System.Drawing.Size(55, 24)
        Me.valorhora.TabIndex = 30
        Me.valorhora.Text = "00,00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(641, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(180, 13)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "(PreçoSeuDia  /  HorasTrabalhadas)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(70, 469)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 13)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Tempo estimado para "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(70, 482)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(137, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "edição do video (em Horas)"
        '
        'txt_tempoproducao
        '
        Me.txt_tempoproducao.Location = New System.Drawing.Point(73, 511)
        Me.txt_tempoproducao.Name = "txt_tempoproducao"
        Me.txt_tempoproducao.Size = New System.Drawing.Size(154, 20)
        Me.txt_tempoproducao.TabIndex = 34
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(314, 474)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(127, 24)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Preço Mínimo"
        '
        'precomin
        '
        Me.precomin.AutoSize = True
        Me.precomin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.precomin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.precomin.Location = New System.Drawing.Point(331, 506)
        Me.precomin.Name = "precomin"
        Me.precomin.Size = New System.Drawing.Size(78, 24)
        Me.precomin.TabIndex = 36
        Me.precomin.Text = "R$00,00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label27.Location = New System.Drawing.Point(686, 469)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(122, 26)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Preço Final"
        '
        'precofinal
        '
        Me.precofinal.AutoSize = True
        Me.precofinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.precofinal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.precofinal.Location = New System.Drawing.Point(699, 506)
        Me.precofinal.Name = "precofinal"
        Me.precofinal.Size = New System.Drawing.Size(94, 26)
        Me.precofinal.TabIndex = 38
        Me.precofinal.Text = "R$00,00"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Location = New System.Drawing.Point(315, 540)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(119, 13)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "(Preço da hora)*(tempo "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label30.Location = New System.Drawing.Point(315, 553)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 13)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "estimado para edição)"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label31.Location = New System.Drawing.Point(682, 540)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(138, 13)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "(Preço mínimo) + (soma dos"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label32.Location = New System.Drawing.Point(682, 553)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 13)
        Me.Label32.TabIndex = 42
        Me.Label32.Text = "serviços da edição)"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Location = New System.Drawing.Point(267, 325)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(21, 13)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "R$"
        '
        'valorlegenda
        '
        Me.valorlegenda.AutoSize = True
        Me.valorlegenda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.valorlegenda.Location = New System.Drawing.Point(286, 325)
        Me.valorlegenda.Name = "valorlegenda"
        Me.valorlegenda.Size = New System.Drawing.Size(34, 13)
        Me.valorlegenda.TabIndex = 44
        Me.valorlegenda.Text = "00,00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label35.Location = New System.Drawing.Point(269, 365)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(27, 13)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "(R$ "
        '
        'valordiferenca
        '
        Me.valordiferenca.AutoSize = True
        Me.valordiferenca.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.valordiferenca.Location = New System.Drawing.Point(296, 365)
        Me.valordiferenca.Name = "valordiferenca"
        Me.valordiferenca.Size = New System.Drawing.Size(34, 13)
        Me.valordiferenca.TabIndex = 46
        Me.valordiferenca.Text = "00,00"
        '
        'valorsimples
        '
        Me.valorsimples.AutoSize = True
        Me.valorsimples.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.valorsimples.Location = New System.Drawing.Point(819, 292)
        Me.valorsimples.Name = "valorsimples"
        Me.valorsimples.Size = New System.Drawing.Size(34, 13)
        Me.valorsimples.TabIndex = 47
        Me.valorsimples.Text = "00,00"
        '
        'valormedia
        '
        Me.valormedia.AutoSize = True
        Me.valormedia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.valormedia.Location = New System.Drawing.Point(786, 338)
        Me.valormedia.Name = "valormedia"
        Me.valormedia.Size = New System.Drawing.Size(34, 13)
        Me.valormedia.TabIndex = 48
        Me.valormedia.Text = "00,00"
        '
        'valorcomplexo
        '
        Me.valorcomplexo.AutoSize = True
        Me.valorcomplexo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.valorcomplexo.Location = New System.Drawing.Point(884, 386)
        Me.valorcomplexo.Name = "valorcomplexo"
        Me.valorcomplexo.Size = New System.Drawing.Size(34, 13)
        Me.valorcomplexo.TabIndex = 49
        Me.valorcomplexo.Text = "00,00"
        '
        'Frm_Precificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 601)
        Me.Controls.Add(Me.valorcomplexo)
        Me.Controls.Add(Me.valormedia)
        Me.Controls.Add(Me.valorsimples)
        Me.Controls.Add(Me.valordiferenca)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.valorlegenda)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.precofinal)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.precomin)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_tempoproducao)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.valorhora)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.somacustomensal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_legendas)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.txt_tempofinal)
        Me.Controls.Add(Me.txt_tempobruto)
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
        Me.Name = "Frm_Precificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precificar"
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
    Friend WithEvents txt_tempobruto As TextBox
    Friend WithEvents txt_tempofinal As TextBox
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents cb_legendas As ns1.BunifuCheckbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents somacustomensal As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents valorhora As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_tempoproducao As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents precomin As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents precofinal As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents valorlegenda As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents valordiferenca As Label
    Friend WithEvents valorsimples As Label
    Friend WithEvents valormedia As Label
    Friend WithEvents valorcomplexo As Label
End Class
