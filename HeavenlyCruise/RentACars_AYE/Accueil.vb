Imports RentACars_AYE.Classes

Public Class Accueil
    Private Sub btn_reserver_Click(sender As Object, e As EventArgs) Handles btn_reserver.Click
        ' Stocker la valeur du rôle dans la classe SessionData
        SessionData.Role = 0
        frm_Categorie.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_categ_Click(sender As Object, e As EventArgs) Handles lbl_categ.Click
        btn_reserver2.Visible = True
    End Sub

    Private Sub btn_reserver2_Click(sender As Object, e As EventArgs) Handles btn_reserver2.Click
        SessionData.Role = 1
        frm_Categorie.Show()
        Me.Hide()
    End Sub
End Class
