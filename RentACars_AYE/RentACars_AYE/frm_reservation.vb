Imports MySql.Data.MySqlClient

Public Class frm_reservation
    Private codeVoiture As Integer
    Private primaryKey As Integer

    Public Sub New(primaryKey As Integer)
        Me.primaryKey = primaryKey
    End Sub

    Private Sub frm_reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        codeVoiture = Me.primaryKey
    End Sub

    Private Sub btn_reserver_Click(sender As Object, e As EventArgs) Handles btn_reserver.Click
        Dim cnxBD As MySqlConnection
        ConnexionBD.InitialiserConnexionBD(cnxBD)

        Dim civilite As String
        ' Paramètres pour la procédure stockée
        If btn_mr.Checked Then
            civilite = btn_mr.Text
        Else
            civilite = btn_mme.Text
        End If
        Dim nom As String = txt_nom.Text
        Dim prenom As String = txt_prenom.Text
        Dim adresseRue As String = txt_adresse.Text
        Dim adresseVille As String = txt_ville.Text
        Dim adresseCP As String = txt_codePostal.Text
        Dim telephone As Integer = Int32.Parse(txt_telephone.Text)
        Dim codeVoiture = Me.primaryKey
        Dim dateDepart As String = date_depart.Value.ToString("yyyy-MM-dd")
        Dim dateRetour As String = date_retour.Value.ToString("yyyy-MM-dd")

        ' Commande pour appeler la procédure stockée
        Dim query As String = "CALL SP_AjouterClientReservation(@p_Civilite,@p_Nom,@p_Prenom,@p_AdresseRue,@p_AdresseVille,@p_AdresseCP,@p_Telephone,@p_CodeVoiture,@p_DateDepart,@p_DateRetour)"

        Using command As New MySqlCommand(query, cnxBD)
            ' Ajout des paramètres de la procédure stockée
            command.Parameters.AddWithValue("@p_Civilite", civilite)
            command.Parameters.AddWithValue("@p_Nom", nom)
            command.Parameters.AddWithValue("@p_Prenom", prenom)
            command.Parameters.AddWithValue("@p_AdresseRue", adresseRue)
            command.Parameters.AddWithValue("@p_AdresseVille", adresseVille)
            command.Parameters.AddWithValue("@p_AdresseCP", adresseCP)
            command.Parameters.AddWithValue("@p_Telephone", telephone)
            command.Parameters.AddWithValue("@p_CodeVoiture", codeVoiture)
            command.Parameters.AddWithValue("@p_DateDepart", dateDepart)
            command.Parameters.AddWithValue("@p_DateRetour", dateRetour)

            ' Exécution de la commande
            command.ExecuteNonQuery()

            MsgBox("Réservation ajoutée avec succès!")
        End Using
    End Sub

End Class