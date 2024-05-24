Imports MySql.Data.MySqlClient
Public Class ConnexionBD
    Public Shared Sub InitialiserConnexionBD(ByRef cnxBD As MySqlConnection)

        ' Création de la connexion
        Dim connectionString As String = "server=172.18.153.42; user=e5;database=heavenlycruise_data; port=3306; password=e5;"

        ' Initialisation de la connexion
        cnxBD = New MySqlConnection(connectionString)

        ' Tentative d'ouverture de connexion
        Try
            cnxBD.Open()
        Catch ex As Exception
            MsgBox("Erreur: Accès à la BD impossible !" + vbCrLf + ex.Message, vbCritical)
        End Try
    End Sub

End Class