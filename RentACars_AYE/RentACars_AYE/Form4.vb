Imports RentACars_AYE.Classes

Public Class Form4
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        ' Obtention des valeurs saisies par l'utilisateur
        Dim marque As String = txt_marque.Text
        Dim tarif As Decimal = Decimal.Parse(txt_tarif.Text)
        Dim volume As Decimal = Decimal.Parse(txt_volume.Text)
        Dim chargeUtile As Decimal = Decimal.Parse(txt_chargeUtile.Text)
        Dim longueur As Decimal = Decimal.Parse(txt_longueur.Text)
        Dim largeur As Decimal = Decimal.Parse(txt_largeur.Text)
        Dim hauteur As Decimal = Decimal.Parse(txt_hauteur.Text)

        ' Création d'une instance de la classe Tourisme avec les valeurs saisies par l'utilisateur
        Dim NewUtilitaire As New Utilitaire("", marque, "", "", tarif, volume, chargeUtile, longueur, largeur, hauteur)

        ' Appel de la méthode InsererTourisme pour insérer les données dans la base de données
        NewUtilitaire.AjouterVoitureUtilitaire()
    End Sub

End Class
