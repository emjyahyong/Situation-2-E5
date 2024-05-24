Imports RentACars_AYE.Classes

Public Class frm_Utilitaire
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Try
            ' Obtention des valeurs saisies par l'utilisateur
            Dim marque As String = txt_marque.Text
            Dim tarif As Decimal = Decimal.Parse(txt_tarif.Text)
            Dim volume As Decimal = Decimal.Parse(txt_volume.Text)
            Dim chargeUtile As Decimal = Decimal.Parse(txt_chargeUtile.Text)
            Dim longueur As Decimal = Decimal.Parse(txt_longueur.Text)
            Dim largeur As Decimal = Decimal.Parse(txt_largeur.Text)
            Dim hauteur As Decimal = Decimal.Parse(txt_hauteur.Text)

            ' Création d'une instance de la classe Utilitaire avec les valeurs saisies par l'utilisateur
            Dim NewUtilitaire As New Utilitaire("", marque, "", "", tarif, volume, chargeUtile, longueur, largeur, hauteur)

            ' Appel de la méthode AjouterVoitureUtilitaire pour insérer les données dans la base de données
            NewUtilitaire.AjouterVoitureUtilitaire()

            ' Afficher un message de succès à l'utilisateur
            MessageBox.Show("La voiture utilitaire a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As FormatException
            ' Gérer l'exception si une conversion de type échoue (par exemple, si l'utilisateur entre du texte au lieu d'un nombre)
            MessageBox.Show("Veuillez saisir des valeurs numériques valides pour le tarif, le volume, la charge utile, la longueur, la largeur et la hauteur.", "Erreur de Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Gérer toutes les autres exceptions
            MessageBox.Show("Une erreur est survenue lors de l'ajout de la voiture utilitaire : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
