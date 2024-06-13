<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_editar_custos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_editar_custos))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_perfilcustos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_diatrabalhado = New System.Windows.Forms.ComboBox()
        Me.cmb_horatrabalhada = New System.Windows.Forms.ComboBox()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nomecusto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.btn_adicionar = New ns1.BunifuFlatButton()
        Me.dgv_listacusto = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco_custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remover = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BunifuSeparator3 = New ns1.BunifuSeparator()
        Me.btn_cadastar = New ns1.BunifuFlatButton()
        Me.BunifuSeparator4 = New ns1.BunifuSeparator()
        Me.dgv_listaperfil = New System.Windows.Forms.DataGridView()
        Me.id_perfil_custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_perfil_custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar_perfil_custo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir_perfil_custo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_precocusto = New System.Windows.Forms.MaskedTextBox()
        Me.btn_sair_modo_edicao = New ns1.BunifuFlatButton()
        CType(Me.dgv_listacusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_listaperfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(31, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome do Perfil de Custos Mensais"
        '
        'txt_perfilcustos
        '
        Me.txt_perfilcustos.Location = New System.Drawing.Point(35, 64)
        Me.txt_perfilcustos.Name = "txt_perfilcustos"
        Me.txt_perfilcustos.Size = New System.Drawing.Size(365, 20)
        Me.txt_perfilcustos.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(512, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dias trabalhados por mês"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(750, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Horas trabalhadas por dia"
        '
        'cmb_diatrabalhado
        '
        Me.cmb_diatrabalhado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_diatrabalhado.FormattingEnabled = True
        Me.cmb_diatrabalhado.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cmb_diatrabalhado.Location = New System.Drawing.Point(516, 64)
        Me.cmb_diatrabalhado.Name = "cmb_diatrabalhado"
        Me.cmb_diatrabalhado.Size = New System.Drawing.Size(198, 21)
        Me.cmb_diatrabalhado.TabIndex = 11
        '
        'cmb_horatrabalhada
        '
        Me.cmb_horatrabalhada.DropDownHeight = 120
        Me.cmb_horatrabalhada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_horatrabalhada.FormattingEnabled = True
        Me.cmb_horatrabalhada.IntegralHeight = False
        Me.cmb_horatrabalhada.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cmb_horatrabalhada.Location = New System.Drawing.Point(754, 64)
        Me.cmb_horatrabalhada.Name = "cmb_horatrabalhada"
        Me.cmb_horatrabalhada.Size = New System.Drawing.Size(199, 21)
        Me.cmb_horatrabalhada.TabIndex = 12
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(12, 91)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator1.TabIndex = 13
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(31, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nome do Custo"
        '
        'txt_nomecusto
        '
        Me.txt_nomecusto.Location = New System.Drawing.Point(35, 156)
        Me.txt_nomecusto.Name = "txt_nomecusto"
        Me.txt_nomecusto.Size = New System.Drawing.Size(679, 20)
        Me.txt_nomecusto.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(750, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Preço R$"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(12, 253)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator2.TabIndex = 19
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adicionar.BorderRadius = 0
        Me.btn_adicionar.ButtonText = "Adicionar Custo Mensal à lista"
        Me.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adicionar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_adicionar.Iconimage = Nothing
        Me.btn_adicionar.Iconimage_right = Nothing
        Me.btn_adicionar.Iconimage_right_Selected = Nothing
        Me.btn_adicionar.Iconimage_Selected = Nothing
        Me.btn_adicionar.IconMarginLeft = 0
        Me.btn_adicionar.IconMarginRight = 0
        Me.btn_adicionar.IconRightVisible = True
        Me.btn_adicionar.IconRightZoom = 0R
        Me.btn_adicionar.IconVisible = False
        Me.btn_adicionar.IconZoom = 90.0R
        Me.btn_adicionar.IsTab = False
        Me.btn_adicionar.Location = New System.Drawing.Point(292, 199)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_adicionar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_adicionar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_adicionar.selected = False
        Me.btn_adicionar.Size = New System.Drawing.Size(454, 48)
        Me.btn_adicionar.TabIndex = 20
        Me.btn_adicionar.Text = "Adicionar Custo Mensal à lista"
        Me.btn_adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_adicionar.Textcolor = System.Drawing.Color.White
        Me.btn_adicionar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgv_listacusto
        '
        Me.dgv_listacusto.AllowUserToAddRows = False
        Me.dgv_listacusto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_listacusto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgv_listacusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listacusto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.nome_custo, Me.preco_custo, Me.remover})
        Me.dgv_listacusto.Location = New System.Drawing.Point(35, 294)
        Me.dgv_listacusto.Name = "dgv_listacusto"
        Me.dgv_listacusto.Size = New System.Drawing.Size(918, 102)
        Me.dgv_listacusto.TabIndex = 21
        '
        'numero
        '
        Me.numero.HeaderText = "NUMERO"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'nome_custo
        '
        Me.nome_custo.HeaderText = "NOME DO CUSTO"
        Me.nome_custo.Name = "nome_custo"
        '
        'preco_custo
        '
        Me.preco_custo.HeaderText = "PRECO DO CUSTO"
        Me.preco_custo.Name = "preco_custo"
        Me.preco_custo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.preco_custo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'remover
        '
        Me.remover.HeaderText = "REMOVER"
        Me.remover.Image = CType(resources.GetObject("remover.Image"), System.Drawing.Image)
        Me.remover.Name = "remover"
        Me.remover.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.remover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 3
        Me.BunifuSeparator3.Location = New System.Drawing.Point(12, 402)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator3.TabIndex = 22
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'btn_cadastar
        '
        Me.btn_cadastar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_cadastar.BackColor = System.Drawing.Color.SeaGreen
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
        Me.btn_cadastar.Location = New System.Drawing.Point(292, 443)
        Me.btn_cadastar.Name = "btn_cadastar"
        Me.btn_cadastar.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btn_cadastar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_cadastar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cadastar.selected = False
        Me.btn_cadastar.Size = New System.Drawing.Size(454, 48)
        Me.btn_cadastar.TabIndex = 23
        Me.btn_cadastar.Text = "CADASTRAR"
        Me.btn_cadastar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cadastar.Textcolor = System.Drawing.Color.White
        Me.btn_cadastar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 3
        Me.BunifuSeparator4.Location = New System.Drawing.Point(12, 497)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(975, 35)
        Me.BunifuSeparator4.TabIndex = 24
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'dgv_listaperfil
        '
        Me.dgv_listaperfil.AllowUserToAddRows = False
        Me.dgv_listaperfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_listaperfil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgv_listaperfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaperfil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_perfil_custo, Me.nome_perfil_custo, Me.editar_perfil_custo, Me.excluir_perfil_custo})
        Me.dgv_listaperfil.Location = New System.Drawing.Point(35, 526)
        Me.dgv_listaperfil.Name = "dgv_listaperfil"
        Me.dgv_listaperfil.Size = New System.Drawing.Size(918, 128)
        Me.dgv_listaperfil.TabIndex = 25
        '
        'id_perfil_custo
        '
        Me.id_perfil_custo.HeaderText = "ID DO PERFIL"
        Me.id_perfil_custo.Name = "id_perfil_custo"
        Me.id_perfil_custo.ReadOnly = True
        '
        'nome_perfil_custo
        '
        Me.nome_perfil_custo.HeaderText = "NOME DO PERFIL"
        Me.nome_perfil_custo.Name = "nome_perfil_custo"
        Me.nome_perfil_custo.ReadOnly = True
        '
        'editar_perfil_custo
        '
        Me.editar_perfil_custo.HeaderText = "EDITAR"
        Me.editar_perfil_custo.Image = CType(resources.GetObject("editar_perfil_custo.Image"), System.Drawing.Image)
        Me.editar_perfil_custo.Name = "editar_perfil_custo"
        Me.editar_perfil_custo.ReadOnly = True
        Me.editar_perfil_custo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'excluir_perfil_custo
        '
        Me.excluir_perfil_custo.HeaderText = "EXCLUIR"
        Me.excluir_perfil_custo.Image = CType(resources.GetObject("excluir_perfil_custo.Image"), System.Drawing.Image)
        Me.excluir_perfil_custo.Name = "excluir_perfil_custo"
        Me.excluir_perfil_custo.ReadOnly = True
        Me.excluir_perfil_custo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'txt_precocusto
        '
        Me.txt_precocusto.Location = New System.Drawing.Point(754, 156)
        Me.txt_precocusto.Name = "txt_precocusto"
        Me.txt_precocusto.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_precocusto.Size = New System.Drawing.Size(199, 20)
        Me.txt_precocusto.TabIndex = 16
        '
        'btn_sair_modo_edicao
        '
        Me.btn_sair_modo_edicao.Activecolor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_sair_modo_edicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_sair_modo_edicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sair_modo_edicao.BorderRadius = 0
        Me.btn_sair_modo_edicao.ButtonText = "Sair do modo de edição"
        Me.btn_sair_modo_edicao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair_modo_edicao.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sair_modo_edicao.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sair_modo_edicao.Iconimage = Nothing
        Me.btn_sair_modo_edicao.Iconimage_right = Nothing
        Me.btn_sair_modo_edicao.Iconimage_right_Selected = Nothing
        Me.btn_sair_modo_edicao.Iconimage_Selected = Nothing
        Me.btn_sair_modo_edicao.IconMarginLeft = 0
        Me.btn_sair_modo_edicao.IconMarginRight = 0
        Me.btn_sair_modo_edicao.IconRightVisible = True
        Me.btn_sair_modo_edicao.IconRightZoom = 0R
        Me.btn_sair_modo_edicao.IconVisible = True
        Me.btn_sair_modo_edicao.IconZoom = 50.0R
        Me.btn_sair_modo_edicao.IsTab = False
        Me.btn_sair_modo_edicao.Location = New System.Drawing.Point(754, 452)
        Me.btn_sair_modo_edicao.Name = "btn_sair_modo_edicao"
        Me.btn_sair_modo_edicao.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_sair_modo_edicao.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_sair_modo_edicao.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sair_modo_edicao.selected = False
        Me.btn_sair_modo_edicao.Size = New System.Drawing.Size(168, 30)
        Me.btn_sair_modo_edicao.TabIndex = 26
        Me.btn_sair_modo_edicao.Text = "Sair do modo de edição"
        Me.btn_sair_modo_edicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sair_modo_edicao.Textcolor = System.Drawing.Color.White
        Me.btn_sair_modo_edicao.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair_modo_edicao.Visible = False
        '
        'Frm_editar_custos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 677)
        Me.Controls.Add(Me.btn_sair_modo_edicao)
        Me.Controls.Add(Me.txt_precocusto)
        Me.Controls.Add(Me.dgv_listaperfil)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.btn_cadastar)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.dgv_listacusto)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nomecusto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.cmb_horatrabalhada)
        Me.Controls.Add(Me.cmb_diatrabalhado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_perfilcustos)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_editar_custos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar custos mensais"
        CType(Me.dgv_listacusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_listaperfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txt_perfilcustos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_diatrabalhado As ComboBox
    Friend WithEvents cmb_horatrabalhada As ComboBox
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nomecusto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents btn_adicionar As ns1.BunifuFlatButton
    Friend WithEvents BunifuSeparator3 As ns1.BunifuSeparator
    Friend WithEvents btn_cadastar As ns1.BunifuFlatButton
    Friend WithEvents BunifuSeparator4 As ns1.BunifuSeparator
    Friend WithEvents dgv_listaperfil As DataGridView
    Friend WithEvents dgv_listacusto As DataGridView
    Friend WithEvents txt_precocusto As MaskedTextBox
    Friend WithEvents btn_sair_modo_edicao As ns1.BunifuFlatButton
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents nome_custo As DataGridViewTextBoxColumn
    Friend WithEvents preco_custo As DataGridViewTextBoxColumn
    Friend WithEvents remover As DataGridViewImageColumn
    Friend WithEvents id_perfil_custo As DataGridViewTextBoxColumn
    Friend WithEvents nome_perfil_custo As DataGridViewTextBoxColumn
    Friend WithEvents editar_perfil_custo As DataGridViewImageColumn
    Friend WithEvents excluir_perfil_custo As DataGridViewImageColumn
End Class
