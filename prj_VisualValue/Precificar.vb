Public Class Frm_Precificar

    Private Sub Precificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Menu.Hide()
    End Sub

    Private Sub Frm_Precificar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Frm_Menu.Show()
    End Sub

    Private Sub txt_tempoproducao_TextChanged(sender As Object, e As EventArgs) Handles txt_tempoproducao.TextChanged

    End Sub

End Class
