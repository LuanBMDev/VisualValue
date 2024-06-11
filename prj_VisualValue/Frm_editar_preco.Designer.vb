<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_editar_preco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_editar_preco))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.txt_perfilpreco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_precodiferenca = New System.Windows.Forms.TextBox()
        Me.txt_precosimples = New System.Windows.Forms.TextBox()
        Me.txt_precomedia = New System.Windows.Forms.TextBox()
        Me.txt_precocomplexa = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.btn_cadastar = New ns1.BunifuFlatButton()
        Me.BunifuSeparator3 = New ns1.BunifuSeparator()
        Me.dgv_precos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Deletar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_precolegenda = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_precos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(29, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome da Configuração"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(12, 93)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'txt_perfilpreco
        '
        Me.txt_perfilpreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txt_perfilpreco.Location = New System.Drawing.Point(33, 67)
        Me.txt_perfilpreco.Name = "txt_perfilpreco"
        Me.txt_perfilpreco.Size = New System.Drawing.Size(402, 26)
        Me.txt_perfilpreco.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(416, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Edição de custos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(29, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Legendas: R$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(29, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Diferença"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(29, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "bruto e final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(262, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "/Min"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(137, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "R$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(282, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "cada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(282, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "10 min"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(455, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Edição"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(455, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 24)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "simples"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(455, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 24)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Edição"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(455, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 24)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "média"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(535, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 24)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "R$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(530, 268)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 24)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "R$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(714, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 24)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Edição"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(714, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 24)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "complexa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(813, 200)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 24)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "R$"
        '
        'txt_precodiferenca
        '
        Me.txt_precodiferenca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_precodiferenca.Location = New System.Drawing.Point(176, 272)
        Me.txt_precodiferenca.Name = "txt_precodiferenca"
        Me.txt_precodiferenca.Size = New System.Drawing.Size(100, 23)
        Me.txt_precodiferenca.TabIndex = 34
        '
        'txt_precosimples
        '
        Me.txt_precosimples.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_precosimples.Location = New System.Drawing.Point(574, 204)
        Me.txt_precosimples.Name = "txt_precosimples"
        Me.txt_precosimples.Size = New System.Drawing.Size(100, 23)
        Me.txt_precosimples.TabIndex = 35
        '
        'txt_precomedia
        '
        Me.txt_precomedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_precomedia.Location = New System.Drawing.Point(574, 273)
        Me.txt_precomedia.Name = "txt_precomedia"
        Me.txt_precomedia.Size = New System.Drawing.Size(100, 23)
        Me.txt_precomedia.TabIndex = 36
        '
        'txt_precocomplexa
        '
        Me.txt_precocomplexa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_precocomplexa.Location = New System.Drawing.Point(852, 204)
        Me.txt_precocomplexa.Name = "txt_precocomplexa"
        Me.txt_precocomplexa.Size = New System.Drawing.Size(100, 23)
        Me.txt_precocomplexa.TabIndex = 37
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(12, 321)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator2.TabIndex = 38
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'btn_cadastar
        '
        Me.btn_cadastar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_cadastar.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_cadastar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cadastar.BorderRadius = 0
        Me.btn_cadastar.ButtonText = "CADASTRAR"
        Me.btn_cadastar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_cadastar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_cadastar.Iconimage = Nothing
        Me.btn_cadastar.Iconimage_right = Nothing
        Me.btn_cadastar.Iconimage_right_Selected = Nothing
        Me.btn_cadastar.Iconimage_Selected = Nothing
        Me.btn_cadastar.IconMarginLeft = 0
        Me.btn_cadastar.IconMarginRight = 0
        Me.btn_cadastar.IconRightVisible = True
        Me.btn_cadastar.IconRightZoom = 0R
        Me.btn_cadastar.IconVisible = True
        Me.btn_cadastar.IconZoom = 90.0R
        Me.btn_cadastar.IsTab = False
        Me.btn_cadastar.Location = New System.Drawing.Point(266, 362)
        Me.btn_cadastar.Name = "btn_cadastar"
        Me.btn_cadastar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_cadastar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_cadastar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cadastar.selected = False
        Me.btn_cadastar.Size = New System.Drawing.Size(454, 48)
        Me.btn_cadastar.TabIndex = 39
        Me.btn_cadastar.Text = "CADASTRAR"
        Me.btn_cadastar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cadastar.Textcolor = System.Drawing.Color.White
        Me.btn_cadastar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 3
        Me.BunifuSeparator3.Location = New System.Drawing.Point(12, 416)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator3.TabIndex = 40
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'dgv_precos
        '
        Me.dgv_precos.AllowUserToAddRows = False
        Me.dgv_precos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_precos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nome, Me.Editar, Me.Deletar})
        Me.dgv_precos.Location = New System.Drawing.Point(33, 457)
        Me.dgv_precos.Name = "dgv_precos"
        Me.dgv_precos.Size = New System.Drawing.Size(936, 189)
        Me.dgv_precos.TabIndex = 41
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nome
        '
        Me.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nome.HeaderText = "Perfil"
        Me.Nome.Name = "Nome"
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.Name = "Editar"
        Me.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Deletar
        '
        Me.Deletar.HeaderText = "Deletar"
        Me.Deletar.Image = CType(resources.GetObject("Deletar.Image"), System.Drawing.Image)
        Me.Deletar.Name = "Deletar"
        Me.Deletar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(417, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 20)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(241, 193)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(261, 272)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 20)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(659, 204)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 20)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(659, 273)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 20)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(937, 203)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 20)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "*"
        '
        'txt_precolegenda
        '
        Me.txt_precolegenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txt_precolegenda.Location = New System.Drawing.Point(156, 193)
        Me.txt_precolegenda.Name = "txt_precolegenda"
        Me.txt_precolegenda.Size = New System.Drawing.Size(100, 23)
        Me.txt_precolegenda.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(708, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 80)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Frm_editar_preco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 677)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.dgv_precos)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.btn_cadastar)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.txt_precocomplexa)
        Me.Controls.Add(Me.txt_precomedia)
        Me.Controls.Add(Me.txt_precosimples)
        Me.Controls.Add(Me.txt_precodiferenca)
        Me.Controls.Add(Me.txt_precolegenda)
        Me.Controls.Add(Me.Label18)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_perfilpreco)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_editar_preco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar tabela de preços"
        CType(Me.dgv_precos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents txt_perfilpreco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_precodiferenca As TextBox
    Friend WithEvents txt_precosimples As TextBox
    Friend WithEvents txt_precomedia As TextBox
    Friend WithEvents txt_precocomplexa As TextBox
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents btn_cadastar As ns1.BunifuFlatButton
    Friend WithEvents BunifuSeparator3 As ns1.BunifuSeparator
    Friend WithEvents dgv_precos As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_precolegenda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Deletar As DataGridViewImageColumn
End Class
