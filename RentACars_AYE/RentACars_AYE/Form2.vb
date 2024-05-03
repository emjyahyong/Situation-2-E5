Imports RentACars_AYE.Classes

Public Class Form2
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        ' Obtention des valeurs saisies par l'utilisateur
        Dim marque As String = txt_marque.Text
        Dim tarif As Decimal = Decimal.Parse(txt_tarif.Text)
        Dim climatisation As Integer = Integer.Parse(txt_clim.Text)
        Dim nbPortes As Integer = Integer.Parse(txt_nbPortes.Text)
        Dim nbPassagers As Integer = Integer.Parse(txt_nbPassagers.Text)
        Dim nbBagages As Integer = Integer.Parse(txt_nbBagages.Text)

        ' Création d'une instance de la classe Tourisme avec les valeurs saisies par l'utilisateur
        Dim NewTourisme As New Tourisme("", marque, "", "", tarif, climatisation, nbPortes, nbPassagers, nbBagages)

        ' Appel de la méthode InsererTourisme pour insérer les données dans la base de données
        NewTourisme.AjouterVoitureTourisme()
    End Sub

End Class
