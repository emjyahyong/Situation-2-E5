Imports MySql.Data.MySqlClient

Public Class Classes
    Public Class SessionData
        Public Shared Role As Integer
    End Class

    Public Class Categorie
        Protected Property Code As String
        Protected Property Libelle As String
        Protected Property Exemple As String
        Protected Property Photo As String
        Protected Property TarifJournalier As Decimal

        Public Sub New(ByVal code As String, ByVal libelle As String, ByVal exemple As String, ByVal photo As String, ByVal tarifJournalier As Decimal)
            Me.Code = code
            Me.Libelle = libelle
            Me.Exemple = exemple
            Me.Photo = photo
            Me.TarifJournalier = tarifJournalier
        End Sub

        ' Ajoutez ici d'autres procédures ou méthodes nécessaires pour la classe Categorie
    End Class

    Public Class Tourisme
        Inherits Categorie
        Protected Property Climatisation As String
        Protected Property NbPortes As Integer
        Protected Property NbPassagersTransportables As Integer
        Protected Property NbBagagesCoffre As Integer

        Public Sub New(ByVal code As String, ByVal libelle As String, ByVal exemple As String, ByVal photo As String, ByVal tarifJournalier As Decimal, ByVal climatisation As String, ByVal nbPortes As Integer, ByVal nbPassagersTransportables As Integer, ByVal nbBagagesCoffre As Integer)
            MyBase.New(code, libelle, exemple, photo, tarifJournalier)
            Me.Climatisation = climatisation
            Me.NbPortes = nbPortes
            Me.NbPassagersTransportables = nbPassagersTransportables
            Me.NbBagagesCoffre = nbBagagesCoffre
        End Sub

        Public Sub AjouterVoitureTourisme()
            Dim cnxBD As MySqlConnection
            ConnexionBD.InitialiserConnexionBD(cnxBD)

            Try
                Dim query As String = "CALL SP_InsertTourisme(@categ_voiture,@categ_tarif,@tourisme_clim,@tourisme_nbPortes,@tourisme_nbPassagers,@tourisme_nbBagages)"

                Using cmd As New MySqlCommand(query, cnxBD)
                    cmd.Parameters.AddWithValue("@categ_voiture", Me.Libelle)
                    cmd.Parameters.AddWithValue("@categ_tarif", Me.TarifJournalier)
                    cmd.Parameters.AddWithValue("@tourisme_clim", Me.Climatisation)
                    cmd.Parameters.AddWithValue("@tourisme_nbPortes", Me.NbPortes)
                    cmd.Parameters.AddWithValue("@tourisme_nbPassagers", Me.NbPassagersTransportables)
                    cmd.Parameters.AddWithValue("@tourisme_nbBagages", Me.NbBagagesCoffre)

                    cmd.ExecuteNonQuery()
                    MsgBox("Insérée")
                End Using
            Catch ex As Exception
                MsgBox("Erreur lors de l'exécution de la commande : " + ex.Message, vbCritical)
            End Try
        End Sub

    End Class

    Public Class Utilitaire
        Inherits Categorie
        Protected Property Volume As Decimal
        Protected Property ChargeUtile As Decimal
        Protected Property Longueur As Decimal
        Protected Property Largeur As Decimal
        Protected Property Hauteur As Decimal

        Public Sub New(ByVal code As String, ByVal libelle As String, ByVal exemple As String, ByVal photo As String, ByVal tarifJournalier As Decimal, ByVal volume As Decimal, ByVal chargeUtile As Decimal, ByVal longueur As Decimal, ByVal largeur As Decimal, ByVal hauteur As Decimal)
            MyBase.New(code, libelle, exemple, photo, tarifJournalier)
            Me.Volume = volume
            Me.ChargeUtile = chargeUtile
            Me.Longueur = longueur
            Me.Largeur = largeur
            Me.Hauteur = hauteur
        End Sub

        Public Sub AjouterVoitureUtilitaire()
            Dim cnxBD As MySqlConnection
            ConnexionBD.InitialiserConnexionBD(cnxBD)

            Try

                Dim query As String = "CALL SP_InsertUtilitaire(@categ_voiture,@categ_tarif,@utilitaire_volume,@utilitaire_chargeUtile,@utilitaire_longueur,@utilitaire_largeur,@utilitaire_hauteur)"

                Using cmd As New MySqlCommand(query, cnxBD)
                    ' Ajout des paramètres à la commande
                    cmd.Parameters.AddWithValue("@categ_voiture", Me.Libelle)
                    cmd.Parameters.AddWithValue("@categ_tarif", Me.TarifJournalier)
                    cmd.Parameters.AddWithValue("@utilitaire_volume", Me.Volume)
                    cmd.Parameters.AddWithValue("@utilitaire_chargeUtile", Me.ChargeUtile)
                    cmd.Parameters.AddWithValue("@utilitaire_longueur", Me.Longueur)
                    cmd.Parameters.AddWithValue("@utilitaire_largeur", Me.Largeur)
                    cmd.Parameters.AddWithValue("@utilitaire_hauteur", Me.Hauteur)

                    ' Exécution de la commande
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Insérée")
            Catch ex As Exception
                MsgBox("Erreur lors de l'exécution de la commande : " + ex.Message, vbCritical)
            End Try
        End Sub

    End Class

End Class