Public Class Frm_Menu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn_precificar_Click(sender As Object, e As EventArgs) Handles btn_precificar.Click
        Frm_Precificar.ShowDialog()
    End Sub

    Private Sub btn_customensal_Click(sender As Object, e As EventArgs) Handles btn_customensal.Click
        Frm_editar_custos.ShowDialog()
    End Sub

    Private Sub btn_custosedicao_Click(sender As Object, e As EventArgs) Handles btn_custosedicao.Click
        Frm_editar_preco.ShowDialog()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click

    End Sub

    Private Sub Frm_Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_banco()

    End Sub
End Class
