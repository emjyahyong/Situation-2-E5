Imports RentACars_AYE.Classes

Public Class frm_Tourisme
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Try
            ' Obtention des valeurs saisies par l'utilisateur
            Dim climatisation As String
            Dim marque As String = txt_marque.Text
            Dim tarif As Decimal = Decimal.Parse(txt_tarif.Text)
            If rdb_climOui.Checked Then
                climatisation = "Oui"
            Else
                climatisation = "Non"
            End If
            Dim nbPortes As Integer = Integer.Parse(txt_nbPortes.Text)
            Dim nbPassagers As Integer = Integer.Parse(txt_nbPassagers.Text)
            Dim nbBagages As Integer = Integer.Parse(txt_nbBagages.Text)

            ' Création d'une instance de la classe Tourisme avec les valeurs saisies par l'utilisateur
            Dim NewTourisme As New Tourisme("", marque, "", "", tarif, climatisation, nbPortes, nbPassagers, nbBagages)

            ' Appel de la méthode InsererTourisme pour insérer les données dans la base de données
            NewTourisme.AjouterVoitureTourisme()

            ' Afficher un message de succès à l'utilisateur
            MessageBox.Show("La voiture de tourisme a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As FormatException
            ' Gérer l'exception si une conversion de type échoue (par exemple, si l'utilisateur entre du texte au lieu d'un nombre)
            MessageBox.Show("Veuillez saisir des valeurs numériques valides pour le tarif, le nombre de portes, le nombre de passagers et le nombre de bagages.", "Erreur de Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Gérer toutes les autres exceptions
            MessageBox.Show("Une erreur est survenue lors de l'ajout de la voiture de tourisme : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
