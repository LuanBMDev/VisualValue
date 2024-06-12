<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_precificar = New ns1.BunifuFlatButton()
        Me.btn_customensal = New ns1.BunifuFlatButton()
        Me.btn_sair = New ns1.BunifuFlatButton()
        Me.btn_custosedicao = New ns1.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(513, 385)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_precificar
        '
        Me.btn_precificar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_precificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_precificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_precificar.BorderRadius = 0
        Me.btn_precificar.ButtonText = "Precificar Video"
        Me.btn_precificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_precificar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_precificar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_precificar.Iconimage = CType(resources.GetObject("btn_precificar.Iconimage"), System.Drawing.Image)
        Me.btn_precificar.Iconimage_right = Nothing
        Me.btn_precificar.Iconimage_right_Selected = Nothing
        Me.btn_precificar.Iconimage_Selected = Nothing
        Me.btn_precificar.IconMarginLeft = 0
        Me.btn_precificar.IconMarginRight = 0
        Me.btn_precificar.IconRightVisible = True
        Me.btn_precificar.IconRightZoom = 0R
        Me.btn_precificar.IconVisible = True
        Me.btn_precificar.IconZoom = 50.0R
        Me.btn_precificar.IsTab = False
        Me.btn_precificar.Location = New System.Drawing.Point(151, 316)
        Me.btn_precificar.Name = "btn_precificar"
        Me.btn_precificar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_precificar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_precificar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_precificar.selected = False
        Me.btn_precificar.Size = New System.Drawing.Size(175, 48)
        Me.btn_precificar.TabIndex = 1
        Me.btn_precificar.Text = "Precificar Video"
        Me.btn_precificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_precificar.Textcolor = System.Drawing.Color.White
        Me.btn_precificar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_customensal
        '
        Me.btn_customensal.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_customensal.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_customensal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customensal.BorderRadius = 0
        Me.btn_customensal.ButtonText = "Custos Mensais"
        Me.btn_customensal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customensal.DisabledColor = System.Drawing.Color.Gray
        Me.btn_customensal.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_customensal.Iconimage = CType(resources.GetObject("btn_customensal.Iconimage"), System.Drawing.Image)
        Me.btn_customensal.Iconimage_right = Nothing
        Me.btn_customensal.Iconimage_right_Selected = Nothing
        Me.btn_customensal.Iconimage_Selected = Nothing
        Me.btn_customensal.IconMarginLeft = 0
        Me.btn_customensal.IconMarginRight = 0
        Me.btn_customensal.IconRightVisible = True
        Me.btn_customensal.IconRightZoom = 0R
        Me.btn_customensal.IconVisible = True
        Me.btn_customensal.IconZoom = 50.0R
        Me.btn_customensal.IsTab = False
        Me.btn_customensal.Location = New System.Drawing.Point(151, 382)
        Me.btn_customensal.Name = "btn_customensal"
        Me.btn_customensal.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_customensal.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_customensal.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_customensal.selected = False
        Me.btn_customensal.Size = New System.Drawing.Size(175, 48)
        Me.btn_customensal.TabIndex = 2
        Me.btn_customensal.Text = "Custos Mensais"
        Me.btn_customensal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_customensal.Textcolor = System.Drawing.Color.White
        Me.btn_customensal.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_sair
        '
        Me.btn_sair.Activecolor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sair.BorderRadius = 0
        Me.btn_sair.ButtonText = "Sair"
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sair.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sair.Iconimage = CType(resources.GetObject("btn_sair.Iconimage"), System.Drawing.Image)
        Me.btn_sair.Iconimage_right = Nothing
        Me.btn_sair.Iconimage_right_Selected = Nothing
        Me.btn_sair.Iconimage_Selected = Nothing
        Me.btn_sair.IconMarginLeft = 0
        Me.btn_sair.IconMarginRight = 0
        Me.btn_sair.IconRightVisible = True
        Me.btn_sair.IconRightZoom = 0R
        Me.btn_sair.IconVisible = True
        Me.btn_sair.IconZoom = 50.0R
        Me.btn_sair.IsTab = False
        Me.btn_sair.Location = New System.Drawing.Point(151, 513)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_sair.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_sair.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sair.selected = False
        Me.btn_sair.Size = New System.Drawing.Size(175, 48)
        Me.btn_sair.TabIndex = 3
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sair.Textcolor = System.Drawing.Color.White
        Me.btn_sair.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_custosedicao
        '
        Me.btn_custosedicao.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_custosedicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_custosedicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_custosedicao.BorderRadius = 0
        Me.btn_custosedicao.ButtonText = "Custos de Edição"
        Me.btn_custosedicao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_custosedicao.DisabledColor = System.Drawing.Color.Gray
        Me.btn_custosedicao.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_custosedicao.Iconimage = CType(resources.GetObject("btn_custosedicao.Iconimage"), System.Drawing.Image)
        Me.btn_custosedicao.Iconimage_right = Nothing
        Me.btn_custosedicao.Iconimage_right_Selected = Nothing
        Me.btn_custosedicao.Iconimage_Selected = Nothing
        Me.btn_custosedicao.IconMarginLeft = 0
        Me.btn_custosedicao.IconMarginRight = 0
        Me.btn_custosedicao.IconRightVisible = True
        Me.btn_custosedicao.IconRightZoom = 0R
        Me.btn_custosedicao.IconVisible = True
        Me.btn_custosedicao.IconZoom = 50.0R
        Me.btn_custosedicao.IsTab = False
        Me.btn_custosedicao.Location = New System.Drawing.Point(151, 448)
        Me.btn_custosedicao.Name = "btn_custosedicao"
        Me.btn_custosedicao.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_custosedicao.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_custosedicao.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_custosedicao.selected = False
        Me.btn_custosedicao.Size = New System.Drawing.Size(175, 48)
        Me.btn_custosedicao.TabIndex = 4
        Me.btn_custosedicao.Text = "Custos de Edição"
        Me.btn_custosedicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_custosedicao.Textcolor = System.Drawing.Color.White
        Me.btn_custosedicao.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 580)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nome: Luan Barbosa Morais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(334, 580)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome: Carlos Daniel Chen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 593)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RA: 1680482321037"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(359, 593)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "RA: 1680482321003"
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 624)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_custosedicao)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_customensal)
        Me.Controls.Add(Me.btn_precificar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_precificar As ns1.BunifuFlatButton
    Friend WithEvents btn_customensal As ns1.BunifuFlatButton
    Friend WithEvents btn_sair As ns1.BunifuFlatButton
    Friend WithEvents btn_custosedicao As ns1.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
