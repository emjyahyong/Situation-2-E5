Imports MySql.Data.MySqlClient
Imports RentACars_AYE.Classes
Public Class frm_Categorie
    Private cnxBD As MySqlConnection
    Private Sub RemplirGrilleCategorie()
        'Jeu d'enregistrement qui contiendra la résultat de la requête SQL Dim dtCategorie As New DataTable 
        Dim dtCategorie As New DataTable
        'Adaptateur SQL: Objet sur lequel les commandes SQL seront lancées
        Dim sdaCategorie As New MySqlDataAdapter

        'Exécution de la requête SQL sur la connexion en cours
        sdaCategorie.SelectCommand = New MySqlCommand("Select * From CATEGORIE Inner Join TOURISME On CATEGORIE.CODE = TOURISME.CODE", cnxBD)
        'Récupération des données
        sdaCategorie.Fill(dtCategorie)
        'Affectation du jeu d'enregistrement résultat à la grille de données
        dgvCategorie.DataSource = dtCategorie
    End Sub

    Private Sub ChangerCategorie(valeur As Integer)
        'Jeu d'enregistrement qui contiendra la résultat de la requête SQL Dim dtCategorie As New DataTable 
        Dim dtCategorie As New DataTable
        'Adaptateur SQL: Objet sur lequel les commandes SQL seront lancées
        Dim sdaCategorie As New MySqlDataAdapter

        'Exécution de la requête SQL sur la connexion en cours
        If valeur = 1 Then
            txt_bleu.Text = "Nos Catégories de véhicules - Réservation de véhicule utilitaire"
            sdaCategorie.SelectCommand = New MySqlCommand("SELECT categorie.code, exemple AS 'Marque', tarifJournalier AS 'Tarif journalier', chargeUtile AS 'Charge utile', longueur AS 'Longueur', largeur AS 'Largeur', hauteur AS 'Hauteur' FROM categorie INNER JOIN utilitaire ON categorie.code = utilitaire.code WHERE estReserve = 0", cnxBD)
        ElseIf valeur = 2 Then
            If btn_tourisme.Checked Then
                txt_bleu.Text = "Nos Catégories de véhicules - Consultation de véhicule touriste réservé"
                sdaCategorie.SelectCommand = New MySqlCommand("SELECT categorie.code, exemple AS 'Marque', tarifJournalier AS 'Tarif journalier', climatisation AS 'Climatisation', nbPortes AS 'Nombre de portes', nbPassagersTransportables AS 'Nombre de passagers', nbBagagesCoffre AS 'Nombre de bagages' FROM categorie INNER JOIN tourisme ON categorie.code = tourisme.code WHERE estReserve = 1", cnxBD)
            Else
                txt_bleu.Text = "Nos Catégories de véhicules - Consultation de véhicule utilitaire réservé"
                sdaCategorie.SelectCommand = New MySqlCommand("SELECT categorie.code, exemple AS 'Marque', tarifJournalier AS 'Tarif journalier', chargeUtile AS 'Charge utile', longueur AS 'Longueur', largeur AS 'Largeur', hauteur AS 'Hauteur' FROM categorie INNER JOIN utilitaire ON categorie.code = utilitaire.code WHERE estReserve = 1", cnxBD)
            End If
        Else
            txt_bleu.Text = "Nos Catégories de véhicules - Réservation de véhicule touriste"
            sdaCategorie.SelectCommand = New MySqlCommand("SELECT categorie.code, exemple AS 'Marque', tarifJournalier AS 'Tarif journalier', climatisation AS 'Climatisation', nbPortes AS 'Nombre de portes', nbPassagersTransportables AS 'Nombre de passagers', nbBagagesCoffre AS 'Nombre de bagages' FROM categorie INNER JOIN tourisme ON categorie.code = tourisme.code WHERE estReserve = 0", cnxBD)
        End If
        'Récupération des données
        sdaCategorie.Fill(dtCategorie)
        'Affectation du jeu d'enregistrement résultat à la grille de données
        dgvCategorie.DataSource = dtCategorie
    End Sub

    Private Sub frmCategorie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim role As Integer = SessionData.Role
        If role = 1 Then
            btn_ajout.Visible = True
            btn_consultReservation.Visible = True
        End If
        ConnexionBD.InitialiserConnexionBD(cnxBD)
    End Sub

    Private Sub btn_tourisme_CheckedChanged(sender As Object, e As EventArgs) Handles btn_tourisme.CheckedChanged
        ChangerCategorie(0)
    End Sub

    Private Sub btn_utilitaire_CheckedChanged(sender As Object, e As EventArgs) Handles btn_utilitaire.CheckedChanged
        ChangerCategorie(1)
    End Sub

    Private Sub btn_consultReservation_Click(sender As Object, e As EventArgs) Handles btn_consultReservation.Click
        ChangerCategorie(2)
    End Sub

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        If btn_tourisme.Checked Then
            frm_Tourisme.Show()
        End If

        If btn_utilitaire.Checked Then
            frm_Utilitaire.Show()
        End If
    End Sub


    Private Sub btn_reservation_Click(sender As Object, e As EventArgs) Handles btn_reservation.Click
        ' Vérifier si un enregistrement est sélectionné dans le DataGrid
        If dgvCategorie.SelectedRows.Count > 0 Then
            ' Récupérer la clé primaire de l'enregistrement sélectionné
            Dim primaryKey As Integer = Convert.ToInt32(dgvCategorie.SelectedRows(0).Cells("code").Value)

            ' Passer la clé primaire à l'autre formulaire et l'afficher
            Dim formReservation As New frm_reservation(primaryKey)
            formReservation.Show()
        Else
            MessageBox.Show("Veuillez sélectionner un enregistrement dans le DataGrid.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
